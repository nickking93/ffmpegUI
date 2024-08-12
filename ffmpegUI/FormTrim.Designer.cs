namespace ffmpegUI
{
    partial class FormTrim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrim));
            panel1 = new Panel();
            btnFormPreset = new Button();
            button2 = new Button();
            button1 = new Button();
            panelIcon = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            pnlProgress = new Panel();
            lblCount = new Label();
            lblProgress = new Label();
            pbProgress = new PictureBox();
            lblComplete = new Label();
            nudOutS = new NumericUpDown();
            nudOutM = new NumericUpDown();
            nudOutH = new NumericUpDown();
            nudInS = new NumericUpDown();
            nudInM = new NumericUpDown();
            nudInH = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            btnConvert = new Button();
            button4 = new Button();
            panel3 = new Panel();
            button5 = new Button();
            lblSize = new Label();
            lblInput = new Label();
            label4 = new Label();
            btnBrowse = new Button();
            txtFileOut = new TextBox();
            txtFileIn = new TextBox();
            btnBrowseOut = new Button();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panelIcon.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            pnlProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProgress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOutS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOutM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOutH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInH).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFormPreset);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panelIcon);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 450);
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
            btnFormPreset.Location = new Point(0, 353);
            btnFormPreset.Name = "btnFormPreset";
            btnFormPreset.Size = new Size(177, 97);
            btnFormPreset.TabIndex = 3;
            btnFormPreset.Text = "Preset Conversions";
            btnFormPreset.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFormPreset.UseVisualStyleBackColor = true;
            btnFormPreset.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(0, 225);
            button2.Name = "button2";
            button2.Size = new Size(177, 122);
            button2.TabIndex = 2;
            button2.Text = "Trim Tool";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Plum;
            button1.FlatAppearance.MouseOverBackColor = Color.Violet;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 111);
            button1.Name = "button1";
            button1.Size = new Size(177, 116);
            button1.TabIndex = 1;
            button1.Text = "Manual Conversion";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelIcon
            // 
            panelIcon.BackColor = Color.BlueViolet;
            panelIcon.Controls.Add(label1);
            panelIcon.Dock = DockStyle.Top;
            panelIcon.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point);
            panelIcon.ForeColor = Color.White;
            panelIcon.Location = new Point(0, 0);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(177, 113);
            panelIcon.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(130, 42);
            label1.TabIndex = 0;
            label1.Text = "ffmpegUI";
            // 
            // panel2
            // 
            panel2.BackColor = Color.BlueViolet;
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(177, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 197);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.MediumPurple;
            panel6.Controls.Add(pnlProgress);
            panel6.Controls.Add(lblComplete);
            panel6.Controls.Add(nudOutS);
            panel6.Controls.Add(nudOutM);
            panel6.Controls.Add(nudOutH);
            panel6.Controls.Add(nudInS);
            panel6.Controls.Add(nudInM);
            panel6.Controls.Add(nudInH);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(btnConvert);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(623, 194);
            panel6.TabIndex = 8;
            panel6.Paint += panel6_Paint;
            // 
            // pnlProgress
            // 
            pnlProgress.Controls.Add(lblCount);
            pnlProgress.Controls.Add(lblProgress);
            pnlProgress.Controls.Add(pbProgress);
            pnlProgress.Location = new Point(375, 11);
            pnlProgress.Name = "pnlProgress";
            pnlProgress.Size = new Size(250, 112);
            pnlProgress.TabIndex = 50;
            pnlProgress.Visible = false;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCount.ForeColor = Color.White;
            lblCount.Location = new Point(95, 19);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(73, 21);
            lblCount.TabIndex = 42;
            lblCount.Text = "File 0 of 0";
            lblCount.Visible = false;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProgress.ForeColor = Color.White;
            lblProgress.Location = new Point(36, -2);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(213, 26);
            lblProgress.TabIndex = 39;
            lblProgress.Text = "ENCODING IN PROGRESS";
            // 
            // pbProgress
            // 
            pbProgress.Image = (Image)resources.GetObject("pbProgress.Image");
            pbProgress.Location = new Point(72, 39);
            pbProgress.Name = "pbProgress";
            pbProgress.Size = new Size(134, 64);
            pbProgress.SizeMode = PictureBoxSizeMode.CenterImage;
            pbProgress.TabIndex = 41;
            pbProgress.TabStop = false;
            // 
            // lblComplete
            // 
            lblComplete.AutoSize = true;
            lblComplete.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblComplete.ForeColor = Color.White;
            lblComplete.Location = new Point(437, 126);
            lblComplete.Name = "lblComplete";
            lblComplete.Size = new Size(173, 26);
            lblComplete.TabIndex = 49;
            lblComplete.Text = "Conversion Complete!";
            lblComplete.Visible = false;
            // 
            // nudOutS
            // 
            nudOutS.Location = new Point(329, 97);
            nudOutS.Name = "nudOutS";
            nudOutS.Size = new Size(34, 23);
            nudOutS.TabIndex = 20;
            // 
            // nudOutM
            // 
            nudOutM.Location = new Point(253, 97);
            nudOutM.Name = "nudOutM";
            nudOutM.Size = new Size(34, 23);
            nudOutM.TabIndex = 19;
            // 
            // nudOutH
            // 
            nudOutH.Location = new Point(174, 97);
            nudOutH.Name = "nudOutH";
            nudOutH.Size = new Size(34, 23);
            nudOutH.TabIndex = 18;
            // 
            // nudInS
            // 
            nudInS.Location = new Point(329, 60);
            nudInS.Name = "nudInS";
            nudInS.Size = new Size(34, 23);
            nudInS.TabIndex = 17;
            // 
            // nudInM
            // 
            nudInM.Location = new Point(253, 60);
            nudInM.Name = "nudInM";
            nudInM.Size = new Size(34, 23);
            nudInM.TabIndex = 16;
            // 
            // nudInH
            // 
            nudInH.Location = new Point(174, 60);
            nudInH.Name = "nudInH";
            nudInH.Size = new Size(34, 23);
            nudInH.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(293, 97);
            label10.Name = "label10";
            label10.Size = new Size(36, 26);
            label10.TabIndex = 14;
            label10.Text = "SS:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(293, 60);
            label11.Name = "label11";
            label11.Size = new Size(36, 26);
            label11.TabIndex = 13;
            label11.Text = "SS:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(214, 97);
            label9.Name = "label9";
            label9.Size = new Size(44, 26);
            label9.TabIndex = 12;
            label9.Text = "MM:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(214, 60);
            label8.Name = "label8";
            label8.Size = new Size(44, 26);
            label8.TabIndex = 11;
            label8.Text = "MM:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(137, 97);
            label7.Name = "label7";
            label7.Size = new Size(40, 26);
            label7.TabIndex = 10;
            label7.Text = "HH:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(137, 60);
            label6.Name = "label6";
            label6.Size = new Size(40, 26);
            label6.TabIndex = 9;
            label6.Text = "HH:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 97);
            label5.Name = "label5";
            label5.Size = new Size(117, 26);
            label5.TabIndex = 8;
            label5.Text = "Clip Duration:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 60);
            label2.Name = "label2";
            label2.Size = new Size(91, 26);
            label2.TabIndex = 7;
            label2.Text = "Clip Start:";
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
            btnConvert.Location = new Point(503, 158);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(117, 33);
            btnConvert.TabIndex = 6;
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Visible = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(763, 0);
            button4.Name = "button4";
            button4.Size = new Size(37, 23);
            button4.TabIndex = 39;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumPurple;
            panel3.Controls.Add(button5);
            panel3.Controls.Add(lblSize);
            panel3.Controls.Add(lblInput);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btnBrowse);
            panel3.Controls.Add(txtFileOut);
            panel3.Controls.Add(txtFileIn);
            panel3.Controls.Add(btnBrowseOut);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(177, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(623, 247);
            panel3.TabIndex = 40;
            panel3.Paint += panel3_Paint;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(586, 0);
            button5.Name = "button5";
            button5.Size = new Size(37, 23);
            button5.TabIndex = 45;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.ForeColor = Color.White;
            lblSize.Location = new Point(488, 147);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(46, 26);
            lblSize.TabIndex = 44;
            lblSize.Text = "Size:";
            lblSize.Visible = false;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblInput.ForeColor = Color.White;
            lblInput.Location = new Point(83, 151);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(88, 26);
            lblInput.TabIndex = 43;
            lblInput.Text = "Input File:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(67, 180);
            label4.Name = "label4";
            label4.Size = new Size(112, 26);
            label4.TabIndex = 41;
            label4.Text = "Output Path:";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Plum;
            btnBrowse.FlatAppearance.BorderColor = Color.DimGray;
            btnBrowse.FlatAppearance.MouseDownBackColor = Color.Violet;
            btnBrowse.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(409, 150);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 38;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtFileOut
            // 
            txtFileOut.BackColor = Color.Gainsboro;
            txtFileOut.Location = new Point(177, 184);
            txtFileOut.Name = "txtFileOut";
            txtFileOut.ReadOnly = true;
            txtFileOut.Size = new Size(226, 23);
            txtFileOut.TabIndex = 42;
            txtFileOut.TabStop = false;
            // 
            // txtFileIn
            // 
            txtFileIn.BackColor = Color.Gainsboro;
            txtFileIn.Location = new Point(177, 151);
            txtFileIn.Name = "txtFileIn";
            txtFileIn.ReadOnly = true;
            txtFileIn.Size = new Size(226, 23);
            txtFileIn.TabIndex = 40;
            txtFileIn.TabStop = false;
            // 
            // btnBrowseOut
            // 
            btnBrowseOut.BackColor = Color.Plum;
            btnBrowseOut.FlatAppearance.BorderColor = Color.DimGray;
            btnBrowseOut.FlatAppearance.MouseDownBackColor = Color.Violet;
            btnBrowseOut.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnBrowseOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowseOut.ForeColor = Color.White;
            btnBrowseOut.Location = new Point(409, 183);
            btnBrowseOut.Name = "btnBrowseOut";
            btnBrowseOut.Size = new Size(75, 23);
            btnBrowseOut.TabIndex = 39;
            btnBrowseOut.Text = "Browse";
            btnBrowseOut.UseVisualStyleBackColor = false;
            btnBrowseOut.Click += btnBrowseOut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 9);
            label3.Name = "label3";
            label3.Size = new Size(552, 172);
            label3.TabIndex = 3;
            label3.Text = "To continue, choose input video and\r\noutput Destination, then conversion options\r\nand press GO!\r\n\r\n";
            label3.Click += label3_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // FormTrim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTrim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ffmpegUI";
            Load += FormTrim_Load;
            panel1.ResumeLayout(false);
            panelIcon.ResumeLayout(false);
            panelIcon.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pnlProgress.ResumeLayout(false);
            pnlProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProgress).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOutS).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOutM).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOutH).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInS).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInM).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInH).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelIcon;
        private Panel panel2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button btnFormPreset;
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