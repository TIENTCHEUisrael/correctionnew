using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correction.Windforms
{
    public partial class FormParent : Form
    {
        private bool ExitApp = true;
        public FormParent()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ExitApp)
              Application.Exit();
        }

        private void editPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPassword form = new EditPassword();
            form.ShowDialog();
        }

        private void FormParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(ExitApp)
                Application.Exit();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUSer form = new FormUSer();
            form.MdiParent = this;
            form.Show();
        }
    }
}
