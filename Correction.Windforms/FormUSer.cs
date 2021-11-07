using Correction.BLL;
using CorrectionCC.BO;
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
    public partial class FormUSer : Form
    {
        private UserManager userManager = new UserManager();
        private User editUser;
        public FormUSer()
        {
            InitializeComponent();
            LoadUSers();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSaave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtConfirm.Text)
                    throw new Exception("New and confirm password doesn't Macht!!");
                var user = new User(txtEmail.Text, txtFull.Text, txtPassword.Text);
               
                if(editUser==null)
                {
                    userManager.AddUser(user);

                }
                else
                {
                    userManager.EditUser(editUser, user);
                }

                MessageBox.Show($"Save done!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();
                editUser = null;
                listViewUSer.SelectedItems.Clear();
                listViewProduct.SelectedItems.Clear();

                LoadUSers();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            txtConfirm.Clear();
            txtEmail.Clear();
            txtFull.Clear();
            txtPassword.Clear();
        }

        private void LoadUSers()
        {
            var users = userManager.GetAllUSer();
            listViewUSer.Items.Clear();
            foreach (var u in users)
            {
                ListViewItem lvi = new ListViewItem(new String[] { u.Email, u.Fullname });
                lvi.Tag = u;
                listViewUSer.Items.Add(lvi);
            }
        }

        private void listViewUSer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUSer.SelectedItems.Count == 0)
                return;
            var user = listViewUSer.SelectedItems[0].Tag as User;

            editUser = user;

            LloadUserProduct(user);
        }

        private void LloadUserProduct(User user)
        {
            var product = user.GetProducts();
            listViewProduct.Items.Clear();
            foreach (var p in product)
            {
                ListViewItem lvi = new ListViewItem(new String[] { p.Reference, p.Name, p.Price.ToString() });
                lvi.Tag = p;
                listViewProduct.Items.Add(lvi);
            }
        }
        private void retourText(User user)
        {
            txtPassword.Text = user.Password;
            txtEmail.Text = user.Email;
            txtFull.Text = user.Fullname;
            txtConfirm.Text = user.Password;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (listViewUSer.SelectedItems.Count == 0)
                return;
            var user = listViewUSer.SelectedItems[0].Tag as User;
            retourText(user);
            editUser = user;
        }

        private void btnAddp_Click(object sender, EventArgs e)
        {
            if (listViewUSer.SelectedItems.Count == 0)
                return;
            var user = listViewUSer.SelectedItems[0].Tag as User;

            FormAdProduct form = new FormAdProduct(user);
            form.ShowDialog();
            LloadUserProduct(user);
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            Clear();
            editUser = null;
            listViewUSer.SelectedItems.Clear();
            listViewProduct.SelectedItems.Clear();
        }

        private void btnDeletep_Click(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 0)
                return;
            var user = listViewUSer.SelectedItems[0].Tag as User;
            var product = listViewProduct.SelectedItems[0].Tag as Product;
            userManager.RemoveUserProduct(user, product);
            LloadUserProduct(user);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditp_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }
    }
}
