
namespace SpotifyCloneUI
{
    partial class SongItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongItem));
            this.nameLabel = new System.Windows.Forms.Label();
            this.singerLabel = new System.Windows.Forms.Label();
            this.playButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new System.Windows.Forms.ComboBox();
            this.removeButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(165, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Song Name";
            // 
            // singerLabel
            // 
            this.singerLabel.AutoSize = true;
            this.singerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singerLabel.ForeColor = System.Drawing.Color.Silver;
            this.singerLabel.Location = new System.Drawing.Point(15, 53);
            this.singerLabel.Name = "singerLabel";
            this.singerLabel.Size = new System.Drawing.Size(101, 20);
            this.singerLabel.TabIndex = 1;
            this.singerLabel.Text = "Singer Name";
            // 
            // playButton
            // 
            this.playButton.CheckedState.Parent = this.playButton;
            this.playButton.CustomImages.Parent = this.playButton;
            this.playButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.HoverState.Parent = this.playButton;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.ImageSize = new System.Drawing.Size(60, 60);
            this.playButton.Location = new System.Drawing.Point(3, 95);
            this.playButton.Name = "playButton";
            this.playButton.ShadowDecoration.Parent = this.playButton;
            this.playButton.Size = new System.Drawing.Size(64, 51);
            this.playButton.TabIndex = 2;
            this.playButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.FormattingEnabled = true;
            this.addButton.Location = new System.Drawing.Point(73, 109);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(196, 28);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add To Other Playlist";
            this.addButton.SelectedValueChanged += new System.EventHandler(this.addButton_SelectedValueChanged);
            // 
            // removeButton
            // 
            this.removeButton.CheckedState.Parent = this.removeButton;
            this.removeButton.CustomImages.Parent = this.removeButton;
            this.removeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.HoverState.Parent = this.removeButton;
            this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
            this.removeButton.ImageSize = new System.Drawing.Size(60, 60);
            this.removeButton.Location = new System.Drawing.Point(275, 95);
            this.removeButton.Name = "removeButton";
            this.removeButton.ShadowDecoration.Parent = this.removeButton;
            this.removeButton.Size = new System.Drawing.Size(64, 51);
            this.removeButton.TabIndex = 4;
            this.removeButton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // SongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.singerLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "SongItem";
            this.Size = new System.Drawing.Size(446, 163);
            this.Load += new System.EventHandler(this.SongItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label singerLabel;
        private Guna.UI2.WinForms.Guna2Button playButton;
        private System.Windows.Forms.ComboBox addButton;
        private Guna.UI2.WinForms.Guna2Button removeButton;
    }
}
