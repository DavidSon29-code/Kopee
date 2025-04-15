using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopee.UserControls
{
    public partial class UC_MenuButton : UserControl
    {
        public UC_MenuButton()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MenuList list = new MenuList();
            list.Show();
        }
    }
}
