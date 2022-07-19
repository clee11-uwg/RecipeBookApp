using RecipeBookApp.Controller;
using RecipeBookApp.Model;
using RecipeBookApp.Utility;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
            this.userIDSignUpText.Focus();
            this.userController = new UserController();
            this.signupMessageLabel.Visible = false;
          //  this.userIDSignUpText.Focus();
            this.confirmPasswordSignUpText.PasswordChar = '*';
            this.passwordSignUpText.PasswordChar = '*';
          
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
            else if (!Regex.IsMatch(this.userIDSignUpText.Text, "[a-zA-Z]"))
            {
                this.signupMessageLabel.Text = "User Name should be a valid string!";
                this.signupMessageLabel.ForeColor = Color.Red;
                this.signupMessageLabel.Visible = true;
                return;
            }
            else if (this.userIDSignUpText.Text.Length < 5 || this.userIDSignUpText.Text.Length > 10)
            {
                this.signupMessageLabel.Text = "User Name should not be less than 5 or greater than 10 char!";
                this.signupMessageLabel.ForeColor = Color.Red;
                this.signupMessageLabel.Visible = true;
                return;
            }
            else if (this.passwordSignUpText.Text.Length < 5 || this.passwordSignUpText.Text.Length > 8)
            {
                this.signupMessageLabel.Text = "Passsword cannot exceed 8 char length or should not be less than 5 char!";
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
                
                this.signupMessageLabel.Visible = true;
                return;

            }
            else if (this.passwordSignUpText.Text.Length > 8  || this.confirmPasswordSignUpText.Text.Length > 8)
            {
                signupMessageLabel.Text = "Passsword cannot be exceed 8 char length!";
                signupMessageLabel.ForeColor = Color.Red;
                signupMessageLabel.Visible = true;
                this.signupMessageLabel.ForeColor = Color.Red;
                this.passwordSignUpText.BackColor = Color.OrangeRed;
                return;
            }
            try
            {
                bool isAdminChecked = isAdminCheckBox.Checked;
          
                this.newRegisteruser = new User
                {
                    Name = this.userIDSignUpText.Text,
                    Password = this.passwordSignUpText.Text,
                    Is_Admin = isAdminChecked

                };

                if (this.userController.AddUser(newRegisteruser))
                {
                    this.signupMessageLabel.Text = "Congratulations! You are registered, Please login using your credentials!";
                    this.signupMessageLabel.ForeColor = Color.Green;
                    this.signupMessageLabel.Visible = true;
                }

            }
            catch (Exception ex)
            {
                this.signupMessageLabel.Text = ex.Message;
                this.signupMessageLabel.ForeColor = Color.Red;
                this.signupMessageLabel.Visible = true;
                this.userIDSignUpText.BackColor = Color.OrangeRed;
                this.userIDSignUpText.Focus();
               
               return;
            }

        }

        private void Reset()
        {
            this.signupMessageLabel.Text = "";
            this.signupMessageLabel.ForeColor = Color.Black;
            this.signupMessageLabel.Visible = false;
            this.passwordSignUpText.BackColor = Color.White;
            this.confirmPasswordSignUpText.BackColor = Color.White;
            this.userIDSignUpText.BackColor = Color.White;

        }


        private void PasswordSignUpText_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        

        private void ConfirmPasswordSignUpText_TextChanged(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void UserIDSignUpText_TextChanged(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void SignUpFormDialog_Load(object sender, EventArgs e)
        {
            this.userIDSignUpText.Focus();
        }
    }   
}
