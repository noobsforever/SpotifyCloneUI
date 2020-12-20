
namespace SpotifyCloneUI
{
    partial class PlaylistEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistEntry));
            this.playlistButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // playlistButton
            // 
            this.playlistButton.BorderRadius = 25;
            this.playlistButton.CheckedState.Parent = this.playlistButton;
            this.playlistButton.CustomImages.Parent = this.playlistButton;
            this.playlistButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.playlistButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistButton.ForeColor = System.Drawing.Color.White;
            this.playlistButton.HoverState.Parent = this.playlistButton;
            this.playlistButton.Image = ((System.Drawing.Image)(resources.GetObject("playlistButton.Image")));
            this.playlistButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.playlistButton.ImageSize = new System.Drawing.Size(60, 60);
            this.playlistButton.Location = new System.Drawing.Point(0, 3);
            this.playlistButton.Name = "playlistButton";
            this.playlistButton.ShadowDecoration.Parent = this.playlistButton;
            this.playlistButton.Size = new System.Drawing.Size(736, 77);
            this.playlistButton.TabIndex = 0;
            this.playlistButton.Text = "Playlist Name";
            this.playlistButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // PlaylistEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playlistButton);
            this.Name = "PlaylistEntry";
            this.Size = new System.Drawing.Size(739, 84);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button playlistButton;
    }
}
