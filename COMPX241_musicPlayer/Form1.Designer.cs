namespace COMPX241_musicPlayer
{
    partial class musicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musicPlayer));
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.menuStripUpload = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMDTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStop = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.track_List = new System.Windows.Forms.ListBox();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.wave_list = new System.Windows.Forms.ListBox();
            this.Volume = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStripUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNext.Location = new System.Drawing.Point(290, 742);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(6);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(254, 63);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPlay.Location = new System.Drawing.Point(858, 742);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(254, 63);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPause.Location = new System.Drawing.Point(1124, 742);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(254, 63);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPrevious.Location = new System.Drawing.Point(24, 742);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(254, 63);
            this.buttonPrevious.TabIndex = 3;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // menuStripUpload
            // 
            this.menuStripUpload.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripUpload.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripUpload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStripUpload.Location = new System.Drawing.Point(0, 0);
            this.menuStripUpload.Name = "menuStripUpload";
            this.menuStripUpload.Size = new System.Drawing.Size(1760, 40);
            this.menuStripUpload.TabIndex = 4;
            this.menuStripUpload.Text = "Upload";
            this.menuStripUpload.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripUpload_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWAVToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openWAVToolStripMenuItem
            // 
            this.openWAVToolStripMenuItem.Name = "openWAVToolStripMenuItem";
            this.openWAVToolStripMenuItem.Size = new System.Drawing.Size(262, 44);
            this.openWAVToolStripMenuItem.Text = "Open WAV";
            this.openWAVToolStripMenuItem.Click += new System.EventHandler(this.openWAVToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem1,
            this.cMDTestToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(242, 44);
            this.testToolStripMenuItem1.Text = "Test";
            this.testToolStripMenuItem1.Click += new System.EventHandler(this.testToolStripMenuItem1_Click);
            // 
            // cMDTestToolStripMenuItem
            // 
            this.cMDTestToolStripMenuItem.Name = "cMDTestToolStripMenuItem";
            this.cMDTestToolStripMenuItem.Size = new System.Drawing.Size(242, 44);
            this.cMDTestToolStripMenuItem.Text = "CMDTest";
            this.cMDTestToolStripMenuItem.Click += new System.EventHandler(this.cMDTestToolStripMenuItem_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStop.Location = new System.Drawing.Point(556, 742);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(6);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(254, 63);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 700);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1620, 31);
            this.progressBar1.TabIndex = 7;
            // 
            // buttonOpen
            // 
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpen.Location = new System.Drawing.Point(1390, 742);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(6);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(254, 63);
            this.buttonOpen.TabIndex = 8;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // track_List
            // 
            this.track_List.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.track_List.ForeColor = System.Drawing.Color.DarkOrange;
            this.track_List.FormattingEnabled = true;
            this.track_List.ItemHeight = 25;
            this.track_List.Location = new System.Drawing.Point(913, 510);
            this.track_List.Margin = new System.Windows.Forms.Padding(6);
            this.track_List.Name = "track_List";
            this.track_List.Size = new System.Drawing.Size(646, 179);
            this.track_List.TabIndex = 9;
            this.track_List.SelectedIndexChanged += new System.EventHandler(this.track_List_SelectedIndexChanged);
            // 
            // pic_art
            // 
            this.pic_art.BackColor = System.Drawing.Color.Transparent;
            this.pic_art.Image = ((System.Drawing.Image)(resources.GetObject("pic_art.Image")));
            this.pic_art.Location = new System.Drawing.Point(56, 131);
            this.pic_art.Margin = new System.Windows.Forms.Padding(6);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(272, 250);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 12;
            this.pic_art.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 438);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1670, 97);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(90, 558);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(24, 817);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(544, 90);
            this.trackBar2.TabIndex = 16;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // wave_list
            // 
            this.wave_list.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.wave_list.ForeColor = System.Drawing.Color.DarkOrange;
            this.wave_list.FormattingEnabled = true;
            this.wave_list.ItemHeight = 25;
            this.wave_list.Location = new System.Drawing.Point(24, 1012);
            this.wave_list.Margin = new System.Windows.Forms.Padding(6);
            this.wave_list.Name = "wave_list";
            this.wave_list.Size = new System.Drawing.Size(1616, 279);
            this.wave_list.TabIndex = 17;
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Volume.Location = new System.Drawing.Point(1656, 694);
            this.Volume.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(84, 25);
            this.Volume.TabIndex = 18;
            this.Volume.Text = "Volume";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(580, 817);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(548, 90);
            this.trackBar3.TabIndex = 19;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(1140, 817);
            this.trackBar4.Margin = new System.Windows.Forms.Padding(6);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(596, 90);
            this.trackBar4.TabIndex = 20;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(340, 79);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 33);
            this.comboBox1.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(614, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 31);
            this.textBox1.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1568, 97);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 592);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Audio 1",
            "Audio 2",
            "Audio 3",
            "Play All Audios"});
            this.checkedListBox1.Location = new System.Drawing.Point(1346, 79);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(213, 116);
            this.checkedListBox1.TabIndex = 24;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(913, 200);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(646, 301);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(24, 697);
            this.Player.Margin = new System.Windows.Forms.Padding(6);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(880, 36);
            this.Player.TabIndex = 14;
            this.Player.Enter += new System.EventHandler(this.Player_Enter);
            // 
            // musicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1760, 1317);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.wave_list);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.track_List);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.menuStripUpload);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.MainMenuStrip = this.menuStripUpload;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "musicPlayer";
            this.Text = "musicPlayer";
            this.Load += new System.EventHandler(this.musicPlayer_Load);
            this.menuStripUpload.ResumeLayout(false);
            this.menuStripUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.MenuStrip menuStripUpload;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ListBox track_List;
        private System.Windows.Forms.PictureBox pic_art;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.ListBox wave_list;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem cMDTestToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

