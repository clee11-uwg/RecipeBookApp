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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeListItem));
            this.picBoxRecipeImage = new System.Windows.Forms.PictureBox();
            this.lblTile = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRecipeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxRecipeImage
            // 
            this.picBoxRecipeImage.Location = new System.Drawing.Point(34, 14);
            this.picBoxRecipeImage.Name = "picBoxRecipeImage";
            this.picBoxRecipeImage.Size = new System.Drawing.Size(198, 99);
            this.picBoxRecipeImage.TabIndex = 0;
            this.picBoxRecipeImage.TabStop = false;
            // 
            // lblTile
            // 
            this.lblTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.Location = new System.Drawing.Point(3, 134);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(259, 24);
            this.lblTile.TabIndex = 1;
            this.lblTile.Text = "Title";
            this.lblTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoEllipsis = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(13, 158);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(235, 108);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = resources.GetString("lblDesc.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 131);
            this.panel1.TabIndex = 3;
            // 
            // RecipeListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.picBoxRecipeImage);
            this.Controls.Add(this.panel1);
            this.Name = "RecipeListItem";
            this.Size = new System.Drawing.Size(265, 278);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRecipeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxRecipeImage;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel panel1;
    }
}
