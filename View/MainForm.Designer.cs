namespace RecipeBookApp.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.hometabPage = new System.Windows.Forms.TabPage();
            this.AddRecipetabPage = new System.Windows.Forms.TabPage();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.signUpPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addRecipeDetailUserControl2 = new RecipeBookApp.UserControls.AddRecipeDetailUserControl();
            this.loginUserControl1 = new RecipeBookApp.UserControls.LoginUserControl();
            this.signUpUserControl1 = new RecipeBookApp.UserControls.SignUpUserControl();
            this.recipeMainUserControl2 = new RecipeBookApp.UserControls.RecipeMainUserControl();
            this.tabControl1.SuspendLayout();
            this.hometabPage.SuspendLayout();
            this.AddRecipetabPage.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.signUpPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.hometabPage);
            this.tabControl1.Controls.Add(this.AddRecipetabPage);
            this.tabControl1.Controls.Add(this.loginPage);
            this.tabControl1.Controls.Add(this.signUpPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 179);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // hometabPage
            // 
            this.hometabPage.Controls.Add(this.recipeMainUserControl2);
            this.hometabPage.Location = new System.Drawing.Point(4, 22);
            this.hometabPage.Margin = new System.Windows.Forms.Padding(2);
            this.hometabPage.Name = "hometabPage";
            this.hometabPage.Padding = new System.Windows.Forms.Padding(2);
            this.hometabPage.Size = new System.Drawing.Size(977, 506);
            this.hometabPage.TabIndex = 0;
            this.hometabPage.Text = "Home";
            this.hometabPage.UseVisualStyleBackColor = true;
            // 
            // AddRecipetabPage
            // 
            this.AddRecipetabPage.Controls.Add(this.addRecipeDetailUserControl2);
            this.AddRecipetabPage.Location = new System.Drawing.Point(4, 22);
            this.AddRecipetabPage.Margin = new System.Windows.Forms.Padding(2);
            this.AddRecipetabPage.Name = "AddRecipetabPage";
            this.AddRecipetabPage.Padding = new System.Windows.Forms.Padding(2);
            this.AddRecipetabPage.Size = new System.Drawing.Size(977, 506);
            this.AddRecipetabPage.TabIndex = 1;
            this.AddRecipetabPage.Text = "Add Recipe";
            this.AddRecipetabPage.UseVisualStyleBackColor = true;
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.loginUserControl1);
            this.loginPage.Location = new System.Drawing.Point(4, 22);
            this.loginPage.Margin = new System.Windows.Forms.Padding(2);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(2);
            this.loginPage.Size = new System.Drawing.Size(977, 506);
            this.loginPage.TabIndex = 2;
            this.loginPage.Text = "Login";
            this.loginPage.UseVisualStyleBackColor = true;
            // 
            // signUpPage
            // 
            this.signUpPage.Controls.Add(this.signUpUserControl1);
            this.signUpPage.Location = new System.Drawing.Point(4, 22);
            this.signUpPage.Margin = new System.Windows.Forms.Padding(2);
            this.signUpPage.Name = "signUpPage";
            this.signUpPage.Padding = new System.Windows.Forms.Padding(2);
            this.signUpPage.Size = new System.Drawing.Size(977, 506);
            this.signUpPage.TabIndex = 3;
            this.signUpPage.Text = "Sign Up";
            this.signUpPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // addRecipeDetailUserControl2
            // 
            this.addRecipeDetailUserControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRecipeDetailUserControl2.Location = new System.Drawing.Point(2, 2);
            this.addRecipeDetailUserControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRecipeDetailUserControl2.Name = "addRecipeDetailUserControl2";
            this.addRecipeDetailUserControl2.Size = new System.Drawing.Size(973, 502);
            this.addRecipeDetailUserControl2.TabIndex = 0;
            // 
            // loginUserControl1
            // 
            this.loginUserControl1.Location = new System.Drawing.Point(64, 46);
            this.loginUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginUserControl1.Name = "loginUserControl1";
            this.loginUserControl1.Size = new System.Drawing.Size(663, 329);
            this.loginUserControl1.TabIndex = 0;
            // 
            // signUpUserControl1
            // 
            this.signUpUserControl1.Location = new System.Drawing.Point(57, 64);
            this.signUpUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signUpUserControl1.Name = "signUpUserControl1";
            this.signUpUserControl1.Size = new System.Drawing.Size(578, 380);
            this.signUpUserControl1.TabIndex = 0;
            // 
            // recipeMainUserControl2
            // 
            this.recipeMainUserControl2.Location = new System.Drawing.Point(7, 7);
            this.recipeMainUserControl2.Margin = new System.Windows.Forms.Padding(2);
            this.recipeMainUserControl2.Name = "recipeMainUserControl2";
            this.recipeMainUserControl2.Size = new System.Drawing.Size(971, 499);
            this.recipeMainUserControl2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 714);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Recipe Book";
            this.tabControl1.ResumeLayout(false);
            this.hometabPage.ResumeLayout(false);
            this.AddRecipetabPage.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.signUpPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage hometabPage;
        private System.Windows.Forms.TabPage AddRecipetabPage;
        private UserControls.AddRecipeDetailUserControl addRecipeDetailUserControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.RecipeMainUserControl recipeMainUserControl1;
        private System.Windows.Forms.TabPage loginPage;
        private System.Windows.Forms.TabPage signUpPage;
        private UserControls.LoginUserControl loginUserControl1;
        private UserControls.SignUpUserControl signUpUserControl1;
        private UserControls.AddRecipeDetailUserControl addRecipeDetailUserControl2;
        private UserControls.RecipeMainUserControl recipeMainUserControl2;
    }
}