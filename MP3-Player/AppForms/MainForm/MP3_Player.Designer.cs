namespace MP3_Player.MainForm.AppForms {
    partial class MP3_Player {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP3_Player));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.aboutProgramButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.openMusicOrPlayListPanel = new System.Windows.Forms.Panel();
            this.uploadMultipleAudioFilesButton = new System.Windows.Forms.Button();
            this.uploadSingleAudioFileButton = new System.Windows.Forms.Button();
            this.musicControlPanel = new System.Windows.Forms.Panel();
            this.playPreviousAudioButton = new System.Windows.Forms.Button();
            this.playNextAudioButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.playAndPauseButton = new System.Windows.Forms.Button();
            this.volumeControlPanel = new System.Windows.Forms.Panel();
            this.volumeMuteButton = new System.Windows.Forms.Button();
            this.volumeDownButton = new System.Windows.Forms.Button();
            this.volumeUpButton = new System.Windows.Forms.Button();
            this.audioTitleLable = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.topPanel.SuspendLayout();
            this.openMusicOrPlayListPanel.SuspendLayout();
            this.musicControlPanel.SuspendLayout();
            this.volumeControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::MP3_Player.Properties.Resources.sound_wave;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(797, 598);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // topPanel
            // 
            this.topPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Controls.Add(this.aboutProgramButton);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Location = new System.Drawing.Point(671, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(126, 61);
            this.topPanel.TabIndex = 1;
            // 
            // aboutProgramButton
            // 
            this.aboutProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutProgramButton.BackgroundImage = global::MP3_Player.Properties.Resources.setting;
            this.aboutProgramButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aboutProgramButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.aboutProgramButton.FlatAppearance.BorderSize = 0;
            this.aboutProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutProgramButton.Location = new System.Drawing.Point(11, 7);
            this.aboutProgramButton.Name = "aboutProgramButton";
            this.aboutProgramButton.Size = new System.Drawing.Size(51, 47);
            this.aboutProgramButton.TabIndex = 3;
            this.aboutProgramButton.UseVisualStyleBackColor = true;
            this.aboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            this.aboutProgramButton.MouseHover += new System.EventHandler(this.AboutProgramButton_MouseHover);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackgroundImage = global::MP3_Player.Properties.Resources.close_button;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(66, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(51, 47);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // openMusicOrPlayListPanel
            // 
            this.openMusicOrPlayListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openMusicOrPlayListPanel.BackColor = System.Drawing.Color.Transparent;
            this.openMusicOrPlayListPanel.Controls.Add(this.uploadMultipleAudioFilesButton);
            this.openMusicOrPlayListPanel.Controls.Add(this.uploadSingleAudioFileButton);
            this.openMusicOrPlayListPanel.Location = new System.Drawing.Point(0, 527);
            this.openMusicOrPlayListPanel.Name = "openMusicOrPlayListPanel";
            this.openMusicOrPlayListPanel.Size = new System.Drawing.Size(132, 71);
            this.openMusicOrPlayListPanel.TabIndex = 2;
            // 
            // uploadMultipleAudioFilesButton
            // 
            this.uploadMultipleAudioFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uploadMultipleAudioFilesButton.BackgroundImage = global::MP3_Player.Properties.Resources.folder;
            this.uploadMultipleAudioFilesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadMultipleAudioFilesButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uploadMultipleAudioFilesButton.FlatAppearance.BorderSize = 0;
            this.uploadMultipleAudioFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadMultipleAudioFilesButton.Location = new System.Drawing.Point(70, 12);
            this.uploadMultipleAudioFilesButton.Name = "uploadMultipleAudioFilesButton";
            this.uploadMultipleAudioFilesButton.Size = new System.Drawing.Size(51, 49);
            this.uploadMultipleAudioFilesButton.TabIndex = 1;
            this.uploadMultipleAudioFilesButton.UseVisualStyleBackColor = true;
            this.uploadMultipleAudioFilesButton.Click += new System.EventHandler(this.UploadMultipleAudioFilesButton_Click);
            this.uploadMultipleAudioFilesButton.MouseHover += new System.EventHandler(this.UploadMultipleAudioFilesButton_MouseHover);
            // 
            // uploadSingleAudioFileButton
            // 
            this.uploadSingleAudioFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uploadSingleAudioFileButton.BackgroundImage = global::MP3_Player.Properties.Resources.music;
            this.uploadSingleAudioFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadSingleAudioFileButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uploadSingleAudioFileButton.FlatAppearance.BorderSize = 0;
            this.uploadSingleAudioFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadSingleAudioFileButton.Location = new System.Drawing.Point(12, 12);
            this.uploadSingleAudioFileButton.Name = "uploadSingleAudioFileButton";
            this.uploadSingleAudioFileButton.Size = new System.Drawing.Size(51, 49);
            this.uploadSingleAudioFileButton.TabIndex = 0;
            this.uploadSingleAudioFileButton.UseVisualStyleBackColor = true;
            this.uploadSingleAudioFileButton.Click += new System.EventHandler(this.UploadSingleAudioFileButton_Click);
            this.uploadSingleAudioFileButton.MouseHover += new System.EventHandler(this.UploadSingleAudioFileButton_MouseHover);
            // 
            // musicControlPanel
            // 
            this.musicControlPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.musicControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.musicControlPanel.Controls.Add(this.playPreviousAudioButton);
            this.musicControlPanel.Controls.Add(this.playNextAudioButton);
            this.musicControlPanel.Controls.Add(this.resetButton);
            this.musicControlPanel.Controls.Add(this.playAndPauseButton);
            this.musicControlPanel.Location = new System.Drawing.Point(267, 527);
            this.musicControlPanel.Name = "musicControlPanel";
            this.musicControlPanel.Size = new System.Drawing.Size(263, 71);
            this.musicControlPanel.TabIndex = 3;
            // 
            // playPreviousAudioButton
            // 
            this.playPreviousAudioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playPreviousAudioButton.BackgroundImage = global::MP3_Player.Properties.Resources.back_button;
            this.playPreviousAudioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playPreviousAudioButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.playPreviousAudioButton.FlatAppearance.BorderSize = 0;
            this.playPreviousAudioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPreviousAudioButton.Location = new System.Drawing.Point(20, 12);
            this.playPreviousAudioButton.Name = "playPreviousAudioButton";
            this.playPreviousAudioButton.Size = new System.Drawing.Size(51, 49);
            this.playPreviousAudioButton.TabIndex = 7;
            this.playPreviousAudioButton.UseVisualStyleBackColor = true;
            this.playPreviousAudioButton.Click += new System.EventHandler(this.PlayPreviousAudioButton_Click);
            this.playPreviousAudioButton.MouseHover += new System.EventHandler(this.PlayPreviousAudioButton_MouseHover);
            // 
            // playNextAudioButton
            // 
            this.playNextAudioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playNextAudioButton.BackgroundImage = global::MP3_Player.Properties.Resources.next_button;
            this.playNextAudioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playNextAudioButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.playNextAudioButton.FlatAppearance.BorderSize = 0;
            this.playNextAudioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playNextAudioButton.Location = new System.Drawing.Point(191, 12);
            this.playNextAudioButton.Name = "playNextAudioButton";
            this.playNextAudioButton.Size = new System.Drawing.Size(51, 49);
            this.playNextAudioButton.TabIndex = 6;
            this.playNextAudioButton.UseVisualStyleBackColor = true;
            this.playNextAudioButton.Click += new System.EventHandler(this.PlayNextAudioButton_Click);
            this.playNextAudioButton.MouseHover += new System.EventHandler(this.PlayNextAudioButton_MouseHover);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resetButton.BackgroundImage = global::MP3_Player.Properties.Resources.reset_button;
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(134, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(51, 49);
            this.resetButton.TabIndex = 5;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            this.resetButton.MouseHover += new System.EventHandler(this.ResetButton_MouseHover);
            // 
            // playAndPauseButton
            // 
            this.playAndPauseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playAndPauseButton.BackColor = System.Drawing.Color.Transparent;
            this.playAndPauseButton.BackgroundImage = global::MP3_Player.Properties.Resources.play_button;
            this.playAndPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playAndPauseButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.playAndPauseButton.FlatAppearance.BorderSize = 0;
            this.playAndPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAndPauseButton.Location = new System.Drawing.Point(77, 12);
            this.playAndPauseButton.Name = "playAndPauseButton";
            this.playAndPauseButton.Size = new System.Drawing.Size(51, 49);
            this.playAndPauseButton.TabIndex = 3;
            this.playAndPauseButton.UseVisualStyleBackColor = false;
            this.playAndPauseButton.Click += new System.EventHandler(this.PlayAndPauseButton_Click);
            this.playAndPauseButton.MouseHover += new System.EventHandler(this.PlayAndPauseButton_MouseHover);
            // 
            // volumeControlPanel
            // 
            this.volumeControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.volumeControlPanel.Controls.Add(this.volumeMuteButton);
            this.volumeControlPanel.Controls.Add(this.volumeDownButton);
            this.volumeControlPanel.Controls.Add(this.volumeUpButton);
            this.volumeControlPanel.Location = new System.Drawing.Point(610, 527);
            this.volumeControlPanel.Name = "volumeControlPanel";
            this.volumeControlPanel.Size = new System.Drawing.Size(187, 71);
            this.volumeControlPanel.TabIndex = 3;
            // 
            // volumeMuteButton
            // 
            this.volumeMuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeMuteButton.BackgroundImage = global::MP3_Player.Properties.Resources.silent;
            this.volumeMuteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeMuteButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.volumeMuteButton.FlatAppearance.BorderSize = 0;
            this.volumeMuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeMuteButton.Location = new System.Drawing.Point(12, 12);
            this.volumeMuteButton.Name = "volumeMuteButton";
            this.volumeMuteButton.Size = new System.Drawing.Size(51, 49);
            this.volumeMuteButton.TabIndex = 4;
            this.volumeMuteButton.UseVisualStyleBackColor = true;
            this.volumeMuteButton.Click += new System.EventHandler(this.VolumeMuteButton_Click);
            this.volumeMuteButton.MouseHover += new System.EventHandler(this.VolumeMuteButton_MouseHover);
            // 
            // volumeDownButton
            // 
            this.volumeDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeDownButton.BackgroundImage = global::MP3_Player.Properties.Resources.volume_down;
            this.volumeDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeDownButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.volumeDownButton.FlatAppearance.BorderSize = 0;
            this.volumeDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeDownButton.Location = new System.Drawing.Point(69, 12);
            this.volumeDownButton.Name = "volumeDownButton";
            this.volumeDownButton.Size = new System.Drawing.Size(51, 49);
            this.volumeDownButton.TabIndex = 3;
            this.volumeDownButton.UseVisualStyleBackColor = true;
            this.volumeDownButton.Click += new System.EventHandler(this.VolumeDownButton_Click);
            this.volumeDownButton.MouseHover += new System.EventHandler(this.VolumeDownButton_MouseHover);
            // 
            // volumeUpButton
            // 
            this.volumeUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeUpButton.BackgroundImage = global::MP3_Player.Properties.Resources.volume_up;
            this.volumeUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeUpButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.volumeUpButton.FlatAppearance.BorderSize = 0;
            this.volumeUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeUpButton.Location = new System.Drawing.Point(126, 12);
            this.volumeUpButton.Name = "volumeUpButton";
            this.volumeUpButton.Size = new System.Drawing.Size(51, 49);
            this.volumeUpButton.TabIndex = 2;
            this.volumeUpButton.UseVisualStyleBackColor = true;
            this.volumeUpButton.Click += new System.EventHandler(this.VolumeUpButton_Click);
            this.volumeUpButton.MouseHover += new System.EventHandler(this.VolumeUpButton_MouseHover);
            // 
            // audioTitleLable
            // 
            this.audioTitleLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.audioTitleLable.AutoSize = true;
            this.audioTitleLable.BackColor = System.Drawing.Color.Transparent;
            this.audioTitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioTitleLable.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.audioTitleLable.Location = new System.Drawing.Point(35, 72);
            this.audioTitleLable.Name = "audioTitleLable";
            this.audioTitleLable.Size = new System.Drawing.Size(0, 15);
            this.audioTitleLable.TabIndex = 4;
            this.audioTitleLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MP3_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MP3_Player.Properties.Resources.sound_wave;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 598);
            this.Controls.Add(this.audioTitleLable);
            this.Controls.Add(this.volumeControlPanel);
            this.Controls.Add(this.musicControlPanel);
            this.Controls.Add(this.openMusicOrPlayListPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.pictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MP3_Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3 Player";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MP3_Player_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.openMusicOrPlayListPanel.ResumeLayout(false);
            this.musicControlPanel.ResumeLayout(false);
            this.volumeControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel openMusicOrPlayListPanel;
        private System.Windows.Forms.Panel musicControlPanel;
        private System.Windows.Forms.Panel volumeControlPanel;
        private System.Windows.Forms.Button uploadSingleAudioFileButton;
        private System.Windows.Forms.Button uploadMultipleAudioFilesButton;
        private System.Windows.Forms.Button volumeMuteButton;
        private System.Windows.Forms.Button volumeDownButton;
        private System.Windows.Forms.Button volumeUpButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button playPreviousAudioButton;
        private System.Windows.Forms.Button playNextAudioButton;
        private System.Windows.Forms.Button playAndPauseButton;
        private System.Windows.Forms.Label audioTitleLable;
        private System.Windows.Forms.Button aboutProgramButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}