
namespace SpotifyCloneUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.homeButton = new Guna.UI2.WinForms.Guna2Button();
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.playlistEntry1 = new SpotifyCloneUI.PlaylistEntry();
            this.playlistEntry2 = new SpotifyCloneUI.PlaylistEntry();
            this.playlistEntry3 = new SpotifyCloneUI.PlaylistEntry();
            this.playlistEntry4 = new SpotifyCloneUI.PlaylistEntry();
            this.playlistEntry5 = new SpotifyCloneUI.PlaylistEntry();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BorderRadius = 22;
            this.homeButton.Checked = true;
            this.homeButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.homeButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.homeButton.CheckedState.Parent = this.homeButton;
            this.homeButton.CustomImages.Parent = this.homeButton;
            this.homeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.homeButton.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.HoverState.Parent = this.homeButton;
            this.homeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeButton.Location = new System.Drawing.Point(-18, -2);
            this.homeButton.Name = "homeButton";
            this.homeButton.ShadowDecoration.Parent = this.homeButton;
            this.homeButton.Size = new System.Drawing.Size(1101, 45);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseTransparentBackground = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AutoSize = true;
            this.usernameDisplay.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameDisplay.ForeColor = System.Drawing.Color.White;
            this.usernameDisplay.Location = new System.Drawing.Point(66, 59);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(89, 21);
            this.usernameDisplay.TabIndex = 1;
            this.usernameDisplay.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(998, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(4, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search Songs";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.Location = new System.Drawing.Point(493, 59);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "Create A New Playlist";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(324, 43);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.playlistEntry1);
            this.flowLayoutPanel1.Controls.Add(this.playlistEntry2);
            this.flowLayoutPanel1.Controls.Add(this.playlistEntry3);
            this.flowLayoutPanel1.Controls.Add(this.playlistEntry4);
            this.flowLayoutPanel1.Controls.Add(this.playlistEntry5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(265, 125);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(769, 468);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // playlistEntry1
            // 
            this.playlistEntry1.Location = new System.Drawing.Point(3, 3);
            this.playlistEntry1.Name = "playlistEntry1";
            this.playlistEntry1.Size = new System.Drawing.Size(739, 84);
            this.playlistEntry1.TabIndex = 0;
            // 
            // playlistEntry2
            // 
            this.playlistEntry2.Location = new System.Drawing.Point(3, 93);
            this.playlistEntry2.Name = "playlistEntry2";
            this.playlistEntry2.Size = new System.Drawing.Size(739, 84);
            this.playlistEntry2.TabIndex = 1;
            // 
            // playlistEntry3
            // 
            this.playlistEntry3.Location = new System.Drawing.Point(3, 183);
            this.playlistEntry3.Name = "playlistEntry3";
            this.playlistEntry3.Size = new System.Drawing.Size(739, 84);
            this.playlistEntry3.TabIndex = 2;
            // 
            // playlistEntry4
            // 
            this.playlistEntry4.Location = new System.Drawing.Point(3, 273);
            this.playlistEntry4.Name = "playlistEntry4";
            this.playlistEntry4.Size = new System.Drawing.Size(739, 84);
            this.playlistEntry4.TabIndex = 3;
            // 
            // playlistEntry5
            // 
            this.playlistEntry5.Location = new System.Drawing.Point(3, 363);
            this.playlistEntry5.Name = "playlistEntry5";
            this.playlistEntry5.Size = new System.Drawing.Size(739, 84);
            this.playlistEntry5.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1073, 605);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.usernameDisplay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.homeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usernameDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button homeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private PlaylistEntry playlistEntry1;
        private PlaylistEntry playlistEntry2;
        private PlaylistEntry playlistEntry3;
        private PlaylistEntry playlistEntry4;
        private PlaylistEntry playlistEntry5;
    }
}