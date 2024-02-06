namespace ffmpegUI
{
    partial class FormShrink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShrink));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblExn = new System.Windows.Forms.Label();
            this.cbExtension = new System.Windows.Forms.ComboBox();
            this.cbFolder = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileOut = new System.Windows.Forms.TextBox();
            this.txtFileIn = new System.Windows.Forms.TextBox();
            this.btnBrowseOut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblComplete = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rb264 = new System.Windows.Forms.RadioButton();
            this.rbHEVC = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rbAMDGPU = new System.Windows.Forms.RadioButton();
            this.rbNVIDIAGPU = new System.Windows.Forms.RadioButton();
            this.rbCPUEncode = new System.Windows.Forms.RadioButton();
            this.pnlPreset = new System.Windows.Forms.Panel();
            this.lbPresets = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rb1440 = new System.Windows.Forms.RadioButton();
            this.rb2160 = new System.Windows.Forms.RadioButton();
            this.rb540 = new System.Windows.Forms.RadioButton();
            this.rb1080p = new System.Windows.Forms.RadioButton();
            this.rbResCopy = new System.Windows.Forms.RadioButton();
            this.rbRes720 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelIcon.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlPreset.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panelIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 103);
            this.button3.TabIndex = 3;
            this.button3.Text = "Preset Conversions";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(0, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 113);
            this.button2.TabIndex = 2;
            this.button2.Text = "Manual Conversion";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnManual);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 117);
            this.button1.TabIndex = 1;
            this.button1.Text = "Shrink Video File";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelIcon
            // 
            this.panelIcon.BackColor = System.Drawing.Color.BlueViolet;
            this.panelIcon.Controls.Add(this.label2);
            this.panelIcon.Controls.Add(this.label1);
            this.panelIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIcon.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelIcon.ForeColor = System.Drawing.Color.White;
            this.panelIcon.Location = new System.Drawing.Point(0, 0);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(177, 113);
            this.panelIcon.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "ffmpegUI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ffmpegUI";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Controls.Add(this.lblExn);
            this.panel3.Controls.Add(this.cbExtension);
            this.panel3.Controls.Add(this.cbFolder);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.lblSize);
            this.panel3.Controls.Add(this.lblInput);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnBrowse);
            this.panel3.Controls.Add(this.txtFileOut);
            this.panel3.Controls.Add(this.txtFileIn);
            this.panel3.Controls.Add(this.btnBrowseOut);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(177, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 210);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblExn
            // 
            this.lblExn.AutoSize = true;
            this.lblExn.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExn.ForeColor = System.Drawing.Color.White;
            this.lblExn.Location = new System.Drawing.Point(238, 102);
            this.lblExn.Name = "lblExn";
            this.lblExn.Size = new System.Drawing.Size(179, 26);
            this.lblExn.TabIndex = 41;
            this.lblExn.Text = "Choose input file type:";
            this.lblExn.Visible = false;
            // 
            // cbExtension
            // 
            this.cbExtension.BackColor = System.Drawing.Color.MediumPurple;
            this.cbExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExtension.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbExtension.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbExtension.ForeColor = System.Drawing.Color.White;
            this.cbExtension.FormattingEnabled = true;
            this.cbExtension.Items.AddRange(new object[] {
            "--Select Type--",
            ".mp4",
            ".mkv",
            ".mov",
            ".ts",
            ".avi",
            ".m4v"});
            this.cbExtension.Location = new System.Drawing.Point(433, 98);
            this.cbExtension.Name = "cbExtension";
            this.cbExtension.Size = new System.Drawing.Size(150, 34);
            this.cbExtension.TabIndex = 40;
            this.cbExtension.Visible = false;
            this.cbExtension.SelectedIndexChanged += new System.EventHandler(this.cbExtension_SelectedIndexChanged);
            // 
            // cbFolder
            // 
            this.cbFolder.AutoSize = true;
            this.cbFolder.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFolder.ForeColor = System.Drawing.Color.White;
            this.cbFolder.Location = new System.Drawing.Point(53, 103);
            this.cbFolder.Name = "cbFolder";
            this.cbFolder.Size = new System.Drawing.Size(174, 30);
            this.cbFolder.TabIndex = 39;
            this.cbFolder.Text = "All Videos in folder";
            this.cbFolder.UseVisualStyleBackColor = true;
            this.cbFolder.CheckedChanged += new System.EventHandler(this.cbFolder_CheckedChanged);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(583, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 23);
            this.button4.TabIndex = 38;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(468, 135);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(46, 26);
            this.lblSize.TabIndex = 37;
            this.lblSize.Text = "Size:";
            this.lblSize.Visible = false;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInput.ForeColor = System.Drawing.Color.White;
            this.lblInput.Location = new System.Drawing.Point(63, 139);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(88, 26);
            this.lblInput.TabIndex = 36;
            this.lblInput.Text = "Input File:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "Output Path:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Plum;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(389, 138);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 31;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileOut
            // 
            this.txtFileOut.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFileOut.Location = new System.Drawing.Point(157, 172);
            this.txtFileOut.Name = "txtFileOut";
            this.txtFileOut.ReadOnly = true;
            this.txtFileOut.Size = new System.Drawing.Size(226, 23);
            this.txtFileOut.TabIndex = 35;
            this.txtFileOut.TabStop = false;
            // 
            // txtFileIn
            // 
            this.txtFileIn.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFileIn.Location = new System.Drawing.Point(157, 139);
            this.txtFileIn.Name = "txtFileIn";
            this.txtFileIn.ReadOnly = true;
            this.txtFileIn.Size = new System.Drawing.Size(226, 23);
            this.txtFileIn.TabIndex = 33;
            this.txtFileIn.TabStop = false;
            this.txtFileIn.TextChanged += new System.EventHandler(this.txtFileIn_TextChanged);
            // 
            // btnBrowseOut
            // 
            this.btnBrowseOut.BackColor = System.Drawing.Color.Plum;
            this.btnBrowseOut.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBrowseOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnBrowseOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnBrowseOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseOut.ForeColor = System.Drawing.Color.White;
            this.btnBrowseOut.Location = new System.Drawing.Point(389, 171);
            this.btnBrowseOut.Name = "btnBrowseOut";
            this.btnBrowseOut.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOut.TabIndex = 32;
            this.btnBrowseOut.Text = "Browse";
            this.btnBrowseOut.UseVisualStyleBackColor = false;
            this.btnBrowseOut.Click += new System.EventHandler(this.btnBrowseOut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 86);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose file and destination, \r\nconversion options and click GO!\r\n";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Plum;
            this.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Image = ((System.Drawing.Image)(resources.GetObject("btnConvert.Image")));
            this.btnConvert.Location = new System.Drawing.Point(329, 203);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(81, 37);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Visible = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(36, 12);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(213, 26);
            this.lblProgress.TabIndex = 39;
            this.lblProgress.Text = "ENCODING IN PROGRESS";
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComplete.ForeColor = System.Drawing.Color.White;
            this.lblComplete.Location = new System.Drawing.Point(432, 209);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(173, 26);
            this.lblComplete.TabIndex = 40;
            this.lblComplete.Text = "Conversion Complete!";
            this.lblComplete.Visible = false;
            // 
            // pbProgress
            // 
            this.pbProgress.Image = ((System.Drawing.Image)(resources.GetObject("pbProgress.Image")));
            this.pbProgress.Location = new System.Drawing.Point(72, 39);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(134, 64);
            this.pbProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProgress.TabIndex = 41;
            this.pbProgress.TabStop = false;
            this.pbProgress.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.rb264);
            this.panel4.Controls.Add(this.rbHEVC);
            this.panel4.Location = new System.Drawing.Point(187, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(106, 87);
            this.panel4.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 26);
            this.label6.TabIndex = 44;
            this.label6.Text = "Codec:";
            // 
            // rb264
            // 
            this.rb264.AutoSize = true;
            this.rb264.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb264.ForeColor = System.Drawing.Color.White;
            this.rb264.Location = new System.Drawing.Point(12, 23);
            this.rb264.Name = "rb264";
            this.rb264.Size = new System.Drawing.Size(51, 23);
            this.rb264.TabIndex = 42;
            this.rb264.Text = "264";
            this.rb264.UseVisualStyleBackColor = true;
            this.rb264.CheckedChanged += new System.EventHandler(this.rb264_CheckedChanged);
            // 
            // rbHEVC
            // 
            this.rbHEVC.AutoSize = true;
            this.rbHEVC.BackColor = System.Drawing.Color.MediumPurple;
            this.rbHEVC.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbHEVC.ForeColor = System.Drawing.Color.White;
            this.rbHEVC.Location = new System.Drawing.Point(12, 41);
            this.rbHEVC.Name = "rbHEVC";
            this.rbHEVC.Size = new System.Drawing.Size(60, 23);
            this.rbHEVC.TabIndex = 43;
            this.rbHEVC.Text = "HEVC";
            this.rbHEVC.UseVisualStyleBackColor = false;
            this.rbHEVC.CheckedChanged += new System.EventHandler(this.rbHEVC_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.rbAMDGPU);
            this.panel5.Controls.Add(this.rbNVIDIAGPU);
            this.panel5.Controls.Add(this.rbCPUEncode);
            this.panel5.Location = new System.Drawing.Point(7, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(176, 90);
            this.panel5.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "CPU/GPU Encoder:";
            // 
            // rbAMDGPU
            // 
            this.rbAMDGPU.AutoSize = true;
            this.rbAMDGPU.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbAMDGPU.ForeColor = System.Drawing.Color.White;
            this.rbAMDGPU.Location = new System.Drawing.Point(26, 26);
            this.rbAMDGPU.Name = "rbAMDGPU";
            this.rbAMDGPU.Size = new System.Drawing.Size(85, 23);
            this.rbAMDGPU.TabIndex = 6;
            this.rbAMDGPU.Text = "AMD GPU";
            this.rbAMDGPU.UseVisualStyleBackColor = true;
            this.rbAMDGPU.CheckedChanged += new System.EventHandler(this.rbAMDGPU_CheckedChanged);
            // 
            // rbNVIDIAGPU
            // 
            this.rbNVIDIAGPU.AutoSize = true;
            this.rbNVIDIAGPU.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbNVIDIAGPU.ForeColor = System.Drawing.Color.White;
            this.rbNVIDIAGPU.Location = new System.Drawing.Point(26, 44);
            this.rbNVIDIAGPU.Name = "rbNVIDIAGPU";
            this.rbNVIDIAGPU.Size = new System.Drawing.Size(98, 23);
            this.rbNVIDIAGPU.TabIndex = 7;
            this.rbNVIDIAGPU.Text = "NVIDIA GPU";
            this.rbNVIDIAGPU.UseVisualStyleBackColor = true;
            this.rbNVIDIAGPU.CheckedChanged += new System.EventHandler(this.rbNVIDIAGPU_CheckedChanged);
            // 
            // rbCPUEncode
            // 
            this.rbCPUEncode.AutoSize = true;
            this.rbCPUEncode.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCPUEncode.ForeColor = System.Drawing.Color.White;
            this.rbCPUEncode.Location = new System.Drawing.Point(26, 61);
            this.rbCPUEncode.Name = "rbCPUEncode";
            this.rbCPUEncode.Size = new System.Drawing.Size(106, 23);
            this.rbCPUEncode.TabIndex = 9;
            this.rbCPUEncode.Text = "CPU Encoding";
            this.rbCPUEncode.UseVisualStyleBackColor = true;
            this.rbCPUEncode.CheckedChanged += new System.EventHandler(this.rbCPUEncode_CheckedChanged);
            // 
            // pnlPreset
            // 
            this.pnlPreset.Controls.Add(this.lbPresets);
            this.pnlPreset.Controls.Add(this.label7);
            this.pnlPreset.Location = new System.Drawing.Point(299, 3);
            this.pnlPreset.Name = "pnlPreset";
            this.pnlPreset.Size = new System.Drawing.Size(118, 87);
            this.pnlPreset.TabIndex = 0;
            // 
            // lbPresets
            // 
            this.lbPresets.BackColor = System.Drawing.Color.MediumPurple;
            this.lbPresets.ForeColor = System.Drawing.Color.White;
            this.lbPresets.FormattingEnabled = true;
            this.lbPresets.ItemHeight = 15;
            this.lbPresets.Items.AddRange(new object[] {
            "ultrafast",
            "superfast",
            "veryfast",
            "faster",
            "fast",
            "medium",
            "slow",
            "slower",
            "veryslow",
            "placebo"});
            this.lbPresets.Location = new System.Drawing.Point(3, 19);
            this.lbPresets.Name = "lbPresets";
            this.lbPresets.Size = new System.Drawing.Size(110, 64);
            this.lbPresets.TabIndex = 46;
            this.lbPresets.SelectedIndexChanged += new System.EventHandler(this.lbPresets_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 26);
            this.label7.TabIndex = 45;
            this.label7.Text = "Preset:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rb1440);
            this.panel6.Controls.Add(this.rb2160);
            this.panel6.Controls.Add(this.rb540);
            this.panel6.Controls.Add(this.rb1080p);
            this.panel6.Controls.Add(this.rbResCopy);
            this.panel6.Controls.Add(this.rbRes720);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(6, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(177, 84);
            this.panel6.TabIndex = 47;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // rb1440
            // 
            this.rb1440.AutoSize = true;
            this.rb1440.BackColor = System.Drawing.Color.MediumPurple;
            this.rb1440.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb1440.ForeColor = System.Drawing.Color.White;
            this.rb1440.Location = new System.Drawing.Point(70, 44);
            this.rb1440.Name = "rb1440";
            this.rb1440.Size = new System.Drawing.Size(66, 23);
            this.rb1440.TabIndex = 50;
            this.rb1440.Text = "1440p";
            this.rb1440.UseVisualStyleBackColor = false;
            // 
            // rb2160
            // 
            this.rb2160.AutoSize = true;
            this.rb2160.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb2160.ForeColor = System.Drawing.Color.White;
            this.rb2160.Location = new System.Drawing.Point(70, 25);
            this.rb2160.Name = "rb2160";
            this.rb2160.Size = new System.Drawing.Size(66, 23);
            this.rb2160.TabIndex = 48;
            this.rb2160.Text = "2160p";
            this.rb2160.UseVisualStyleBackColor = true;
            // 
            // rb540
            // 
            this.rb540.AutoSize = true;
            this.rb540.BackColor = System.Drawing.Color.MediumPurple;
            this.rb540.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb540.ForeColor = System.Drawing.Color.White;
            this.rb540.Location = new System.Drawing.Point(70, 60);
            this.rb540.Name = "rb540";
            this.rb540.Size = new System.Drawing.Size(58, 23);
            this.rb540.TabIndex = 49;
            this.rb540.Text = "540p";
            this.rb540.UseVisualStyleBackColor = false;
            // 
            // rb1080p
            // 
            this.rb1080p.AutoSize = true;
            this.rb1080p.BackColor = System.Drawing.Color.MediumPurple;
            this.rb1080p.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb1080p.ForeColor = System.Drawing.Color.White;
            this.rb1080p.Location = new System.Drawing.Point(6, 44);
            this.rb1080p.Name = "rb1080p";
            this.rb1080p.Size = new System.Drawing.Size(67, 23);
            this.rb1080p.TabIndex = 47;
            this.rb1080p.Text = "1080P";
            this.rb1080p.UseVisualStyleBackColor = false;
            // 
            // rbResCopy
            // 
            this.rbResCopy.AutoSize = true;
            this.rbResCopy.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbResCopy.ForeColor = System.Drawing.Color.White;
            this.rbResCopy.Location = new System.Drawing.Point(6, 25);
            this.rbResCopy.Name = "rbResCopy";
            this.rbResCopy.Size = new System.Drawing.Size(54, 23);
            this.rbResCopy.TabIndex = 45;
            this.rbResCopy.Text = "Copy";
            this.rbResCopy.UseVisualStyleBackColor = true;
            // 
            // rbRes720
            // 
            this.rbRes720.AutoSize = true;
            this.rbRes720.BackColor = System.Drawing.Color.MediumPurple;
            this.rbRes720.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbRes720.ForeColor = System.Drawing.Color.White;
            this.rbRes720.Location = new System.Drawing.Point(6, 60);
            this.rbRes720.Name = "rbRes720";
            this.rbRes720.Size = new System.Drawing.Size(58, 23);
            this.rbRes720.TabIndex = 46;
            this.rbRes720.Text = "720p";
            this.rbRes720.UseVisualStyleBackColor = false;
            this.rbRes720.CheckedChanged += new System.EventHandler(this.rbRes720_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 26);
            this.label8.TabIndex = 45;
            this.label8.Text = "Resolution:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.pnlProgress);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.pnlPreset);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblComplete);
            this.panel2.Controls.Add(this.btnConvert);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(177, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 249);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.lblProgress);
            this.pnlProgress.Controls.Add(this.pbProgress);
            this.pnlProgress.Location = new System.Drawing.Point(370, 94);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(250, 112);
            this.pnlProgress.TabIndex = 48;
            this.pnlProgress.Visible = false;
            // 
            // FormShrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShrink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ffmpegUI";
            this.Load += new System.EventHandler(this.FormShrink_Load);
            this.panel1.ResumeLayout(false);
            this.panelIcon.ResumeLayout(false);
            this.panelIcon.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlPreset.ResumeLayout(false);
            this.pnlPreset.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panelIcon;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Label lblSize;
        private Label lblInput;
        private Label label4;
        private Button btnBrowse;
        private TextBox txtFileOut;
        private TextBox txtFileIn;
        private Button btnBrowseOut;
        private Button button4;
        private CheckBox cbFolder;
        private ComboBox cbExtension;
        private Label lblExn;
        private Button btnConvert;
        private Label lblProgress;
        private Label lblComplete;
        private PictureBox pbProgress;
        private Panel panel4;
        private Label label6;
        private RadioButton rb264;
        private RadioButton rbHEVC;
        private Panel panel5;
        private Label label5;
        private RadioButton rbAMDGPU;
        private RadioButton rbNVIDIAGPU;
        private RadioButton rbCPUEncode;
        private Panel pnlPreset;
        private ListBox lbPresets;
        private Label label7;
        private Panel panel6;
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
    }
}