
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
            this.byLabel = new System.Windows.Forms.Label();
            this.byNameLabel = new System.Windows.Forms.Label();
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
            this.playlistButton.Size = new System.Drawing.Size(736, 108);
            this.playlistButton.TabIndex = 0;
            this.playlistButton.Text = "Playlist Name";
            this.playlistButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // byLabel
            // 
            this.byLabel.AutoSize = true;
            this.byLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.byLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byLabel.ForeColor = System.Drawing.Color.White;
            this.byLabel.Location = new System.Drawing.Point(534, 76);
            this.byLabel.Name = "byLabel";
            this.byLabel.Size = new System.Drawing.Size(46, 25);
            this.byLabel.TabIndex = 1;
            this.byLabel.Text = "By:";
            this.byLabel.Visible = false;
            // 
            // byNameLabel
            // 
            this.byNameLabel.AutoSize = true;
            this.byNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.byNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byNameLabel.ForeColor = System.Drawing.Color.White;
            this.byNameLabel.Location = new System.Drawing.Point(576, 80);
            this.byNameLabel.Name = "byNameLabel";
            this.byNameLabel.Size = new System.Drawing.Size(31, 20);
            this.byNameLabel.TabIndex = 2;
            this.byNameLabel.Text = "By:";
            this.byNameLabel.Visible = false;
            // 
            // PlaylistEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.byNameLabel);
            this.Controls.Add(this.byLabel);
            this.Controls.Add(this.playlistButton);
            this.Name = "PlaylistEntry";
            this.Size = new System.Drawing.Size(739, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button playlistButton;
        private System.Windows.Forms.Label byLabel;
        private System.Windows.Forms.Label byNameLabel;
    }
}
