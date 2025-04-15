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
    public partial class UC_ClasicsDrinks : UserControl
    {
        public UC_ClasicsDrinks()
        {
            InitializeComponent();
        }

        int quantity1 = 1;
        int quantity2 = 1;

        private void Minus_Click(object sender, EventArgs e)
        {
            if (quantity1 > 1)
            {
                quantity1--;
                lblQuantity.Text = quantity1.ToString();
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            quantity1++;
            lblQuantity.Text = quantity1.ToString();
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void UC_ClasicsDrinks_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxMinus_Click(object sender, EventArgs e)
        {
            if (quantity1 > 1)
            {
                quantity1--;
                lblQuantity.Text = quantity1.ToString();
            }
        }

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            quantity1++;
            lblQuantity.Text = quantity1.ToString();
        }

        private void lblQuantity1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMinus1_Click(object sender, EventArgs e)
        {
            if (quantity2 > 1)
            {
                quantity2--;
                lbl1.Text = quantity2.ToString();
            }
        }

        private void pictureBoxPlus1_Click(object sender, EventArgs e)
        {
            quantity2++;
            lbl1.Text = quantity2.ToString();
        }
    }
}
