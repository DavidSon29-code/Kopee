using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Kopee
{
    public partial class MenuList : Form
    {
        public MenuList()
        {
            InitializeComponent();
        }

        bool isShow;
        int quan1 = 1;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = N1ComboBox.SelectedItem.ToString();

            if (selectedItem == "DRINKS")
            {
                DrinksMenucs drinksMenu = new DrinksMenucs();
                drinksMenu.Show();
                this.Hide();
            }
            else if (selectedItem == "FOOD")
            {

                FoodMenu foodMenu = new FoodMenu();
                foodMenu.Show();
                this.Hide();
            }
        }
        private void Classics_Click(object sender, EventArgs e)
        {

        }

        private void MenuList_Load(object sender, EventArgs e)
        {
            flowPanelMenu.Hide();
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
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            flowPanelMenu.Hide();

        }

        private void flowPanelMenu_Paint(object sender, PaintEventArgs e)
        {

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
