namespace RecipeBookApp.View
{
    partial class UpdateRecipeForm
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
            this.updateRecipeUserControl1 = new RecipeBookApp.UserControls.UpdateRecipeUserControl();
            this.SuspendLayout();
            // 
            // updateRecipeUserControl1
            // 
            this.updateRecipeUserControl1.Location = new System.Drawing.Point(3, 5);
            this.updateRecipeUserControl1.Name = "updateRecipeUserControl1";
            this.updateRecipeUserControl1.Size = new System.Drawing.Size(862, 692);
            this.updateRecipeUserControl1.TabIndex = 0;
            // 
            // UpdateRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 700);
            this.Controls.Add(this.updateRecipeUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateRecipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Recipe";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UpdateRecipeUserControl updateRecipeUserControl1;
    }
}