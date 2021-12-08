using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void End_Load(object sender, EventArgs e)
        {
            lblUser.Text = User.Name;
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}
