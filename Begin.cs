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
    public partial class Begin : Form
    {
        public Begin()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("User name is not blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Test test = new Test();
                test.UserName = txtName.Text;
                User.Name = txtName.Text;
                this.Visible = false;
                test.ShowDialog();
            }
        }
    }
}
