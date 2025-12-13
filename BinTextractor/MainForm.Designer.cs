namespace BinTextractor
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            minBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            maxBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            labelTitle = new Label();
            buttonTheme = new Guna.UI2.WinForms.Guna2Button();
            buttonAbout = new Guna.UI2.WinForms.Guna2Button();
            panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            buttonBrowseOutput = new Guna.UI2.WinForms.Guna2Button();
            groupBoxFilters = new GroupBox();
            checkBoxAscii = new Guna.UI2.WinForms.Guna2CheckBox();
            textBoxSearchPattern = new Guna.UI2.WinForms.Guna2TextBox();
            labelSearchPattern = new Label();
            numericUpDownMinLength = new NumericUpDown();
            labelMinLength = new Label();
            checkBoxUnicode = new Guna.UI2.WinForms.Guna2CheckBox();
            labelTargetFile = new Label();
            textBoxTargetPath = new Guna.UI2.WinForms.Guna2TextBox();
            buttonBrowseTarget = new Guna.UI2.WinForms.Guna2Button();
            labelOutputFile = new Label();
            textBoxOutputPath = new Guna.UI2.WinForms.Guna2TextBox();
            progressBarExtraction = new Guna.UI2.WinForms.Guna2ProgressBar();
            panelRight = new Guna.UI2.WinForms.Guna2Panel();
            groupBoxResults = new GroupBox();
            richTextBoxResults = new RichTextBox();
            textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            labelSearchResults = new Label();
            labelStats = new Label();
            panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            buttonStop = new Guna.UI2.WinForms.Guna2Button();
            buttonExtract = new Guna.UI2.WinForms.Guna2Button();
            buttonClearResults = new Guna.UI2.WinForms.Guna2Button();
            buttonSaveResults = new Guna.UI2.WinForms.Guna2Button();
            buttonCopyResults = new Guna.UI2.WinForms.Guna2Button();
            statusStripMain = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar = new ToolStripProgressBar();
            timerProgress = new System.Windows.Forms.Timer(components);
            maximuzeToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            panelHeader.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinLength).BeginInit();
            panelRight.SuspendLayout();
            groupBoxResults.SuspendLayout();
            panelBottom.SuspendLayout();
            statusStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Black;
            panelHeader.Controls.Add(minBtn);
            panelHeader.Controls.Add(maxBtn);
            panelHeader.Controls.Add(closeBtn);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Controls.Add(buttonTheme);
            panelHeader.Controls.Add(buttonAbout);
            panelHeader.CustomizableEdges = null;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = Color.FromArgb(5, 10, 15);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.CustomizableEdges = null;
            panelHeader.Size = new Size(1198, 71);
            panelHeader.TabIndex = 0;
            panelHeader.MouseDown += OnMouseDown;
            panelHeader.MouseMove += OnMouseMove;
            panelHeader.MouseUp += OnMouseUp;
            // 
            // minBtn
            // 
            minBtn.AnimatedGIF = true;
            minBtn.BackColor = Color.Transparent;
            minBtn.CheckedState.ImageSize = new Size(64, 64);
            minBtn.Dock = DockStyle.Right;
            minBtn.HoverState.Image = (Image)resources.GetObject("resource.Image");
            minBtn.HoverState.ImageSize = new Size(13, 13);
            minBtn.Image = (Image)resources.GetObject("minBtn.Image");
            minBtn.ImageOffset = new Point(0, 0);
            minBtn.ImageRotate = 0F;
            minBtn.ImageSize = new Size(12, 12);
            minBtn.Location = new Point(1150, 0);
            minBtn.Margin = new Padding(4, 3, 4, 3);
            minBtn.Name = "minBtn";
            minBtn.Padding = new Padding(5, 0, 0, 0);
            minBtn.PressedState.ImageSize = new Size(13, 13);
            minBtn.ShadowDecoration.Color = Color.FromArgb(0, 255, 0);
            minBtn.ShadowDecoration.CustomizableEdges = customizableEdges1;
            minBtn.ShadowDecoration.Depth = 10;
            minBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            minBtn.ShadowDecoration.Shadow = new Padding(0, 0, 0, 10);
            minBtn.Size = new Size(20, 71);
            minBtn.TabIndex = 7;
            minBtn.Click += minBtn_Click;
            // 
            // maxBtn
            // 
            maxBtn.AnimatedGIF = true;
            maxBtn.BackColor = Color.Transparent;
            maxBtn.CheckedState.ImageSize = new Size(64, 64);
            maxBtn.Dock = DockStyle.Right;
            maxBtn.HoverState.Image = (Image)resources.GetObject("resource.Image1");
            maxBtn.HoverState.ImageSize = new Size(13, 13);
            maxBtn.Image = (Image)resources.GetObject("maxBtn.Image");
            maxBtn.ImageOffset = new Point(0, 0);
            maxBtn.ImageRotate = 0F;
            maxBtn.ImageSize = new Size(12, 12);
            maxBtn.Location = new Point(1170, 0);
            maxBtn.Margin = new Padding(4, 3, 4, 3);
            maxBtn.Name = "maxBtn";
            maxBtn.Padding = new Padding(5, 0, 0, 0);
            maxBtn.PressedState.ImageSize = new Size(13, 13);
            maxBtn.ShadowDecoration.Color = Color.FromArgb(0, 255, 0);
            maxBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            maxBtn.ShadowDecoration.Depth = 10;
            maxBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            maxBtn.ShadowDecoration.Shadow = new Padding(0, 0, 0, 10);
            maxBtn.Size = new Size(13, 71);
            maxBtn.TabIndex = 6;
            maxBtn.Click += maxBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Transparent;
            closeBtn.CheckedState.ImageSize = new Size(64, 64);
            closeBtn.Dock = DockStyle.Right;
            closeBtn.HoverState.Image = (Image)resources.GetObject("resource.Image2");
            closeBtn.HoverState.ImageSize = new Size(13, 13);
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.ImageOffset = new Point(0, 0);
            closeBtn.ImageRotate = 0F;
            closeBtn.ImageSize = new Size(12, 12);
            closeBtn.Location = new Point(1183, 0);
            closeBtn.Margin = new Padding(4, 3, 4, 3);
            closeBtn.Name = "closeBtn";
            closeBtn.Padding = new Padding(10, 0, 0, 0);
            closeBtn.PressedState.ImageSize = new Size(13, 13);
            closeBtn.ShadowDecoration.Color = Color.FromArgb(255, 0, 0);
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            closeBtn.ShadowDecoration.Depth = 10;
            closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            closeBtn.ShadowDecoration.Shadow = new Padding(0, 0, 0, 10);
            closeBtn.Size = new Size(15, 71);
            closeBtn.TabIndex = 5;
            closeBtn.Click += closeBtn_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Consolas", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(0, 255, 0);
            labelTitle.Location = new Point(20, 20);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(181, 28);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "BinTextractor";
            labelTitle.MouseDown += OnMouseDown;
            labelTitle.MouseMove += OnMouseMove;
            labelTitle.MouseUp += OnMouseUp;
            // 
            // buttonTheme
            // 
            buttonTheme.Animated = true;
            buttonTheme.BackColor = Color.Transparent;
            buttonTheme.BorderColor = Color.Transparent;
            buttonTheme.BorderRadius = 8;
            buttonTheme.BorderThickness = 1;
            buttonTheme.CustomBorderColor = Color.FromArgb(100, 116, 139);
            buttonTheme.CustomizableEdges = null;
            buttonTheme.DisabledState.BorderColor = Color.FromArgb(148, 163, 184);
            buttonTheme.DisabledState.CustomBorderColor = Color.FromArgb(148, 163, 184);
            buttonTheme.DisabledState.FillColor = Color.FromArgb(148, 163, 184);
            buttonTheme.DisabledState.ForeColor = Color.FromArgb(100, 116, 139);
            buttonTheme.FillColor = Color.Transparent;
            buttonTheme.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonTheme.ForeColor = Color.FromArgb(248, 250, 252);
            buttonTheme.HoverState.FillColor = Color.Transparent;
            buttonTheme.Image = Properties.Resources.Do_not_Disturb_iOS;
            buttonTheme.Location = new Point(1117, 20);
            buttonTheme.Margin = new Padding(4, 3, 4, 3);
            buttonTheme.Name = "buttonTheme";
            buttonTheme.PressedColor = Color.Silver;
            buttonTheme.ShadowDecoration.CustomizableEdges = null;
            buttonTheme.Size = new Size(31, 34);
            buttonTheme.TabIndex = 2;
            buttonTheme.Visible = false;
            buttonTheme.Click += buttonTheme_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = Color.Transparent;
            buttonAbout.BorderColor = Color.FromArgb(32, 39, 46);
            buttonAbout.BorderRadius = 8;
            buttonAbout.BorderThickness = 1;
            buttonAbout.CustomBorderColor = Color.FromArgb(168, 85, 247);
            buttonAbout.CustomizableEdges = null;
            buttonAbout.DisabledState.BorderColor = Color.FromArgb(148, 163, 184);
            buttonAbout.DisabledState.CustomBorderColor = Color.FromArgb(148, 163, 184);
            buttonAbout.DisabledState.FillColor = Color.FromArgb(168, 85, 247);
            buttonAbout.DisabledState.ForeColor = Color.FromArgb(100, 116, 139);
            buttonAbout.FillColor = Color.FromArgb(14, 20, 26);
            buttonAbout.Font = new Font("Segoe UI", 9F);
            buttonAbout.ForeColor = Color.FromArgb(248, 250, 252);
            buttonAbout.HoverState.FillColor = Color.FromArgb(12, 19, 26);
            buttonAbout.Location = new Point(1075, 24);
            buttonAbout.Margin = new Padding(4, 3, 4, 3);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.PressedColor = Color.Silver;
            buttonAbout.ShadowDecoration.BorderRadius = 10;
            buttonAbout.ShadowDecoration.Color = Color.Indigo;
            buttonAbout.ShadowDecoration.CustomizableEdges = null;
            buttonAbout.ShadowDecoration.Depth = 50;
            buttonAbout.ShadowDecoration.Enabled = true;
            buttonAbout.ShadowDecoration.Shadow = new Padding(0);
            buttonAbout.Size = new Size(73, 30);
            buttonAbout.TabIndex = 3;
            buttonAbout.Text = "About";
            buttonAbout.Click += buttonAbout_Click;
            // 
            // panelLeft
            // 
            panelLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelLeft.BorderRadius = 4;
            panelLeft.Controls.Add(buttonBrowseOutput);
            panelLeft.Controls.Add(groupBoxFilters);
            panelLeft.Controls.Add(labelTargetFile);
            panelLeft.Controls.Add(textBoxTargetPath);
            panelLeft.Controls.Add(buttonBrowseTarget);
            panelLeft.Controls.Add(labelOutputFile);
            panelLeft.Controls.Add(textBoxOutputPath);
            panelLeft.Controls.Add(progressBarExtraction);
            panelLeft.CustomizableEdges = null;
            panelLeft.FillColor = Color.FromArgb(8, 12, 16);
            panelLeft.Location = new Point(5, 72);
            panelLeft.Margin = new Padding(4, 3, 4, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.ShadowDecoration.CustomizableEdges = null;
            panelLeft.Size = new Size(420, 458);
            panelLeft.TabIndex = 1;
            panelLeft.MouseDown += OnMouseDown;
            panelLeft.MouseMove += OnMouseMove;
            panelLeft.MouseUp += OnMouseUp;
            // 
            // buttonBrowseOutput
            // 
            buttonBrowseOutput.BackColor = Color.Transparent;
            buttonBrowseOutput.BorderColor = Color.Lime;
            buttonBrowseOutput.BorderRadius = 8;
            buttonBrowseOutput.BorderThickness = 1;
            buttonBrowseOutput.CustomBorderColor = Color.FromArgb(0, 255, 0);
            buttonBrowseOutput.CustomizableEdges = customizableEdges4;
            buttonBrowseOutput.DisabledState.BorderColor = Color.FromArgb(100, 100, 100);
            buttonBrowseOutput.DisabledState.CustomBorderColor = Color.FromArgb(100, 100, 100);
            buttonBrowseOutput.DisabledState.FillColor = Color.FromArgb(50, 50, 50);
            buttonBrowseOutput.DisabledState.ForeColor = Color.FromArgb(150, 150, 150);
            buttonBrowseOutput.FillColor = Color.FromArgb(0, 50, 0);
            buttonBrowseOutput.Font = new Font("Consolas", 9F, FontStyle.Bold);
            buttonBrowseOutput.ForeColor = Color.FromArgb(0, 255, 0);
            buttonBrowseOutput.HoverState.FillColor = Color.FromArgb(0, 100, 0);
            buttonBrowseOutput.Location = new Point(300, 113);
            buttonBrowseOutput.Margin = new Padding(4, 3, 4, 3);
            buttonBrowseOutput.Name = "buttonBrowseOutput";
            buttonBrowseOutput.PressedColor = Color.Silver;
            buttonBrowseOutput.ShadowDecoration.BorderRadius = 10;
            buttonBrowseOutput.ShadowDecoration.Color = Color.Lime;
            buttonBrowseOutput.ShadowDecoration.CustomizableEdges = null;
            buttonBrowseOutput.ShadowDecoration.Enabled = true;
            buttonBrowseOutput.Size = new Size(94, 25);
            buttonBrowseOutput.TabIndex = 7;
            buttonBrowseOutput.Text = "Browse";
            buttonBrowseOutput.Click += buttonBrowseOutput_Click;
            // 
            // groupBoxFilters
            // 
            groupBoxFilters.Controls.Add(checkBoxAscii);
            groupBoxFilters.Controls.Add(textBoxSearchPattern);
            groupBoxFilters.Controls.Add(labelSearchPattern);
            groupBoxFilters.Controls.Add(numericUpDownMinLength);
            groupBoxFilters.Controls.Add(labelMinLength);
            groupBoxFilters.Controls.Add(checkBoxUnicode);
            groupBoxFilters.Font = new Font("Consolas", 10F, FontStyle.Bold);
            groupBoxFilters.ForeColor = Color.Lime;
            groupBoxFilters.Location = new Point(5, 233);
            groupBoxFilters.Margin = new Padding(4, 3, 4, 3);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Padding = new Padding(4, 3, 4, 3);
            groupBoxFilters.Size = new Size(390, 180);
            groupBoxFilters.TabIndex = 5;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Text = "Extraction Filters";
            // 
            // checkBoxAscii
            // 
            checkBoxAscii.AutoSize = true;
            checkBoxAscii.Checked = true;
            checkBoxAscii.CheckedState.BorderColor = Color.FromArgb(0, 255, 0);
            checkBoxAscii.CheckedState.BorderRadius = 2;
            checkBoxAscii.CheckedState.BorderThickness = 2;
            checkBoxAscii.CheckedState.FillColor = Color.FromArgb(0, 255, 0);
            checkBoxAscii.CheckState = CheckState.Checked;
            checkBoxAscii.Font = new Font("Consolas", 10F);
            checkBoxAscii.ForeColor = Color.FromArgb(0, 255, 0);
            checkBoxAscii.Location = new Point(24, 113);
            checkBoxAscii.Margin = new Padding(4, 3, 4, 3);
            checkBoxAscii.Name = "checkBoxAscii";
            checkBoxAscii.Size = new Size(67, 21);
            checkBoxAscii.TabIndex = 7;
            checkBoxAscii.Text = "ASCII";
            checkBoxAscii.UncheckedState.BorderColor = Color.FromArgb(100, 100, 100);
            checkBoxAscii.UncheckedState.BorderRadius = 2;
            checkBoxAscii.UncheckedState.BorderThickness = 2;
            checkBoxAscii.UncheckedState.FillColor = Color.Transparent;
            checkBoxAscii.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchPattern
            // 
            textBoxSearchPattern.BackgroundImageLayout = ImageLayout.Center;
            textBoxSearchPattern.BorderRadius = 8;
            textBoxSearchPattern.BorderThickness = 2;
            textBoxSearchPattern.CustomizableEdges = null;
            textBoxSearchPattern.DefaultText = "";
            textBoxSearchPattern.DisabledState.BorderColor = Color.FromArgb(148, 163, 184);
            textBoxSearchPattern.DisabledState.FillColor = Color.FromArgb(248, 250, 252);
            textBoxSearchPattern.DisabledState.ForeColor = Color.FromArgb(100, 116, 139);
            textBoxSearchPattern.DisabledState.PlaceholderForeColor = Color.FromArgb(148, 163, 184);
            textBoxSearchPattern.FillColor = Color.FromArgb(0, 4, 8);
            textBoxSearchPattern.FocusedState.BorderColor = Color.FromArgb(0, 255, 0);
            textBoxSearchPattern.Font = new Font("Consolas", 10F);
            textBoxSearchPattern.ForeColor = Color.FromArgb(200, 255, 200);
            textBoxSearchPattern.HoverState.BorderColor = Color.Lime;
            textBoxSearchPattern.Location = new Point(25, 50);
            textBoxSearchPattern.Name = "textBoxSearchPattern";
            textBoxSearchPattern.PlaceholderText = "Enter regex pattern (e.g., .*string.*)";
            textBoxSearchPattern.SelectedText = "";
            textBoxSearchPattern.ShadowDecoration.CustomizableEdges = null;
            textBoxSearchPattern.Size = new Size(350, 25);
            textBoxSearchPattern.TabIndex = 6;
            // 
            // labelSearchPattern
            // 
            labelSearchPattern.AutoSize = true;
            labelSearchPattern.Font = new Font("Consolas", 10F);
            labelSearchPattern.ForeColor = Color.Lime;
            labelSearchPattern.Location = new Point(24, 25);
            labelSearchPattern.Margin = new Padding(4, 0, 4, 0);
            labelSearchPattern.Name = "labelSearchPattern";
            labelSearchPattern.Size = new Size(192, 17);
            labelSearchPattern.TabIndex = 0;
            labelSearchPattern.Text = "Search Pattern (Regex):";
            // 
            // numericUpDownMinLength
            // 
            numericUpDownMinLength.BackColor = Color.Black;
            numericUpDownMinLength.Font = new Font("Consolas", 10F);
            numericUpDownMinLength.ForeColor = Color.Silver;
            numericUpDownMinLength.Location = new Point(200, 80);
            numericUpDownMinLength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMinLength.Name = "numericUpDownMinLength";
            numericUpDownMinLength.Size = new Size(120, 23);
            numericUpDownMinLength.TabIndex = 2;
            numericUpDownMinLength.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // labelMinLength
            // 
            labelMinLength.AutoSize = true;
            labelMinLength.Font = new Font("Consolas", 10F);
            labelMinLength.ForeColor = Color.Lime;
            labelMinLength.Location = new Point(24, 82);
            labelMinLength.Margin = new Padding(4, 0, 4, 0);
            labelMinLength.Name = "labelMinLength";
            labelMinLength.Size = new Size(128, 17);
            labelMinLength.TabIndex = 1;
            labelMinLength.Text = "Minimum Length:";
            // 
            // checkBoxUnicode
            // 
            checkBoxUnicode.AutoSize = true;
            checkBoxUnicode.Checked = true;
            checkBoxUnicode.CheckedState.BorderColor = Color.FromArgb(0, 255, 0);
            checkBoxUnicode.CheckedState.BorderRadius = 2;
            checkBoxUnicode.CheckedState.BorderThickness = 2;
            checkBoxUnicode.CheckedState.FillColor = Color.FromArgb(0, 255, 0);
            checkBoxUnicode.CheckState = CheckState.Checked;
            checkBoxUnicode.Font = new Font("Consolas", 10F);
            checkBoxUnicode.ForeColor = Color.FromArgb(0, 255, 0);
            checkBoxUnicode.Location = new Point(24, 140);
            checkBoxUnicode.Margin = new Padding(4, 3, 4, 3);
            checkBoxUnicode.Name = "checkBoxUnicode";
            checkBoxUnicode.Size = new Size(83, 21);
            checkBoxUnicode.TabIndex = 4;
            checkBoxUnicode.Text = "Unicode";
            checkBoxUnicode.UncheckedState.BorderColor = Color.FromArgb(100, 100, 100);
            checkBoxUnicode.UncheckedState.BorderRadius = 2;
            checkBoxUnicode.UncheckedState.BorderThickness = 2;
            checkBoxUnicode.UncheckedState.FillColor = Color.Transparent;
            checkBoxUnicode.UseVisualStyleBackColor = true;
            // 
            // labelTargetFile
            // 
            labelTargetFile.AutoSize = true;
            labelTargetFile.BackColor = Color.Transparent;
            labelTargetFile.Font = new Font("Consolas", 10F, FontStyle.Bold);
            labelTargetFile.ForeColor = Color.Lime;
            labelTargetFile.Location = new Point(15, 24);
            labelTargetFile.Margin = new Padding(4, 0, 4, 0);
            labelTargetFile.Name = "labelTargetFile";
            labelTargetFile.Size = new Size(104, 17);
            labelTargetFile.TabIndex = 0;
            labelTargetFile.Text = "Target File:";
            // 
            // textBoxTargetPath
            // 
            textBoxTargetPath.AllowDrop = true;
            textBoxTargetPath.BackgroundImageLayout = ImageLayout.Center;
            textBoxTargetPath.BorderRadius = 8;
            textBoxTargetPath.BorderThickness = 2;
            textBoxTargetPath.CustomizableEdges = null;
            textBoxTargetPath.DefaultText = "";
            textBoxTargetPath.DisabledState.BorderColor = Color.FromArgb(148, 163, 184);
            textBoxTargetPath.DisabledState.FillColor = Color.FromArgb(248, 250, 252);
            textBoxTargetPath.DisabledState.ForeColor = Color.FromArgb(100, 116, 139);
            textBoxTargetPath.DisabledState.PlaceholderForeColor = Color.FromArgb(148, 163, 184);
            textBoxTargetPath.FillColor = Color.Black;
            textBoxTargetPath.FocusedState.BorderColor = Color.FromArgb(0, 255, 0);
            textBoxTargetPath.Font = new Font("Consolas", 10F);
            textBoxTargetPath.ForeColor = Color.FromArgb(200, 255, 200);
            textBoxTargetPath.HoverState.BorderColor = Color.Lime;
            textBoxTargetPath.Location = new Point(15, 48);
            textBoxTargetPath.Name = "textBoxTargetPath";
            textBoxTargetPath.PlaceholderText = "Select exe/dll file to extract strings from";
            textBoxTargetPath.SelectedText = "";
            textBoxTargetPath.ShadowDecoration.CustomizableEdges = null;
            textBoxTargetPath.Size = new Size(280, 25);
            textBoxTargetPath.TabIndex = 1;
            textBoxTargetPath.DragDrop += textBoxTargetPath_DragDrop;
            textBoxTargetPath.DragEnter += textBoxTargetPath_DragEnter;
            textBoxTargetPath.DragOver += textBoxTargetPath_DragOver;
            // 
            // buttonBrowseTarget
            // 
            buttonBrowseTarget.BackColor = Color.Transparent;
            buttonBrowseTarget.BorderColor = Color.Lime;
            buttonBrowseTarget.BorderRadius = 8;
            buttonBrowseTarget.BorderThickness = 1;
            buttonBrowseTarget.CustomBorderColor = Color.FromArgb(0, 255, 0);
            buttonBrowseTarget.CustomizableEdges = customizableEdges5;
            buttonBrowseTarget.DisabledState.BorderColor = Color.FromArgb(100, 100, 100);
            buttonBrowseTarget.DisabledState.CustomBorderColor = Color.FromArgb(100, 100, 100);
            buttonBrowseTarget.DisabledState.FillColor = Color.FromArgb(50, 50, 50);
            buttonBrowseTarget.DisabledState.ForeColor = Color.FromArgb(150, 150, 150);
            buttonBrowseTarget.FillColor = Color.FromArgb(0, 50, 0);
            buttonBrowseTarget.Font = new Font("Consolas", 9F, FontStyle.Bold);
            buttonBrowseTarget.ForeColor = Color.FromArgb(0, 255, 0);
            buttonBrowseTarget.HoverState.FillColor = Color.FromArgb(0, 100, 0);
            buttonBrowseTarget.Location = new Point(300, 48);
            buttonBrowseTarget.Margin = new Padding(4, 3, 4, 3);
            buttonBrowseTarget.Name = "buttonBrowseTarget";
            buttonBrowseTarget.PressedColor = Color.Silver;
            buttonBrowseTarget.ShadowDecoration.BorderRadius = 10;
            buttonBrowseTarget.ShadowDecoration.Color = Color.Lime;
            buttonBrowseTarget.ShadowDecoration.CustomizableEdges = null;
            buttonBrowseTarget.ShadowDecoration.Enabled = true;
            buttonBrowseTarget.Size = new Size(94, 25);
            buttonBrowseTarget.TabIndex = 2;
            buttonBrowseTarget.Text = "Browse";
            buttonBrowseTarget.Click += buttonBrowseTarget_Click;
            // 
            // labelOutputFile
            // 
            labelOutputFile.AutoSize = true;
            labelOutputFile.BackColor = Color.Transparent;
            labelOutputFile.Font = new Font("Consolas", 10F, FontStyle.Bold);
            labelOutputFile.ForeColor = Color.Lime;
            labelOutputFile.Location = new Point(15, 88);
            labelOutputFile.Margin = new Padding(4, 0, 4, 0);
            labelOutputFile.Name = "labelOutputFile";
            labelOutputFile.Size = new Size(104, 17);
            labelOutputFile.TabIndex = 3;
            labelOutputFile.Text = "Output File:";
            // 
            // textBoxOutputPath
            // 
            textBoxOutputPath.BackgroundImageLayout = ImageLayout.Center;
            textBoxOutputPath.BorderRadius = 8;
            textBoxOutputPath.BorderThickness = 2;
            textBoxOutputPath.CustomizableEdges = null;
            textBoxOutputPath.DefaultText = "";
            textBoxOutputPath.DisabledState.BorderColor = Color.FromArgb(148, 163, 184);
            textBoxOutputPath.DisabledState.FillColor = Color.FromArgb(248, 250, 252);
            textBoxOutputPath.DisabledState.ForeColor = Color.FromArgb(100, 116, 139);
            textBoxOutputPath.DisabledState.PlaceholderForeColor = Color.FromArgb(148, 163, 184);
            textBoxOutputPath.FillColor = Color.Black;
            textBoxOutputPath.FocusedState.BorderColor = Color.FromArgb(0, 255, 0);
            textBoxOutputPath.Font = new Font("Consolas", 10F);
            textBoxOutputPath.ForeColor = Color.FromArgb(200, 255, 200);
            textBoxOutputPath.HoverState.BorderColor = Color.Lime;
            textBoxOutputPath.Location = new Point(15, 113);
            textBoxOutputPath.Name = "textBoxOutputPath";
            textBoxOutputPath.PlaceholderText = "Output file path for extracted strings";
            textBoxOutputPath.SelectedText = "";
            textBoxOutputPath.ShadowDecoration.CustomizableEdges = null;
            textBoxOutputPath.Size = new Size(280, 25);
            textBoxOutputPath.TabIndex = 4;
            // 
            // progressBarExtraction
            // 
            progressBarExtraction.BorderColor = Color.White;
            progressBarExtraction.BorderRadius = 8;
            progressBarExtraction.CustomizableEdges = null;
            progressBarExtraction.FillColor = Color.FromArgb(29, 33, 38);
            progressBarExtraction.ForeColor = Color.White;
            progressBarExtraction.Location = new Point(5, 418);
            progressBarExtraction.Margin = new Padding(4, 3, 4, 3);
            progressBarExtraction.Name = "progressBarExtraction";
            progressBarExtraction.ProgressColor = Color.FromArgb(0, 255, 0);
            progressBarExtraction.ProgressColor2 = Color.FromArgb(0, 255, 255);
            progressBarExtraction.ShadowDecoration.CustomizableEdges = null;
            progressBarExtraction.Size = new Size(390, 30);
            progressBarExtraction.TabIndex = 6;
            progressBarExtraction.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(groupBoxResults);
            panelRight.CustomizableEdges = null;
            panelRight.FillColor = Color.FromArgb(10, 15, 20);
            panelRight.Location = new Point(440, 71);
            panelRight.Margin = new Padding(4, 3, 4, 3);
            panelRight.Name = "panelRight";
            panelRight.ShadowDecoration.CustomizableEdges = null;
            panelRight.Size = new Size(758, 545);
            panelRight.TabIndex = 2;
            // 
            // groupBoxResults
            // 
            groupBoxResults.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxResults.Controls.Add(richTextBoxResults);
            groupBoxResults.Controls.Add(textBoxSearch);
            groupBoxResults.Controls.Add(labelSearchResults);
            groupBoxResults.Font = new Font("Consolas", 10F, FontStyle.Bold);
            groupBoxResults.ForeColor = Color.Lime;
            groupBoxResults.Location = new Point(2, 0);
            groupBoxResults.Margin = new Padding(4, 3, 4, 3);
            groupBoxResults.Name = "groupBoxResults";
            groupBoxResults.Padding = new Padding(4, 3, 4, 3);
            groupBoxResults.Size = new Size(756, 459);
            groupBoxResults.TabIndex = 0;
            groupBoxResults.TabStop = false;
            groupBoxResults.Text = "Extraction Results";
            // 
            // richTextBoxResults
            // 
            richTextBoxResults.BackColor = Color.FromArgb(5, 10, 15);
            richTextBoxResults.Font = new Font("Consolas", 10F);
            richTextBoxResults.ForeColor = Color.FromArgb(0, 255, 0);
            richTextBoxResults.Location = new Point(15, 85);
            richTextBoxResults.Margin = new Padding(4, 3, 4, 3);
            richTextBoxResults.Name = "richTextBoxResults";
            richTextBoxResults.ReadOnly = true;
            richTextBoxResults.Size = new Size(739, 354);
            richTextBoxResults.TabIndex = 2;
            richTextBoxResults.Text = "";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackgroundImageLayout = ImageLayout.Center;
            textBoxSearch.BorderRadius = 8;
            textBoxSearch.BorderThickness = 2;
            textBoxSearch.CustomizableEdges = null;
            textBoxSearch.DefaultText = "";
            textBoxSearch.DisabledState.BorderColor = Color.FromArgb(148, 163, 184);
            textBoxSearch.DisabledState.FillColor = Color.FromArgb(248, 250, 252);
            textBoxSearch.DisabledState.ForeColor = Color.FromArgb(100, 116, 139);
            textBoxSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(148, 163, 184);
            textBoxSearch.FillColor = Color.Black;
            textBoxSearch.FocusedState.BorderColor = Color.FromArgb(0, 255, 0);
            textBoxSearch.Font = new Font("Consolas", 10F);
            textBoxSearch.ForeColor = Color.FromArgb(200, 255, 200);
            textBoxSearch.HoverState.BorderColor = Color.Lime;
            textBoxSearch.Location = new Point(20, 50);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search in extracted results...";
            textBoxSearch.SelectedText = "";
            textBoxSearch.ShadowDecoration.CustomizableEdges = null;
            textBoxSearch.Size = new Size(250, 25);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // labelSearchResults
            // 
            labelSearchResults.AutoSize = true;
            labelSearchResults.Font = new Font("Consolas", 10F);
            labelSearchResults.ForeColor = Color.Lime;
            labelSearchResults.Location = new Point(20, 25);
            labelSearchResults.Margin = new Padding(4, 0, 4, 0);
            labelSearchResults.Name = "labelSearchResults";
            labelSearchResults.Size = new Size(128, 17);
            labelSearchResults.TabIndex = 0;
            labelSearchResults.Text = "Filter Results:";
            // 
            // labelStats
            // 
            labelStats.AutoSize = true;
            labelStats.Font = new Font("Consolas", 9F, FontStyle.Italic);
            labelStats.ForeColor = Color.FromArgb(0, 255, 255);
            labelStats.Location = new Point(738, 543);
            labelStats.Margin = new Padding(4, 0, 4, 0);
            labelStats.Name = "labelStats";
            labelStats.Size = new Size(168, 14);
            labelStats.TabIndex = 1;
            labelStats.Text = "Ready for extraction...";
            labelStats.TextAlign = ContentAlignment.MiddleLeft;
            labelStats.Click += labelStats_Click;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonStop);
            panelBottom.Controls.Add(buttonExtract);
            panelBottom.Controls.Add(buttonClearResults);
            panelBottom.Controls.Add(buttonSaveResults);
            panelBottom.Controls.Add(buttonCopyResults);
            panelBottom.CustomizableEdges = null;
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.FillColor = Color.FromArgb(14, 20, 26);
            panelBottom.Location = new Point(0, 536);
            panelBottom.Margin = new Padding(4, 3, 4, 3);
            panelBottom.Name = "panelBottom";
            panelBottom.ShadowDecoration.CustomizableEdges = null;
            panelBottom.Size = new Size(1198, 80);
            panelBottom.TabIndex = 3;
            panelBottom.MouseDown += OnMouseDown;
            panelBottom.MouseMove += OnMouseMove;
            panelBottom.MouseUp += OnMouseUp;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.Transparent;
            buttonStop.BorderColor = Color.Red;
            buttonStop.BorderRadius = 8;
            buttonStop.BorderThickness = 1;
            buttonStop.CustomBorderColor = Color.FromArgb(255, 0, 0);
            buttonStop.CustomizableEdges = customizableEdges6;
            buttonStop.DisabledState.BorderColor = Color.FromArgb(100, 100, 100);
            buttonStop.DisabledState.CustomBorderColor = Color.FromArgb(100, 100, 100);
            buttonStop.DisabledState.FillColor = Color.FromArgb(50, 50, 50);
            buttonStop.DisabledState.ForeColor = Color.FromArgb(150, 150, 150);
            buttonStop.Enabled = false;
            buttonStop.FillColor = Color.FromArgb(50, 0, 0);
            buttonStop.Font = new Font("Consolas", 9F, FontStyle.Bold);
            buttonStop.ForeColor = Color.FromArgb(255, 0, 0);
            buttonStop.HoverState.FillColor = Color.FromArgb(100, 0, 0);
            buttonStop.Location = new Point(200, 24);
            buttonStop.Margin = new Padding(4, 3, 4, 3);
            buttonStop.Name = "buttonStop";
            buttonStop.PressedColor = Color.Silver;
            buttonStop.ShadowDecoration.BorderRadius = 10;
            buttonStop.ShadowDecoration.Color = Color.Red;
            buttonStop.ShadowDecoration.CustomizableEdges = null;
            buttonStop.Size = new Size(120, 31);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Stop";
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonExtract
            // 
            buttonExtract.BackColor = Color.Transparent;
            buttonExtract.BorderColor = Color.Lime;
            buttonExtract.BorderRadius = 8;
            buttonExtract.BorderThickness = 1;
            buttonExtract.CustomBorderColor = Color.FromArgb(0, 255, 0);
            buttonExtract.CustomizableEdges = customizableEdges7;
            buttonExtract.DisabledState.BorderColor = Color.FromArgb(100, 100, 100);
            buttonExtract.DisabledState.CustomBorderColor = Color.FromArgb(100, 100, 100);
            buttonExtract.DisabledState.FillColor = Color.FromArgb(50, 50, 50);
            buttonExtract.DisabledState.ForeColor = Color.FromArgb(150, 150, 150);
            buttonExtract.FillColor = Color.FromArgb(0, 50, 0);
            buttonExtract.Font = new Font("Consolas", 9F, FontStyle.Bold);
            buttonExtract.ForeColor = Color.FromArgb(0, 255, 0);
            buttonExtract.HoverState.FillColor = Color.FromArgb(0, 100, 0);
            buttonExtract.Location = new Point(50, 24);
            buttonExtract.Margin = new Padding(4, 3, 4, 3);
            buttonExtract.Name = "buttonExtract";
            buttonExtract.PressedColor = Color.Silver;
            buttonExtract.ShadowDecoration.BorderRadius = 10;
            buttonExtract.ShadowDecoration.Color = Color.Lime;
            buttonExtract.ShadowDecoration.CustomizableEdges = null;
            buttonExtract.ShadowDecoration.Enabled = true;
            buttonExtract.Size = new Size(120, 31);
            buttonExtract.TabIndex = 0;
            buttonExtract.Text = "Extract";
            buttonExtract.Click += buttonExtract_Click;
            // 
            // buttonClearResults
            // 
            buttonClearResults.BackColor = Color.Transparent;
            buttonClearResults.BorderColor = Color.FromArgb(32, 39, 46);
            buttonClearResults.BorderRadius = 8;
            buttonClearResults.BorderThickness = 1;
            buttonClearResults.CustomBorderColor = Color.FromArgb(255, 255, 0);
            buttonClearResults.CustomizableEdges = customizableEdges8;
            buttonClearResults.DisabledState.BorderColor = Color.FromArgb(100, 100, 100);
            buttonClearResults.DisabledState.CustomBorderColor = Color.FromArgb(100, 100, 100);
            buttonClearResults.DisabledState.FillColor = Color.FromArgb(50, 50, 50);
            buttonClearResults.DisabledState.ForeColor = Color.FromArgb(150, 150, 150);
            buttonClearResults.FillColor = Color.FromArgb(5, 10, 15);
            buttonClearResults.Font = new Font("Consolas", 9F, FontStyle.Bold);
            buttonClearResults.ForeColor = Color.FromArgb(255, 255, 0);
            buttonClearResults.HoverState.FillColor = Color.FromArgb(12, 19, 26);
            buttonClearResults.Location = new Point(1070, 16);
            buttonClearResults.Margin = new Padding(4, 3, 4, 3);
            buttonClearResults.Name = "buttonClearResults";
            buttonClearResults.PressedColor = Color.Silver;
            buttonClearResults.ShadowDecoration.CustomizableEdges = null;
            buttonClearResults.Size = new Size(120, 34);
            buttonClearResults.TabIndex = 4;
            buttonClearResults.Text = "Clear";
            buttonClearResults.Click += buttonClearResults_Click;
            // 
            // buttonSaveResults
            // 
            buttonSaveResults.BackColor = Color.Transparent;
            buttonSaveResults.BorderColor = Color.FromArgb(32, 39, 46);
            buttonSaveResults.BorderRadius = 8;
            buttonSaveResults.BorderThickness = 1;
            buttonSaveResults.CustomBorderColor = Color.FromArgb(0, 150, 255);
            buttonSaveResults.CustomizableEdges = customizableEdges9;
            buttonSaveResults.DisabledState.BorderColor = Color.FromArgb(100, 100, 100);
            buttonSaveResults.DisabledState.CustomBorderColor = Color.FromArgb(100, 100, 100);
            buttonSaveResults.DisabledState.FillColor = Color.FromArgb(50, 50, 50);
            buttonSaveResults.DisabledState.ForeColor = Color.FromArgb(150, 150, 150);
            buttonSaveResults.FillColor = Color.FromArgb(5, 10, 15);
            buttonSaveResults.Font = new Font("Consolas", 9F, FontStyle.Bold);
            buttonSaveResults.ForeColor = Color.FromArgb(0, 150, 255);
            buttonSaveResults.HoverState.FillColor = Color.FromArgb(12, 19, 26);
            buttonSaveResults.Location = new Point(930, 16);
            buttonSaveResults.Margin = new Padding(4, 3, 4, 3);
            buttonSaveResults.Name = "buttonSaveResults";
            buttonSaveResults.PressedColor = Color.Silver;
            buttonSaveResults.ShadowDecoration.CustomizableEdges = null;
            buttonSaveResults.Size = new Size(120, 34);
            buttonSaveResults.TabIndex = 3;
            buttonSaveResults.Text = "Save";
            buttonSaveResults.Click += buttonSaveResults_Click;
            // 
            // buttonCopyResults
            // 
            buttonCopyResults.BackColor = Color.Transparent;
            buttonCopyResults.BorderColor = Color.FromArgb(32, 39, 46);
            buttonCopyResults.BorderRadius = 8;
            buttonCopyResults.BorderThickness = 1;
            buttonCopyResults.CustomBorderColor = Color.FromArgb(255, 0, 255);
            buttonCopyResults.CustomizableEdges = customizableEdges10;
            buttonCopyResults.DisabledState.BorderColor = Color.FromArgb(100, 100, 100);
            buttonCopyResults.DisabledState.CustomBorderColor = Color.FromArgb(100, 100, 100);
            buttonCopyResults.DisabledState.FillColor = Color.FromArgb(50, 50, 50);
            buttonCopyResults.DisabledState.ForeColor = Color.FromArgb(150, 150, 150);
            buttonCopyResults.FillColor = Color.FromArgb(5, 10, 15);
            buttonCopyResults.Font = new Font("Consolas", 9F, FontStyle.Bold);
            buttonCopyResults.ForeColor = Color.FromArgb(255, 0, 255);
            buttonCopyResults.HoverState.FillColor = Color.FromArgb(12, 19, 26);
            buttonCopyResults.Location = new Point(789, 16);
            buttonCopyResults.Margin = new Padding(4, 3, 4, 3);
            buttonCopyResults.Name = "buttonCopyResults";
            buttonCopyResults.PressedColor = Color.Silver;
            buttonCopyResults.ShadowDecoration.CustomizableEdges = null;
            buttonCopyResults.Size = new Size(120, 34);
            buttonCopyResults.TabIndex = 2;
            buttonCopyResults.Text = "Copy";
            buttonCopyResults.Click += buttonCopyResults_Click;
            // 
            // statusStripMain
            // 
            statusStripMain.BackColor = Color.FromArgb(30, 34, 42);
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, toolStripProgressBar });
            statusStripMain.Location = new Point(0, 616);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(1198, 22);
            statusStripMain.SizingGrip = false;
            statusStripMain.TabIndex = 4;
            statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Font = new Font("Consolas", 9F);
            toolStripStatusLabel.ForeColor = Color.FromArgb(0, 255, 0);
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(42, 17);
            toolStripStatusLabel.Text = "Ready";
            toolStripStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(200, 16);
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.Visible = false;
            // 
            // timerProgress
            // 
            timerProgress.Tick += timerProgress_Tick;
            // 
            // maximuzeToolTip
            // 
            maximuzeToolTip.AllowLinksHandling = true;
            maximuzeToolTip.BackColor = Color.Transparent;
            maximuzeToolTip.BorderColor = Color.Transparent;
            maximuzeToolTip.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maximuzeToolTip.MaximumSize = new Size(0, 0);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(5, 10, 15);
            ClientSize = new Size(1198, 638);
            Controls.Add(panelBottom);
            Controls.Add(labelStats);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelHeader);
            Controls.Add(statusStripMain);
            Font = new Font("Consolas", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(750, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BinTextractor";
            MouseDown += OnMouseDown;
            MouseMove += OnMouseMove;
            MouseUp += OnMouseUp;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            groupBoxFilters.ResumeLayout(false);
            groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinLength).EndInit();
            panelRight.ResumeLayout(false);
            groupBoxResults.ResumeLayout(false);
            groupBoxResults.PerformLayout();
            panelBottom.ResumeLayout(false);
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2Button buttonTheme;
        private Guna.UI2.WinForms.Guna2Button buttonAbout;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxUnicode;
        private System.Windows.Forms.NumericUpDown numericUpDownMinLength;
        private System.Windows.Forms.Label labelMinLength;
        private System.Windows.Forms.Label labelSearchPattern;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearchPattern;
        private System.Windows.Forms.Label labelTargetFile;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTargetPath;
        private Guna.UI2.WinForms.Guna2Button buttonBrowseTarget;
        private System.Windows.Forms.Label labelOutputFile;
        private Guna.UI2.WinForms.Guna2TextBox textBoxOutputPath;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBarExtraction;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label labelSearchResults;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button buttonStop;
        private Guna.UI2.WinForms.Guna2Button buttonExtract;
        private Guna.UI2.WinForms.Guna2Button buttonClearResults;
        private Guna.UI2.WinForms.Guna2Button buttonSaveResults;
        private Guna.UI2.WinForms.Guna2Button buttonCopyResults;
        private System.Windows.Forms.Timer timerProgress;
        private Guna.UI2.WinForms.Guna2ImageButton minBtn;
        private Guna.UI2.WinForms.Guna2ImageButton maxBtn;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private Guna.UI2.WinForms.Guna2HtmlToolTip maximuzeToolTip;
        private Guna.UI2.WinForms.Guna2Button buttonBrowseOutput;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxAscii;
    }
}
