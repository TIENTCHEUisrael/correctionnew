
namespace Correction.Windforms
{
    partial class FormUSer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewUSer = new System.Windows.Forms.ListView();
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fullnmae = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.Reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFull = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblusers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddp = new System.Windows.Forms.Button();
            this.btnDeletep = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnSaave = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnEditp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewUSer
            // 
            this.listViewUSer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewUSer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Email,
            this.Fullnmae});
            this.listViewUSer.FullRowSelect = true;
            this.listViewUSer.GridLines = true;
            this.listViewUSer.HideSelection = false;
            this.listViewUSer.Location = new System.Drawing.Point(252, 17);
            this.listViewUSer.Margin = new System.Windows.Forms.Padding(4);
            this.listViewUSer.Name = "listViewUSer";
            this.listViewUSer.Size = new System.Drawing.Size(385, 203);
            this.listViewUSer.TabIndex = 0;
            this.listViewUSer.UseCompatibleStateImageBehavior = false;
            this.listViewUSer.View = System.Windows.Forms.View.Details;
            this.listViewUSer.SelectedIndexChanged += new System.EventHandler(this.listViewUSer_SelectedIndexChanged);
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 187;
            // 
            // Fullnmae
            // 
            this.Fullnmae.Text = "Fullname";
            this.Fullnmae.Width = 198;
            // 
            // listViewProduct
            // 
            this.listViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Reference,
            this.Name,
            this.Price});
            this.listViewProduct.FullRowSelect = true;
            this.listViewProduct.GridLines = true;
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(252, 246);
            this.listViewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(385, 190);
            this.listViewProduct.TabIndex = 1;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            // 
            // Reference
            // 
            this.Reference.Text = "Reference";
            this.Reference.Width = 135;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 136;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 117;
            // 
            // txtFull
            // 
            this.txtFull.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFull.Location = new System.Drawing.Point(17, 86);
            this.txtFull.Margin = new System.Windows.Forms.Padding(4);
            this.txtFull.Name = "txtFull";
            this.txtFull.Size = new System.Drawing.Size(212, 24);
            this.txtFull.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.Location = new System.Drawing.Point(17, 163);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 24);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPassword.Location = new System.Drawing.Point(17, 236);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(212, 24);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtConfirm.Location = new System.Drawing.Point(17, 318);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(212, 24);
            this.txtConfirm.TabIndex = 3;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblusers
            // 
            this.lblusers.AutoSize = true;
            this.lblusers.Location = new System.Drawing.Point(249, 224);
            this.lblusers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusers.Name = "lblusers";
            this.lblusers.Size = new System.Drawing.Size(46, 18);
            this.lblusers.TabIndex = 6;
            this.lblusers.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fullname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirm password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(645, 17);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 35);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit User";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(645, 75);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(984, 588);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 47);
            this.button4.TabIndex = 14;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAddp
            // 
            this.btnAddp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddp.Location = new System.Drawing.Point(645, 246);
            this.btnAddp.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddp.Name = "btnAddp";
            this.btnAddp.Size = new System.Drawing.Size(145, 35);
            this.btnAddp.TabIndex = 7;
            this.btnAddp.Text = "Add User Product";
            this.btnAddp.UseVisualStyleBackColor = true;
            this.btnAddp.Click += new System.EventHandler(this.btnAddp_Click);
            // 
            // btnDeletep
            // 
            this.btnDeletep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletep.Location = new System.Drawing.Point(645, 289);
            this.btnDeletep.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletep.Name = "btnDeletep";
            this.btnDeletep.Size = new System.Drawing.Size(145, 35);
            this.btnDeletep.TabIndex = 8;
            this.btnDeletep.Text = "Del User Product";
            this.btnDeletep.UseVisualStyleBackColor = true;
            this.btnDeletep.Click += new System.EventHandler(this.btnDeletep_Click);
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Location = new System.Drawing.Point(645, 394);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(145, 35);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnSaave
            // 
            this.btnSaave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaave.ForeColor = System.Drawing.Color.Green;
            this.btnSaave.Location = new System.Drawing.Point(127, 369);
            this.btnSaave.Name = "btnSaave";
            this.btnSaave.Size = new System.Drawing.Size(102, 35);
            this.btnSaave.TabIndex = 4;
            this.btnSaave.Text = "Save";
            this.btnSaave.UseVisualStyleBackColor = true;
            this.btnSaave.Click += new System.EventHandler(this.btnSaave_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.ForeColor = System.Drawing.Color.Green;
            this.btnRetry.Location = new System.Drawing.Point(17, 369);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(104, 36);
            this.btnRetry.TabIndex = 19;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnEditp
            // 
            this.btnEditp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditp.Location = new System.Drawing.Point(645, 331);
            this.btnEditp.Name = "btnEditp";
            this.btnEditp.Size = new System.Drawing.Size(145, 34);
            this.btnEditp.TabIndex = 9;
            this.btnEditp.Text = "Edit User Product";
            this.btnEditp.UseVisualStyleBackColor = true;
            this.btnEditp.Click += new System.EventHandler(this.btnEditp_Click);
            // 
            // FormUSer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 449);
            this.Controls.Add(this.btnEditp);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnSaave);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnDeletep);
            this.Controls.Add(this.btnAddp);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblusers);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFull);
            this.Controls.Add(this.listViewProduct);
            this.Controls.Add(this.listViewUSer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
           // this.Name = "FormUSer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewUSer;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.TextBox txtFull;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblusers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddp;
        private System.Windows.Forms.Button btnDeletep;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnSaave;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Fullnmae;
        private System.Windows.Forms.ColumnHeader Reference;
        private new System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button btnEditp;
    }
}