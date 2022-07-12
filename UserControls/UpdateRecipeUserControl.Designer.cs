namespace RecipeBookApp.UserControls
{
    partial class UpdateRecipeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recipeNameTextBox = new System.Windows.Forms.TextBox();
            this.updateRecipeLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recipeNameTextBox
            // 
            this.recipeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeNameTextBox.Location = new System.Drawing.Point(109, 44);
            this.recipeNameTextBox.Name = "recipeNameTextBox";
            this.recipeNameTextBox.Size = new System.Drawing.Size(293, 26);
            this.recipeNameTextBox.TabIndex = 1;
            // 
            // updateRecipeLbl
            // 
            this.updateRecipeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRecipeLbl.Location = new System.Drawing.Point(3, 6);
            this.updateRecipeLbl.Name = "updateRecipeLbl";
            this.updateRecipeLbl.Size = new System.Drawing.Size(587, 25);
            this.updateRecipeLbl.TabIndex = 0;
            this.updateRecipeLbl.Text = "Update Recipe";
            this.updateRecipeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recipe Name:";
            // 
            // UpdateRecipeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateRecipeLbl);
            this.Controls.Add(this.recipeNameTextBox);
            this.Name = "UpdateRecipeUserControl";
            this.Size = new System.Drawing.Size(593, 316);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox recipeNameTextBox;
        private System.Windows.Forms.Label updateRecipeLbl;
        private System.Windows.Forms.Label label2;
    }
}
