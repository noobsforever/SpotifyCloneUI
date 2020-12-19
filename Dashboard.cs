using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyCloneUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

        private void homeButton_Click(object sender, EventArgs e)
        {
            homeButton.Checked = true;
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
