using RecipeBookApp.Controller;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBookApp.View
{
    public partial class SignUpFormDialog : Form
    {
        private readonly UserController userController;
        private User newRegisteruser;
        public SignUpFormDialog()
        {
            InitializeComponent();
            this.signupMessageLabel.Visible = false;
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            this.CreateUser();
        }

        private void CreateUser()
        {
            if (string.IsNullOrEmpty(this.userIDSignUpText.Text.Trim()) ||
                string.IsNullOrEmpty(this.passwordSignUpText.Text.Trim()) ||
                string.IsNullOrEmpty(this.confirmPasswordSignUpText.Text.Trim()))
            {
                this.signupMessageLabel.Text = "User Name and password cannot be empty!";
                this.signupMessageLabel.ForeColor = Color.Red;
                this.signupMessageLabel.Visible = true;
                return;
            }

            else if (!this.passwordSignUpText.Text.Equals(this.confirmPasswordSignUpText.Text))
            {
                this.signupMessageLabel.Text = "Password is not matching reenter your password again!";
                this.signupMessageLabel.ForeColor = Color.Red;
                this.passwordSignUpText.BackColor = Color.OrangeRed;
                this.confirmPasswordSignUpText.BackColor = Color.OrangeRed;
                this.confirmPasswordSignUpText.Focus();
                this.signupMessageLabel.Visible = true;
                return;

            }
            bool isAdminChecked = isAdminCheckBox.Checked;
            this.newRegisteruser = new User
            {
                Name = this.userIDSignUpText.Text,
                Password = this.passwordSignUpText.Text,
                Is_Admin = isAdminChecked

            };

            this.userController.AddUser(newRegisteruser);

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
