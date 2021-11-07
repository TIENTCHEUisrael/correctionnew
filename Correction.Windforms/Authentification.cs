using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorrectionCC.BO;
using Correction.BLL;

namespace Correction.Windforms
{
    public partial class Authentification : Form
    {
        private bool exitApp = true;
        public Authentification()
        {
            InitializeComponent();
            txtEmail.Text = "admin@gmail.com";
            txtPassword.Text = "administrator";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager userManager = new UserManager();
                var user = userManager.Authenticate(txtEmail.Text, txtPassword.Text);
                if (user == null)
                    throw new Exception("Email or password is incorrect");
                Program.currentuser = user;
                MessageBox.Show($"Welcome {user.Fullname} !", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form = new FormParent();
                form.Show();
                exitApp = false;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clean()
        {
            txtPassword.Clear();
            txtEmail.Clear();
        }

        private void Authentfication_Load(object sender, EventArgs e)
        {

        }

        private void Authentification_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(exitApp)
                Application.Exit();
        }
    }
}
