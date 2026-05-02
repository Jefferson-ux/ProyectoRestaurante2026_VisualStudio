using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI_V_2.Login
{
    public partial class PinSeguridad : Form
    {
        public PinSeguridad()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PinSeguridad_Load(object sender, EventArgs e)
        {

        }

        private void radViewPin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkViewPin_CheckedChanged(object sender, EventArgs e)
        {
            chkViewPin.BackColor = chkViewPin.Checked ? Color.Gray : Color.White;
        }
    }
}
