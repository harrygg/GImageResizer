namespace GImageResizer
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.resize_btn = new System.Windows.Forms.Button();
      this.labelPrefix = new System.Windows.Forms.Label();
      this.labelSuffix = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.bgWorker = new System.ComponentModel.BackgroundWorker();
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.browseFromDir_btn = new System.Windows.Forms.Button();
      this.browseToDir_btn = new System.Windows.Forms.Button();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label7 = new System.Windows.Forms.Label();
      this.cancel_btn = new System.Windows.Forms.Button();
      this.logoPanel = new System.Windows.Forms.Panel();
      this.label8 = new System.Windows.Forms.Label();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.panel4 = new System.Windows.Forms.Panel();
      this.checkBoxUseCurrentDir = new System.Windows.Forms.CheckBox();
      this.fromDir = new System.Windows.Forms.TextBox();
      this.toDir = new System.Windows.Forms.TextBox();
      this.checkBoxConcurrent = new System.Windows.Forms.CheckBox();
      this.logoInnerPanel = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.labelPosition = new System.Windows.Forms.Label();
      this.textBoxPositionY = new System.Windows.Forms.TextBox();
      this.logoText = new System.Windows.Forms.TextBox();
      this.textBoxPositionX = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.chooseColor_btn = new System.Windows.Forms.Button();
      this.labelPositionX = new System.Windows.Forms.Label();
      this.labelPositionY = new System.Windows.Forms.Label();
      this.chooseFont_btn = new System.Windows.Forms.Button();
      this.checkBoxUseLogo = new System.Windows.Forms.CheckBox();
      this.checkBoxRenameImages = new System.Windows.Forms.CheckBox();
      this.textBoxWidth = new System.Windows.Forms.TextBox();
      this.textBoxHeight = new System.Windows.Forms.TextBox();
      this.textBoxPrefix = new System.Windows.Forms.TextBox();
      this.textBoxSuffix = new System.Windows.Forms.TextBox();
      this.checkBoxKeepAspect = new System.Windows.Forms.CheckBox();
      this.fontDialog = new System.Windows.Forms.FontDialog();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.preview_btn = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.logoPanel.SuspendLayout();
      this.panel4.SuspendLayout();
      this.logoInnerPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // resize_btn
      // 
      this.resize_btn.Location = new System.Drawing.Point(6, 504);
      this.resize_btn.Name = "resize_btn";
      this.resize_btn.Size = new System.Drawing.Size(76, 33);
      this.resize_btn.TabIndex = 0;
      this.resize_btn.Text = "Resize";
      this.resize_btn.UseVisualStyleBackColor = true;
      this.resize_btn.Click += new System.EventHandler(this.resize_btn_Click);
      // 
      // labelPrefix
      // 
      this.labelPrefix.AutoSize = true;
      this.labelPrefix.Location = new System.Drawing.Point(2, 111);
      this.labelPrefix.Name = "labelPrefix";
      this.labelPrefix.Size = new System.Drawing.Size(33, 13);
      this.labelPrefix.TabIndex = 4;
      this.labelPrefix.Tag = "";
      this.labelPrefix.Text = "Prefix";
      this.labelPrefix.MouseHover += new System.EventHandler(this.Prefix_MouseHover);
      // 
      // labelSuffix
      // 
      this.labelSuffix.AutoSize = true;
      this.labelSuffix.Location = new System.Drawing.Point(3, 137);
      this.labelSuffix.Name = "labelSuffix";
      this.labelSuffix.Size = new System.Drawing.Size(33, 13);
      this.labelSuffix.TabIndex = 5;
      this.labelSuffix.Text = "Suffix";
      this.labelSuffix.MouseHover += new System.EventHandler(this.Suffix_MouseHover);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 28);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Width";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 54);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(38, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Height";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 4);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(157, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Resize all images from directory:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 5);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(180, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "Save the resized images to directory:";
      // 
      // progressBar
      // 
      this.progressBar.Location = new System.Drawing.Point(6, 475);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(334, 23);
      this.progressBar.TabIndex = 16;
      // 
      // browseFromDir_btn
      // 
      this.browseFromDir_btn.Location = new System.Drawing.Point(272, 18);
      this.browseFromDir_btn.Name = "browseFromDir_btn";
      this.browseFromDir_btn.Size = new System.Drawing.Size(59, 23);
      this.browseFromDir_btn.TabIndex = 17;
      this.browseFromDir_btn.Text = "Browse";
      this.browseFromDir_btn.UseVisualStyleBackColor = true;
      this.browseFromDir_btn.Click += new System.EventHandler(this.browse_btn_Click);
      // 
      // browseToDir_btn
      // 
      this.browseToDir_btn.Location = new System.Drawing.Point(272, 18);
      this.browseToDir_btn.Name = "browseToDir_btn";
      this.browseToDir_btn.Size = new System.Drawing.Size(59, 23);
      this.browseToDir_btn.TabIndex = 18;
      this.browseToDir_btn.Text = "Browse";
      this.browseToDir_btn.UseVisualStyleBackColor = true;
      this.browseToDir_btn.Click += new System.EventHandler(this.browseToDir_btn_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.fromDir);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.browseFromDir_btn);
      this.panel1.Location = new System.Drawing.Point(-1, 26);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(334, 45);
      this.panel1.TabIndex = 19;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.toDir);
      this.panel2.Controls.Add(this.browseToDir_btn);
      this.panel2.Location = new System.Drawing.Point(-1, 72);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(334, 45);
      this.panel2.TabIndex = 20;
      // 
      // panel3
      // 
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel3.Controls.Add(this.checkBoxRenameImages);
      this.panel3.Controls.Add(this.label7);
      this.panel3.Controls.Add(this.labelPrefix);
      this.panel3.Controls.Add(this.textBoxWidth);
      this.panel3.Controls.Add(this.textBoxHeight);
      this.panel3.Controls.Add(this.textBoxPrefix);
      this.panel3.Controls.Add(this.labelSuffix);
      this.panel3.Controls.Add(this.textBoxSuffix);
      this.panel3.Controls.Add(this.checkBoxKeepAspect);
      this.panel3.Controls.Add(this.label3);
      this.panel3.Controls.Add(this.label4);
      this.panel3.Location = new System.Drawing.Point(7, 133);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(334, 164);
      this.panel3.TabIndex = 21;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(2, 5);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(133, 13);
      this.label7.TabIndex = 10;
      this.label7.Text = "New image properties:";
      // 
      // cancel_btn
      // 
      this.cancel_btn.Enabled = false;
      this.cancel_btn.Location = new System.Drawing.Point(265, 504);
      this.cancel_btn.Name = "cancel_btn";
      this.cancel_btn.Size = new System.Drawing.Size(76, 33);
      this.cancel_btn.TabIndex = 22;
      this.cancel_btn.Text = "Cancel";
      this.cancel_btn.UseVisualStyleBackColor = true;
      this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
      // 
      // logoPanel
      // 
      this.logoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.logoPanel.Controls.Add(this.logoInnerPanel);
      this.logoPanel.Controls.Add(this.checkBoxUseLogo);
      this.logoPanel.Controls.Add(this.label8);
      this.logoPanel.Location = new System.Drawing.Point(7, 303);
      this.logoPanel.Name = "logoPanel";
      this.logoPanel.Size = new System.Drawing.Size(334, 166);
      this.logoPanel.TabIndex = 23;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(4, 4);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(99, 13);
      this.label8.TabIndex = 0;
      this.label8.Text = "Logo properties:";
      // 
      // panel4
      // 
      this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel4.Controls.Add(this.checkBoxUseCurrentDir);
      this.panel4.Controls.Add(this.panel1);
      this.panel4.Controls.Add(this.panel2);
      this.panel4.Location = new System.Drawing.Point(7, 8);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(334, 119);
      this.panel4.TabIndex = 18;
      // 
      // checkBoxUseCurrentDir
      // 
      this.checkBoxUseCurrentDir.AutoSize = true;
      this.checkBoxUseCurrentDir.Checked = global::GImageResizer.Properties.Settings.Default.useCurrentDir;
      this.checkBoxUseCurrentDir.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GImageResizer.Properties.Settings.Default, "useCurrentDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxUseCurrentDir.Location = new System.Drawing.Point(5, 3);
      this.checkBoxUseCurrentDir.Name = "checkBoxUseCurrentDir";
      this.checkBoxUseCurrentDir.Size = new System.Drawing.Size(187, 17);
      this.checkBoxUseCurrentDir.TabIndex = 14;
      this.checkBoxUseCurrentDir.Text = "Get images from current directory?";
      this.checkBoxUseCurrentDir.UseVisualStyleBackColor = true;
      this.checkBoxUseCurrentDir.Click += new System.EventHandler(this.UseCurrentDir_Click);
      this.checkBoxUseCurrentDir.MouseHover += new System.EventHandler(this.UseCurrentDir_MouseHover);
      // 
      // fromDir
      // 
      this.fromDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GImageResizer.Properties.Settings.Default, "fromDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.fromDir.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::GImageResizer.Properties.Settings.Default, "fromDirEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.fromDir.Enabled = global::GImageResizer.Properties.Settings.Default.fromDirEnabled;
      this.fromDir.Location = new System.Drawing.Point(5, 20);
      this.fromDir.Name = "fromDir";
      this.fromDir.Size = new System.Drawing.Size(261, 20);
      this.fromDir.TabIndex = 10;
      this.fromDir.Tag = "";
      this.fromDir.Text = global::GImageResizer.Properties.Settings.Default.fromDir;
      // 
      // toDir
      // 
      this.toDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GImageResizer.Properties.Settings.Default, "toDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.toDir.Location = new System.Drawing.Point(5, 21);
      this.toDir.Name = "toDir";
      this.toDir.Size = new System.Drawing.Size(261, 20);
      this.toDir.TabIndex = 13;
      this.toDir.Text = global::GImageResizer.Properties.Settings.Default.toDir;
      // 
      // checkBoxConcurrent
      // 
      this.checkBoxConcurrent.AutoSize = true;
      this.checkBoxConcurrent.Checked = global::GImageResizer.Properties.Settings.Default.concurrentResize;
      this.checkBoxConcurrent.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxConcurrent.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GImageResizer.Properties.Settings.Default, "concurrentResize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxConcurrent.Location = new System.Drawing.Point(88, 513);
      this.checkBoxConcurrent.Name = "checkBoxConcurrent";
      this.checkBoxConcurrent.Size = new System.Drawing.Size(114, 17);
      this.checkBoxConcurrent.TabIndex = 24;
      this.checkBoxConcurrent.Text = "Concurrent resize?";
      this.checkBoxConcurrent.UseVisualStyleBackColor = true;
      this.checkBoxConcurrent.MouseHover += new System.EventHandler(this.Concurrent_MouseHover);
      // 
      // logoInnerPanel
      // 
      this.logoInnerPanel.Controls.Add(this.preview_btn);
      this.logoInnerPanel.Controls.Add(this.label2);
      this.logoInnerPanel.Controls.Add(this.label1);
      this.logoInnerPanel.Controls.Add(this.labelPosition);
      this.logoInnerPanel.Controls.Add(this.textBoxPositionY);
      this.logoInnerPanel.Controls.Add(this.logoText);
      this.logoInnerPanel.Controls.Add(this.textBoxPositionX);
      this.logoInnerPanel.Controls.Add(this.label9);
      this.logoInnerPanel.Controls.Add(this.chooseColor_btn);
      this.logoInnerPanel.Controls.Add(this.labelPositionX);
      this.logoInnerPanel.Controls.Add(this.labelPositionY);
      this.logoInnerPanel.Controls.Add(this.chooseFont_btn);
      this.logoInnerPanel.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::GImageResizer.Properties.Settings.Default, "logoInnerPanelEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.logoInnerPanel.Enabled = global::GImageResizer.Properties.Settings.Default.logoInnerPanelEnabled;
      this.logoInnerPanel.Location = new System.Drawing.Point(3, 47);
      this.logoInnerPanel.Name = "logoInnerPanel";
      this.logoInnerPanel.Size = new System.Drawing.Size(326, 114);
      this.logoInnerPanel.TabIndex = 11;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(108, 79);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(18, 13);
      this.label2.TabIndex = 13;
      this.label2.Text = "px";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(108, 58);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(18, 13);
      this.label1.TabIndex = 12;
      this.label1.Text = "px";
      // 
      // labelPosition
      // 
      this.labelPosition.AutoSize = true;
      this.labelPosition.Location = new System.Drawing.Point(3, 36);
      this.labelPosition.Name = "labelPosition";
      this.labelPosition.Size = new System.Drawing.Size(44, 13);
      this.labelPosition.TabIndex = 11;
      this.labelPosition.Text = "Position";
      // 
      // textBoxPositionY
      // 
      this.textBoxPositionY.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GImageResizer.Properties.Settings.Default, "logoY", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.textBoxPositionY.Location = new System.Drawing.Point(67, 79);
      this.textBoxPositionY.Name = "textBoxPositionY";
      this.textBoxPositionY.Size = new System.Drawing.Size(40, 20);
      this.textBoxPositionY.TabIndex = 10;
      this.textBoxPositionY.Text = global::GImageResizer.Properties.Settings.Default.logoY;
      this.textBoxPositionY.MouseHover += new System.EventHandler(this.PositionY_MouseHover);
      // 
      // logoText
      // 
      this.logoText.BackColor = System.Drawing.Color.White;
      this.logoText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GImageResizer.Properties.Settings.Default, "logoText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.logoText.Location = new System.Drawing.Point(36, 3);
      this.logoText.Name = "logoText";
      this.logoText.Size = new System.Drawing.Size(155, 20);
      this.logoText.TabIndex = 3;
      this.logoText.Text = global::GImageResizer.Properties.Settings.Default.logoText;
      // 
      // textBoxPositionX
      // 
      this.textBoxPositionX.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GImageResizer.Properties.Settings.Default, "logoX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.textBoxPositionX.Location = new System.Drawing.Point(67, 55);
      this.textBoxPositionX.Name = "textBoxPositionX";
      this.textBoxPositionX.Size = new System.Drawing.Size(40, 20);
      this.textBoxPositionX.TabIndex = 9;
      this.textBoxPositionX.Text = global::GImageResizer.Properties.Settings.Default.logoX;
      this.textBoxPositionX.MouseHover += new System.EventHandler(this.PositionX_MouseHover);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(2, 7);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(28, 13);
      this.label9.TabIndex = 2;
      this.label9.Text = "Text";
      // 
      // chooseColor_btn
      // 
      this.chooseColor_btn.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::GImageResizer.Properties.Settings.Default, "logoColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.chooseColor_btn.ForeColor = global::GImageResizer.Properties.Settings.Default.logoColor;
      this.chooseColor_btn.Location = new System.Drawing.Point(248, 1);
      this.chooseColor_btn.Name = "chooseColor_btn";
      this.chooseColor_btn.Size = new System.Drawing.Size(45, 23);
      this.chooseColor_btn.TabIndex = 8;
      this.chooseColor_btn.Text = "Color";
      this.chooseColor_btn.UseVisualStyleBackColor = true;
      this.chooseColor_btn.Click += new System.EventHandler(this.chooseColor_Click);
      // 
      // labelPositionX
      // 
      this.labelPositionX.AutoSize = true;
      this.labelPositionX.Location = new System.Drawing.Point(3, 58);
      this.labelPositionX.Name = "labelPositionX";
      this.labelPositionX.Size = new System.Drawing.Size(50, 13);
      this.labelPositionX.TabIndex = 4;
      this.labelPositionX.Text = "From left:";
      this.labelPositionX.MouseHover += new System.EventHandler(this.PositionX_MouseHover);
      // 
      // labelPositionY
      // 
      this.labelPositionY.AutoSize = true;
      this.labelPositionY.Location = new System.Drawing.Point(3, 82);
      this.labelPositionY.Name = "labelPositionY";
      this.labelPositionY.Size = new System.Drawing.Size(51, 13);
      this.labelPositionY.TabIndex = 7;
      this.labelPositionY.Text = "From top:";
      this.labelPositionY.MouseHover += new System.EventHandler(this.PositionY_MouseHover);
      // 
      // chooseFont_btn
      // 
      this.chooseFont_btn.Location = new System.Drawing.Point(197, 1);
      this.chooseFont_btn.Name = "chooseFont_btn";
      this.chooseFont_btn.Size = new System.Drawing.Size(45, 23);
      this.chooseFont_btn.TabIndex = 6;
      this.chooseFont_btn.Text = "Font";
      this.chooseFont_btn.UseVisualStyleBackColor = true;
      this.chooseFont_btn.Click += new System.EventHandler(this.chooseFont_Click);
      // 
      // checkBoxUseLogo
      // 
      this.checkBoxUseLogo.AutoSize = true;
      this.checkBoxUseLogo.Checked = global::GImageResizer.Properties.Settings.Default.useLogo;
      this.checkBoxUseLogo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GImageResizer.Properties.Settings.Default, "useLogo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxUseLogo.Location = new System.Drawing.Point(7, 24);
      this.checkBoxUseLogo.Name = "checkBoxUseLogo";
      this.checkBoxUseLogo.Size = new System.Drawing.Size(214, 17);
      this.checkBoxUseLogo.TabIndex = 1;
      this.checkBoxUseLogo.Text = "Add custom text to images (watermark)?";
      this.checkBoxUseLogo.UseVisualStyleBackColor = true;
      this.checkBoxUseLogo.Click += new System.EventHandler(this.checkBoxUseLogo_Click);
      this.checkBoxUseLogo.MouseHover += new System.EventHandler(this.UseLogo_MouseHover);
      // 
      // checkBoxRenameImages
      // 
      this.checkBoxRenameImages.AutoSize = true;
      this.checkBoxRenameImages.Checked = global::GImageResizer.Properties.Settings.Default.renameImage;
      this.checkBoxRenameImages.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GImageResizer.Properties.Settings.Default, "renameImage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxRenameImages.Location = new System.Drawing.Point(7, 85);
      this.checkBoxRenameImages.Name = "checkBoxRenameImages";
      this.checkBoxRenameImages.Size = new System.Drawing.Size(108, 17);
      this.checkBoxRenameImages.TabIndex = 11;
      this.checkBoxRenameImages.Text = "Rename images?";
      this.checkBoxRenameImages.UseVisualStyleBackColor = true;
      this.checkBoxRenameImages.Click += new System.EventHandler(this.RenameImages_Click);
      this.checkBoxRenameImages.MouseHover += new System.EventHandler(this.RenameImages_MouseHover);
      // 
      // textBoxWidth
      // 
      this.textBoxWidth.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GImageResizer.Properties.Settings.Default, "imageWidth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.textBoxWidth.Location = new System.Drawing.Point(57, 25);
      this.textBoxWidth.Name = "textBoxWidth";
      this.textBoxWidth.Size = new System.Drawing.Size(46, 20);
      this.textBoxWidth.TabIndex = 1;
      this.textBoxWidth.Text = global::GImageResizer.Properties.Settings.Default.imageWidth;
      // 
      // textBoxHeight
      // 
      this.textBoxHeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GImageResizer.Properties.Settings.Default, "imageHeight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.textBoxHeight.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::GImageResizer.Properties.Settings.Default, "imageHeightEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.textBoxHeight.Enabled = global::GImageResizer.Properties.Settings.Default.imageHeightEnabled;
      this.textBoxHeight.Location = new System.Drawing.Point(57, 51);
      this.textBoxHeight.Name = "textBoxHeight";
      this.textBoxHeight.Size = new System.Drawing.Size(46, 20);
      this.textBoxHeight.TabIndex = 2;
      this.textBoxHeight.Text = global::GImageResizer.Properties.Settings.Default.imageHeight;
      // 
      // textBoxPrefix
      // 
      this.textBoxPrefix.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GImageResizer.Properties.Settings.Default, "imagePrefix", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.textBoxPrefix.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::GImageResizer.Properties.Settings.Default, "imagePrefixEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.textBoxPrefix.Enabled = global::GImageResizer.Properties.Settings.Default.imagePrefixEnabled;
      this.textBoxPrefix.Location = new System.Drawing.Point(57, 108);
      this.textBoxPrefix.Name = "textBoxPrefix";
      this.textBoxPrefix.Size = new System.Drawing.Size(100, 20);
      this.textBoxPrefix.TabIndex = 3;
      this.textBoxPrefix.Text = global::GImageResizer.Properties.Settings.Default.imagePrefix;
      this.textBoxPrefix.MouseHover += new System.EventHandler(this.Prefix_MouseHover);
      // 
      // textBoxSuffix
      // 
      this.textBoxSuffix.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GImageResizer.Properties.Settings.Default, "imageSuffix", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.textBoxSuffix.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::GImageResizer.Properties.Settings.Default, "imageSuffixEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.textBoxSuffix.Enabled = global::GImageResizer.Properties.Settings.Default.imageSuffixEnabled;
      this.textBoxSuffix.Location = new System.Drawing.Point(57, 134);
      this.textBoxSuffix.Name = "textBoxSuffix";
      this.textBoxSuffix.Size = new System.Drawing.Size(100, 20);
      this.textBoxSuffix.TabIndex = 6;
      this.textBoxSuffix.Text = global::GImageResizer.Properties.Settings.Default.imageSuffix;
      this.textBoxSuffix.MouseHover += new System.EventHandler(this.Suffix_MouseHover);
      // 
      // checkBoxKeepAspect
      // 
      this.checkBoxKeepAspect.AutoSize = true;
      this.checkBoxKeepAspect.Checked = global::GImageResizer.Properties.Settings.Default.keepAspectRatio;
      this.checkBoxKeepAspect.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxKeepAspect.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GImageResizer.Properties.Settings.Default, "keepAspectRatio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxKeepAspect.Location = new System.Drawing.Point(117, 28);
      this.checkBoxKeepAspect.Name = "checkBoxKeepAspect";
      this.checkBoxKeepAspect.Size = new System.Drawing.Size(151, 17);
      this.checkBoxKeepAspect.TabIndex = 9;
      this.checkBoxKeepAspect.Text = "Keep original aspect ration";
      this.checkBoxKeepAspect.UseVisualStyleBackColor = true;
      this.checkBoxKeepAspect.Click += new System.EventHandler(this.keepAspect_Click);
      // 
      // fontDialog
      // 
      this.fontDialog.Font = global::GImageResizer.Properties.Settings.Default.logoFont;
      // 
      // colorDialog1
      // 
      this.colorDialog1.Color = global::GImageResizer.Properties.Settings.Default.logoColor;
      // 
      // preview_btn
      // 
      this.preview_btn.Location = new System.Drawing.Point(268, 88);
      this.preview_btn.Name = "preview_btn";
      this.preview_btn.Size = new System.Drawing.Size(55, 23);
      this.preview_btn.TabIndex = 14;
      this.preview_btn.Text = "Preview";
      this.preview_btn.UseVisualStyleBackColor = true;
      this.preview_btn.Click += new System.EventHandler(this.preview_btn_Click);
      this.preview_btn.MouseHover += new System.EventHandler(this.preview_btn_MouseHover);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(349, 544);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.checkBoxConcurrent);
      this.Controls.Add(this.logoPanel);
      this.Controls.Add(this.cancel_btn);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.progressBar);
      this.Controls.Add(this.resize_btn);
      this.Name = "MainForm";
      this.Text = "g Image Resizer";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.logoPanel.ResumeLayout(false);
      this.logoPanel.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.logoInnerPanel.ResumeLayout(false);
      this.logoInnerPanel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button resize_btn;
    private System.Windows.Forms.TextBox textBoxWidth;
    private System.Windows.Forms.TextBox textBoxHeight;
    private System.Windows.Forms.TextBox textBoxPrefix;
    private System.Windows.Forms.Label labelPrefix;
    private System.Windows.Forms.Label labelSuffix;
    private System.Windows.Forms.TextBox textBoxSuffix;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox checkBoxKeepAspect;
    private System.Windows.Forms.TextBox fromDir;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox toDir;
    private System.Windows.Forms.CheckBox checkBoxUseCurrentDir;
    private System.ComponentModel.BackgroundWorker bgWorker;
    private System.Windows.Forms.ProgressBar progressBar;
    private System.Windows.Forms.Button browseFromDir_btn;
    private System.Windows.Forms.Button browseToDir_btn;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button cancel_btn;
    private System.Windows.Forms.Panel logoPanel;
    private System.Windows.Forms.Button chooseFont_btn;
    private System.Windows.Forms.TextBox logoText;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.CheckBox checkBoxUseLogo;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.FontDialog fontDialog;
    private System.Windows.Forms.CheckBox checkBoxConcurrent;
    private System.Windows.Forms.Button chooseColor_btn;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Label labelPositionY;
    private System.Windows.Forms.Label labelPositionX;
    private System.Windows.Forms.TextBox textBoxPositionY;
    private System.Windows.Forms.TextBox textBoxPositionX;
    private System.Windows.Forms.Panel logoInnerPanel;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.CheckBox checkBoxRenameImages;
    private System.Windows.Forms.Label labelPosition;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Button preview_btn;
  }
}

