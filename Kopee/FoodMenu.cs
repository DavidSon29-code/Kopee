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
    public partial class FoodMenu : Form
    {
        public FoodMenu()
        {
            InitializeComponent();
            UC_Cakes cs = new UC_Cakes();
            addUserControl(cs);
        }

        bool isShow;
        int quan1 = 1;
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelFoodContainer.Controls.Clear();
            PanelFoodContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pastry_Click(object sender, EventArgs e)
        {
            UC_Pastry uc = new UC_Pastry();
            addUserControl(uc);
        }

        private void Buns_Click(object sender, EventArgs e)
        {
            UC_Buns uc = new UC_Buns();
            addUserControl(uc);

        }

        private void Cakes_Click(object sender, EventArgs e)
        {
            UC_Cakes uc = new UC_Cakes();
            addUserControl(uc);
        }

        private void FoodMenu_Load(object sender, EventArgs e)
        {
            flowPanelMenu.Hide();
        }

        private void N1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = N1ComboBox.SelectedItem.ToString();

            if (selectedItem == "DRINKS")
            {
                DrinksMenucs drinksMenu = new DrinksMenucs();
                drinksMenu.Show();
                this.Hide();
            }
        }

        private void PanelFoodContainer_Paint(object sender, PaintEventArgs e)
        {

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

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            quan1++;
            lblQuantity.Text = quan1.ToString();
        }
    }
}
