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
            this.confirmPasswordSignUpText = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.userIDSignUpText = new System.Windows.Forms.TextBox();
            this.passwordSignUpText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.42542F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.57458F));
            this.tableLayoutPanel1.Controls.Add(this.confirmPasswordSignUpText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.userNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.newPasswordLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.userIDSignUpText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordSignUpText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.signupButton, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.21906F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.67892F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.72479F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.37723F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 405);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // confirmPasswordSignUpText
            // 
            this.confirmPasswordSignUpText.Location = new System.Drawing.Point(262, 213);
            this.confirmPasswordSignUpText.Name = "confirmPasswordSignUpText";
            this.confirmPasswordSignUpText.Size = new System.Drawing.Size(375, 22);
            this.confirmPasswordSignUpText.TabIndex = 8;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(3, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(95, 22);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User ID : ";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(3, 210);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(206, 25);
            this.newPasswordLabel.TabIndex = 5;
            this.newPasswordLabel.Text = "Confirm Password : ";
            // 
            // userIDSignUpText
            // 
            this.userIDSignUpText.Location = new System.Drawing.Point(262, 3);
            this.userIDSignUpText.Name = "userIDSignUpText";
            this.userIDSignUpText.Size = new System.Drawing.Size(375, 22);
            this.userIDSignUpText.TabIndex = 6;
            // 
            // passwordSignUpText
            // 
            this.passwordSignUpText.Location = new System.Drawing.Point(262, 101);
            this.passwordSignUpText.Name = "passwordSignUpText";
            this.passwordSignUpText.Size = new System.Drawing.Size(375, 22);
            this.passwordSignUpText.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(3, 98);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(125, 25);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password : ";
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.Location = new System.Drawing.Point(262, 309);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(154, 52);
            this.signupButton.TabIndex = 3;
            this.signupButton.Text = "SignUp";
            this.signupButton.UseVisualStyleBackColor = false;
            // 
            // SignUpFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SignUpFormDialog";
            this.Text = "SignUpFormDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox confirmPasswordSignUpText;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox userIDSignUpText;
        private System.Windows.Forms.TextBox passwordSignUpText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button signupButton;
    }
}