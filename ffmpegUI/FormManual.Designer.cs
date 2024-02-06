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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.lblVal = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.tbQP = new System.Windows.Forms.TrackBar();
            this.lblCQP = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlCqp = new System.Windows.Forms.Panel();
            this.lbSpeed = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbManualSpeed = new System.Windows.Forms.RadioButton();
            this.rbCopySpeed = new System.Windows.Forms.RadioButton();
            this.pnlResolution = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rbKeep = new System.Windows.Forms.RadioButton();
            this.rbRemove = new System.Windows.Forms.RadioButton();
            this.pnlFrameRate = new System.Windows.Forms.Panel();
            this.tbHeight = new System.Windows.Forms.MaskedTextBox();
            this.tbWidth = new System.Windows.Forms.MaskedTextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbManualRes = new System.Windows.Forms.RadioButton();
            this.rbCopyRes = new System.Windows.Forms.RadioButton();
            this.pnlCodec = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rbHEVC = new System.Windows.Forms.RadioButton();
            this.rb264 = new System.Windows.Forms.RadioButton();
            this.pnlHwChoice = new System.Windows.Forms.Panel();
            this.rbCPUEncode = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbNVIDIAGPU = new System.Windows.Forms.RadioButton();
            this.rbAMDGPU = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
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
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQP)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlCqp.SuspendLayout();
            this.pnlResolution.SuspendLayout();
            this.pnlFrameRate.SuspendLayout();
            this.pnlCodec.SuspendLayout();
            this.pnlHwChoice.SuspendLayout();
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
            this.button3.Location = new System.Drawing.Point(0, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 97);
            this.button3.TabIndex = 3;
            this.button3.Text = "Preset Conversions";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Plum;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(0, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 122);
            this.button2.TabIndex = 2;
            this.button2.Text = "Manual Conversion";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 108);
            this.button1.TabIndex = 1;
            this.button1.Text = "Shrink Video File";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelIcon
            // 
            this.panelIcon.BackColor = System.Drawing.Color.BlueViolet;
            this.panelIcon.Controls.Add(this.label1);
            this.panelIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIcon.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelIcon.ForeColor = System.Drawing.Color.White;
            this.panelIcon.Location = new System.Drawing.Point(0, 0);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(177, 113);
            this.panelIcon.TabIndex = 0;
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
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(177, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 197);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumPurple;
            this.panel6.Controls.Add(this.txtVal);
            this.panel6.Controls.Add(this.lblVal);
            this.panel6.Controls.Add(this.lblHigh);
            this.panel6.Controls.Add(this.lblLow);
            this.panel6.Controls.Add(this.tbQP);
            this.panel6.Controls.Add(this.lblCQP);
            this.panel6.Controls.Add(this.btnConvert);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(623, 97);
            this.panel6.TabIndex = 8;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // txtVal
            // 
            this.txtVal.BackColor = System.Drawing.Color.Gainsboro;
            this.txtVal.ForeColor = System.Drawing.Color.Firebrick;
            this.txtVal.Location = new System.Drawing.Point(410, 58);
            this.txtVal.Name = "txtVal";
            this.txtVal.ReadOnly = true;
            this.txtVal.Size = new System.Drawing.Size(79, 23);
            this.txtVal.TabIndex = 47;
            this.txtVal.TextChanged += new System.EventHandler(this.txtVal_TextChanged);
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVal.ForeColor = System.Drawing.Color.White;
            this.lblVal.Location = new System.Drawing.Point(370, 58);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(43, 23);
            this.lblVal.TabIndex = 46;
            this.lblVal.Text = "CQP:";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHigh.ForeColor = System.Drawing.Color.White;
            this.lblHigh.Location = new System.Drawing.Point(308, 27);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(107, 23);
            this.lblHigh.TabIndex = 45;
            this.lblHigh.Text = "Higher Quality";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLow.ForeColor = System.Drawing.Color.White;
            this.lblLow.Location = new System.Drawing.Point(10, 27);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(109, 23);
            this.lblLow.TabIndex = 44;
            this.lblLow.Text = "Lower File Size";
            this.lblLow.Visible = false;
            // 
            // tbQP
            // 
            this.tbQP.BackColor = System.Drawing.Color.MediumPurple;
            this.tbQP.Location = new System.Drawing.Point(27, 45);
            this.tbQP.Maximum = 51;
            this.tbQP.Name = "tbQP";
            this.tbQP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbQP.Size = new System.Drawing.Size(340, 45);
            this.tbQP.TabIndex = 43;
            this.tbQP.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbQP.Value = 28;
            // 
            // lblCQP
            // 
            this.lblCQP.AutoSize = true;
            this.lblCQP.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCQP.ForeColor = System.Drawing.Color.White;
            this.lblCQP.Location = new System.Drawing.Point(15, 2);
            this.lblCQP.Name = "lblCQP";
            this.lblCQP.Size = new System.Drawing.Size(116, 26);
            this.lblCQP.TabIndex = 5;
            this.lblCQP.Text = "CQP (Quality)";
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
            this.btnConvert.Location = new System.Drawing.Point(503, 55);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(117, 33);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Visible = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlCqp);
            this.panel4.Controls.Add(this.pnlResolution);
            this.panel4.Controls.Add(this.pnlFrameRate);
            this.panel4.Controls.Add(this.pnlCodec);
            this.panel4.Controls.Add(this.pnlHwChoice);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(623, 100);
            this.panel4.TabIndex = 7;
            // 
            // pnlCqp
            // 
            this.pnlCqp.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlCqp.Controls.Add(this.lbSpeed);
            this.pnlCqp.Controls.Add(this.label8);
            this.pnlCqp.Controls.Add(this.rbManualSpeed);
            this.pnlCqp.Controls.Add(this.rbCopySpeed);
            this.pnlCqp.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCqp.Location = new System.Drawing.Point(526, 0);
            this.pnlCqp.Name = "pnlCqp";
            this.pnlCqp.Size = new System.Drawing.Size(97, 100);
            this.pnlCqp.TabIndex = 11;
            // 
            // lbSpeed
            // 
            this.lbSpeed.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSpeed.FormattingEnabled = true;
            this.lbSpeed.ItemHeight = 21;
            this.lbSpeed.Items.AddRange(new object[] {
            "-2x",
            "-1.5x",
            "-.5",
            ".5x",
            "1.5x",
            "2x"});
            this.lbSpeed.Location = new System.Drawing.Point(11, 71);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(74, 25);
            this.lbSpeed.TabIndex = 16;
            this.lbSpeed.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Speed";
            // 
            // rbManualSpeed
            // 
            this.rbManualSpeed.AutoSize = true;
            this.rbManualSpeed.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbManualSpeed.ForeColor = System.Drawing.Color.White;
            this.rbManualSpeed.Location = new System.Drawing.Point(11, 48);
            this.rbManualSpeed.Name = "rbManualSpeed";
            this.rbManualSpeed.Size = new System.Drawing.Size(66, 23);
            this.rbManualSpeed.TabIndex = 14;
            this.rbManualSpeed.Text = "Manual";
            this.rbManualSpeed.UseVisualStyleBackColor = true;
            this.rbManualSpeed.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // rbCopySpeed
            // 
            this.rbCopySpeed.AutoSize = true;
            this.rbCopySpeed.Checked = true;
            this.rbCopySpeed.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCopySpeed.ForeColor = System.Drawing.Color.White;
            this.rbCopySpeed.Location = new System.Drawing.Point(11, 21);
            this.rbCopySpeed.Name = "rbCopySpeed";
            this.rbCopySpeed.Size = new System.Drawing.Size(54, 23);
            this.rbCopySpeed.TabIndex = 13;
            this.rbCopySpeed.TabStop = true;
            this.rbCopySpeed.Text = "Copy";
            this.rbCopySpeed.UseVisualStyleBackColor = true;
            this.rbCopySpeed.CheckedChanged += new System.EventHandler(this.rbCopySpeed_CheckedChanged);
            // 
            // pnlResolution
            // 
            this.pnlResolution.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlResolution.Controls.Add(this.label6);
            this.pnlResolution.Controls.Add(this.rbKeep);
            this.pnlResolution.Controls.Add(this.rbRemove);
            this.pnlResolution.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlResolution.Location = new System.Drawing.Point(391, 0);
            this.pnlResolution.Name = "pnlResolution";
            this.pnlResolution.Size = new System.Drawing.Size(142, 100);
            this.pnlResolution.TabIndex = 11;
            this.pnlResolution.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlResolution_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Duplicate Frames";
            // 
            // rbKeep
            // 
            this.rbKeep.AutoSize = true;
            this.rbKeep.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbKeep.ForeColor = System.Drawing.Color.White;
            this.rbKeep.Location = new System.Drawing.Point(3, 45);
            this.rbKeep.Name = "rbKeep";
            this.rbKeep.Size = new System.Drawing.Size(54, 23);
            this.rbKeep.TabIndex = 8;
            this.rbKeep.Text = "Keep";
            this.rbKeep.UseVisualStyleBackColor = true;
            // 
            // rbRemove
            // 
            this.rbRemove.AutoSize = true;
            this.rbRemove.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbRemove.ForeColor = System.Drawing.Color.White;
            this.rbRemove.Location = new System.Drawing.Point(3, 20);
            this.rbRemove.Name = "rbRemove";
            this.rbRemove.Size = new System.Drawing.Size(70, 23);
            this.rbRemove.TabIndex = 7;
            this.rbRemove.Text = "Remove";
            this.rbRemove.UseVisualStyleBackColor = true;
            // 
            // pnlFrameRate
            // 
            this.pnlFrameRate.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlFrameRate.Controls.Add(this.tbHeight);
            this.pnlFrameRate.Controls.Add(this.tbWidth);
            this.pnlFrameRate.Controls.Add(this.lblX);
            this.pnlFrameRate.Controls.Add(this.label7);
            this.pnlFrameRate.Controls.Add(this.rbManualRes);
            this.pnlFrameRate.Controls.Add(this.rbCopyRes);
            this.pnlFrameRate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFrameRate.Location = new System.Drawing.Point(261, 0);
            this.pnlFrameRate.Name = "pnlFrameRate";
            this.pnlFrameRate.Size = new System.Drawing.Size(130, 100);
            this.pnlFrameRate.TabIndex = 10;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(71, 71);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(56, 23);
            this.tbHeight.TabIndex = 15;
            this.tbHeight.Visible = false;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(0, 71);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(54, 23);
            this.tbWidth.TabIndex = 14;
            this.tbWidth.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblX.Location = new System.Drawing.Point(54, 67);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 28);
            this.lblX.TabIndex = 13;
            this.lblX.Text = "x";
            this.lblX.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Resolution:";
            // 
            // rbManualRes
            // 
            this.rbManualRes.AutoSize = true;
            this.rbManualRes.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbManualRes.ForeColor = System.Drawing.Color.White;
            this.rbManualRes.Location = new System.Drawing.Point(6, 45);
            this.rbManualRes.Name = "rbManualRes";
            this.rbManualRes.Size = new System.Drawing.Size(66, 23);
            this.rbManualRes.TabIndex = 11;
            this.rbManualRes.Text = "Manual";
            this.rbManualRes.UseVisualStyleBackColor = true;
            this.rbManualRes.CheckedChanged += new System.EventHandler(this.rbManualRes_CheckedChanged);
            // 
            // rbCopyRes
            // 
            this.rbCopyRes.AutoSize = true;
            this.rbCopyRes.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCopyRes.ForeColor = System.Drawing.Color.White;
            this.rbCopyRes.Location = new System.Drawing.Point(6, 20);
            this.rbCopyRes.Name = "rbCopyRes";
            this.rbCopyRes.Size = new System.Drawing.Size(54, 23);
            this.rbCopyRes.TabIndex = 10;
            this.rbCopyRes.Text = "Copy";
            this.rbCopyRes.UseVisualStyleBackColor = true;
            this.rbCopyRes.CheckedChanged += new System.EventHandler(this.rbCopyRes_CheckedChanged);
            // 
            // pnlCodec
            // 
            this.pnlCodec.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlCodec.Controls.Add(this.label5);
            this.pnlCodec.Controls.Add(this.rbHEVC);
            this.pnlCodec.Controls.Add(this.rb264);
            this.pnlCodec.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCodec.Location = new System.Drawing.Point(171, 0);
            this.pnlCodec.Name = "pnlCodec";
            this.pnlCodec.Size = new System.Drawing.Size(90, 100);
            this.pnlCodec.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Codec";
            // 
            // rbHEVC
            // 
            this.rbHEVC.AutoSize = true;
            this.rbHEVC.BackColor = System.Drawing.Color.MediumPurple;
            this.rbHEVC.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbHEVC.ForeColor = System.Drawing.Color.White;
            this.rbHEVC.Location = new System.Drawing.Point(3, 45);
            this.rbHEVC.Name = "rbHEVC";
            this.rbHEVC.Size = new System.Drawing.Size(60, 23);
            this.rbHEVC.TabIndex = 5;
            this.rbHEVC.Text = "HEVC";
            this.rbHEVC.UseVisualStyleBackColor = false;
            this.rbHEVC.CheckedChanged += new System.EventHandler(this.rbHEVC_CheckedChanged);
            // 
            // rb264
            // 
            this.rb264.AutoSize = true;
            this.rb264.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb264.ForeColor = System.Drawing.Color.White;
            this.rb264.Location = new System.Drawing.Point(3, 20);
            this.rb264.Name = "rb264";
            this.rb264.Size = new System.Drawing.Size(51, 23);
            this.rb264.TabIndex = 4;
            this.rb264.Text = "264";
            this.rb264.UseVisualStyleBackColor = true;
            // 
            // pnlHwChoice
            // 
            this.pnlHwChoice.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlHwChoice.Controls.Add(this.rbCPUEncode);
            this.pnlHwChoice.Controls.Add(this.label2);
            this.pnlHwChoice.Controls.Add(this.rbNVIDIAGPU);
            this.pnlHwChoice.Controls.Add(this.rbAMDGPU);
            this.pnlHwChoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHwChoice.Location = new System.Drawing.Point(0, 0);
            this.pnlHwChoice.Name = "pnlHwChoice";
            this.pnlHwChoice.Size = new System.Drawing.Size(171, 100);
            this.pnlHwChoice.TabIndex = 9;
            // 
            // rbCPUEncode
            // 
            this.rbCPUEncode.AutoSize = true;
            this.rbCPUEncode.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCPUEncode.ForeColor = System.Drawing.Color.White;
            this.rbCPUEncode.Location = new System.Drawing.Point(0, 67);
            this.rbCPUEncode.Name = "rbCPUEncode";
            this.rbCPUEncode.Size = new System.Drawing.Size(106, 23);
            this.rbCPUEncode.TabIndex = 3;
            this.rbCPUEncode.Text = "CPU Encoding";
            this.rbCPUEncode.UseVisualStyleBackColor = true;
            this.rbCPUEncode.CheckedChanged += new System.EventHandler(this.rbCPUEncode_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPU/GPU Encoder:";
            // 
            // rbNVIDIAGPU
            // 
            this.rbNVIDIAGPU.AutoSize = true;
            this.rbNVIDIAGPU.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbNVIDIAGPU.ForeColor = System.Drawing.Color.White;
            this.rbNVIDIAGPU.Location = new System.Drawing.Point(0, 45);
            this.rbNVIDIAGPU.Name = "rbNVIDIAGPU";
            this.rbNVIDIAGPU.Size = new System.Drawing.Size(98, 23);
            this.rbNVIDIAGPU.TabIndex = 1;
            this.rbNVIDIAGPU.Text = "NVIDIA GPU";
            this.rbNVIDIAGPU.UseVisualStyleBackColor = true;
            this.rbNVIDIAGPU.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbAMDGPU
            // 
            this.rbAMDGPU.AutoSize = true;
            this.rbAMDGPU.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbAMDGPU.ForeColor = System.Drawing.Color.White;
            this.rbAMDGPU.Location = new System.Drawing.Point(0, 20);
            this.rbAMDGPU.Name = "rbAMDGPU";
            this.rbAMDGPU.Size = new System.Drawing.Size(85, 23);
            this.rbAMDGPU.TabIndex = 0;
            this.rbAMDGPU.Text = "AMD GPU";
            this.rbAMDGPU.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(452, 97);
            this.panel5.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(763, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 23);
            this.button4.TabIndex = 39;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Controls.Add(this.button5);
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
            this.panel3.Size = new System.Drawing.Size(623, 247);
            this.panel3.TabIndex = 40;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(586, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 23);
            this.button5.TabIndex = 45;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(488, 147);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(46, 26);
            this.lblSize.TabIndex = 44;
            this.lblSize.Text = "Size:";
            this.lblSize.Visible = false;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInput.ForeColor = System.Drawing.Color.White;
            this.lblInput.Location = new System.Drawing.Point(83, 151);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(88, 26);
            this.lblInput.TabIndex = 43;
            this.lblInput.Text = "Input File:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 41;
            this.label4.Text = "Output Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Plum;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(409, 150);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 38;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileOut
            // 
            this.txtFileOut.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFileOut.Location = new System.Drawing.Point(177, 184);
            this.txtFileOut.Name = "txtFileOut";
            this.txtFileOut.ReadOnly = true;
            this.txtFileOut.Size = new System.Drawing.Size(226, 23);
            this.txtFileOut.TabIndex = 42;
            this.txtFileOut.TabStop = false;
            // 
            // txtFileIn
            // 
            this.txtFileIn.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFileIn.Location = new System.Drawing.Point(177, 151);
            this.txtFileIn.Name = "txtFileIn";
            this.txtFileIn.ReadOnly = true;
            this.txtFileIn.Size = new System.Drawing.Size(226, 23);
            this.txtFileIn.TabIndex = 40;
            this.txtFileIn.TabStop = false;
            // 
            // btnBrowseOut
            // 
            this.btnBrowseOut.BackColor = System.Drawing.Color.Plum;
            this.btnBrowseOut.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBrowseOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnBrowseOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnBrowseOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseOut.ForeColor = System.Drawing.Color.White;
            this.btnBrowseOut.Location = new System.Drawing.Point(409, 183);
            this.btnBrowseOut.Name = "btnBrowseOut";
            this.btnBrowseOut.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOut.TabIndex = 39;
            this.btnBrowseOut.Text = "Browse";
            this.btnBrowseOut.UseVisualStyleBackColor = false;
            this.btnBrowseOut.Click += new System.EventHandler(this.btnBrowseOut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(552, 172);
            this.label3.TabIndex = 3;
            this.label3.Text = "To continue, choose input video and\r\noutput Destination, then conversion options\r" +
    "\nand press GO!\r\n\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ffmpegUI";
            this.Load += new System.EventHandler(this.FormManual_Load);
            this.panel1.ResumeLayout(false);
            this.panelIcon.ResumeLayout(false);
            this.panelIcon.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQP)).EndInit();
            this.panel4.ResumeLayout(false);
            this.pnlCqp.ResumeLayout(false);
            this.pnlCqp.PerformLayout();
            this.pnlResolution.ResumeLayout(false);
            this.pnlResolution.PerformLayout();
            this.pnlFrameRate.ResumeLayout(false);
            this.pnlFrameRate.PerformLayout();
            this.pnlCodec.ResumeLayout(false);
            this.pnlCodec.PerformLayout();
            this.pnlHwChoice.ResumeLayout(false);
            this.pnlHwChoice.PerformLayout();
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
        private Button button4;
        private Panel panel3;
        private Label label3;
        private Label lblSize;
        private Label lblInput;
        private Label label4;
        private Button btnBrowse;
        private TextBox txtFileOut;
        private TextBox txtFileIn;
        private Button btnBrowseOut;
        private Button btnConvert;
        private Panel pnlCqp;
        private Panel pnlFrameRate;
        private Panel panel4;
        private Panel pnlResolution;
        private Panel pnlCodec;
        private Panel pnlHwChoice;
        private Label label2;
        private RadioButton rbNVIDIAGPU;
        private RadioButton rbAMDGPU;
        private Panel panel5;
        private Label label8;
        private RadioButton rbManualSpeed;
        private RadioButton rbCopySpeed;
        private Label label7;
        private RadioButton rbManualRes;
        private RadioButton rbCopyRes;
        private Label label6;
        private RadioButton rbKeep;
        private RadioButton rbRemove;
        private Label label5;
        private RadioButton rbHEVC;
        private RadioButton rb264;
        private RadioButton rbCPUEncode;
        private Panel panel6;
        private TextBox txtVal;
        private Label lblVal;
        private Label lblHigh;
        private Label lblLow;
        private TrackBar tbQP;
        private Label lblCQP;
        private Label lblX;
        private MaskedTextBox tbHeight;
        private MaskedTextBox tbWidth;
        private ListBox lbSpeed;
        private Button button5;
    }
}