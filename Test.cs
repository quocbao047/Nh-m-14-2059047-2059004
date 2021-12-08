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
    public partial class Test : Form
    {
        private String userName;
        public String UserName
        {
            get { return this.userName; }
            set
            {
                this.userName = value;
                lblUsername.Text = this.userName;
            }
        }
        public Test()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Application message", "Submit success", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                End end = new End();
                this.Hide();
                end.ShowDialog();
            }
        }
    }
}
