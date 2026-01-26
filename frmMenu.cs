using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp.Transaction
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new frmDepartment();
            fr.MdiParent = this;
            fr.Show();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new addUser();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
