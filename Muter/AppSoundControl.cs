using Muter.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Muter
{
    public partial class AppSoundControl : UserControl
    {
        private App _app;

        public AppSoundControl(App app)
        {
            InitializeComponent();
            VolumeTrackBar.ValueChanged += new EventHandler(VolumeTrackBar_ValueChange);
            _app = app;
            UpdateIcon();
            UpdateData();
        }

        private void UpdateIcon()
        {
            IconPictureBox.Image = _app.Icon?.ToBitmap();
            
            UpdateIconBackColor();
        }

        private void UpdateIconBackColor()
        {
            if (IconPictureBox.Image is null)
            {
                IconPictureBox.BackColor = Color.LightGray;
            }
            else
            {
                IconPictureBox.BackColor = Color.Transparent;
            }
        }

        private void UpdateData()
        {
            NameLabel.Text = _app.Name;
            VolumeTrackBar.Value = (int)_app.Volume;
            SetMuteUnmuteButtonAppearence(_app.IsMuted);
        }

        public void Reset()
        {
            VolumeTrackBar.Value = VolumeTrackBar.Maximum;

            if (_app.IsMuted)
            {
                MuteUnmuteButton.PerformClick();
            }
        }

        private void MuteUnmuteButton_Click(object sender, EventArgs e)
        {
            bool newMuted = !_app.IsMuted;

            SetMuteUnmuteButtonAppearence(newMuted);

            _app.IsMuted = newMuted;
        }

        private void SetMuteUnmuteButtonAppearence(bool muted)
        {
            if (muted)
            {
                MuteUnmuteButton.Text = "Muted";
                MuteUnmuteButton.BackColor = Color.Gray;
            }
            else
            {
                MuteUnmuteButton.Text = "Mute";
                MuteUnmuteButton.BackColor = Color.IndianRed;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void VolumeTrackBar_ValueChange(object sender, EventArgs e)
        {
            _app.Volume = VolumeTrackBar.Value;
        }
    }
}
