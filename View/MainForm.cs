﻿using RecipeBookApp.Controller;
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
                if (UserController.GetLoginUser() != null)
            {
                this.welcomeLabel.ForeColor = Color.SandyBrown;
                this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                this.welcomeLabel.Text = "Welcome " + UserController.GetLoginUser().Name.ToUpper() + " to the Recipe App !";
                this.welcomeLabel.Visible = true;
                this.logoutLinkLabel.Visible = true;
                tabControl1.TabPages.Remove(loginPage);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LoginlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            using (Form loginDialog = new View.LoginFormDialog())
            {
                DialogResult result = loginDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //this.Reset();

                    
                }
            }
        }
    }
}
