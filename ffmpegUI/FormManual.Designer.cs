namespace ffmpegUI
{
    partial class FormManual
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            panel1 = new Panel();
            btnFormPreset = new Button();
            btnFormClip = new Button();
            btnFormShrink = new Button();
            panelIcon = new Panel();
            label2 = new Label();
            label1 = new Label();
            pnlIO = new Panel();
            lblExn = new Label();
            cbExtension = new ComboBox();
            cbFolder = new CheckBox();
            btnClose = new Button();
            lblSize = new Label();
            lblInput = new Label();
            label4 = new Label();
            btnBrowse = new Button();
            txtFileOut = new TextBox();
            txtFileIn = new TextBox();
            btnBrowseOut = new Button();
            label3 = new Label();
            btnConvert = new Button();
            lblProgress = new Label();
            lblComplete = new Label();
            pbProgress = new PictureBox();
            pnlCodec = new Panel();
            rbAV1 = new RadioButton();
            label6 = new Label();
            rb264 = new RadioButton();
            rbHEVC = new RadioButton();
            pnlEncoder = new Panel();
            label5 = new Label();
            rbAMDGPU = new RadioButton();
            rbNVIDIAGPU = new RadioButton();
            rbCPUEncode = new RadioButton();
            pnlPreset = new Panel();
            lbPresets = new ListBox();
            label7 = new Label();
            pnlRes = new Panel();
            cbPortrait = new CheckBox();
            rb1440 = new RadioButton();
            rb2160 = new RadioButton();
            rb540 = new RadioButton();
            rb1080p = new RadioButton();
            rbResCopy = new RadioButton();
            rbRes720 = new RadioButton();
            label8 = new Label();
            panel2 = new Panel();
            cbDeleteOrig = new CheckBox();
            pnlProgress = new Panel();
            lblCount = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panelIcon.SuspendLayout();
            pnlIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProgress).BeginInit();
            pnlCodec.SuspendLayout();
            pnlEncoder.SuspendLayout();
            pnlPreset.SuspendLayout();
            pnlRes.SuspendLayout();
            panel2.SuspendLayout();
            pnlProgress.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFormPreset);
            panel1.Controls.Add(btnFormClip);
            panel1.Controls.Add(btnFormShrink);
            panel1.Controls.Add(panelIcon);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 600);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnFormPreset
            // 
            btnFormPreset.FlatAppearance.BorderSize = 0;
            btnFormPreset.FlatAppearance.MouseDownBackColor = Color.Plum;
            btnFormPreset.FlatAppearance.MouseOverBackColor = Color.Violet;
            btnFormPreset.FlatStyle = FlatStyle.Flat;
            btnFormPreset.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFormPreset.ForeColor = Color.White;
            btnFormPreset.Image = (Image)resources.GetObject("btnFormPreset.Image");
            btnFormPreset.Location = new Point(0, 463);
            btnFormPreset.Margin = new Padding(3, 4, 3, 4);
            btnFormPreset.Name = "btnFormPreset";
            btnFormPreset.Size = new Size(202, 137);
            btnFormPreset.TabIndex = 3;
            btnFormPreset.Text = "Preset Conversions";
            btnFormPreset.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFormPreset.UseVisualStyleBackColor = true;
            btnFormPreset.Click += button3_Click;
            // 
            // btnFormClip
            // 
            btnFormClip.FlatAppearance.BorderSize = 0;
            btnFormClip.FlatAppearance.MouseDownBackColor = Color.Plum;
            btnFormClip.FlatAppearance.MouseOverBackColor = Color.Violet;
            btnFormClip.FlatStyle = FlatStyle.Flat;
            btnFormClip.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFormClip.ForeColor = Color.White;
            btnFormClip.Image = (Image)resources.GetObject("btnFormClip.Image");
            btnFormClip.ImageAlign = ContentAlignment.TopCenter;
            btnFormClip.Location = new Point(0, 312);
            btnFormClip.Margin = new Padding(3, 4, 3, 4);
            btnFormClip.Name = "btnFormClip";
            btnFormClip.Size = new Size(202, 151);
            btnFormClip.TabIndex = 2;
            btnFormClip.Text = "Trim Tool";
            btnFormClip.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFormClip.UseVisualStyleBackColor = true;
            btnFormClip.Click += btnManual;
            // 
            // btnFormShrink
            // 
            btnFormShrink.BackColor = Color.Plum;
            btnFormShrink.FlatAppearance.BorderColor = Color.Black;
            btnFormShrink.FlatAppearance.BorderSize = 3;
            btnFormShrink.FlatStyle = FlatStyle.Flat;
            btnFormShrink.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFormShrink.ForeColor = Color.White;
            btnFormShrink.Image = (Image)resources.GetObject("btnFormShrink.Image");
            btnFormShrink.ImageAlign = ContentAlignment.TopCenter;
            btnFormShrink.Location = new Point(0, 148);
            btnFormShrink.Margin = new Padding(3, 4, 3, 4);
            btnFormShrink.Name = "btnFormShrink";
            btnFormShrink.Size = new Size(202, 156);
            btnFormShrink.TabIndex = 1;
            btnFormShrink.Text = "Manual Conversion";
            btnFormShrink.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFormShrink.UseVisualStyleBackColor = true;
            btnFormShrink.Click += btnFormShrink_Click;
            // 
            // panelIcon
            // 
            panelIcon.BackColor = Color.BlueViolet;
            panelIcon.Controls.Add(label2);
            panelIcon.Controls.Add(label1);
            panelIcon.Dock = DockStyle.Top;
            panelIcon.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point);
            panelIcon.ForeColor = Color.White;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Margin = new Padding(3, 4, 3, 4);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(202, 151);
            panelIcon.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 47);
            label2.Name = "label2";
            label2.Size = new Size(160, 52);
            label2.TabIndex = 1;
            label2.Text = "ffmpegUI";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 51);
            label1.Name = "label1";
            label1.Size = new Size(160, 52);
            label1.TabIndex = 0;
            label1.Text = "ffmpegUI";
            // 
            // pnlIO
            // 
            pnlIO.BackColor = Color.MediumPurple;
            pnlIO.Controls.Add(lblExn);
            pnlIO.Controls.Add(cbExtension);
            pnlIO.Controls.Add(cbFolder);
            pnlIO.Controls.Add(btnClose);
            pnlIO.Controls.Add(lblSize);
            pnlIO.Controls.Add(lblInput);
            pnlIO.Controls.Add(label4);
            pnlIO.Controls.Add(btnBrowse);
            pnlIO.Controls.Add(txtFileOut);
            pnlIO.Controls.Add(txtFileIn);
            pnlIO.Controls.Add(btnBrowseOut);
            pnlIO.Controls.Add(label3);
            pnlIO.Dock = DockStyle.Top;
            pnlIO.Location = new Point(202, 0);
            pnlIO.Margin = new Padding(3, 4, 3, 4);
            pnlIO.Name = "pnlIO";
            pnlIO.Size = new Size(712, 280);
            pnlIO.TabIndex = 0;
            pnlIO.Paint += panel3_Paint;
            // 
            // lblExn
            // 
            lblExn.AutoSize = true;
            lblExn.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblExn.ForeColor = Color.White;
            lblExn.Location = new Point(272, 136);
            lblExn.Name = "lblExn";
            lblExn.Size = new Size(232, 33);
            lblExn.TabIndex = 41;
            lblExn.Text = "Choose input file type:";
            lblExn.Visible = false;
            // 
            // cbExtension
            // 
            cbExtension.BackColor = Color.MediumPurple;
            cbExtension.DropDownStyle = ComboBoxStyle.DropDownList;
            cbExtension.FlatStyle = FlatStyle.Popup;
            cbExtension.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbExtension.ForeColor = Color.White;
            cbExtension.FormattingEnabled = true;
            cbExtension.Items.AddRange(new object[] { "--Select Type--", ".mp4", ".mkv", ".mov", ".ts", ".avi", ".m4v" });
            cbExtension.Location = new Point(495, 131);
            cbExtension.Margin = new Padding(3, 4, 3, 4);
            cbExtension.Name = "cbExtension";
            cbExtension.Size = new Size(171, 41);
            cbExtension.TabIndex = 40;
            cbExtension.Visible = false;
            cbExtension.SelectedIndexChanged += cbExtension_SelectedIndexChanged;
            // 
            // cbFolder
            // 
            cbFolder.AutoSize = true;
            cbFolder.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbFolder.ForeColor = Color.White;
            cbFolder.Location = new Point(61, 137);
            cbFolder.Margin = new Padding(3, 4, 3, 4);
            cbFolder.Name = "cbFolder";
            cbFolder.Size = new Size(223, 37);
            cbFolder.TabIndex = 39;
            cbFolder.Text = "All Videos in folder";
            cbFolder.UseVisualStyleBackColor = true;
            cbFolder.CheckedChanged += cbFolder_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(666, 4);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 31);
            btnClose.TabIndex = 38;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button4_Click;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.ForeColor = Color.White;
            lblSize.Location = new Point(535, 180);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(58, 33);
            lblSize.TabIndex = 37;
            lblSize.Text = "Size:";
            lblSize.Visible = false;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblInput.ForeColor = Color.White;
            lblInput.Location = new Point(72, 185);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(112, 33);
            lblInput.TabIndex = 36;
            lblInput.Text = "Input File:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(54, 224);
            label4.Name = "label4";
            label4.Size = new Size(143, 33);
            label4.TabIndex = 34;
            label4.Text = "Output Path:";
            label4.Click += label4_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Plum;
            btnBrowse.FlatAppearance.BorderColor = Color.DimGray;
            btnBrowse.FlatAppearance.MouseDownBackColor = Color.Violet;
            btnBrowse.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(445, 184);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(86, 31);
            btnBrowse.TabIndex = 31;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtFileOut
            // 
            txtFileOut.BackColor = Color.Gainsboro;
            txtFileOut.Location = new Point(179, 229);
            txtFileOut.Margin = new Padding(3, 4, 3, 4);
            txtFileOut.Name = "txtFileOut";
            txtFileOut.ReadOnly = true;
            txtFileOut.Size = new Size(258, 27);
            txtFileOut.TabIndex = 35;
            txtFileOut.TabStop = false;
            // 
            // txtFileIn
            // 
            txtFileIn.BackColor = Color.Gainsboro;
            txtFileIn.Location = new Point(179, 185);
            txtFileIn.Margin = new Padding(3, 4, 3, 4);
            txtFileIn.Name = "txtFileIn";
            txtFileIn.ReadOnly = true;
            txtFileIn.Size = new Size(258, 27);
            txtFileIn.TabIndex = 33;
            txtFileIn.TabStop = false;
            txtFileIn.TextChanged += txtFileIn_TextChanged;
            // 
            // btnBrowseOut
            // 
            btnBrowseOut.BackColor = Color.Plum;
            btnBrowseOut.FlatAppearance.BorderColor = Color.DimGray;
            btnBrowseOut.FlatAppearance.MouseDownBackColor = Color.Violet;
            btnBrowseOut.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnBrowseOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowseOut.ForeColor = Color.White;
            btnBrowseOut.Location = new Point(445, 228);
            btnBrowseOut.Margin = new Padding(3, 4, 3, 4);
            btnBrowseOut.Name = "btnBrowseOut";
            btnBrowseOut.Size = new Size(86, 31);
            btnBrowseOut.TabIndex = 32;
            btnBrowseOut.Text = "Browse";
            btnBrowseOut.UseVisualStyleBackColor = false;
            btnBrowseOut.Click += btnBrowseOut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(104, 16);
            label3.Name = "label3";
            label3.Size = new Size(519, 108);
            label3.TabIndex = 2;
            label3.Text = "Choose file and destination, \r\nconversion options and click GO!\r\n";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.Plum;
            btnConvert.FlatAppearance.BorderColor = Color.White;
            btnConvert.FlatAppearance.MouseDownBackColor = Color.Violet;
            btnConvert.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnConvert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.ForeColor = Color.White;
            btnConvert.Image = (Image)resources.GetObject("btnConvert.Image");
            btnConvert.Location = new Point(376, 271);
            btnConvert.Margin = new Padding(3, 4, 3, 4);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(93, 49);
            btnConvert.TabIndex = 5;
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Visible = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProgress.ForeColor = Color.White;
            lblProgress.Location = new Point(41, -3);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(267, 33);
            lblProgress.TabIndex = 39;
            lblProgress.Text = "ENCODING IN PROGRESS";
            // 
            // lblComplete
            // 
            lblComplete.AutoSize = true;
            lblComplete.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblComplete.ForeColor = Color.White;
            lblComplete.Location = new Point(494, 279);
            lblComplete.Name = "lblComplete";
            lblComplete.Size = new Size(222, 33);
            lblComplete.TabIndex = 40;
            lblComplete.Text = "Conversion Complete!";
            lblComplete.Visible = false;
            // 
            // pbProgress
            // 
            pbProgress.Image = (Image)resources.GetObject("pbProgress.Image");
            pbProgress.Location = new Point(82, 52);
            pbProgress.Margin = new Padding(3, 4, 3, 4);
            pbProgress.Name = "pbProgress";
            pbProgress.Size = new Size(153, 85);
            pbProgress.SizeMode = PictureBoxSizeMode.CenterImage;
            pbProgress.TabIndex = 41;
            pbProgress.TabStop = false;
            pbProgress.Click += pictureBox1_Click;
            // 
            // pnlCodec
            // 
            pnlCodec.Controls.Add(rbAV1);
            pnlCodec.Controls.Add(label6);
            pnlCodec.Controls.Add(rb264);
            pnlCodec.Controls.Add(rbHEVC);
            pnlCodec.Location = new Point(214, 4);
            pnlCodec.Margin = new Padding(3, 4, 3, 4);
            pnlCodec.Name = "pnlCodec";
            pnlCodec.Size = new Size(121, 116);
            pnlCodec.TabIndex = 45;
            // 
            // rbAV1
            // 
            rbAV1.AutoSize = true;
            rbAV1.BackColor = Color.MediumPurple;
            rbAV1.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbAV1.ForeColor = Color.White;
            rbAV1.Location = new Point(14, 78);
            rbAV1.Margin = new Padding(3, 4, 3, 4);
            rbAV1.Name = "rbAV1";
            rbAV1.Size = new Size(62, 28);
            rbAV1.TabIndex = 45;
            rbAV1.Text = "AV1";
            rbAV1.UseVisualStyleBackColor = false;
            rbAV1.CheckedChanged += rbAV1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, -4);
            label6.Name = "label6";
            label6.Size = new Size(78, 33);
            label6.TabIndex = 44;
            label6.Text = "Codec:";
            // 
            // rb264
            // 
            rb264.AutoSize = true;
            rb264.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rb264.ForeColor = Color.White;
            rb264.Location = new Point(14, 31);
            rb264.Margin = new Padding(3, 4, 3, 4);
            rb264.Name = "rb264";
            rb264.Size = new Size(61, 28);
            rb264.TabIndex = 42;
            rb264.Text = "264";
            rb264.UseVisualStyleBackColor = true;
            rb264.CheckedChanged += rb264_CheckedChanged;
            // 
            // rbHEVC
            // 
            rbHEVC.AutoSize = true;
            rbHEVC.BackColor = Color.MediumPurple;
            rbHEVC.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbHEVC.ForeColor = Color.White;
            rbHEVC.Location = new Point(14, 55);
            rbHEVC.Margin = new Padding(3, 4, 3, 4);
            rbHEVC.Name = "rbHEVC";
            rbHEVC.Size = new Size(72, 28);
            rbHEVC.TabIndex = 43;
            rbHEVC.Text = "HEVC";
            rbHEVC.UseVisualStyleBackColor = false;
            rbHEVC.CheckedChanged += rbHEVC_CheckedChanged;
            // 
            // pnlEncoder
            // 
            pnlEncoder.Controls.Add(label5);
            pnlEncoder.Controls.Add(rbAMDGPU);
            pnlEncoder.Controls.Add(rbNVIDIAGPU);
            pnlEncoder.Controls.Add(rbCPUEncode);
            pnlEncoder.Location = new Point(8, 0);
            pnlEncoder.Margin = new Padding(3, 4, 3, 4);
            pnlEncoder.Name = "pnlEncoder";
            pnlEncoder.Size = new Size(201, 120);
            pnlEncoder.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 0);
            label5.Name = "label5";
            label5.Size = new Size(204, 33);
            label5.TabIndex = 8;
            label5.Text = "CPU/GPU Encoder:";
            // 
            // rbAMDGPU
            // 
            rbAMDGPU.AutoSize = true;
            rbAMDGPU.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbAMDGPU.ForeColor = Color.White;
            rbAMDGPU.Location = new Point(30, 35);
            rbAMDGPU.Margin = new Padding(3, 4, 3, 4);
            rbAMDGPU.Name = "rbAMDGPU";
            rbAMDGPU.Size = new Size(104, 28);
            rbAMDGPU.TabIndex = 6;
            rbAMDGPU.Text = "AMD GPU";
            rbAMDGPU.UseVisualStyleBackColor = true;
            rbAMDGPU.CheckedChanged += rbAMDGPU_CheckedChanged;
            // 
            // rbNVIDIAGPU
            // 
            rbNVIDIAGPU.AutoSize = true;
            rbNVIDIAGPU.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbNVIDIAGPU.ForeColor = Color.White;
            rbNVIDIAGPU.Location = new Point(30, 59);
            rbNVIDIAGPU.Margin = new Padding(3, 4, 3, 4);
            rbNVIDIAGPU.Name = "rbNVIDIAGPU";
            rbNVIDIAGPU.Size = new Size(120, 28);
            rbNVIDIAGPU.TabIndex = 7;
            rbNVIDIAGPU.Text = "NVIDIA GPU";
            rbNVIDIAGPU.UseVisualStyleBackColor = true;
            rbNVIDIAGPU.CheckedChanged += rbNVIDIAGPU_CheckedChanged;
            // 
            // rbCPUEncode
            // 
            rbCPUEncode.AutoSize = true;
            rbCPUEncode.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbCPUEncode.ForeColor = Color.White;
            rbCPUEncode.Location = new Point(30, 81);
            rbCPUEncode.Margin = new Padding(3, 4, 3, 4);
            rbCPUEncode.Name = "rbCPUEncode";
            rbCPUEncode.Size = new Size(132, 28);
            rbCPUEncode.TabIndex = 9;
            rbCPUEncode.Text = "CPU Encoding";
            rbCPUEncode.UseVisualStyleBackColor = true;
            rbCPUEncode.CheckedChanged += rbCPUEncode_CheckedChanged;
            // 
            // pnlPreset
            // 
            pnlPreset.Controls.Add(lbPresets);
            pnlPreset.Controls.Add(label7);
            pnlPreset.Location = new Point(342, 4);
            pnlPreset.Margin = new Padding(3, 4, 3, 4);
            pnlPreset.Name = "pnlPreset";
            pnlPreset.Size = new Size(135, 116);
            pnlPreset.TabIndex = 0;
            // 
            // lbPresets
            // 
            lbPresets.BackColor = Color.MediumPurple;
            lbPresets.ForeColor = Color.White;
            lbPresets.FormattingEnabled = true;
            lbPresets.ItemHeight = 20;
            lbPresets.Items.AddRange(new object[] { "ultrafast", "superfast", "veryfast", "faster", "fast", "medium", "slow", "slower", "veryslow", "placebo" });
            lbPresets.Location = new Point(3, 25);
            lbPresets.Margin = new Padding(3, 4, 3, 4);
            lbPresets.Name = "lbPresets";
            lbPresets.Size = new Size(125, 84);
            lbPresets.TabIndex = 46;
            lbPresets.SelectedIndexChanged += lbPresets_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, -4);
            label7.Name = "label7";
            label7.Size = new Size(81, 33);
            label7.TabIndex = 45;
            label7.Text = "Preset:";
            // 
            // pnlRes
            // 
            pnlRes.Controls.Add(cbPortrait);
            pnlRes.Controls.Add(rb1440);
            pnlRes.Controls.Add(rb2160);
            pnlRes.Controls.Add(rb540);
            pnlRes.Controls.Add(rb1080p);
            pnlRes.Controls.Add(rbResCopy);
            pnlRes.Controls.Add(rbRes720);
            pnlRes.Controls.Add(label8);
            pnlRes.Location = new Point(7, 120);
            pnlRes.Margin = new Padding(3, 4, 3, 4);
            pnlRes.Name = "pnlRes";
            pnlRes.Size = new Size(202, 155);
            pnlRes.TabIndex = 47;
            pnlRes.Paint += panel6_Paint;
            // 
            // cbPortrait
            // 
            cbPortrait.AutoSize = true;
            cbPortrait.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbPortrait.ForeColor = Color.White;
            cbPortrait.Location = new Point(6, 111);
            cbPortrait.Margin = new Padding(3, 4, 3, 4);
            cbPortrait.Name = "cbPortrait";
            cbPortrait.Size = new Size(178, 37);
            cbPortrait.TabIndex = 51;
            cbPortrait.Text = "Portrait mode";
            cbPortrait.UseVisualStyleBackColor = true;
            // 
            // rb1440
            // 
            rb1440.AutoSize = true;
            rb1440.BackColor = Color.MediumPurple;
            rb1440.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rb1440.ForeColor = Color.White;
            rb1440.Location = new Point(80, 59);
            rb1440.Margin = new Padding(3, 4, 3, 4);
            rb1440.Name = "rb1440";
            rb1440.Size = new Size(80, 28);
            rb1440.TabIndex = 50;
            rb1440.Text = "1440p";
            rb1440.UseVisualStyleBackColor = false;
            // 
            // rb2160
            // 
            rb2160.AutoSize = true;
            rb2160.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rb2160.ForeColor = Color.White;
            rb2160.Location = new Point(80, 33);
            rb2160.Margin = new Padding(3, 4, 3, 4);
            rb2160.Name = "rb2160";
            rb2160.Size = new Size(80, 28);
            rb2160.TabIndex = 48;
            rb2160.Text = "2160p";
            rb2160.UseVisualStyleBackColor = true;
            // 
            // rb540
            // 
            rb540.AutoSize = true;
            rb540.BackColor = Color.MediumPurple;
            rb540.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rb540.ForeColor = Color.White;
            rb540.Location = new Point(80, 80);
            rb540.Margin = new Padding(3, 4, 3, 4);
            rb540.Name = "rb540";
            rb540.Size = new Size(70, 28);
            rb540.TabIndex = 49;
            rb540.Text = "540p";
            rb540.UseVisualStyleBackColor = false;
            // 
            // rb1080p
            // 
            rb1080p.AutoSize = true;
            rb1080p.BackColor = Color.MediumPurple;
            rb1080p.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rb1080p.ForeColor = Color.White;
            rb1080p.Location = new Point(7, 59);
            rb1080p.Margin = new Padding(3, 4, 3, 4);
            rb1080p.Name = "rb1080p";
            rb1080p.Size = new Size(81, 28);
            rb1080p.TabIndex = 47;
            rb1080p.Text = "1080P";
            rb1080p.UseVisualStyleBackColor = false;
            // 
            // rbResCopy
            // 
            rbResCopy.AutoSize = true;
            rbResCopy.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbResCopy.ForeColor = Color.White;
            rbResCopy.Location = new Point(7, 33);
            rbResCopy.Margin = new Padding(3, 4, 3, 4);
            rbResCopy.Name = "rbResCopy";
            rbResCopy.Size = new Size(66, 28);
            rbResCopy.TabIndex = 45;
            rbResCopy.Text = "Copy";
            rbResCopy.UseVisualStyleBackColor = true;
            // 
            // rbRes720
            // 
            rbRes720.AutoSize = true;
            rbRes720.BackColor = Color.MediumPurple;
            rbRes720.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbRes720.ForeColor = Color.White;
            rbRes720.Location = new Point(7, 80);
            rbRes720.Margin = new Padding(3, 4, 3, 4);
            rbRes720.Name = "rbRes720";
            rbRes720.Size = new Size(70, 28);
            rbRes720.TabIndex = 46;
            rbRes720.Text = "720p";
            rbRes720.UseVisualStyleBackColor = false;
            rbRes720.CheckedChanged += rbRes720_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(15, 4);
            label8.Name = "label8";
            label8.Size = new Size(119, 33);
            label8.TabIndex = 45;
            label8.Text = "Resolution:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumPurple;
            panel2.Controls.Add(cbDeleteOrig);
            panel2.Controls.Add(pnlProgress);
            panel2.Controls.Add(pnlRes);
            panel2.Controls.Add(pnlPreset);
            panel2.Controls.Add(pnlEncoder);
            panel2.Controls.Add(pnlCodec);
            panel2.Controls.Add(lblComplete);
            panel2.Controls.Add(btnConvert);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(202, 268);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 332);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // cbDeleteOrig
            // 
            cbDeleteOrig.AutoSize = true;
            cbDeleteOrig.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbDeleteOrig.ForeColor = Color.White;
            cbDeleteOrig.Location = new Point(159, 279);
            cbDeleteOrig.Margin = new Padding(3, 4, 3, 4);
            cbDeleteOrig.Name = "cbDeleteOrig";
            cbDeleteOrig.Size = new Size(231, 37);
            cbDeleteOrig.TabIndex = 49;
            cbDeleteOrig.Text = "Delete Original File?";
            cbDeleteOrig.UseVisualStyleBackColor = true;
            // 
            // pnlProgress
            // 
            pnlProgress.Controls.Add(lblCount);
            pnlProgress.Controls.Add(lblProgress);
            pnlProgress.Controls.Add(pbProgress);
            pnlProgress.Location = new Point(423, 125);
            pnlProgress.Margin = new Padding(3, 4, 3, 4);
            pnlProgress.Name = "pnlProgress";
            pnlProgress.Size = new Size(286, 149);
            pnlProgress.TabIndex = 48;
            pnlProgress.Visible = false;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCount.ForeColor = Color.White;
            lblCount.Location = new Point(109, 25);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(91, 26);
            lblCount.TabIndex = 42;
            lblCount.Text = "File 0 of 0";
            lblCount.Visible = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.WorkerSupportsCancellation = true;
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            // 
            // FormShrink
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DimGray;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlIO);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormShrink";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ffmpegUI";
            Load += FormManual_Load;
            panel1.ResumeLayout(false);
            panelIcon.ResumeLayout(false);
            panelIcon.PerformLayout();
            pnlIO.ResumeLayout(false);
            pnlIO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProgress).EndInit();
            pnlCodec.ResumeLayout(false);
            pnlCodec.PerformLayout();
            pnlEncoder.ResumeLayout(false);
            pnlEncoder.PerformLayout();
            pnlPreset.ResumeLayout(false);
            pnlPreset.PerformLayout();
            pnlRes.ResumeLayout(false);
            pnlRes.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlProgress.ResumeLayout(false);
            pnlProgress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelIcon;
        private Label label1;
        private Button btnFormClip;
        private Button btnFormShrink;
        private Button btnFormPreset;
        private Label label2;
        private Panel pnlIO;
        private Label label3;
        private Label lblSize;
        private Label lblInput;
        private Label label4;
        private Button btnBrowse;
        private TextBox txtFileOut;
        private TextBox txtFileIn;
        private Button btnBrowseOut;
        private Button btnClose;
        private CheckBox cbFolder;
        private ComboBox cbExtension;
        private Label lblExn;
        private Button btnConvert;
        private Label lblProgress;
        private Label lblComplete;
        private PictureBox pbProgress;
        private Panel pnlCodec;
        private Label label6;
        private RadioButton rb264;
        private RadioButton rbHEVC;
        private Panel pnlEncoder;
        private Label label5;
        private RadioButton rbAMDGPU;
        private RadioButton rbNVIDIAGPU;
        private RadioButton rbCPUEncode;
        private Panel pnlPreset;
        private ListBox lbPresets;
        private Label label7;
        private Panel pnlRes;
        private RadioButton rb1440;
        private RadioButton rb2160;
        private RadioButton rb540;
        private RadioButton rb1080p;
        private RadioButton rbResCopy;
        private RadioButton rbRes720;
        private Label label8;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlProgress;
        private Label lblCount;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private CheckBox cbDeleteOrig;
        private CheckBox cbPortrait;
        private RadioButton rbAV1;
    }
}