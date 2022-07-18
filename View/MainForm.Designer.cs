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
            this.recipeMainUserControl2 = new RecipeBookApp.UserControls.RecipeMainUserControl();
            this.AddRecipetabPage = new System.Windows.Forms.TabPage();
            this.addRecipeDetailUserControl2 = new RecipeBookApp.UserControls.AddRecipeDetailUserControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.signUplabel = new System.Windows.Forms.LinkLabel();
            this.loginlinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.hometabPage.SuspendLayout();
            this.AddRecipetabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.hometabPage);
            this.tabControl1.Controls.Add(this.AddRecipetabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 173);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // hometabPage
            // 
            this.hometabPage.Controls.Add(this.recipeMainUserControl2);
            this.hometabPage.Location = new System.Drawing.Point(4, 22);
            this.hometabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hometabPage.Name = "hometabPage";
            this.hometabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hometabPage.Size = new System.Drawing.Size(977, 511);
            this.hometabPage.TabIndex = 0;
            this.hometabPage.Text = "Home";
            this.hometabPage.UseVisualStyleBackColor = true;
            // 
            // recipeMainUserControl2
            // 
            this.recipeMainUserControl2.Location = new System.Drawing.Point(7, 7);
            this.recipeMainUserControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recipeMainUserControl2.Name = "recipeMainUserControl2";
            this.recipeMainUserControl2.Size = new System.Drawing.Size(971, 499);
            this.recipeMainUserControl2.TabIndex = 0;
            this.recipeMainUserControl2.Load += new System.EventHandler(this.recipeMainUserControl2_Load);
            // 
            // AddRecipetabPage
            // 
            this.AddRecipetabPage.Controls.Add(this.addRecipeDetailUserControl2);
            this.AddRecipetabPage.Location = new System.Drawing.Point(4, 22);
            this.AddRecipetabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddRecipetabPage.Name = "AddRecipetabPage";
            this.AddRecipetabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddRecipetabPage.Size = new System.Drawing.Size(977, 525);
            this.AddRecipetabPage.TabIndex = 1;
            this.AddRecipetabPage.Text = "Add Recipe";
            this.AddRecipetabPage.UseVisualStyleBackColor = true;
            // 
            // addRecipeDetailUserControl2
            // 
            this.addRecipeDetailUserControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRecipeDetailUserControl2.Location = new System.Drawing.Point(2, 2);
            this.addRecipeDetailUserControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRecipeDetailUserControl2.Name = "addRecipeDetailUserControl2";
            this.addRecipeDetailUserControl2.Size = new System.Drawing.Size(973, 521);
            this.addRecipeDetailUserControl2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(294, 158);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(52, 13);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome";
            this.welcomeLabel.Visible = false;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(896, 156);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(68, 20);
            this.logoutLinkLabel.TabIndex = 3;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "LogOut";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // signUplabel
            // 
            this.signUplabel.AutoSize = true;
            this.signUplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUplabel.Location = new System.Drawing.Point(817, 156);
            this.signUplabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signUplabel.Name = "signUplabel";
            this.signUplabel.Size = new System.Drawing.Size(68, 20);
            this.signUplabel.TabIndex = 4;
            this.signUplabel.TabStop = true;
            this.signUplabel.Text = "SignUp";
            this.signUplabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUplabel_LinkClicked);
            // 
            // loginlinkLabel
            // 
            this.loginlinkLabel.AutoSize = true;
            this.loginlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlinkLabel.Location = new System.Drawing.Point(746, 156);
            this.loginlinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginlinkLabel.Name = "loginlinkLabel";
            this.loginlinkLabel.Size = new System.Drawing.Size(53, 20);
            this.loginlinkLabel.TabIndex = 5;
            this.loginlinkLabel.TabStop = true;
            this.loginlinkLabel.Text = "Login";
            this.loginlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginlinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 712);
            this.Controls.Add(this.loginlinkLabel);
            this.Controls.Add(this.signUplabel);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Recipe Book";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.hometabPage.ResumeLayout(false);
            this.AddRecipetabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage hometabPage;
        private System.Windows.Forms.TabPage AddRecipetabPage;
        private UserControls.AddRecipeDetailUserControl addRecipeDetailUserControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.RecipeMainUserControl recipeMainUserControl1;
        private UserControls.RecipeMainUserControl recipeMainUserControl2;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.LinkLabel signUplabel;
        private System.Windows.Forms.LinkLabel loginlinkLabel;
        private UserControls.AddRecipeDetailUserControl addRecipeDetailUserControl2;
    }
}