using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Text.Encodings.Web;

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

        static async Task writeFFmpegTrim(string fileIn, string timeIn, string path, string dur, string fullName)
        {
            string[] lines =
            {
                "cd ffmpeg\\bin ",
                $"ffprobe -v quiet -show_streams -select_streams v:0 \"{fileIn}\" > probe.txt",
                $"@ffmpeg.exe -y -hide_banner -hwaccel d3d11va -i \"{fileIn}\" -c copy -ss {timeIn} -t {dur} tmp_{fullName}\"",
                $"@ffmpeg.exe -y -hide_banner -i tmp_{fullName} -c copy \"{path}{fullName}\"",
                $@"rm tmp_{fullName}",
                 "exit"
            };

            await System.IO.File.WriteAllLinesAsync("ff.bat", lines);
        }

        static async Task writeAuto(string line0)
        {
            string[] lines =
            {
                    "cd ffmpeg\\bin && ",
                    line0,
                    "exit"
                };

            await System.IO.File.WriteAllLinesAsync("ff.bat", lines);
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
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new();
            openFileDialog1.Filter = "Video Files|*.mkv;*.mp4;*.ts;*.mov;*.avi;*.m4v;*.mp4a;*.mp3;";
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

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            //Declare variables
            string fileIn = txtFileIn.Text;
            string fullName = System.IO.Path.GetFileName(fileIn);
            string fileName = System.IO.Path.GetFileName(fileIn);
            string path = txtFileOut.Text + "\\";
            string dir = System.IO.Directory.GetCurrentDirectory();
            int inH = Convert.ToInt16(nudInH.Value);
            int inM = Convert.ToInt16(nudInM.Value);
            int inS = Convert.ToInt16(nudInS.Value);
            int outH = Convert.ToInt16(nudOutH.Value);
            int outM = Convert.ToInt16(nudOutM.Value);
            int outS = Convert.ToInt16(nudOutS.Value);
            string timeIn = inH + ":" + inM + ":" + inS;
            string dur = outH + ":" + outM + ":" + outS;

            //Set control visibility appropriately
            pnlProgress.Visible = true;
            lblProgress.Visible = true;
            btnConvert.Visible = false;

            //Start conversion
            await writeFFmpegTrim(fileIn, timeIn, path, dur, fullName);
            backgroundWorker1.RunWorkerAsync();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ProcessStartInfo ffmpegInfo = new ProcessStartInfo();
            ffmpegInfo.CreateNoWindow = false;  //true to hide console window, false to show
            ffmpegInfo.UseShellExecute = false;
            ffmpegInfo.FileName = "./ff.bat";
            ffmpegInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process process = new Process();
            try
            {
                using (process = Process.Start(ffmpegInfo))
                {
                    process.WaitForExit();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (backgroundWorker1.IsBusy == false)
            {
                pnlProgress.Visible = false;
                lblComplete.Visible = true;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pnlProgress.Visible = true;
            lblComplete.Visible = false;
            lblProgress.Visible = true;
            pbProgress.Enabled = true;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormManual_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbWidth_Validating(object sender, CancelEventArgs e)
        {
        }

        private void tbHeight_Validating(object sender, CancelEventArgs e)
        {
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtVal_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbManualRes_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbCopyRes_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbCopySpeed_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbCPUEncode_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbHEVC_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void pnlResolution_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}