
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.songsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.publicButton = new Guna.UI2.WinForms.Guna2Button();
            this.songsPanel.SuspendLayout();
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
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(139, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(177, 31);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Playlist Name";
            // 
            // songsPanel
            // 
            this.songsPanel.AutoScroll = true;
            this.songsPanel.Controls.Add(this.emptyLabel);
            this.songsPanel.Location = new System.Drawing.Point(94, 73);
            this.songsPanel.Name = "songsPanel";
            this.songsPanel.Size = new System.Drawing.Size(487, 710);
            this.songsPanel.TabIndex = 8;
            // 
            // emptyLabel
            // 
            this.emptyLabel.AutoSize = true;
            this.emptyLabel.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel.ForeColor = System.Drawing.Color.White;
            this.emptyLabel.Location = new System.Drawing.Point(3, 0);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(318, 42);
            this.emptyLabel.TabIndex = 8;
            this.emptyLabel.Text = "Wow! Such Empty....";
            this.emptyLabel.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.CheckedState.Parent = this.deleteButton;
            this.deleteButton.CustomImages.Parent = this.deleteButton;
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.HoverState.Parent = this.deleteButton;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageSize = new System.Drawing.Size(60, 60);
            this.deleteButton.Location = new System.Drawing.Point(501, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ShadowDecoration.Parent = this.deleteButton;
            this.deleteButton.Size = new System.Drawing.Size(64, 51);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // publicButton
            // 
            this.publicButton.BorderColor = System.Drawing.Color.White;
            this.publicButton.BorderRadius = 15;
            this.publicButton.BorderThickness = 1;
            this.publicButton.CheckedState.Parent = this.publicButton;
            this.publicButton.CustomImages.Parent = this.publicButton;
            this.publicButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.publicButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.publicButton.ForeColor = System.Drawing.Color.White;
            this.publicButton.HoverState.Parent = this.publicButton;
            this.publicButton.ImageSize = new System.Drawing.Size(60, 60);
            this.publicButton.Location = new System.Drawing.Point(402, 16);
            this.publicButton.Name = "publicButton";
            this.publicButton.ShadowDecoration.Parent = this.publicButton;
            this.publicButton.Size = new System.Drawing.Size(81, 44);
            this.publicButton.TabIndex = 10;
            this.publicButton.Text = "Make Publilc";
            this.publicButton.Click += new System.EventHandler(this.publicButton_Click);
            // 
            // PlaylistView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(558, 795);
            this.Controls.Add(this.publicButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.songsPanel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaylistView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaylistView";
            this.Load += new System.EventHandler(this.PlaylistView_Load);
            this.songsPanel.ResumeLayout(false);
            this.songsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.FlowLayoutPanel songsPanel;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private System.Windows.Forms.Label emptyLabel;
        private Guna.UI2.WinForms.Guna2Button publicButton;
    }
}