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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.menuStripUpload = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepperateAudioFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.track_List = new System.Windows.Forms.ListBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.checkbox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.menuStripUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPlay.Location = new System.Drawing.Point(134, 42);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(127, 33);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPause.Location = new System.Drawing.Point(267, 42);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(127, 33);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // menuStripUpload
            // 
            this.menuStripUpload.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripUpload.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripUpload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripUpload.Location = new System.Drawing.Point(0, 0);
            this.menuStripUpload.Name = "menuStripUpload";
            this.menuStripUpload.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStripUpload.Size = new System.Drawing.Size(1882, 46);
            this.menuStripUpload.TabIndex = 4;
            this.menuStripUpload.Text = "Upload";
            this.menuStripUpload.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripUpload_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWAVToolStripMenuItem,
            this.sepperateAudioFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(76, 44);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openWAVToolStripMenuItem
            // 
            this.openWAVToolStripMenuItem.Name = "openWAVToolStripMenuItem";
            this.openWAVToolStripMenuItem.Size = new System.Drawing.Size(371, 48);
            this.openWAVToolStripMenuItem.Text = "Open Audio File";
            this.openWAVToolStripMenuItem.Click += new System.EventHandler(this.openWAVToolStripMenuItem_Click);
            // 
            // sepperateAudioFileToolStripMenuItem
            // 
            this.sepperateAudioFileToolStripMenuItem.Name = "sepperateAudioFileToolStripMenuItem";
            this.sepperateAudioFileToolStripMenuItem.Size = new System.Drawing.Size(371, 48);
            this.sepperateAudioFileToolStripMenuItem.Text = "Separate Audio File";
            this.sepperateAudioFileToolStripMenuItem.Click += new System.EventHandler(this.sepperateAudioFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(371, 48);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpen.Location = new System.Drawing.Point(400, 42);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(127, 33);
            this.buttonOpen.TabIndex = 8;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // track_List
            // 
            this.track_List.BackColor = System.Drawing.Color.Lavender;
            this.track_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_List.ForeColor = System.Drawing.Color.Black;
            this.track_List.FormattingEnabled = true;
            this.track_List.ItemHeight = 47;
            this.track_List.Location = new System.Drawing.Point(134, 587);
            this.track_List.Name = "track_List";
            this.track_List.Size = new System.Drawing.Size(1529, 333);
            this.track_List.TabIndex = 9;
            this.track_List.SelectedIndexChanged += new System.EventHandler(this.track_List_SelectedIndexChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1677, 114);
            this.trackBar2.Maximum = 50;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(193, 69);
            this.trackBar2.TabIndex = 16;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(134, 351);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1529, 88);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(134, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1529, 88);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(1677, 237);
            this.trackBar6.Maximum = 50;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(193, 69);
            this.trackBar6.TabIndex = 26;
            this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar6.Scroll += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(134, 218);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1529, 88);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // trackBar7
            // 
            this.trackBar7.Location = new System.Drawing.Point(1677, 372);
            this.trackBar7.Maximum = 50;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(193, 69);
            this.trackBar7.TabIndex = 29;
            this.trackBar7.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar7.Scroll += new System.EventHandler(this.trackBar7_Scroll);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(134, 466);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1529, 88);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // trackBar9
            // 
            this.trackBar9.Location = new System.Drawing.Point(1677, 483);
            this.trackBar9.Maximum = 50;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Size = new System.Drawing.Size(193, 69);
            this.trackBar9.TabIndex = 32;
            this.trackBar9.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // checkbox4
            // 
            this.checkbox4.AutoSize = true;
            this.checkbox4.Checked = true;
            this.checkbox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox4.ForeColor = System.Drawing.Color.SlateBlue;
            this.checkbox4.Location = new System.Drawing.Point(12, 114);
            this.checkbox4.Name = "checkbox4";
            this.checkbox4.Size = new System.Drawing.Size(138, 51);
            this.checkbox4.TabIndex = 35;
            this.checkbox4.Text = "Bass";
            this.checkbox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.SlateBlue;
            this.checkBox1.Location = new System.Drawing.Point(10, 237);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 51);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Drums";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.SlateBlue;
            this.checkBox2.Location = new System.Drawing.Point(12, 372);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(149, 51);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.Text = "Other";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.SlateBlue;
            this.checkBox3.Location = new System.Drawing.Point(10, 483);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(171, 51);
            this.checkBox3.TabIndex = 38;
            this.checkBox3.Text = "Vocals";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(788, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 39;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(666, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 40;
            this.button2.Text = "Combine";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(533, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 33);
            this.button3.TabIndex = 41;
            this.button3.Text = "Separate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1709, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 42;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(1677, 613);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(176, 333);
            this.txtLog.TabIndex = 43;
            // 
            // musicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1882, 958);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkbox4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.trackBar9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.track_List);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.menuStripUpload);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripUpload;
            this.Name = "musicPlayer";
            this.Text = "Play It Again Sam - Audio Player";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.musicPlayer_Load);
            this.menuStripUpload.ResumeLayout(false);
            this.menuStripUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.MenuStrip menuStripUpload;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ListBox track_List;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWAVToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.CheckBox checkbox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem sepperateAudioFileToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLog;
    }
}

