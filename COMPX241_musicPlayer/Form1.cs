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

namespace COMPX241_musicPlayer
{
    public partial class musicPlayer : Form
    {
        //NAudio test
        //private NAudio.Wave.WaveFileReader wave = null;
        private NAudio.Wave.DirectSoundOut output = null;
        //MP3
        private NAudio.Wave.BlockAlignReductionStream stream = null;



        public musicPlayer()
        {
            InitializeComponent();

            //Add audio deviced to combo box
            NAudio.CoreAudioApi.MMDeviceEnumerator enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());

            

        }
        string[] paths, files;

        private void track_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = paths[track_List.SelectedIndex];
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
            progressBar1.Value = 0;
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
            output.Stop();
            buttonPause.Enabled = false;
            buttonPlay.Enabled = true;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
            output.Play();
            buttonPlay.Enabled = false;
            buttonPause.Enabled = true;

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (track_List.SelectedIndex < track_List.SelectedIndex - 1)
            {
                Player.Ctlcontrols.next();
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (track_List.SelectedIndex > 0)
            {
                Player.Ctlcontrols.previous();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)Player.Ctlcontrols.currentPosition;
            }

            if (comboBox1.SelectedItem != null)
            {
                var device = (MMDevice)comboBox1.SelectedItem;
                progressBar1.Value = (int)device.AudioMeterInformation.MasterPeakValue * 10000;
            }
            //NAudio.CoreAudioApi.MMDeviceEnumerator devEnum = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            //NAudio.CoreAudioApi.MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(NAudio.CoreAudioApi.DataFlow.Render, NAudio.CoreAudioApi.Role.Multimedia);
            //int leftVolume = (int)defaultDevice.AudioMeterInformation.PeakValues.Count;
            //Console.WriteLine(leftVolume.ToString());
            //int rightVolume = defaultDevice.AudioMeterInformation.PeakValues;

            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            //Console.WriteLine("Sending Volume level through " + port.PortName);
            //Console.WriteLine("\rCurrent Level: " + defaultDevice.AudioMeterInformation.MasterPeakValue.ToString());
            Console.WriteLine("\rCurrent Level: " + defaultDevice.AudioMeterInformation.PeakValues[0]);
            progressBar1.Value = (int)defaultDevice.AudioMeterInformation.PeakValues[0];
            //Test levels of audio
            textBox1.Text = (defaultDevice.AudioMeterInformation.PeakValues[0] * 100).ToString();
            //textBox1.Text = defaultDevice.AudioClient.AudioStreamVolume.ToString();

            pictureBox2.Height =  (int)defaultDevice.AudioMeterInformation.PeakValues[1] * 100;

        }

        private void Player_Enter(object sender, EventArgs e)
        {

        }

        private void menuStripUpload_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openWAVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //NAudio test WAV
        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
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
                wave_list.Items.Add(open.FileName);
            }

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

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK) return;
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < paths.Length; i++)
                {
                    track_List.Items.Add(paths[i]);
                }
            }

        }



    }
}
