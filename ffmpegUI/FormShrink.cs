using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;

namespace ffmpegUI
{
    public partial class FormShrink : Form
    {
        public FormShrink()
        {
            InitializeComponent();
        }
        //Do upom Form Starting
        private void FormShrink_Load(object sender, EventArgs e)
        {
            //Set default control properties
            lblSize.Text = "Size: " + txtFileIn.Text;
            rbCPUEncode.Checked = true;
            rbHEVC.Checked = true;
            cbExtension.SelectedIndex = 0;
            lbPresets.SelectedIndex = 1;
            rbResCopy.Checked = true;

            //Tooltips
            ToolTip tooltipAMD = new ToolTip();
            tooltipAMD.SetToolTip(rbAMDGPU, "Select this option if your pc has an AMD Graphics card installed.");
            ToolTip tooltipNVIDIA = new ToolTip();
            tooltipNVIDIA.SetToolTip(rbNVIDIAGPU, "Select this option if your pc has a NVIDIA Graphics card installed.");
            ToolTip tooltipCPU = new ToolTip();
            tooltipCPU.SetToolTip(rbCPUEncode, "Select this option if Graphics Card is unknown, or if you simply prefer to encode with the CPU.");
            ToolTip tooltip264 = new ToolTip();
            tooltip264.SetToolTip(rb264, "Slightly less compressed than HEVC, but compatibile with most devices and playback software.");
            ToolTip tooltipHEVC = new ToolTip();
            tooltipHEVC.SetToolTip(rbHEVC, "Offers more compression without quality loss, but some devices may require an extension or a 3rd party media player application.");

            //Variables and Tasks
            string dir = "tmp";
            Directory.CreateDirectory(dir);
        }

        //Method for running batch script containing ffmpeg command
        public static void OpenCMD(Process process)
        {
            ProcessStartInfo ffmpegInfo = new ProcessStartInfo();
            ffmpegInfo.CreateNoWindow = true;  //true to hide console window, false to show
            ffmpegInfo.UseShellExecute = false;
            ffmpegInfo.FileName = "./ff.bat";
            ffmpegInfo.WindowStyle = ProcessWindowStyle.Hidden;

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

        //Methods which build bat files containing ffmpeg command
        static async Task write264AMF(string fileIn, string res, string path, string safeName)
        {
            string[] lines =
            {
                "cd ffmpeg\\bin ",
                $"@ffmpeg.exe -y -hide_banner -hwaccel d3d11va -hwaccel d3d11va -i \"{fileIn}\" -fflags +genpts -c:v h264_amf {res} -rc cqp -qp_i 24 -qp_p 24 -qp_b 24 -q:v 24 -c:a copy -movflags +faststart -fps_mode vfr \"{path}{safeName}.mp4\"",
                 "exit"
            };

            await System.IO.File.WriteAllLinesAsync("ff.bat", lines);
        }

        static async Task writeHEVCAMF(string fileIn, string res, string path, string safeName)
        {
            string[] lines =
            {
                "cd ffmpeg\\bin ",
                 $"@ffmpeg.exe -y -hide_banner -hwaccel d3d11va -i \"{fileIn}\" -fflags +genpts -c:v hevc_amf {res} -rc cqp -qp_i 28 -qp_p 28 -q:v 28 -tag:v hvc1 -c:a copy -movflags +faststart -fps_mode vfr \"{path}{safeName}.mp4\"",
                 "exit"
            };

            await System.IO.File.WriteAllLinesAsync("ff.bat", lines);
        }

        static async Task writeX264(string fileIn, string preset, string path, string res, string safeName)
        {
            string[] lines =
            {
                "cd ffmpeg\\bin ",
                $"@ffmpeg.exe -y -hide_banner -hwaccel d3d11va -i \"{fileIn}\" -fflags +genpts -c:v libx264 {res} -crf 24 -crf_max 24 24 -preset {preset} -c:a copy -movflags +faststart -fps_mode vfr \"{path}{safeName}.mp4\"",
                "exit"
            };

            await System.IO.File.WriteAllLinesAsync("ff.bat", lines);
        }

        static async Task writeX265(string fileIn, string preset, string res, string path, string safeName)
        {
            string[] lines =
            {
                "cd ffmpeg\\bin ",
                $"@ffmpeg.exe -y -hide_banner -hwaccel d3d11va -i \"{fileIn}\" -fflags +genpts -c:v libx265 {res} -crf 24 -qp 24 -preset {preset} -tag:v hvc1 -c:a copy -movflags +faststart -fps_mode vfr \"{path}{safeName}.mp4\"",
                "exit"
            };

        await System.IO.File.WriteAllLinesAsync("ff.bat", lines);
        }

        static async Task write264NVENC(string fileIn, string res, string path, string safeName)
        {
            string[] lines =
            {
                "cd ffmpeg\\bin ",
                $"@ffmpeg.exe -y -hide_banner -hwaccel d3d11va -i \"{fileIn}\" -fflags +genpts -c:v h264_nvenc {res} -rc constqp -qp 24 -preset fast -c:a copy -movflags faststart -fps_mode vfr \"{path}{safeName}.mp4\"",
                "exit"
            };

        await System.IO.File.WriteAllLinesAsync("ff.bat", lines);
        }

        static async Task writeHEVCNVENC(string fileIn, string res, string path, string safeName)
        {
            string[] lines =
            {
                "cd ffmpeg\\bin ",
                $"@ffmpeg.exe -y -hide_banner -hwaccel d3d11va -i \"{fileIn}\" -fflags +genpts -c:v hevc_nvenc {res} -rc constqp -qp 24 -preset fast -tag:v hvc1 -c:a copy -movflags faststart -fps_mode vfr \"{path}{safeName}.mp4\"",
                "exit"
            };

        await System.IO.File.WriteAllLinesAsync("ff.bat", lines);
    }
        static async Task writeAutoFolder(string line0)
        {
            string[] lines =
            {
                    "cd ffmpeg\\bin && ",
                    line0,
                    "exit"
                };

            await System.IO.File.WriteAllLinesAsync("ff.bat", lines);
        }

        //Control Events
        private void btnManual(object sender, EventArgs e)
        {
            this.Hide();
            var formManual = new FormManual();
            formManual.Tag = this;
            formManual.StartPosition = FormStartPosition.Manual;
            formManual.Location = this.Location;
            formManual.Closed += (s, args) => this.Close();
            formManual.Show();
        }

        //Button for "Presets Library" tab
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

        //Browse Button for input file
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (cbFolder.Checked == false)
            {
                int size = -1;
                lblComplete.Visible = false;
                OpenFileDialog openFileDialog1 = new();
                openFileDialog1.Filter = "Video Files|*.mkv;*.mp4;*.ts;*.mov;*.avi;*.m4v;*.mp4a;";
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
                        if (txtFileOut.Text != "" && cbFolder.Checked == false)
                        {
                            btnConvert.Visible = true;
                        }
                        else if (txtFileOut.Text != "" && cbFolder.Checked == true && cbExtension.SelectedIndex != 0)
                        {
                            btnConvert.Visible = true;
                        }
                        else
                        {
                            btnConvert.Visible = false;
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
            else
            {
                FolderBrowserDialog folderBrowserDialog1 = new();
                DialogResult result = folderBrowserDialog1.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    string outputDir = folderBrowserDialog1.SelectedPath;
                    txtFileIn.Text = outputDir;
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
        }

        //Browse button for output directory
        private void btnBrowseOut_Click(object sender, EventArgs e)
        {
            lblComplete.Visible = false;
            FolderBrowserDialog folderBrowserDialog1 = new();
            DialogResult result = folderBrowserDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string outputDir = folderBrowserDialog1.SelectedPath;
                txtFileOut.Text = outputDir;
                try
                {
                    if (txtFileIn.Text != "" && cbFolder.Checked == false)
                    {
                        btnConvert.Visible = true;
                    }
                    else if (txtFileIn.Text != "" && cbFolder.Checked == true && cbExtension.SelectedIndex != 0)
                    {
                        btnConvert.Visible = true;
                    }
                    else
                    {
                        btnConvert.Visible = false;
                    }
                }
                catch (IOException)
                {
                }
            }
        }


        //Main Conversion Click Event!!
        private async void btnConvert_Click(object sender, EventArgs e)
        {
            //Declare variables
            string fileIn = txtFileIn.Text;
            string safeName = System.IO.Path.GetFileNameWithoutExtension(fileIn);
            string fileName = System.IO.Path.GetFileName(fileIn);
            string path = txtFileOut.Text + "\\";
            string dir = System.IO.Directory.GetCurrentDirectory();
            string exn = cbExtension.Text.ToString();
            string preset = lbPresets.Text.ToString();
            string res = string.Empty;
            if (rbRes720.Checked == true)
            {
                res = $"-vf \"scale=1280:720:flags=lanczos\" -aspect 16:9";
            }
            else if (rb1080p.Checked == true)
            {
                res = $"-vf \"scale=1920:1080:flags=lanczos\" -aspect 16:9";
            }
            else if (rb2160.Checked == true)
            {
                res = $"-vf \"scale=3840:2160:flags=lanczos\" -aspect 16:9";
            }
            else if (rb1440.Checked == true)
            {
                res = $"-vf \"scale=2560:1440:flags=lanczos\" -aspect 16:9";
            }
            else if (rb540.Checked == true)
            {
                res = $"-vf \"scale=960:540:flags=lanczos\" -aspect 16:9";
            }
            else
            {
                res = "";
            }

            //Check whether the folder conversion check box is checked
            if (cbFolder.Checked == false)
            {
                if (rbCPUEncode.Checked == true)
                {
                    if (rb264.Checked == true)
                    {
                        //Set control visibility appropriately
                        pnlProgress.Visible= true ;
                        lblProgress.Visible = true;
                        btnConvert.Visible = false;

                        //Start conversion
                        await writeX264(fileIn, preset, res, path, safeName);
                        backgroundWorker1.RunWorkerAsync();
                    }
                    else
                    {
                        //Set control visibility appropriately
                        pnlProgress.Visible = true;
                        lblProgress.Visible = true;
                        btnConvert.Visible = false;

                        //Start conversion
                        await writeX265(fileIn, preset, res, path, safeName);
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                if (rbAMDGPU.Checked == true)
                {
                    if (rb264.Checked == true)
                    {
                        //Set control visibility appropriately
                        pnlProgress.Visible = true;
                        lblProgress.Visible = true;
                        btnConvert.Visible = false;

                        //Start conversion
                        await write264AMF(fileIn, res, path, safeName);
                        backgroundWorker1.RunWorkerAsync();
                    }
                    else
                    {
                        //Set control visibility appropriately
                        pnlProgress.Visible = true;
                        lblProgress.Visible = true;
                        btnConvert.Visible = false;

                        //Start conversion
                        await writeHEVCAMF(fileIn, res, path, safeName);
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                if (rbNVIDIAGPU.Checked == true)
                {
                    if (rb264.Checked == true)
                    {
                        //Set control visibility appropriately
                        pnlProgress.Visible = true;
                        lblProgress.Visible = true;
                        btnConvert.Visible = false;

                        //Start conversion
                        await write264NVENC(fileIn, res, path, safeName);
                        backgroundWorker1.RunWorkerAsync();
                    }
                    else
                    {
                        //Set control visibility appropriately
                        pnlProgress.Visible = true;
                        lblProgress.Visible = true;
                        btnConvert.Visible = false;

                        //Start conversion
                        await writeHEVCNVENC(fileIn, res, path, safeName);
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
            }
            else if (cbFolder.Checked == true)
            {
                string getExt = "*" + cbExtension.Text.ToString();
                DirectoryInfo directory = new DirectoryInfo(txtFileIn.Text);
                foreach (var file in directory.GetFiles(getExt))
                {
                    List<string> files = new List<string>();
                    string file1 = file.ToString();
                    files.Add(file1);
                    for (int i = 0; i < files.Count; i++)
                    {
                        string safeEach = Path.GetFileNameWithoutExtension(files[i]);
                        if (rbCPUEncode.Checked == true)
                        {
                            if (rb264.Checked == true)
                            {
                                //Set control visibility appropriately
                                pnlProgress.Visible = true;
                                lblProgress.Visible = true;
                                btnConvert.Visible = false;

                                //Start conversion
                                await writeX264(files[i], preset, res, path, safeEach);
                                Process ffmpeg = new Process();
                                OpenCMD(ffmpeg);
                                ffmpeg.Close();
                            }
                            else
                            {
                                //Set control visibility appropriately
                                pnlProgress.Visible = true;
                                lblProgress.Visible = true;
                                btnConvert.Visible = false;

                                //Start conversion
                                await writeX265(files[i], preset, res, path, safeEach);
                                Process ffmpeg = new Process();
                                OpenCMD(ffmpeg);
                                ffmpeg.Close();
                            }
                        }
                        if (rbAMDGPU.Checked == true)
                        {
                            if (rb264.Checked == true)
                            {
                                //Set control visibility appropriately
                                pnlProgress.Visible = true;
                                lblProgress.Visible = true;
                                btnConvert.Visible = false;

                                //Start conversion
                                await write264AMF(files[i], res, path, safeEach);
                                Process ffmpeg = new Process();
                                OpenCMD(ffmpeg);
                                ffmpeg.Close();
                            }
                            else
                            {
                                //Set control visibility appropriately
                                pnlProgress.Visible = true;
                                lblProgress.Visible = true;
                                btnConvert.Visible = false;

                                //Start conversion
                                await writeHEVCAMF(files[i], res, path, safeEach);
                                Process ffmpeg = new Process();
                                OpenCMD(ffmpeg);
                                ffmpeg.Close();
                            }
                        }
                        if (rbNVIDIAGPU.Checked == true)
                        {
                            if (rb264.Checked == true)
                            {
                                //Set control visibility appropriately
                                pnlProgress.Visible = true;
                                lblProgress.Visible = true;
                                btnConvert.Visible = false;

                                //Start conversion
                                await write264NVENC(files[i], res, path, safeEach);
                                Process ffmpeg = new Process();
                                OpenCMD(ffmpeg);
                                ffmpeg.Close();
                            }
                            else
                            {
                                //Set control visibility appropriately
                                pnlProgress.Visible = true;
                                lblProgress.Visible = true;
                                btnConvert.Visible = false;

                                //Start conversion
                                await writeHEVCNVENC(files[i], res, path, safeEach);
                                Process ffmpeg = new Process();
                                OpenCMD(ffmpeg);
                                ffmpeg.Close();
                            }
                        }
                    }
                }
            }
            //this.Close();
        }
        private void cbFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFolder.Checked)
            {
                cbExtension.Visible = true;
                lblSize.Visible = false;
                lblExn.Visible = true;
            }
            else
            {
                cbExtension.Visible = false;
                lblSize.Visible = true;
                lblExn.Visible = false;
            }
            lblComplete.Visible = false;
        }

        private void cbExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbExtension.SelectedIndex != 0 && txtFileIn.Text != "" && txtFileOut.Text != "")
            {
                btnConvert.Visible = true;
            }
            else 
            {
                btnConvert.Visible = false;
            }
            lblComplete.Visible = false;
        }

        private void rbAMDGPU_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPUEncode.Checked == true)
            {
                pnlPreset.Visible = true;
            }
            else
            {
                pnlPreset.Visible = false;
            }

            lblComplete.Visible = false;
            if (txtFileIn.Text != "" && txtFileOut.Text != "" && cbFolder.Checked == false)
            {
                btnConvert.Visible = true;
            }
            else if (txtFileIn.Text != "" && txtFileOut.Text != "" && cbFolder.Checked == true && cbExtension.SelectedIndex != 0)
            {
                btnConvert.Visible = true;
            }
            else 
            {
                btnConvert.Visible = false;
            }
        }

        private void rbNVIDIAGPU_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPUEncode.Checked == true)
            {
                pnlPreset.Visible = true;
            }
            else
            {
                pnlPreset.Visible = false;
            }

            lblComplete.Visible = false;
            if (txtFileIn.Text != "" && txtFileOut.Text != "" && cbFolder.Checked == false)
            {
                btnConvert.Visible = true;
            }
            else if (txtFileIn.Text != "" && txtFileOut.Text != "" && cbFolder.Checked == true && cbExtension.SelectedIndex != 0)
            {
                btnConvert.Visible = true;
            }
            else
            {
                btnConvert.Visible = false;
            }
        }

        private void rbCPUEncode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPUEncode.Checked == true)
            {
                pnlPreset.Visible = true;
            }
            else
            {
                pnlPreset.Visible = false;
            }

            lblComplete.Visible = false;
            if (txtFileIn.Text != "" && txtFileOut.Text != "" && cbFolder.Checked == false)
            {
                btnConvert.Visible = true;
            }
            else if (txtFileIn.Text != "" && txtFileOut.Text != "" && cbFolder.Checked == true && cbExtension.SelectedIndex != 0)
            {
                btnConvert.Visible = true;
            }
            else
            {
                btnConvert.Visible = false;
            }
        }

        private void rb264_CheckedChanged(object sender, EventArgs e)
        {
            lblComplete.Visible = false;
            if (txtFileIn.Text != "" && txtFileOut.Text != "" && cbFolder.Checked == false)
            {
                btnConvert.Visible = true;
            }
            else if (txtFileIn.Text != "" && txtFileOut.Text != "" && cbFolder.Checked == true && cbExtension.SelectedIndex != 0)
            {
                btnConvert.Visible = true;
            }
            else
            {
                btnConvert.Visible = false;
            }
        }

        private void rbHEVC_CheckedChanged(object sender, EventArgs e)
        {
            lblComplete.Visible = false;
            if (txtFileIn.Text != "" && txtFileOut.Text != "" && cbFolder.Checked == false)
            {
                btnConvert.Visible = true;
            }
            else if (txtFileIn.Text != "" && txtFileOut.Text != "" && cbFolder.Checked == true && cbExtension.SelectedIndex != 0)
            {
                btnConvert.Visible = true;
            }
            else
            {
                btnConvert.Visible = false;
            }
        }
        private void lbPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblComplete.Visible = false;
            if (txtFileIn.Text != "" && txtFileOut.Text != "" && cbFolder.Checked == false)
            {
                btnConvert.Visible = true;
            }
            else if (txtFileIn.Text != "" && txtFileOut.Text != "" && cbFolder.Checked == true && cbExtension.SelectedIndex != 0)
            {
                btnConvert.Visible = true;
            }
            else
            {
                btnConvert.Visible = false;
            }
        }

        //Unused Events
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtFileIn_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbRes720_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ProcessStartInfo ffmpegInfo = new ProcessStartInfo();
                ffmpegInfo.CreateNoWindow = true;  //true to hide console window, false to show
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
            pbProgress.Enabled= true;
        }
    }
}