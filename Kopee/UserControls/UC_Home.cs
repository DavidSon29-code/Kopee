using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopee
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LogInForm lg = new LogInForm();
            lg.Show();
        }
    }
}
