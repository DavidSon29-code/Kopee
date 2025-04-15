using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kopee.UC_Drinks_Food;

namespace Kopee
{
    public partial class DrinksMenucs : Form
    {
        public DrinksMenucs()
        {
            InitializeComponent();
            UC_ClasicsDrinks cs = new UC_ClasicsDrinks();
            addUserControl(cs);
        }

        bool isShow;
        int quan1 = 1;
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelDrinksContainer.Controls.Clear();
            PanelDrinksContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void N1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = N1ComboBox.SelectedItem.ToString();

            if (selectedItem == "FOOD")
            {
                FoodMenu foodMenu = new FoodMenu();
                foodMenu.Show();
                this.Hide();
            }
        }

        private void Classics_Click(object sender, EventArgs e)
        {
            UC_ClasicsDrinks uc = new UC_ClasicsDrinks();
            addUserControl(uc);
        }

        private void Frappè_Click(object sender, EventArgs e)
        {
            UC_FrapDrinkss uc = new UC_FrapDrinkss();
            addUserControl(uc);
        }

        private void DrinksMenucs_Load(object sender, EventArgs e)
        {
            flowPanelMenu.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tea_Click(object sender, EventArgs e)
        {
            UC_TeaDrinks uc = new UC_TeaDrinks();
            addUserControl(uc);
        }

        private void NonCoffee_Click(object sender, EventArgs e)
        {
            UC_NonCoffee uc = new UC_NonCoffee();
            addUserControl(uc);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int maxWidth = 150;
            int slideSpeed = 20;

            if (isShow)
            {
                if (flowPanelMenu.Width < maxWidth)
                {
                    flowPanelMenu.Width += slideSpeed;
                }
                else
                {
                    flowPanelMenu.Width = maxWidth;
                    timer1.Stop();
                }
            }
            else
            {
                if (flowPanelMenu.Width > 0)
                {
                    flowPanelMenu.Width -= slideSpeed;
                }
                else
                {
                    flowPanelMenu.Width = 0;
                    flowPanelMenu.Hide(); // Only hide when fully closed
                    timer1.Stop();
                }
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (flowPanelMenu.Visible)
            {
                isShow = false;
                flowPanelMenu.Hide();
                timer1.Start();

            }
            else
                isShow = true;
            flowPanelMenu.Show();
            timer1.Start();
            {
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            flowPanelMenu.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Receipt gt1 = new Receipt();
            gt1.Show();
            this.Hide();
        }

        private void pictureBoxMinus_Click(object sender, EventArgs e)
        {
            if (quan1 > 1)
            {
                quan1--;
                lblQuantity.Text = quan1.ToString();
            }
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            quan1++;
            lblQuantity.Text = quan1.ToString();
        }
    }
}
