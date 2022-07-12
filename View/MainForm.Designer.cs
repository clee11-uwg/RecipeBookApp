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
            this.loginUserControl1 = new RecipeBookApp.UserControls.LoginUserControl();
            this.signUpPage = new System.Windows.Forms.TabPage();
            this.signUpUserControl1 = new RecipeBookApp.UserControls.SignUpUserControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recipeMainUserControl2 = new RecipeBookApp.UserControls.RecipeMainUserControl();
            this.addRecipeDetailUserControl2 = new RecipeBookApp.UserControls.AddRecipeDetailUserControl();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 220);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1347, 688);
            this.tabControl1.TabIndex = 0;
            // 
            // hometabPage
            // 
            this.hometabPage.Controls.Add(this.recipeMainUserControl2);
            this.hometabPage.Location = new System.Drawing.Point(4, 25);
            this.hometabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hometabPage.Name = "hometabPage";
            this.hometabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hometabPage.Size = new System.Drawing.Size(1339, 659);
            this.hometabPage.TabIndex = 0;
            this.hometabPage.Text = "Home";
            this.hometabPage.UseVisualStyleBackColor = true;
            // 
            // AddRecipetabPage
            // 
            this.AddRecipetabPage.Controls.Add(this.addRecipeDetailUserControl2);
            this.AddRecipetabPage.Location = new System.Drawing.Point(4, 25);
            this.AddRecipetabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRecipetabPage.Name = "AddRecipetabPage";
            this.AddRecipetabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRecipetabPage.Size = new System.Drawing.Size(1339, 659);
            this.AddRecipetabPage.TabIndex = 1;
            this.AddRecipetabPage.Text = "Add Recipe";
            this.AddRecipetabPage.UseVisualStyleBackColor = true;
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.loginUserControl1);
            this.loginPage.Location = new System.Drawing.Point(4, 25);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginPage.Size = new System.Drawing.Size(1339, 659);
            this.loginPage.TabIndex = 2;
            this.loginPage.Text = "Login";
            this.loginPage.UseVisualStyleBackColor = true;
            // 
            // loginUserControl1
            // 
            this.loginUserControl1.Location = new System.Drawing.Point(86, 57);
            this.loginUserControl1.Name = "loginUserControl1";
            this.loginUserControl1.Size = new System.Drawing.Size(884, 405);
            this.loginUserControl1.TabIndex = 0;
            // 
            // signUpPage
            // 
            this.signUpPage.Controls.Add(this.signUpUserControl1);
            this.signUpPage.Location = new System.Drawing.Point(4, 25);
            this.signUpPage.Name = "signUpPage";
            this.signUpPage.Padding = new System.Windows.Forms.Padding(3);
            this.signUpPage.Size = new System.Drawing.Size(1339, 659);
            this.signUpPage.TabIndex = 3;
            this.signUpPage.Text = "Sign Up";
            this.signUpPage.UseVisualStyleBackColor = true;
            // 
            // signUpUserControl1
            // 
            this.signUpUserControl1.Location = new System.Drawing.Point(76, 79);
            this.signUpUserControl1.Name = "signUpUserControl1";
            this.signUpUserControl1.Size = new System.Drawing.Size(771, 468);
            this.signUpUserControl1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1381, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // recipeMainUserControl2
            // 
            this.recipeMainUserControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeMainUserControl2.Location = new System.Drawing.Point(3, 2);
            this.recipeMainUserControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recipeMainUserControl2.Name = "recipeMainUserControl2";
            this.recipeMainUserControl2.Size = new System.Drawing.Size(1333, 655);
            this.recipeMainUserControl2.TabIndex = 0;
            // 
            // addRecipeDetailUserControl2
            // 
            this.addRecipeDetailUserControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRecipeDetailUserControl2.Location = new System.Drawing.Point(3, 2);
            this.addRecipeDetailUserControl2.Name = "addRecipeDetailUserControl2";
            this.addRecipeDetailUserControl2.Size = new System.Drawing.Size(1333, 655);
            this.addRecipeDetailUserControl2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1381, 847);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private UserControls.RecipeMainUserControl recipeMainUserControl2;
        private UserControls.AddRecipeDetailUserControl addRecipeDetailUserControl2;
    }
}