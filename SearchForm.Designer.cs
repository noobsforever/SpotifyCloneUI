
namespace SpotifyCloneUI
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.searchText = new Guna.UI2.WinForms.Guna2TextBox();
            this.songsPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.guna2Button1.Location = new System.Drawing.Point(-22, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(118, 68);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // searchText
            // 
            this.searchText.Animated = true;
            this.searchText.BorderRadius = 15;
            this.searchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchText.DefaultText = "";
            this.searchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchText.DisabledState.Parent = this.searchText;
            this.searchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.searchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchText.FocusedState.Parent = this.searchText;
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.ForeColor = System.Drawing.Color.Black;
            this.searchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchText.HoverState.Parent = this.searchText;
            this.searchText.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchText.IconLeft")));
            this.searchText.Location = new System.Drawing.Point(103, 13);
            this.searchText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.searchText.PlaceholderText = "Search For Songs";
            this.searchText.SelectedText = "";
            this.searchText.ShadowDecoration.Parent = this.searchText;
            this.searchText.Size = new System.Drawing.Size(371, 46);
            this.searchText.TabIndex = 4;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // songsPanel
            // 
            this.songsPanel.AutoScroll = true;
            this.songsPanel.Location = new System.Drawing.Point(25, 108);
            this.songsPanel.Name = "songsPanel";
            this.songsPanel.Size = new System.Drawing.Size(493, 583);
            this.songsPanel.TabIndex = 5;
            // 
            // SearchForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(500, 703);
            this.Controls.Add(this.songsPanel);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox searchText;
        private System.Windows.Forms.FlowLayoutPanel songsPanel;
    }
}