using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class lossForm : Form
    {
        public lossForm()
        {
            InitializeComponent();

            lossText.SelectAll();
            lossText.SelectionAlignment = HorizontalAlignment.Center;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void lossText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
