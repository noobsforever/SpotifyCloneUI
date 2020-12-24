
namespace SpotifyCloneUI
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.volumeSlider1 = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.singerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.song_picture = new System.Windows.Forms.PictureBox();
            this.stopButton = new Guna.UI2.WinForms.Guna2Button();
            this.pauseButton = new Guna.UI2.WinForms.Guna2Button();
            this.previousButton = new Guna.UI2.WinForms.Guna2Button();
            this.playButton = new Guna.UI2.WinForms.Guna2Button();
            this.nextButton = new Guna.UI2.WinForms.Guna2Button();
            this.playlistnameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.song_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(-6, -2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(118, 68);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.volumeSlider1);
            this.panel1.Controls.Add(this.singerLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.song_picture);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.pauseButton);
            this.panel1.Controls.Add(this.previousButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Location = new System.Drawing.Point(127, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 478);
            this.panel1.TabIndex = 3;
            // 
            // volumeSlider1
            // 
            this.volumeSlider1.BorderRadius = 15;
            this.volumeSlider1.FillColor = System.Drawing.Color.White;
            this.volumeSlider1.HoverState.Parent = null;
            this.volumeSlider1.LargeChange = 10;
            this.volumeSlider1.Location = new System.Drawing.Point(44, 443);
            this.volumeSlider1.MouseWheelBarPartitions = 10;
            this.volumeSlider1.Name = "volumeSlider1";
            this.volumeSlider1.PressedState.Parent = this.volumeSlider1;
            this.volumeSlider1.ScrollbarSize = 18;
            this.volumeSlider1.Size = new System.Drawing.Size(300, 18);
            this.volumeSlider1.TabIndex = 9;
            this.volumeSlider1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.volumeSlider1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volumeSlider1_Scroll);
            // 
            // singerLabel
            // 
            this.singerLabel.AutoSize = true;
            this.singerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singerLabel.ForeColor = System.Drawing.Color.LightGray;
            this.singerLabel.Location = new System.Drawing.Point(68, 344);
            this.singerLabel.Name = "singerLabel";
            this.singerLabel.Size = new System.Drawing.Size(94, 18);
            this.singerLabel.TabIndex = 8;
            this.singerLabel.Text = "Singer Name";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(68, 310);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(120, 24);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Song Name";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // song_picture
            // 
            this.song_picture.Image = ((System.Drawing.Image)(resources.GetObject("song_picture.Image")));
            this.song_picture.Location = new System.Drawing.Point(72, 3);
            this.song_picture.Name = "song_picture";
            this.song_picture.Size = new System.Drawing.Size(565, 293);
            this.song_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.song_picture.TabIndex = 6;
            this.song_picture.TabStop = false;
            // 
            // stopButton
            // 
            this.stopButton.CheckedState.Parent = this.stopButton;
            this.stopButton.CustomImages.Parent = this.stopButton;
            this.stopButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.HoverState.Parent = this.stopButton;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageSize = new System.Drawing.Size(40, 40);
            this.stopButton.Location = new System.Drawing.Point(468, 383);
            this.stopButton.Name = "stopButton";
            this.stopButton.ShadowDecoration.Parent = this.stopButton;
            this.stopButton.Size = new System.Drawing.Size(48, 45);
            this.stopButton.TabIndex = 4;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.CheckedState.Parent = this.pauseButton;
            this.pauseButton.CustomImages.Parent = this.pauseButton;
            this.pauseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.pauseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pauseButton.ForeColor = System.Drawing.Color.White;
            this.pauseButton.HoverState.Parent = this.pauseButton;
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.ImageSize = new System.Drawing.Size(40, 40);
            this.pauseButton.Location = new System.Drawing.Point(183, 383);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.ShadowDecoration.Parent = this.pauseButton;
            this.pauseButton.Size = new System.Drawing.Size(48, 45);
            this.pauseButton.TabIndex = 3;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.CheckedState.Parent = this.previousButton;
            this.previousButton.CustomImages.Parent = this.previousButton;
            this.previousButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.previousButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.previousButton.ForeColor = System.Drawing.Color.White;
            this.previousButton.HoverState.Parent = this.previousButton;
            this.previousButton.Image = ((System.Drawing.Image)(resources.GetObject("previousButton.Image")));
            this.previousButton.ImageSize = new System.Drawing.Size(40, 40);
            this.previousButton.Location = new System.Drawing.Point(44, 383);
            this.previousButton.Name = "previousButton";
            this.previousButton.ShadowDecoration.Parent = this.previousButton;
            this.previousButton.Size = new System.Drawing.Size(48, 45);
            this.previousButton.TabIndex = 2;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // playButton
            // 
            this.playButton.CheckedState.Parent = this.playButton;
            this.playButton.CustomImages.Parent = this.playButton;
            this.playButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.HoverState.Parent = this.playButton;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.ImageSize = new System.Drawing.Size(40, 40);
            this.playButton.Location = new System.Drawing.Point(321, 383);
            this.playButton.Name = "playButton";
            this.playButton.ShadowDecoration.Parent = this.playButton;
            this.playButton.Size = new System.Drawing.Size(48, 45);
            this.playButton.TabIndex = 1;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.CheckedState.Parent = this.nextButton;
            this.nextButton.CustomImages.Parent = this.nextButton;
            this.nextButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.HoverState.Parent = this.nextButton;
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.ImageSize = new System.Drawing.Size(40, 40);
            this.nextButton.Location = new System.Drawing.Point(614, 383);
            this.nextButton.Name = "nextButton";
            this.nextButton.ShadowDecoration.Parent = this.nextButton;
            this.nextButton.Size = new System.Drawing.Size(48, 45);
            this.nextButton.TabIndex = 0;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // playlistnameLabel
            // 
            this.playlistnameLabel.AutoSize = true;
            this.playlistnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistnameLabel.ForeColor = System.Drawing.Color.White;
            this.playlistnameLabel.Location = new System.Drawing.Point(381, 11);
            this.playlistnameLabel.Name = "playlistnameLabel";
            this.playlistnameLabel.Size = new System.Drawing.Size(165, 31);
            this.playlistnameLabel.TabIndex = 4;
            this.playlistnameLabel.Text = "Song Name";
            // 
            // MusicPlayer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(965, 568);
            this.Controls.Add(this.playlistnameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.song_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button stopButton;
        private Guna.UI2.WinForms.Guna2Button pauseButton;
        private Guna.UI2.WinForms.Guna2Button previousButton;
        private Guna.UI2.WinForms.Guna2Button playButton;
        private Guna.UI2.WinForms.Guna2Button nextButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox song_picture;
        private System.Windows.Forms.Label singerLabel;
        private Guna.UI2.WinForms.Guna2HScrollBar volumeSlider1;
        private System.Windows.Forms.Label playlistnameLabel;
    }
}