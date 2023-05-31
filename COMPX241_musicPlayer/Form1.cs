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


namespace COMPX241_musicPlayer
{
    public partial class musicPlayer : Form
    {
        //NAudio test
        //private NAudio.Wave.WaveFileReader wave = null;
        private NAudio.Wave.DirectSoundOut output = null;
        //MP3
        private NAudio.Wave.BlockAlignReductionStream stream = null;


        //Creates a class to be displayed in the listbox
        public class AudioFile
        {
            public string Name { get; set; }
            public string Path { get; set; }
        }
        public void listbox()
        {
            track_List.Items.Clear();
            string[] getfiles = Directory.GetFiles("C:\\Users\\willi\\Music"); //\\separated\\htdemucs\\test");
            string[] dirs = Directory.GetDirectories("C:\\Users\\willi\\Music"); // \\separated\\htdemucs\\test");

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
            foreach (string dir in dirs)
            {
                // Create an item for the list
                var thisItem = new AudioFile
                {
                    Name = Path.GetFileName(dir),
                    Path = dir
                };

                track_List.Items.Add(thisItem);
            }
        }

        public musicPlayer()
        {
            InitializeComponent();

            //Add audio deviced to combo box
            NAudio.CoreAudioApi.MMDeviceEnumerator enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());

            listbox();

        }
        string[] paths, files;

        private void track_List_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Player.URL = paths[track_List.SelectedIndex];
            if (track_List.SelectedIndex == -1 || track_List.SelectedIndex == 0) { return; }
            else
            {
                //string filePath = paths[track_List.SelectedIndex];

                //DisplayWaveform(new string[] { filePath });
            }
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
                buttonPause.Enabled = false;
                buttonPlay.Enabled = true;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                output.Play();
                buttonPlay.Enabled = false;
                buttonPause.Enabled = true;
            }

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
   

        }

        private void cMDTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       //private List<string> selectedWavFiles = new List<string>();

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string filePath = paths[e.Index];

            if (e.CurrentValue == CheckState.Unchecked)
            {
                selectedWavFiles.Add(filePath);
            }
            else if (e.CurrentValue == CheckState.Checked)
            {
                selectedWavFiles.Remove(filePath);
            }
            DisposeWave();

            if (selectedWavFiles.Count > 0)
            {
                var mixer = new WaveMixerStream32();

                foreach (var file in selectedWavFiles)
                {
                    var reader = new WaveFileReader(file);
                    mixer.AddInputStream(new WaveChannel32(reader));
                }
                output = new DirectSoundOut();
                output.Init(mixer);
                output.Play();
            }*/
        }
       

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void DisplayWaveform(string[] filePaths)
        {
            if (filePaths == null || filePaths.Length == 0)
                return;

            Bitmap waveformBitmap = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            Graphics graphics = Graphics.FromImage(waveformBitmap);

            int numFiles = filePaths.Length;
            int bytesPerSample = 0;
            long maxSampleCount = 0;

            // Find the maximum sample count and bytes per sample among the files
            for (int i = 0; i < numFiles; i++)
            {
                using (WaveFileReader reader = new WaveFileReader(filePaths[i]))
                {
                    bytesPerSample = Math.Max(bytesPerSample, reader.WaveFormat.BitsPerSample / 8);
                    maxSampleCount = Math.Max(maxSampleCount, reader.SampleCount);
                }
            }

            int samplesPerPixel = (int)(maxSampleCount / (long)pictureBox3.Width);
            byte[] buffer = new byte[samplesPerPixel * bytesPerSample];

            for (int x = 0; x < pictureBox3.Width; x++)
            {
                for (int i = 0; i < numFiles; i++)
                {
                    using (WaveFileReader reader = new WaveFileReader(filePaths[i]))
                    {
                        reader.Position = x * samplesPerPixel * bytesPerSample;
                        reader.Read(buffer, 0, buffer.Length);

                        float maxAmplitude = 0;

                        for (int j = 0; j < buffer.Length; j += bytesPerSample)
                        {
                            float sample = 0;

                            if (bytesPerSample == 2)
                                sample = BitConverter.ToInt16(buffer, j) / 32768f;
                            else if (bytesPerSample == 4)
                                sample = BitConverter.ToInt32(buffer, j) / 2147483648f;

                            if (Math.Abs(sample) > maxAmplitude)
                                maxAmplitude = Math.Abs(sample);
                        }

                        int lineHeight = (int)(maxAmplitude * pictureBox3.Height / 2);
                        int y = i * (pictureBox3.Height / numFiles) + (pictureBox3.Height / numFiles - lineHeight) / 2;
                        int height = lineHeight * 2;

                        graphics.DrawLine(Pens.Black, x, y, x, y + height);
                    }
                }
            }

            pictureBox3.Image = waveformBitmap;
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void sepperateAudioFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Start process to write to cmd
            Process process = new Process();
            //Code to write to cmd prompt
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WorkingDirectory = "C:\\Users\\willi\\anaconda3\\Scripts";

            process.Start();

            using (var sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    //Activate anaconda 
                    sw.WriteLine("C:\\Users\\willi\\anaconda3\\Scripts\\activate.bat");
                    //Activate environment
                    sw.WriteLine("activate base");

                    sw.WriteLine("cd/");
                    sw.WriteLine("cd Users");
                    sw.WriteLine("cd willi");
                    sw.WriteLine("cd Music");
                    //Code to execute
                    sw.WriteLine("demucs MJ.mp3");
                }
            }

            while (!process.StandardOutput.EndOfStream)
            {
                var line = process.StandardOutput.ReadLine();
                Console.WriteLine(line);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 4; i++)
            {
                if(i == 0)
                {
                    
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string audioPath = track_List.Text;
            //MessageBox.Show(audioPath);
            //Start process to write to cmd
            Process process = new Process();
            //Code to write to cmd prompt
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WorkingDirectory = "C:\\Users\\willi\\anaconda3\\Scripts";

            process.Start();

            using (var sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    //Activate anaconda 
                    sw.WriteLine("C:\\Users\\willi\\anaconda3\\Scripts\\activate.bat");
                    //Activate environment
                    sw.WriteLine("activate base");

                    sw.WriteLine("cd/");
                    sw.WriteLine("cd Users");
                    sw.WriteLine("cd willi");
                    sw.WriteLine("cd Music");
                    //Code to execute
                    sw.WriteLine("demucs " + audioPath);
                }
            }

            while (!process.StandardOutput.EndOfStream)
            {
                var line = process.StandardOutput.ReadLine();
                Console.WriteLine(line);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK) //return;
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < paths.Length; i++)
                {
                    track_List.Items.Add(paths[i]);
                }

                //string[] filePaths = paths.Take(3).ToArray();
                //DisplayWaveform(filePaths);
            }

        }



    }
}
