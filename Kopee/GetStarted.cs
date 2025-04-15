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
    public partial class GetStarted : Form
    {
        public GetStarted()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            LogInForm lg = new LogInForm();
            lg.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
