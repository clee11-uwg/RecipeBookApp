namespace RecipeBookApp.UserControls
{
    partial class RecipeListItem
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
            this.picBoxRecipeImage = new System.Windows.Forms.PictureBox();
            this.lblTile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRecipeImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxRecipeImage
            // 
            this.picBoxRecipeImage.Location = new System.Drawing.Point(0, 0);
            this.picBoxRecipeImage.Name = "picBoxRecipeImage";
            this.picBoxRecipeImage.Size = new System.Drawing.Size(266, 149);
            this.picBoxRecipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRecipeImage.TabIndex = 0;
            this.picBoxRecipeImage.TabStop = false;
            // 
            // lblTile
            // 
            this.lblTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.Location = new System.Drawing.Point(2, 160);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(259, 24);
            this.lblTile.TabIndex = 1;
            this.lblTile.Text = "Title";
            this.lblTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.picBoxRecipeImage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 149);
            this.panel1.TabIndex = 3;
            // 
            // RecipeListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 15);
            this.Name = "RecipeListItem";
            this.Size = new System.Drawing.Size(264, 197);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRecipeImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxRecipeImage;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Panel panel1;
    }
}
