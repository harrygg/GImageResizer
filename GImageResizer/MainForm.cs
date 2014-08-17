using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GImageResizer
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      InitializeBackgroundWorker();
    }

    IEnumerable<string> files;
    Font font = new Font("Arial", 30);
    SolidBrush brush = new SolidBrush(Color.White);

    #region MainForm properties
    int LogoPositionX
    {
      get { return Convert.ToInt32(textBoxPositionX.Text); }
    }

    int LogoPositionY
    {
      get { return Convert.ToInt32(textBoxPositionY.Text); }
    }
    #endregion

    #region Click on resize button
    private void resize_btn_Click(object sender, EventArgs e)
    {
      resize_btn.Enabled = false;

      if (!Directory.Exists(fromDir.Text))
      {
        MessageBox.Show("Selected folder does not exist!");
        resize_btn.Enabled = true;
        return;
      }

      files = Directory.EnumerateFiles(fromDir.Text, "*.*")
        .Where(s => s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".png", StringComparison.OrdinalIgnoreCase));

      int selectedFiles = files.ToList<string>().Count;
      if (selectedFiles == 0)
      {
        MessageBox.Show("No images found in the selected directory!");
        resize_btn.Enabled = true;
        return;
      }

      // Set the progress bar max value to the number of images we have to handle
      progressBar.Maximum = selectedFiles;
      // Reset the progress bar
      progressBar.Value = 0;

      if (!Directory.Exists(toDir.Text))
        Directory.CreateDirectory(toDir.Text);

      cancel_btn.Enabled = true;
      resize_btn.Text = "Resizing...";
      if (bgWorker.IsBusy != true)
        bgWorker.RunWorkerAsync();
    }
    #endregion 


    #region Scale images
    private void ScaleImages(BackgroundWorker worker, DoWorkEventArgs e)
    {
      // If concurrent resize is selected we will try to resize all images at the same time using multiple threads
      if (checkBoxConcurrent.Checked)
      {
        Parallel.ForEach(files, file =>
        {
          ResizeImageAddLogo(worker, e, file);
        });
      }
      else
      {
        foreach(var file in files)
          ResizeImageAddLogo(worker, e, file);
      }
    }
    #endregion
    
    #region Resize image, add text and name if needed
    void ResizeImageAddLogo(BackgroundWorker worker, DoWorkEventArgs e, string file)
    {
      if (worker.CancellationPending)
        e.Cancel = true;
      else
      {
        FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
        using (Image originalImg = Image.FromStream(fs))
        {
          var newImage = ScaleImage(originalImg);
          originalImg.Dispose();

          //If needed change the image file name by adding a prefix and suffix
          var fileName = checkBoxRenameImages.Checked ? textBoxPrefix.Text.Trim() + Path.GetFileNameWithoutExtension(file) + textBoxSuffix.Text.Trim() + Path.GetExtension(file) : Path.GetFileName(file);
          var newFilePath = Path.Combine(toDir.Text, fileName);

          if (newImage != null)
          {
            newImage.Save(newFilePath, ImageFormat.Jpeg);
            worker.ReportProgress(1);
            newImage.Dispose();
          }
        }
      }
    }
    #endregion

    #region Scale single image

    Image ScaleImage(Image image)
    {
      try
      {
        var aspectRatio = Convert.ToDouble(image.Width) / Convert.ToDouble(image.Height);
        int newWidth = Convert.ToInt32(textBoxWidth.Text);
        int newHeight = keepAspect.Checked ? (int)(newWidth / aspectRatio) : Convert.ToInt16(textBoxHeight.Text);

        var newImage = new Bitmap(newWidth, newHeight);
        Graphics graphics = Graphics.FromImage(newImage);
        graphics.DrawImage(image, 0, 0, newWidth, newHeight);

        // if we want to set a custom log text
        if (checkBoxUseLogo.Checked && logoText.Text.Trim() != "")
        {
          var location = new PointF(LogoPositionX, LogoPositionY);
          //this is to prevent InvalidOperationException
          //object is in use elsewhere
          //practically it renders the Parallel.Foreach useless ... :(
          //TODO find a way to fix it
          if (checkBoxConcurrent.Checked)
          {
            lock (brush)
              graphics.DrawString(logoText.Text, font, brush, location);
          }
          else
            graphics.DrawString(logoText.Text, font, brush, location);

        }
        return newImage;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
        return null;
      }
    }
    #endregion

    #region Click on the Use current dir checkbox
    void UseCurrentDir_CheckedChanged(object sender, EventArgs e)
    {
      if (fromDir.Enabled == true)
      {
        fromDir.Text = Directory.GetCurrentDirectory();
        toDir.Text = Path.Combine(fromDir.Text, "resized");
      }

      fromDir.Enabled = checkBoxUseCurrentDir.Checked ? false : true;
      browseFromDir_btn.Enabled = checkBoxUseCurrentDir.Checked ? false : true;
    }
    #endregion

    #region Background worker initializer
    void InitializeBackgroundWorker()
    {
      bgWorker.WorkerReportsProgress = true;
      bgWorker.WorkerSupportsCancellation = true;
      bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
      bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
      bgWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
    }
    #endregion

    #region Background worker DoWork code
    void bgWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      BackgroundWorker worker = sender as BackgroundWorker;
      ScaleImages(worker, e);
    }
    #endregion

    #region Background worker progress changed event handler
    void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      int newValue = progressBar.Value + e.ProgressPercentage;
      progressBar.Value = newValue >= progressBar.Maximum ? progressBar.Maximum : newValue;
    }
    #endregion

    #region Background worker action completed event handler
    void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      // First, handle the case where an exception was thrown. 
      if (e.Error != null)
        MessageBox.Show(e.Error.Message);
      else if (e.Cancelled)
        MessageBox.Show("Resizing was canceled!");
      else
        progressBar.Value = progressBar.Maximum;
      
      resize_btn.Text = "Resize";
      resize_btn.Enabled = true;
      cancel_btn.Enabled = false;

    }
    #endregion

    #region Background worker click on the Cancel button
    void cancel_btn_Click(object sender, EventArgs e)
    {
      if (bgWorker.WorkerSupportsCancellation == true)
        bgWorker.CancelAsync();
    }
    #endregion

    #region Handle clicking on Browse buttons
    void BrowseClick(TextBox t)
    {
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        t.Text = folderBrowserDialog1.SelectedPath;
    }

    void browse_btn_Click(object sender, EventArgs e)
    {
      BrowseClick(fromDir);
    }

    void browseToDir_btn_Click(object sender, EventArgs e)
    {
      BrowseClick(toDir);
    }
    #endregion

    #region Handle the click on the Font button
    void chooseFont_Click(object sender, EventArgs e)
    {
      if (fontDialog.ShowDialog() != DialogResult.Cancel)
        font = fontDialog.Font;
    }
    #endregion

    #region Handle the click on the Color button
    void chooseColor_Click(object sender, EventArgs e)
    {
      ColorDialog cd = new ColorDialog();
      cd.AllowFullOpen = false;
      cd.ShowHelp = true;
      cd.Color = Color.White;

      // Update the text box color if the user clicks OK  
      if (cd.ShowDialog() == DialogResult.OK)
      {
        logoText.ForeColor = cd.Color;
        brush.Color = cd.Color;
      }
    }
    #endregion

    #region Handle the click on the "Add text to image" checkbox
    void UseLogo_CheckedChanged(object sender, EventArgs e)
    {
      logoInnerPanel.Enabled = checkBoxUseLogo.Checked ? true : false;
    }
    #endregion

    #region Handle the click on the "Keep aspect ration" checkbox
    void keepAspect_CheckedChanged(object sender, EventArgs e)
    {
      textBoxHeight.Enabled = keepAspect.Checked ? false : true;
    }
    #endregion

    #region Tooltips
    void UseCurrentDir_MouseHover(object sender, EventArgs e)
    {
      toolTip1.Show("Resize all images from the directory where the SimpleImageResizer tool is:\n"
        + Directory.GetCurrentDirectory(), (Control)sender);
    }

    void Prefix_MouseHover(object sender, EventArgs e)
    {
      toolTip1.Show("The prefix will be inserted before all image file names", (Control)sender);
    }

    void Suffix_MouseHover(object sender, EventArgs e)
    {
      toolTip1.Show("The suffix will be appended to the end of all image file names", (Control)sender);
    }

    void RenameImages_CheckedChanged(object sender, EventArgs e)
    {
      textBoxPrefix.Enabled = checkBoxRenameImages.Checked ? true : false;
      textBoxSuffix.Enabled = checkBoxRenameImages.Checked ? true : false;
    }

    void RenameImages_MouseHover(object sender, EventArgs e)
    {
      toolTip1.Show("Change the original image names by adding a preffix and suffix", (Control)sender);
    }

    void PositionX_MouseHover(object sender, EventArgs e)
    {
      toolTip1.Show("The horizontal offset (in pixels) from the top left corner of the image", (Control)sender);
    }

    void PositionY_MouseHover(object sender, EventArgs e)
    {
      toolTip1.Show("The vertical offset (in pixels) from the top left corner of the image", (Control)sender);
    }

    void Concurrent_MouseHover(object sender, EventArgs e)
    {
      toolTip1.Show("Resize all images at the same time using multiple threads", (Control)sender);
    }

    void UseLogo_MouseHover(object sender, EventArgs e)
    {
      toolTip1.Show("Add custom message to the image", (Control)sender);
    }

    #endregion

  }
}
