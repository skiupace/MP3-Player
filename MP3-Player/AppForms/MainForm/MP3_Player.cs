using System;
using NAudio.Wave;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MP3_Player.Classes.MyGenericCollections;

namespace MP3_Player.MainForm.AppForms {
    public partial class MP3_Player : Form {
        public MP3_Player() {
            InitializeComponent();
            audioVolumeFlag   = 1;
            playAndPauseFlag  = 1;
            audioPlaylistSize = 0;
            audioFilePosition = 0;

            player = new WaveOut();
            audioPlaylist = new Vector<string>();

            playImage = new Bitmap(Properties.Resources.play_button);
            pauseImage = new Bitmap(Properties.Resources.pause_button);
        }

        #region Close Application

        private void CloseButton_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        #endregion

        #region About Program Button

        private void AboutProgramButton_Click(object sender, EventArgs e) {
            MessageBox.Show(
                @"This App Developed BY => Ahmed 
                aka @skiupace in Github and x.com", "About"
            );
        }

        #endregion

        #region Volume Control Buttons

        private void VolumeUpButton_Click(object sender, EventArgs e) {
            try {
                player.Volume += 0.1f;
            } catch (Exception) { }
        }

        private void VolumeDownButton_Click(object sender, EventArgs e) {
            try {
                player.Volume -= 0.1f;
            } catch (Exception) { }
        }

        private void VolumeMuteButton_Click(object sender, EventArgs e) {
            try {
                audioVolumeFlag *= -1;

                if (audioVolumeFlag == -1) {
                    previousAudioVolume = player.Volume;
                    player.Volume = 0.0f;
                } else
                    player.Volume = previousAudioVolume;
            } catch (Exception) { }
        }

        #endregion

        #region Open Single Audio File

        private void UploadSingleAudioFileButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 Files|*.mp3";

            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK) {
                audioPlaylistSize = audioPlaylist.GetSize();
                audioPlaylist.PushBack(openFileDialog.FileName);
                audioTitleLable.Text = audioPlaylist.ValueAt(audioPlaylistSize);

                reader = new AudioFileReader(audioPlaylist.ValueAt(audioPlaylistSize));
                player.Init(reader);
            }
        }

        #endregion

        #region Open Multiple Audio Files

        private void UploadMultipleAudioFilesButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 Files|*.mp3";
            openFileDialog.Multiselect = true;

            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK) {
                audioPlaylistSize = audioPlaylist.GetSize();
                foreach (string fileName in openFileDialog.FileNames)
                    audioPlaylist.PushBack(fileName);

                audioTitleLable.Text = audioPlaylist.ValueAt(audioPlaylistSize);
                reader = new AudioFileReader(audioPlaylist.ValueAt(audioPlaylistSize));
                player.Init(reader);
            }
        }

        #endregion

        #region ToolTips For All The Buttons

        private void CloseButton_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(closeButton, "Close");
        }

        private void AboutProgramButton_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(aboutProgramButton, "About");
        }

        private void UploadSingleAudioFileButton_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(uploadSingleAudioFileButton, "Upload Single File");
        }

        private void UploadMultipleAudioFilesButton_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(uploadMultipleAudioFilesButton, "Upload Multiple Files");
        }

        private void PlayPreviousAudioButton_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(playPreviousAudioButton, "Previous");
        }

        private void PlayAndPauseButton_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(playAndPauseButton, "Play/Pause");
        }

        private void ResetButton_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(resetButton, "Reset");
        }

        private void PlayNextAudioButton_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(playNextAudioButton, "Next");
        }

        private void VolumeMuteButton_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(volumeMuteButton, "Mute");
        }

        private void VolumeDownButton_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(volumeDownButton, "Volume Down");
        }

        private void VolumeUpButton_MouseHover(object sender, EventArgs e) {
            toolTip.SetToolTip(volumeUpButton, "Volume UP");
        }

        #endregion

        #region Play, Pause And Reset Buttons

        private void PlayAndPauseButton_Click(object sender, EventArgs e) {
            try {
                if (reader != null) {
                    playAndPauseFlag *= -1;
                
                    if (playAndPauseFlag == -1) {
                        playAndPauseButton.BackgroundImage = pauseImage;
                        player.Play();
                        pictureBox.Visible = true;
                    } else {
                        playAndPauseButton.BackgroundImage = playImage;
                        player.Pause();
                        pictureBox.Visible = false;
                    }
                }
            } catch (Exception) { }
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            try {
                if (reader != null) {
                    player.Dispose();
                    player = new WaveOut();

                    if (playAndPauseFlag == -1) {
                        playAndPauseFlag *= -1;
                        playAndPauseButton.BackgroundImage = playImage;
                    } reader = new AudioFileReader(audioPlaylist.ValueAt(audioFilePosition));

                    player.Init(reader);
                    pictureBox.Visible = false;
                }
            } catch (Exception) { }
        }

        #endregion

        #region Play Next And Previous Audio File

        private void MakeAudioPlayWhileChangingFiles() {
            if (playAndPauseFlag == 1) {
                playAndPauseFlag *= -1;
                pictureBox.Visible = true;
                playAndPauseButton.BackgroundImage = pauseImage;
            }
        }

        private void PlayNextAudioButton_Click(object sender, EventArgs e) {
            try {
                if (reader != null) {
                    player.Dispose();
                    player = new WaveOut();

                    MakeAudioPlayWhileChangingFiles();
                    if (audioFilePosition < (audioPlaylist.GetSize() - 1))
                        audioFilePosition++;

                    reader = new AudioFileReader(audioPlaylist.ValueAt(audioFilePosition));
                    audioTitleLable.Text = audioPlaylist.ValueAt(audioFilePosition);

                    player.Init(reader);
                    player.Play();
                }
            } catch (Exception) { }
        }

        private void PlayPreviousAudioButton_Click(object sender, EventArgs e) {
            try {
                if (reader != null) {
                    player.Dispose();
                    player = new WaveOut();

                    MakeAudioPlayWhileChangingFiles();
                    if (audioFilePosition > 0)
                        audioFilePosition--;

                    reader = new AudioFileReader(audioPlaylist.ValueAt(audioFilePosition));
                    audioTitleLable.Text = audioPlaylist.ValueAt(audioFilePosition);

                    player.Init(reader);
                    player.Play();
                }
            } catch (Exception) { }
        }

        #endregion

        #region Make the Boarderless Window Draggable

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void MP3_Player_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e) {
            MP3_Player_MouseDown(sender, e);
        }

        #endregion

        #region Audio Player Variables

        private readonly Bitmap playImage;
        private readonly Bitmap pauseImage;

        private IWavePlayer player;
        private AudioFileReader reader;

        private short audioVolumeFlag;
        private float previousAudioVolume;

        private Vector<string> audioPlaylist;
        private ushort audioPlaylistSize;

        private short playAndPauseFlag;
        private ushort audioFilePosition;

        #endregion
    }
}
