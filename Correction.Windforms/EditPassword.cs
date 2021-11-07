using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correction.BLL;
using CorrectionCC.BO;

namespace Correction.Windforms
{
    public partial class EditPassword : Form
    {
        public EditPassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager userManager = new UserManager();
                User user = userManager.Authenticate(Program.currentuser.Email,txtOld.Text);
                if (user == null)
                    throw new Exception(" Ol password is incorrect is incorrect");
                if (txtOld.Text != txtNew.Text)
                    throw new Exception("New and confirm password doesn't Macht!!");

                Program.currentuser.Password= txtNew.Text;

                userManager.EditUser(user, Program.currentuser);
                MessageBox.Show($"Change pawwsord is successfuly!", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
