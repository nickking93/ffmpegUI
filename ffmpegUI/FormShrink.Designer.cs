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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rbAMDGPU = new System.Windows.Forms.RadioButton();
            this.rbNVIDIAGPU = new System.Windows.Forms.RadioButton();
            this.rbCPUEncode = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rb264 = new System.Windows.Forms.RadioButton();
            this.rbHEVC = new System.Windows.Forms.RadioButton();
            this.pbProgress = new System.Windows.Forms.PictureBox();
            this.lblComplete = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
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
            this.panel1.SuspendLayout();
            this.panelIcon.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress)).BeginInit();
            this.panel3.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pbProgress);
            this.panel2.Controls.Add(this.lblComplete);
            this.panel2.Controls.Add(this.lblProgress);
            this.panel2.Controls.Add(this.btnConvert);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(177, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 177);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.rbAMDGPU);
            this.panel5.Controls.Add(this.rbNVIDIAGPU);
            this.panel5.Controls.Add(this.rbCPUEncode);
            this.panel5.Location = new System.Drawing.Point(47, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 102);
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
            this.rbAMDGPU.Location = new System.Drawing.Point(26, 25);
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
            this.rbCPUEncode.Location = new System.Drawing.Point(26, 65);
            this.rbCPUEncode.Name = "rbCPUEncode";
            this.rbCPUEncode.Size = new System.Drawing.Size(106, 23);
            this.rbCPUEncode.TabIndex = 9;
            this.rbCPUEncode.Text = "CPU Encoding";
            this.rbCPUEncode.UseVisualStyleBackColor = true;
            this.rbCPUEncode.CheckedChanged += new System.EventHandler(this.rbCPUEncode_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.rb264);
            this.panel4.Controls.Add(this.rbHEVC);
            this.panel4.Location = new System.Drawing.Point(275, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(106, 99);
            this.panel4.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, -6);
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
            this.rbHEVC.Location = new System.Drawing.Point(12, 48);
            this.rbHEVC.Name = "rbHEVC";
            this.rbHEVC.Size = new System.Drawing.Size(60, 23);
            this.rbHEVC.TabIndex = 43;
            this.rbHEVC.Text = "HEVC";
            this.rbHEVC.UseVisualStyleBackColor = false;
            this.rbHEVC.CheckedChanged += new System.EventHandler(this.rbHEVC_CheckedChanged);
            // 
            // pbProgress
            // 
            this.pbProgress.Image = ((System.Drawing.Image)(resources.GetObject("pbProgress.Image")));
            this.pbProgress.Location = new System.Drawing.Point(433, 61);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(134, 64);
            this.pbProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProgress.TabIndex = 41;
            this.pbProgress.TabStop = false;
            this.pbProgress.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComplete.ForeColor = System.Drawing.Color.White;
            this.lblComplete.Location = new System.Drawing.Point(410, 128);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(173, 26);
            this.lblComplete.TabIndex = 40;
            this.lblComplete.Text = "Conversion Complete!";
            this.lblComplete.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(409, 32);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(170, 26);
            this.lblProgress.TabIndex = 39;
            this.lblProgress.Text = "Encoding in progress";
            this.lblProgress.Visible = false;
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
            this.btnConvert.Location = new System.Drawing.Point(221, 108);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(162, 37);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Visible = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
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
            this.panel3.Size = new System.Drawing.Size(623, 274);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblExn
            // 
            this.lblExn.AutoSize = true;
            this.lblExn.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExn.ForeColor = System.Drawing.Color.White;
            this.lblExn.Location = new System.Drawing.Point(238, 154);
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
            this.cbExtension.Location = new System.Drawing.Point(433, 150);
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
            this.cbFolder.Location = new System.Drawing.Point(53, 155);
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
            this.lblSize.Location = new System.Drawing.Point(468, 187);
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
            this.lblInput.Location = new System.Drawing.Point(63, 191);
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
            this.label4.Location = new System.Drawing.Point(47, 220);
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
            this.btnBrowse.Location = new System.Drawing.Point(389, 190);
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
            this.txtFileOut.Location = new System.Drawing.Point(157, 224);
            this.txtFileOut.Name = "txtFileOut";
            this.txtFileOut.ReadOnly = true;
            this.txtFileOut.Size = new System.Drawing.Size(226, 23);
            this.txtFileOut.TabIndex = 35;
            this.txtFileOut.TabStop = false;
            // 
            // txtFileIn
            // 
            this.txtFileIn.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFileIn.Location = new System.Drawing.Point(157, 191);
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
            this.btnBrowseOut.Location = new System.Drawing.Point(389, 223);
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
            this.label3.Location = new System.Drawing.Point(91, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 129);
            this.label3.TabIndex = 2;
            this.label3.Text = "To Continue with auto shrink, \r\nchoose file and destination, then \r\nclick GO!\r\n";
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panelIcon;
        private Panel panel2;
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
        private Button btnConvert;
        private RadioButton rbCPUEncode;
        private Label label5;
        private RadioButton rbNVIDIAGPU;
        private RadioButton rbAMDGPU;
        private Label lblProgress;
        private Label lblComplete;
        private PictureBox pbProgress;
        private CheckBox cbFolder;
        private ComboBox cbExtension;
        private Label lblExn;
        private Panel panel5;
        private Panel panel4;
        private Label label6;
        private RadioButton rb264;
        private RadioButton rbHEVC;
    }
}