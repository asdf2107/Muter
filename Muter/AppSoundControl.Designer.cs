namespace Muter
{
    partial class AppSoundControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MuteUnmuteButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MuteUnmuteButton
            // 
            this.MuteUnmuteButton.BackColor = System.Drawing.Color.IndianRed;
            this.MuteUnmuteButton.FlatAppearance.BorderSize = 0;
            this.MuteUnmuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuteUnmuteButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MuteUnmuteButton.ForeColor = System.Drawing.Color.White;
            this.MuteUnmuteButton.Location = new System.Drawing.Point(407, 3);
            this.MuteUnmuteButton.Name = "MuteUnmuteButton";
            this.MuteUnmuteButton.Size = new System.Drawing.Size(87, 88);
            this.MuteUnmuteButton.TabIndex = 2;
            this.MuteUnmuteButton.Text = "Mute / Unmute";
            this.MuteUnmuteButton.UseVisualStyleBackColor = false;
            this.MuteUnmuteButton.Click += new System.EventHandler(this.MuteUnmuteButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(101, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(87, 88);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.LargeChange = 25;
            this.VolumeTrackBar.Location = new System.Drawing.Point(194, 20);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(195, 56);
            this.VolumeTrackBar.TabIndex = 1;
            this.VolumeTrackBar.TickFrequency = 5;
            this.VolumeTrackBar.Value = 100;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Location = new System.Drawing.Point(26, 14);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(48, 48);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconPictureBox.TabIndex = 3;
            this.IconPictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameLabel.Location = new System.Drawing.Point(0, 64);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 25);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "[  Name  ]";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppSoundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.MuteUnmuteButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AppSoundControl";
            this.Size = new System.Drawing.Size(497, 94);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MuteUnmuteButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Label NameLabel;
    }
}
