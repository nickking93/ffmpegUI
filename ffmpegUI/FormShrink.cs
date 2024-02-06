using System.Diagnostics;

namespace ffmpegUI
{
    public partial class FormShrink : Form
    {
        public FormShrink()
        {
            InitializeComponent();
        }

        public static async Task OpenWithDefaultProgram(string pathIn)
        {
            using Process fileopener = new Process();
            fileopener.StartInfo.FileName = pathIn;
            fileopener.StartInfo.UseShellExecute = true;
            fileopener.Start();
            return;
        }

        static async Task writeAuto(string line0, string line1)
        {
            string[] lines =
            {
                    line0,
                    line1,
                    "pause"
                };

            await System.IO.File.WriteAllLinesAsync("ff.bat", lines);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formManual = new FormManual();
            formManual.Tag = this;
            formManual.StartPosition = FormStartPosition.Manual;
            formManual.Location = this.Location;
            formManual.Closed += (s, args) => this.Close();
            formManual.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
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

        private void FormShrink_Load(object sender, EventArgs e)
        {
            string dir = "tmp";
            Directory.CreateDirectory(dir);
            lblSize.Text = "Size: " + txtFileIn.Text;
            rbCPUEncode.Checked = true;
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            string fileIn = txtFileIn.Text;
            string safeName = System.IO.Path.GetFileNameWithoutExtension(fileIn);
            string fileName = System.IO.Path.GetFileName(fileIn);
            string path = txtFileOut.Text + "\\";
            string dir = System.IO.Directory.GetCurrentDirectory();
            string cmd0 = string.Empty;
            if (rbCPUEncode.Checked == true)
            {
                cmd0 = $"cd ffmpeg\\bin && ffmpeg.exe -y -hide_banner -probesize 100M -analyzeduration 250M -i \"{fileIn}\" -fflags +genpts -c:v libx264 -crf 28 -crf_max 28 -preset veryfast -c:a copy -movflags +faststart -fps_mode vfr \"{path}{safeName}.mp4\"";
            }
            if (rbAMDGPU.Checked == true)
            {
                cmd0 = $"cd ffmpeg\\bin && ffmpeg.exe -y -hide_banner -hwaccel d3d11va -probesize 100M -analyzeduration 250M -i \"{fileIn}\" -fflags +genpts -c:v h264_amf -vf mpdecimate -rc cqp -qp_i 28 -qp_p 28 -qp_b 28 -q:v 28 -c:a copy -movflags +faststart -fps_mode vfr \"{path}{safeName}.mp4\"";
            }
            if (rbNVIDIAGPU.Checked == true)
            {
                cmd0 = $"cd ffmpeg/bin && ffmpeg.exe -y -hide_banner -hwaccel d3d11va -i \"{fileIn}\" -fflags +genpts -c:v h264_nvenc -rc constqp -qp 28 -preset fast -vf mpdecimate -c:a copy -movflags faststart -fps_mode vfr \"{path}{safeName}.mp4\"";
            }
            string cmd1 = string.Empty;
            writeAuto(cmd0, cmd1);
            Process ffmpeg = Process.Start("./ff.bat");
            //ffmpeg.WaitForExit();
            ffmpeg.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            ffmpeg.StartInfo.UseShellExecute = true;
            while (ffmpeg.HasExited == false)
            {
                progressBar1.Visible = true;
                lblProgress.Visible = true;
                btnConvert.Visible = false;
            }
            if (ffmpeg.HasExited == true)
            {
                progressBar1.Visible = false;
                lblProgress.Visible = false;
            }
            //this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}