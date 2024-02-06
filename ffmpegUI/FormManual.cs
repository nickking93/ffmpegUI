using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace ffmpegUI
{
    public partial class FormManual : Form
    {
        public FormManual()
        {
            InitializeComponent();
        }


        public static void OpenWithDefaultProgram(string pathIn)
        {
            using Process fileopener = new Process();
            fileopener.StartInfo.FileName = pathIn;
            fileopener.StartInfo.UseShellExecute = true;
            fileopener.Start();
        }

        static async Task writeAuto(string line0)
        {
            string[] lines =
            {
                    line0,
                    "pause"
                };

            await System.IO.File.WriteAllLinesAsync("ff.bat", lines);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormManual_Load(object sender, EventArgs e)
        {
            rbAMDGPU.Checked = false;
            rbNVIDIAGPU.Checked = false;
            rbCPUEncode.Checked = true;
            rb264.Checked = true;
            rbHEVC.Checked = false;
            rbCopyRes.Checked = true;
            rbManualRes.Checked = false;
            rbRemove.Checked= true;
            rbKeep.Checked = false;
            rbManualSpeed.Checked = false;
            rbCopySpeed.Checked = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formClip = new FormClip();
            formClip.Tag = this;
            formClip.StartPosition = FormStartPosition.Manual;
            formClip.Location = this.Location;
            formClip.Closed += (s, args) => this.Close();
            formClip.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormShrink = new FormShrink();
            FormShrink.Tag = this;
            FormShrink.StartPosition = FormStartPosition.Manual;
            FormShrink.Location = this.Location;
            FormShrink.Closed += (s, args) => this.Close();
            FormShrink.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbWidth_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = int.Parse(tbWidth.Text) <= 9999;
        }

        private void tbHeight_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = int.Parse(tbHeight.Text) <= 9999;
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string fileIn = txtFileIn.Text;
            string safeName = System.IO.Path.GetFileNameWithoutExtension(fileIn);
            string fileName = System.IO.Path.GetFileName(fileIn);
            string path = txtFileOut.Text + "\\";
            string dir = System.IO.Directory.GetCurrentDirectory();
            int qp = tbQP.Value;
            string cmd0 = $"cd ffmpeg\\bin && ffmpeg.exe -y -hide_banner -hwaccel d3d11va -probesize 100M -analyzeduration 250M -i \"{fileIn}\" -fflags +genpts ";
            string resW = tbWidth.Text;
            string resH = tbHeight.Text;
            string cmdEncoder = string.Empty;
            string cmdCQP = string.Empty;
            string dupFrames = string.Empty;
            string speed = string.Empty;
            string cmdEnd = $"-c:a copy -movflags +faststart -fps_mode vfr \"{path}{safeName}.mp4\"";
            if (rbAMDGPU.Checked == true && rb264.Checked == true)
            {
                cmdEncoder = $"-c:v h264_amf ";
                cmdCQP = $"-rc cqp -qp_i {qp} -qp_p {qp} -qp_b {qp} ";
            }
            if (rbAMDGPU.Checked == true && rbHEVC.Checked == true)
            {
                cmdEncoder = $"-c:v hevc_amf ";
                cmdCQP = $"-rc cqp -qp_i {qp} -qp_p {qp} ";
            }
            if (rbNVIDIAGPU.Checked == true && rb264.Checked == true)
            {
                cmdEncoder = $"-c:v h264_nvenc -preset fast ";
                cmdCQP = $"-rc constqp -qp {qp} ";
            }
            if (rbNVIDIAGPU.Checked = true && rbHEVC.Checked == true)
            {
                cmdEncoder = $"-c:v hevc_nvenc -preset fast ";
                cmdCQP = $"-rc constqp -qp {qp} ";
            }
            if (rbCPUEncode.Checked == true && rb264.Checked == true)
            {
                cmdEncoder = $"-c:v libx264 -preset veryfast ";
                cmdCQP = $"-crf {qp} -crf_max {qp} ";
                rbNVIDIAGPU.Checked = false;
            }
            if (rbCPUEncode.Checked == true && rbHEVC.Checked == true)
            {
                cmdEncoder = $"-c:v libx265 -preset veryfast ";
                cmdCQP = $"-crf {qp} -crf_max {qp} ";
                rbNVIDIAGPU.Checked = false;
            }
            //ADD REST OF SPEED OPTS
            if (rbCopyRes.Checked == true && rbRemove.Checked == true)
            {
                dupFrames = $"-vf mpdecimate ";
            }
            if (rbManualRes.Checked == true && rbRemove.Checked == true)
            {
                dupFrames = $"-vf \"scale={resW}:{resH}:flags=lanczos,mpdecimate\" ";
            }
            if (rbManualRes.Checked == true && rbKeep.Checked == true)
            {
                dupFrames = $"-vf \"scale={resW}:{resH}:flags=lanczos\" ";
            }
            else
            {
                dupFrames = string.Empty;
            }
            if (rbCopySpeed.Checked == true)
            {
                speed = string.Empty;
            }
            else
            {
                speed = $"-r {speed} ";
            }
            string cmdFinal = cmd0 + cmdEncoder + cmdCQP + dupFrames + speed + cmdEnd;
            writeAuto(cmdFinal);
            Process.Start("./ff.bat");
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new();
            openFileDialog1.Filter = "Video Files|*.mkv;*.mp4;*.ts;*.mov;*.avi;*.m4v;";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                txtFileIn.Text = file;
                try
                {
                    string text = openFileDialog1.FileName;
                    FileInfo fileInf = new FileInfo(text);
                    float fileSize = fileInf.Length;
                    string tmpSize = fileSize.ToString();
                    float fileSizeKB = fileSize / 1024;
                    float fileSizeMB = (fileSize / 1024) / 1024;
                    float fileSizeGB = (fileSizeMB / 1024);
                    size = text.Length;
                    if (txtFileOut.TextLength >= 0)
                    {
                        btnConvert.Visible = false;
                    }
                    else
                    {
                        btnConvert.Visible = true;
                    }
                    txtVal.Visible = true;
                    lblVal.Visible = true;
                    lblHigh.Visible = true;
                    lblLow.Visible = true;
                    tbQP.Visible = true;
                    tbQP.Value = 28;
                    txtVal.Text = tbQP.Value.ToString();
                    lblSize.Visible = true;

                    if (tmpSize.Length >= 9)
                    {
                        lblSize.Text = "Size: " + fileSizeGB.ToString("n2") + " GB";
                    }
                    else if (tmpSize.Length > 5 && tmpSize.Length < 9)
                    {
                        lblSize.Text = "Size: " + fileSizeMB.ToString("n2") + " MB";
                    }
                    else
                    {
                        lblSize.Text = "Size: " + fileSizeKB.ToString("n2") + " KB";
                    }

                }
                catch (IOException)
                {
                }
            }
        }

        private void btnBrowseOut_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new();
            DialogResult result = folderBrowserDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string outputDir = folderBrowserDialog1.SelectedPath;
                txtFileOut.Text = outputDir;
                try
                {
                    if (outputDir != "")
                    {
                        btnConvert.Visible = true;
                    }
                }
                catch (IOException)
                {
                }
            }
        }

        private void txtVal_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbManualRes_CheckedChanged(object sender, EventArgs e)
        {
            tbWidth.Visible= true;
            tbHeight.Visible= true;
            lblX.Visible= true;
        }

        private void rbCopyRes_CheckedChanged(object sender, EventArgs e)
        {
            tbWidth.Visible = false;
            tbHeight.Visible = false;
            lblX.Visible = false;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            lbSpeed.Visible= true;
        }

        private void rbCopySpeed_CheckedChanged(object sender, EventArgs e)
        {
            lbSpeed.Visible= false;
        }

        private void rbCPUEncode_CheckedChanged(object sender, EventArgs e)
        {
            rbAMDGPU.Checked = false;
            rbNVIDIAGPU.Checked = false;
        }

        private void rbHEVC_CheckedChanged(object sender, EventArgs e)
        {
            rb264.Checked = false;
        }

        private void pnlResolution_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}