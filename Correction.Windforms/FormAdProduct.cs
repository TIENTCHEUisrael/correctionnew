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
    public partial class FormAdProduct : Form
    {
        private User user;
        private FormAdProduct()
        {
            InitializeComponent();
        }

        public FormAdProduct(User user) : this()
        {
            this.user = user;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager userManager = new UserManager();

                if (!double.TryParse(textPrice.Text, out _))
                    throw new Exception("Invalid price!");

                var product = new Product(txtReference.Text, txtName.Text, double.Parse(textPrice.Text));

                userManager.AddUserProduct(user, product);

                MessageBox.Show($"Product added", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAdProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
