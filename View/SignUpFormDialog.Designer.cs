namespace RecipeBookApp.View
{
    partial class SignUpFormDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.signupMessageLabel = new System.Windows.Forms.Label();
            this.confirmPasswordSignUpText = new System.Windows.Forms.TextBox();
            this.passwordSignUpText = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.userIDSignUpText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.backButtom = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::RecipeBookApp.Properties.Resources.logimimage_3;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.42542F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.57458F));
            this.tableLayoutPanel1.Controls.Add(this.signupMessageLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.confirmPasswordSignUpText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.passwordSignUpText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.newPasswordLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.passwordLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.userNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.90654F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.42991F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.97196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.69159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 563);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // signupMessageLabel
            // 
            this.signupMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signupMessageLabel.AutoSize = true;
            this.signupMessageLabel.Location = new System.Drawing.Point(806, 304);
            this.signupMessageLabel.Name = "signupMessageLabel";
            this.signupMessageLabel.Size = new System.Drawing.Size(35, 16);
            this.signupMessageLabel.TabIndex = 12;
            this.signupMessageLabel.Text = "error";
            // 
            // confirmPasswordSignUpText
            // 
            this.confirmPasswordSignUpText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmPasswordSignUpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordSignUpText.Location = new System.Drawing.Point(406, 261);
            this.confirmPasswordSignUpText.Name = "confirmPasswordSignUpText";
            this.confirmPasswordSignUpText.Size = new System.Drawing.Size(371, 28);
            this.confirmPasswordSignUpText.TabIndex = 8;
            this.confirmPasswordSignUpText.TextChanged += new System.EventHandler(this.ConfirmPasswordSignUpText_TextChanged);
            // 
            // passwordSignUpText
            // 
            this.passwordSignUpText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordSignUpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSignUpText.Location = new System.Drawing.Point(406, 189);
            this.passwordSignUpText.Name = "passwordSignUpText";
            this.passwordSignUpText.Size = new System.Drawing.Size(371, 28);
            this.passwordSignUpText.TabIndex = 7;
            this.passwordSignUpText.Click += new System.EventHandler(this.PasswordSignUpText_Click);
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(194, 263);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(206, 25);
            this.newPasswordLabel.TabIndex = 5;
            this.newPasswordLabel.Text = "Confirm Password : ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(275, 190);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(125, 25);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password : ";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(305, 114);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(95, 22);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User ID : ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.28249F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7175F));
            this.tableLayoutPanel2.Controls.Add(this.isAdminCheckBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.userIDSignUpText, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(406, 94);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(577, 62);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.isAdminCheckBox.AutoSize = true;
            this.isAdminCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAdminCheckBox.Location = new System.Drawing.Point(472, 16);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(95, 29);
            this.isAdminCheckBox.TabIndex = 10;
            this.isAdminCheckBox.Text = "Admin";
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // userIDSignUpText
            // 
            this.userIDSignUpText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userIDSignUpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDSignUpText.Location = new System.Drawing.Point(3, 17);
            this.userIDSignUpText.Name = "userIDSignUpText";
            this.userIDSignUpText.Size = new System.Drawing.Size(463, 28);
            this.userIDSignUpText.TabIndex = 6;
            this.userIDSignUpText.TextChanged += new System.EventHandler(this.UserIDSignUpText_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.backButtom, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.signupButton, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(406, 339);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(562, 100);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // backButtom
            // 
            this.backButtom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backButtom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButtom.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.backButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButtom.Location = new System.Drawing.Point(304, 3);
            this.backButtom.Name = "backButtom";
            this.backButtom.Size = new System.Drawing.Size(235, 46);
            this.backButtom.TabIndex = 11;
            this.backButtom.Text = "Go Back To Home Page";
            this.backButtom.UseVisualStyleBackColor = false;
            // 
            // signupButton
            // 
            this.signupButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signupButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.Location = new System.Drawing.Point(63, 3);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(154, 46);
            this.signupButton.TabIndex = 3;
            this.signupButton.Text = "SignUp";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // SignUpFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SignUpFormDialog";
            this.Text = "SignUpFormDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Button backButtom;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.CheckBox isAdminCheckBox;
        private System.Windows.Forms.Label signupMessageLabel;
        private System.Windows.Forms.TextBox confirmPasswordSignUpText;
        private System.Windows.Forms.TextBox passwordSignUpText;
        private System.Windows.Forms.TextBox userIDSignUpText;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}