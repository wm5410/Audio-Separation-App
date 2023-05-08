using System;
using NAudio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPX241_musicPlayer
{
    public partial class musicPlayer : Form
    {
        //NAudio test
        private NAudio.Wave.WaveFileReader wave = null;
        private NAudio.Wave.DirectSoundOut output = null;


        public musicPlayer()
        {
            InitializeComponent();
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
            if (track_List.SelectedIndex<track_List.SelectedIndex-1)
            {
                Player.Ctlcontrols.next();
            }       
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (track_List.SelectedIndex>0)
            {
                Player.Ctlcontrols.previous();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Player.playState== WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)Player.Ctlcontrols.currentPosition;
            }
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

        //NAudio test
        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Wave FIle (*.wav)|*.wav;";
            open.Multiselect = true;
            if (open.ShowDialog() == DialogResult.OK) //return;
            {
                wave = new NAudio.Wave.WaveFileReader(open.FileName);
                output = new NAudio.Wave.DirectSoundOut();
                output.Init(new NAudio.Wave.WaveChannel32(wave));
                //output.Play();
                buttonPause.Enabled = false;
            }

            
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
