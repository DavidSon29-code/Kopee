using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kopee.UserControls;

namespace Kopee
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            UC_MenuButton uc = new UC_MenuButton();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer1.Controls.Clear();
            panelContainer1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UC_MenuButton uc = new UC_MenuButton();
            addUserControl(uc);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_About uc = new UC_About();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Contact uc = new UC_Contact();
            addUserControl(uc);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelContainer1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
