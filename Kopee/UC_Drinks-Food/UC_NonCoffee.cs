using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopee.UC_Drinks_Food
{
    public partial class UC_NonCoffee : UserControl
    {
        public UC_NonCoffee()
        {
            InitializeComponent();
        }

        int quan1 = 1;
        int quan2 = 1;

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMinus_Click(object sender, EventArgs e)
        {
            if (quan1 > 1)
            {
                quan1--;
                lblQuantity.Text = quan1.ToString();
            }
        }

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            quan1++;
            lblQuantity.Text = quan1.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (quan2 > 1)
            {
                quan2--;
                label5.Text = quan2.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            quan2++;
            label5.Text = quan2.ToString();
        }
    }
}
