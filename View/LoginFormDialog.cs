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
    public partial class LoginFormDialog : Form
    {
        private readonly UserController userController;
        private User welcomeUser;
        public LoginFormDialog()
        {
            InitializeComponent();
            this.userController = new UserController();
            this.ControlBox = false;
            this.loginErrorLabelText.Visible = false;
            this.welcomeLabel.Visible = false;
            this.welcomeUser = new User();
            this.currentPasswordTextBox.PasswordChar = '*';
            this.newPassowrdTextBox.PasswordChar = '*';
            this.newPassowrdTextBox.MaxLength = 8;
            this.changePasswordButton.Visible = false;


        }
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {

            if (this.changePasswordButton.Text == "Submit")

            {
                this.ProcessNewPassword();
            }
            Reset();
            this.newPassowrdTextBox.Visible = true;
            this.newPasswordLabel.Visible = true;
            this.loginButton.Visible = false;
            this.changePasswordButton.Text = "Submit";
           
        }

        private void ProcessNewPassword()
        {
            if (string.IsNullOrEmpty(this.userNameTextBox.Text.Trim()) || string.IsNullOrEmpty(this.currentPasswordTextBox.Text.Trim()) || string.IsNullOrEmpty(this.newPassowrdTextBox.Text.Trim()))
            {
                loginErrorLabelText.Text = "User Name and password cannot be empty!";
                loginErrorLabelText.ForeColor = Color.Red;
                loginErrorLabelText.Visible = true;
                return;
            }
            if (this.newPassowrdTextBox.MaxLength > 8)
            {
                loginErrorLabelText.Text = "Passsword cannot be exceed 8 char length!";
                loginErrorLabelText.ForeColor = Color.Red;
                loginErrorLabelText.Visible = true;
                return;
            }
           this.userController.ChangeUserPassword(UserController.GetLoginUser(), this.currentPasswordTextBox.Text, this.newPassowrdTextBox.Text);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.ValidateUser();
        }

        private void ValidateUser()
        {
            if (string.IsNullOrEmpty(this.userNameTextBox.Text) || string.IsNullOrEmpty(this.currentPasswordTextBox.Text))
            {
                loginErrorLabelText.Text = "User Name and password cannot be empty!";
                loginErrorLabelText.ForeColor = Color.Red;
                loginErrorLabelText.Visible = true;
                return;
            }
           
            try
            {
                this.welcomeUser = this.userController.Login(this.userNameTextBox.Text, this.currentPasswordTextBox.Text);
                this.loginErrorLabelText.Text = "You have login successfully!";
                this.loginErrorLabelText.ForeColor = Color.Green;
                this.loginErrorLabelText.Visible = true;
                this.welcomeLabel.ForeColor = Color.White;
                this.welcomeLabel.BackColor = Color.Orange;
                this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                this.welcomeLabel.Text = "Welcome " + this.welcomeUser.Name.ToUpper() + " to the Recipe App !";
              
                this.welcomeLabel.Visible = true;
                UserController.SetLoginUser(this.welcomeUser);
                this.changePasswordButton.Visible = true;


            }
            catch (Exception ex)
            {
                this.loginErrorLabelText.Text = ex.Message;
                this.loginErrorLabelText.ForeColor = Color.Red;
                this.loginErrorLabelText.Visible = true;
                return;
            }
        }
        private void Reset()
        {
            this.loginErrorLabelText.Text = "";
            this.loginErrorLabelText.Visible = false;
            this.newPassowrdTextBox.Visible = false;
            this.newPasswordLabel.Visible = false;

        }
    }
}
