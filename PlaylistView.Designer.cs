
namespace SpotifyCloneUI
{
    partial class PlaylistView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistView));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.songItem1 = new SpotifyCloneUI.SongItem();
            this.songItem2 = new SpotifyCloneUI.SongItem();
            this.songItem3 = new SpotifyCloneUI.SongItem();
            this.songItem4 = new SpotifyCloneUI.SongItem();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.guna2Button1.Location = new System.Drawing.Point(0, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(118, 68);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Playlist Name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.songItem1);
            this.flowLayoutPanel1.Controls.Add(this.songItem2);
            this.flowLayoutPanel1.Controls.Add(this.songItem3);
            this.flowLayoutPanel1.Controls.Add(this.songItem4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(94, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(487, 513);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // songItem1
            // 
            this.songItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.songItem1.Location = new System.Drawing.Point(3, 3);
            this.songItem1.Name = "songItem1";
            this.songItem1.Size = new System.Drawing.Size(446, 163);
            this.songItem1.TabIndex = 0;
            // 
            // songItem2
            // 
            this.songItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.songItem2.Location = new System.Drawing.Point(3, 172);
            this.songItem2.Name = "songItem2";
            this.songItem2.Size = new System.Drawing.Size(446, 163);
            this.songItem2.TabIndex = 1;
            // 
            // songItem3
            // 
            this.songItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.songItem3.Location = new System.Drawing.Point(3, 341);
            this.songItem3.Name = "songItem3";
            this.songItem3.Size = new System.Drawing.Size(446, 163);
            this.songItem3.TabIndex = 2;
            // 
            // songItem4
            // 
            this.songItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.songItem4.Location = new System.Drawing.Point(3, 510);
            this.songItem4.Name = "songItem4";
            this.songItem4.Size = new System.Drawing.Size(446, 163);
            this.songItem4.TabIndex = 3;
            // 
            // PlaylistView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(673, 598);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaylistView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaylistView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private SongItem songItem1;
        private SongItem songItem2;
        private SongItem songItem3;
        private SongItem songItem4;
    }
}