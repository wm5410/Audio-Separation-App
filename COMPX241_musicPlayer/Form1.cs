using System;
using NAudio;
using NAudio.Wave;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using NAudio.CoreAudioApi;
using AxWMPLib;
using NAudio.Gui;
using System.Diagnostics;
using System.IO;
using NAudio.Wave.SampleProviders;
using System.Threading;
using Microsoft.WindowsAPICodePack.Dialogs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using static COMPX241_musicPlayer.musicPlayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace COMPX241_musicPlayer
{
    public partial class musicPlayer : Form
    {

        private NAudio.Wave.DirectSoundOut output = null;
        //MP3
        private NAudio.Wave.BlockAlignReductionStream stream = null;

        public static WaveStream stream1;
        public static WaveStream stream2;
        public static WaveStream stream3;
        public static WaveStream stream4;
        public static WaveChannel32 first32;
        public static WaveChannel32 second32;
        public static WaveChannel32 third32;
        public static WaveChannel32 fourth32;
        public static MixingWaveProvider32 mixer;
        public static DirectSoundOut dso;

        private List<PictureBox> pictureBoxes;


        //Creates a class to be displayed in the listbox
        public class AudioFile
        {
            public string Name { get; set; }
            public string Path { get; set; }

        }
        public void listbox()
        {
            track_List.Items.Clear();
            string[] getfiles = Directory.GetFiles("C:\\Users\\William\\Music"); //\\separated\\htdemucs\\test");
            //string[] getfiles = Directory.GetFiles("C:\\Users\\William\\Music"); //\\separated\\htdemucs\\test");
            string[] dirs = Directory.GetDirectories("C:\\Users\\William\\Music"); // \\separated\\htdemucs\\test");
            //string[] dirs = Directory.GetDirectories("C:\\Users\\William\\Music"); // \\separated\\htdemucs\\test");

            track_List.DisplayMember = "Name";
            track_List.ValueMember = "Path";

            foreach (string file in getfiles)
            {
                // Create an item for the list
                var thisItem = new AudioFile
                {
                    Name = Path.GetFileName(file),
                    Path = file
                };

                track_List.Items.Add(thisItem);
            }
            //foreach (string dir in dirs)
            //{
            //    // Create an item for the list
            //    var thisItem = new AudioFile
            //    {
            //        Name = Path.GetFileName(dir),
            //        Path = dir
            //    };

            //    track_List.Items.Add(thisItem);
            //}
        }

        public musicPlayer()
        {
            InitializeComponent();

            checkbox4.CheckedChanged += (s, e) => button2_Click(s, e);
            checkBox1.CheckedChanged += (s, e) => button2_Click(s, e);
            checkBox2.CheckedChanged += (s, e) => button2_Click(s, e);
            checkBox3.CheckedChanged += (s, e) => button2_Click(s, e);

            trackBar2.Scroll += (s, e) => button2_Click(s, e);
            trackBar6.Scroll += (s, e) => button2_Click(s, e);
            trackBar7.Scroll += (s, e) => button2_Click(s, e);
            trackBar9.Scroll += (s, e) => button2_Click(s, e);

            //Add audio deviced to combo box
            NAudio.CoreAudioApi.MMDeviceEnumerator enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.Active);

            pictureBoxes = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };

            listbox();


        }

        private void track_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (track_List.SelectedIndex == -1 || track_List.SelectedIndex == 0) { return; }
            //else
            //{
            //    string filePath = ((AudioFile)track_List.SelectedItem).Path;

            //    // Find the next available PictureBox
            //    PictureBox nextPictureBox = pictureBoxes.FirstOrDefault(p => p.Image == null);

            //    if (nextPictureBox != null)
            //    {
            //        // Display the waveform in the next PictureBox
            //        DisplayWaveform(filePath, nextPictureBox);
            //    }
            //    else
            //    {
            //        MessageBox.Show("No available PictureBox found.");
            //    }
            //}

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = 0;
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
              
            if (output != null)
            {
                output.Stop();
            }
            if (dso != null)
            {
                if (dso.PlaybackState == PlaybackState.Playing)
                {
                    dso.Pause();
                }
            }
            buttonPause.Enabled = false;
            buttonPlay.Enabled = true;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //string to_play = track_List.SelectedIndex.ToString();
            //MessageBox.Show(to_play);
            //if (track_List.SelectedIndex >= 0)
            //{
            //   // string to_play = track_List.SelectedItem.ToString();
            //    //audiofile = new AudioFileReader(to_play);
            //    //outputdevice.Init(audiofile);



            //    //Uncompressed audio
            //    //NAudio.Wave.WaveStream uncompressedAudio = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(open.FileName));
            //    //Create block alignment reduction stream
            //    //stream = new NAudio.Wave.BlockAlignReductionStream(uncompressedAudio);
            //    //output = new NAudio.Wave.DirectSoundOut();
            //    //output.Init(stream);
            //    //output.Play();
            //}

            if (output != null)
            {
                output.Play();
                
            }
            if (dso != null)
            {
                if (dso.PlaybackState == PlaybackState.Stopped || dso.PlaybackState == PlaybackState.Paused)
                {
                    dso.Play();
                }
            }
            buttonPlay.Enabled = false;
            buttonPause.Enabled = true;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (track_List.SelectedIndex < track_List.SelectedIndex - 1)
            {

            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (track_List.SelectedIndex > 0)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            //if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            //{
            //    progressBar1.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
            //    progressBar1.Value = (int)Player.Ctlcontrols.currentPosition;
            //}

            //if (comboBox1.SelectedItem != null)
            //{
            //    var device = (MMDevice)comboBox1.SelectedItem;
            //    progressBar1.Value = (int)device.AudioMeterInformation.MasterPeakValue * 10000;
            //}
            //NAudio.CoreAudioApi.MMDeviceEnumerator devEnum = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            //NAudio.CoreAudioApi.MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(NAudio.CoreAudioApi.DataFlow.Render, NAudio.CoreAudioApi.Role.Multimedia);
            //int leftVolume = (int)defaultDevice.AudioMeterInformation.PeakValues.Count;
            //Console.WriteLine(leftVolume.ToString());
            //int rightVolume = defaultDevice.AudioMeterInformation.PeakValues;

            //MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            //MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            //Console.WriteLine("Sending Volume level through " + port.PortName);
            //Console.WriteLine("\rCurrent Level: " + defaultDevice.AudioMeterInformation.MasterPeakValue.ToString());


            //Console.WriteLine("\rCurrent Level: " + defaultDevice.AudioMeterInformation.PeakValues[0]);
            //progressBar1.Value = (int)defaultDevice.AudioMeterInformation.PeakValues[0];
            //Test levels of audio
            //textBox1.Text = (defaultDevice.AudioMeterInformation.PeakValues[0] * 100).ToString();
            //textBox1.Text = defaultDevice.AudioClient.AudioStreamVolume.ToString();

        }

        private void Player_Enter(object sender, EventArgs e)
        {

        }

        private void menuStripUpload_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openWAVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void Open()
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Audio FIle (*.mp3;*.wav)|*.mp3;*.wav;";
            open.Multiselect = true;
            if (open.ShowDialog() == DialogResult.OK) //return;
            {
                DisposeWave();

                if (open.FileName.EndsWith(".mp3"))
                {
                    //Uncompressed audio
                    NAudio.Wave.WaveStream uncompressedAudio = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(open.FileName));
                    //Create block alignment reduction stream
                    stream = new NAudio.Wave.BlockAlignReductionStream(uncompressedAudio);
                }
                else if (open.FileName.EndsWith(".wav"))
                {
                    NAudio.Wave.WaveStream uncompressedAudio = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(open.FileName));
                    stream = new NAudio.Wave.BlockAlignReductionStream(uncompressedAudio);
                }
                else
                {
                    MessageBox.Show("Error");
                }
                output = new NAudio.Wave.DirectSoundOut();
                output.Init(stream);
                buttonPause.Enabled = false;
                track_List.Items.Add(open.FileName);
            }
        }

        //NAudio test WAV
        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        /// <summary>
        /// Dispose of mp3 wave properly 
        /// </summary>
        private void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }


        private void musicPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            
        }

        private void musicPlayer_Load(object sender, EventArgs e)
        {
            trackBar6.Value = 50;
            trackBar2.Value = 50;
            trackBar7.Value = 50;
            trackBar9.Value = 50;

        }

        private void cMDTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       //private List<string> selectedWavFiles = new List<string>();

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
       

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void DisplayWaveform(string filePath, PictureBox pictureBox)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist.");
                return;
            }

            WaveFileReader reader = new WaveFileReader(filePath);

            // Create a bitmap to draw the waveform
            Bitmap waveformBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(waveformBitmap);

            // Get the number of samples and bytes per sample
            int sampleCount = (int)reader.SampleCount;
            int bytesPerSample = reader.WaveFormat.BitsPerSample / 4;

            // Calculate the number of samples to skip for each pixel
            int samplesPerPixel = (int)Math.Max(1, sampleCount / (double)pictureBox.Width);

            byte[] buffer = new byte[samplesPerPixel * bytesPerSample];

            for (int x = 0; x < pictureBox.Width; x++)
            {
                int startSample = x * samplesPerPixel;
                int endSample = startSample + samplesPerPixel;

                // Read the samples for the current pixel
                int bytesRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                {
                    break;
                }

                // Calculate the maximum amplitude for the current samples
                float maxAmplitude = 0;

                for (int i = 0; i < bytesRead; i += bytesPerSample)
                {
                    float sample = 0;

                    if (bytesPerSample == 2)
                    {
                        sample = BitConverter.ToInt16(buffer, i) / 32768f;
                    }
                    else if (bytesPerSample == 4)
                    {
                        sample = BitConverter.ToInt32(buffer, i) / 2147483648f;
                    }

                    if (Math.Abs(sample) > maxAmplitude)
                    {
                        maxAmplitude = Math.Abs(sample);
                    }
                }

                // Calculate the height of the waveform for the current pixel
                int waveformHeight = (int)(maxAmplitude * pictureBox.Height);
                int waveformY = (pictureBox.Height - waveformHeight) / 2;

                // Draw the waveform for the current pixel
                graphics.DrawLine(Pens.Black, x, waveformY, x, waveformY + waveformHeight);
            }

            pictureBox.Image = waveformBitmap;

            reader.Dispose();

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private async void sepperateAudioFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog { Filter = "Audio (*.mp3;*.wav)|*.mp3;*.wav" };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            await RunDemucs(dlg.FileName);
        }




        private void button1_Click(object sender, EventArgs e)
        {
            buttonPlay.Enabled = true;
            if (dso != null)
            {
                dso.Stop();
                dso.Dispose();
                dso = null;
            }

            // reset volumes visually—but do not re-combine automatically
            trackBar6.Value = 50;
            trackBar2.Value = 50;
            trackBar7.Value = 50;
            trackBar9.Value = 50;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Stop & dispose previous playback
            if (dso != null)
            {
                dso.Stop();
                dso.Dispose();
                dso = null;
            }

            // Create a fresh mixer
            mixer = new MixingWaveProvider32();

            // Only add streams if their checkbox is checked—do NOT dispose them here!
            if (checkbox4.Checked && first32 != null)
            {
                first32.Volume = trackBar2.Value / 50f;
                mixer.AddInputStream(first32);
            }
            if (checkBox1.Checked && second32 != null)
            {
                second32.Volume = trackBar6.Value / 50f;
                mixer.AddInputStream(second32);
            }
            if (checkBox2.Checked && third32 != null)
            {
                third32.Volume = trackBar7.Value / 50f;
                mixer.AddInputStream(third32);
            }
            if (checkBox3.Checked && fourth32 != null)
            {
                fourth32.Volume = trackBar9.Value / 50f;
                mixer.AddInputStream(fourth32);
            }

            // Init & play
            dso = new DirectSoundOut(DirectSoundOut.DSDEVID_DefaultPlayback);
            dso.Init(mixer);
            dso.Play();

            // Update button states
            buttonPlay.Enabled = false;
            buttonPause.Enabled = true;
        }



        private async void button3_Click(object sender, EventArgs e)
        {
            if (!(track_List.SelectedItem is AudioFile item))
            {
                MessageBox.Show("Please select a track first.");
                return;
            }
            await RunDemucs(item.Path);
        }

        private async Task RunDemucs(string audioPath)
        {
            string demucsExe = @"C:\Users\William\anaconda3\envs\demucs-env\Scripts\demucs.exe";
            if (!File.Exists(demucsExe))
            {
                MessageBox.Show($"Cannot find demucs.exe at:\n{demucsExe}");
                return;
            }

            // disable UI to prevent re-clicks
            sepperateAudioFileToolStripMenuItem.Enabled = false;
            button3.Enabled = false;
            label1.Text = "Starting separation…";
            txtLog.Clear();

            await Task.Run(() =>
            {
                var psi = new ProcessStartInfo
                {
                    FileName = demucsExe,
                    Arguments = $"\"{audioPath}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                using var proc = new Process { StartInfo = psi, EnableRaisingEvents = true };

                proc.OutputDataReceived += (_, e) => {
                    if (e.Data != null)
                        Invoke((Action)(() => {
                            txtLog.AppendText(e.Data + "\r\n");
                            label1.Text = e.Data;
                        }));
                };
                proc.ErrorDataReceived += (_, e) => {
                    if (e.Data != null)
                        Invoke((Action)(() => {
                            txtLog.AppendText("[ERR] " + e.Data + "\r\n");
                        }));
                };

                proc.Start();
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();
                proc.WaitForExit();
            });

            label1.Text = "Separation complete!";
            LoadSeparatedStems(audioPath);
            sepperateAudioFileToolStripMenuItem.Enabled = true;
            button3.Enabled = true;
        }



        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// After separation, look in the Demucs output folder (relative to your EXE),
        /// find the bass/drums/other/vocals WAVs, display their waveforms, and
        /// prepare them for mixing/playback.
        /// </summary>
        private void LoadSeparatedStems(string originalPath)
        {
            // 1) Build Demucs output folder path
            string exeDir = Path.GetDirectoryName(Application.ExecutablePath);
            string songName = Path.GetFileNameWithoutExtension(originalPath);
            string outDir = Path.Combine(exeDir, "separated", "htdemucs", songName);

            if (!Directory.Exists(outDir))
            {
                MessageBox.Show($"Couldn’t find separated stems:\n{outDir}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2) Paths for each stem
            string bassPath = Path.Combine(outDir, "bass.wav");
            string drumsPath = Path.Combine(outDir, "drums.wav");
            string otherPath = Path.Combine(outDir, "other.wav");
            string vocalsPath = Path.Combine(outDir, "vocals.wav");

            // 3) Display waveforms
            if (File.Exists(bassPath)) DisplayWaveform(bassPath, pictureBox1);
            if (File.Exists(drumsPath)) DisplayWaveform(drumsPath, pictureBox2);
            if (File.Exists(otherPath)) DisplayWaveform(otherPath, pictureBox3);
            if (File.Exists(vocalsPath)) DisplayWaveform(vocalsPath, pictureBox4);

            // 4) Prepare streams & channels (discard any previous ones)
            DisposeWave();
            mixer = new MixingWaveProvider32();

            if (File.Exists(bassPath))
            {
                stream1 = new WaveFileReader(bassPath);
                first32 = new WaveChannel32(stream1);
            }
            if (File.Exists(drumsPath))
            {
                stream2 = new WaveFileReader(drumsPath);
                second32 = new WaveChannel32(stream2);
            }
            if (File.Exists(otherPath))
            {
                stream3 = new WaveFileReader(otherPath);
                third32 = new WaveChannel32(stream3);
            }
            if (File.Exists(vocalsPath))
            {
                stream4 = new WaveFileReader(vocalsPath);
                fourth32 = new WaveChannel32(stream4);
            }

            // 5) Enable your Combine button
            button2.Enabled = true;
        }



        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Open();

        }



    }
}
