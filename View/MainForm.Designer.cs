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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.hometabPage = new System.Windows.Forms.TabPage();
            this.recipeMainUserControl1 = new RecipeBookApp.UserControls.RecipeMainUserControl();
            this.AddRecipetabPage = new System.Windows.Forms.TabPage();
            this.addRecipeDetailUserControl1 = new RecipeBookApp.UserControls.AddRecipeDetailUserControl();
            this.tabControl1.SuspendLayout();
            this.hometabPage.SuspendLayout();
            this.AddRecipetabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.hometabPage);
            this.tabControl1.Controls.Add(this.AddRecipetabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1346, 908);
            this.tabControl1.TabIndex = 0;
            // 
            // hometabPage
            // 
            this.hometabPage.Controls.Add(this.recipeMainUserControl1);
            this.hometabPage.Location = new System.Drawing.Point(4, 25);
            this.hometabPage.Name = "hometabPage";
            this.hometabPage.Padding = new System.Windows.Forms.Padding(3);
            this.hometabPage.Size = new System.Drawing.Size(1338, 879);
            this.hometabPage.TabIndex = 0;
            this.hometabPage.Text = "Home";
            this.hometabPage.UseVisualStyleBackColor = true;
            // 
            // recipeMainUserControl1
            // 
            this.recipeMainUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeMainUserControl1.Location = new System.Drawing.Point(3, 3);
            this.recipeMainUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.recipeMainUserControl1.Name = "recipeMainUserControl1";
            this.recipeMainUserControl1.Size = new System.Drawing.Size(1332, 873);
            this.recipeMainUserControl1.TabIndex = 0;
            // 
            // AddRecipetabPage
            // 
            this.AddRecipetabPage.Controls.Add(this.addRecipeDetailUserControl1);
            this.AddRecipetabPage.Location = new System.Drawing.Point(4, 25);
            this.AddRecipetabPage.Name = "AddRecipetabPage";
            this.AddRecipetabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddRecipetabPage.Size = new System.Drawing.Size(1338, 696);
            this.AddRecipetabPage.TabIndex = 1;
            this.AddRecipetabPage.Text = "Add Recipe";
            this.AddRecipetabPage.UseVisualStyleBackColor = true;
            // 
            // addRecipeDetailUserControl1
            // 
            this.addRecipeDetailUserControl1.Location = new System.Drawing.Point(11, 24);
            this.addRecipeDetailUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.addRecipeDetailUserControl1.Name = "addRecipeDetailUserControl1";
            this.addRecipeDetailUserControl1.Size = new System.Drawing.Size(1580, 731);
            this.addRecipeDetailUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 906);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "DigitalRecipe";
            this.tabControl1.ResumeLayout(false);
            this.hometabPage.ResumeLayout(false);
            this.AddRecipetabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage hometabPage;
        private System.Windows.Forms.TabPage AddRecipetabPage;
        private UserControls.RecipeMainUserControl recipeMainUserControl1;
        private UserControls.AddRecipeDetailUserControl addRecipeDetailUserControl1;
    }
}