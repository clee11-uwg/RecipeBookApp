using RecipeBookApp.Controller;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LogoutClear();
        }


        private void LoginlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            using (Form loginDialog = new View.LoginFormDialog())
            {
                DialogResult result = loginDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.LoginDisplay();
                    this.recipeMainUserControl2.SetUser(UserController.GetLoginUser());
                    this.recipeMainUserControl2.Reset();
                }
            }
        }

        private void DisplayUserDetails()
        {
            if (UserController.GetLoginUser() != null)
            {
                this.welcomeLabel.ForeColor = Color.White;
                this.welcomeLabel.BackColor = Color.Orange;
                this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                this.welcomeLabel.Text = "Welcome " + UserController.GetLoginUser().Name.ToUpper() + " to the Recipe App !";
                this.welcomeLabel.Visible = true;
                this.logoutLinkLabel.Visible = true;
                this.tabControl1.TabPages.Add(AddRecipetabPage);
                this.loginlinkLabel.Visible = false;
                this.signUplabel.Visible = false;
            }

        }

        private void SignUplabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Form signUpDialog = new View.SignUpFormDialog())
            {
                DialogResult result = signUpDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "You are about to logout from the RecipeApp, Please confirm?";
            string title = "Log Out Recipe App";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.LogoutClear();
                this.recipeMainUserControl2.SetUser(UserController.GetLoginUser());
                this.recipeMainUserControl2.Reset();
            }
            
        }

        private void LogoutClear()
        {
            UserController.SetLoginUser(null);
            this.loginlinkLabel.Visible = true;
            this.signUplabel.Visible = true;
            this.logoutLinkLabel.Visible = false;
            this.welcomeLabel.Text = "";
            this.welcomeLabel.Visible = false;
           this.tabControl1.TabPages.Remove(AddRecipetabPage);
        }

        private void LoginDisplay()
        {
            this.DisplayUserDetails();           
            
        }

        private void recipeMainUserControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
