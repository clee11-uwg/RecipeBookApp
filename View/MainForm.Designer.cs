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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addRecipeDetailUserControl1 = new RecipeBookApp.UserControls.AddRecipeDetailUserControl();
            this.recipeMainUserControl1 = new RecipeBookApp.UserControls.RecipeMainUserControl();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 179);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 559);
            this.tabControl1.TabIndex = 0;
            // 
            // hometabPage
            // 
            this.hometabPage.Controls.Add(this.recipeMainUserControl1);
            this.hometabPage.Location = new System.Drawing.Point(4, 22);
            this.hometabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hometabPage.Name = "hometabPage";
            this.hometabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hometabPage.Size = new System.Drawing.Size(1002, 533);
            this.hometabPage.TabIndex = 0;
            this.hometabPage.Text = "Home";
            this.hometabPage.UseVisualStyleBackColor = true;
            // 
            // AddRecipetabPage
            // 
            this.AddRecipetabPage.Controls.Add(this.addRecipeDetailUserControl1);
            this.AddRecipetabPage.Location = new System.Drawing.Point(4, 22);
            this.AddRecipetabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddRecipetabPage.Name = "AddRecipetabPage";
            this.AddRecipetabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddRecipetabPage.Size = new System.Drawing.Size(1002, 533);
            this.AddRecipetabPage.TabIndex = 1;
            this.AddRecipetabPage.Text = "Add Recipe";
            this.AddRecipetabPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // addRecipeDetailUserControl1
            // 
            this.addRecipeDetailUserControl1.Location = new System.Drawing.Point(0, 6);
            this.addRecipeDetailUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRecipeDetailUserControl1.Name = "addRecipeDetailUserControl1";
            this.addRecipeDetailUserControl1.Size = new System.Drawing.Size(983, 417);
            this.addRecipeDetailUserControl1.TabIndex = 0;
            // 
            // recipeMainUserControl1
            // 
            this.recipeMainUserControl1.Location = new System.Drawing.Point(-2, 4);
            this.recipeMainUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.recipeMainUserControl1.Name = "recipeMainUserControl1";
            this.recipeMainUserControl1.Size = new System.Drawing.Size(1002, 533);
            this.recipeMainUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 736);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Recipe Book";
            this.tabControl1.ResumeLayout(false);
            this.hometabPage.ResumeLayout(false);
            this.AddRecipetabPage.ResumeLayout(false);
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
    }
}