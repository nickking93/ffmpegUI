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
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.PictureBox();
            this.lblComplete = new System.Windows.Forms.Label();
            this.nudOutS = new System.Windows.Forms.NumericUpDown();
            this.nudOutM = new System.Windows.Forms.NumericUpDown();
            this.nudOutH = new System.Windows.Forms.NumericUpDown();
            this.nudInS = new System.Windows.Forms.NumericUpDown();
            this.nudInM = new System.Windows.Forms.NumericUpDown();
            this.nudInH = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panelIcon.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInH)).BeginInit();
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
            this.button2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(0, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 122);
            this.button2.TabIndex = 2;
            this.button2.Text = "Trim Tool";
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
            this.button1.Location = new System.Drawing.Point(0, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 116);
            this.button1.TabIndex = 1;
            this.button1.Text = "Manual Conversion";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(177, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 197);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumPurple;
            this.panel6.Controls.Add(this.pnlProgress);
            this.panel6.Controls.Add(this.lblComplete);
            this.panel6.Controls.Add(this.nudOutS);
            this.panel6.Controls.Add(this.nudOutM);
            this.panel6.Controls.Add(this.nudOutH);
            this.panel6.Controls.Add(this.nudInS);
            this.panel6.Controls.Add(this.nudInM);
            this.panel6.Controls.Add(this.nudInH);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btnConvert);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(623, 194);
            this.panel6.TabIndex = 8;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.lblCount);
            this.pnlProgress.Controls.Add(this.lblProgress);
            this.pnlProgress.Controls.Add(this.pbProgress);
            this.pnlProgress.Location = new System.Drawing.Point(375, 11);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(250, 112);
            this.pnlProgress.TabIndex = 50;
            this.pnlProgress.Visible = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(95, 19);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(73, 21);
            this.lblCount.TabIndex = 42;
            this.lblCount.Text = "File 0 of 0";
            this.lblCount.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(36, -2);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(213, 26);
            this.lblProgress.TabIndex = 39;
            this.lblProgress.Text = "ENCODING IN PROGRESS";
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
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComplete.ForeColor = System.Drawing.Color.White;
            this.lblComplete.Location = new System.Drawing.Point(437, 126);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(173, 26);
            this.lblComplete.TabIndex = 49;
            this.lblComplete.Text = "Conversion Complete!";
            this.lblComplete.Visible = false;
            // 
            // nudOutS
            // 
            this.nudOutS.Location = new System.Drawing.Point(329, 97);
            this.nudOutS.Name = "nudOutS";
            this.nudOutS.Size = new System.Drawing.Size(34, 23);
            this.nudOutS.TabIndex = 20;
            // 
            // nudOutM
            // 
            this.nudOutM.Location = new System.Drawing.Point(253, 97);
            this.nudOutM.Name = "nudOutM";
            this.nudOutM.Size = new System.Drawing.Size(34, 23);
            this.nudOutM.TabIndex = 19;
            // 
            // nudOutH
            // 
            this.nudOutH.Location = new System.Drawing.Point(174, 97);
            this.nudOutH.Name = "nudOutH";
            this.nudOutH.Size = new System.Drawing.Size(34, 23);
            this.nudOutH.TabIndex = 18;
            // 
            // nudInS
            // 
            this.nudInS.Location = new System.Drawing.Point(329, 60);
            this.nudInS.Name = "nudInS";
            this.nudInS.Size = new System.Drawing.Size(34, 23);
            this.nudInS.TabIndex = 17;
            // 
            // nudInM
            // 
            this.nudInM.Location = new System.Drawing.Point(253, 60);
            this.nudInM.Name = "nudInM";
            this.nudInM.Size = new System.Drawing.Size(34, 23);
            this.nudInM.TabIndex = 16;
            // 
            // nudInH
            // 
            this.nudInH.Location = new System.Drawing.Point(174, 60);
            this.nudInH.Name = "nudInH";
            this.nudInH.Size = new System.Drawing.Size(34, 23);
            this.nudInH.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(293, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "SS:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(293, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 26);
            this.label11.TabIndex = 13;
            this.label11.Text = "SS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(214, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "MM:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(214, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "MM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(137, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "HH:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(137, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "HH:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Clip Duration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clip Start:";
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
            this.btnConvert.Location = new System.Drawing.Point(503, 158);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(117, 33);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Visible = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
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
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
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
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInH)).EndInit();
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
        private Button button5;
        private Panel panel6;
        private Label label6;
        private Label label5;
        private Label label2;
        private Button btnConvert;
        private NumericUpDown nudOutS;
        private NumericUpDown nudOutM;
        private NumericUpDown nudOutH;
        private NumericUpDown nudInS;
        private NumericUpDown nudInM;
        private NumericUpDown nudInH;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel pnlProgress;
        private Label lblCount;
        private Label lblProgress;
        private PictureBox pbProgress;
        private Label lblComplete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}