namespace RecipeBookApp.View
{
    partial class RecipeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeDetails));
            this.titleLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ingredientsHeadingLbl = new System.Windows.Forms.Label();
            this.kitchenwareHeadingLbl = new System.Windows.Forms.Label();
            this.ingredientsListView = new System.Windows.Forms.ListView();
            this.kitchenwareListView = new System.Windows.Forms.ListView();
            this.instructionsTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 133);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(735, 24);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ingredientsHeadingLbl
            // 
            this.ingredientsHeadingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsHeadingLbl.Location = new System.Drawing.Point(30, 180);
            this.ingredientsHeadingLbl.Name = "ingredientsHeadingLbl";
            this.ingredientsHeadingLbl.Size = new System.Drawing.Size(224, 33);
            this.ingredientsHeadingLbl.TabIndex = 2;
            this.ingredientsHeadingLbl.Text = "Ingredients";
            this.ingredientsHeadingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kitchenwareHeadingLbl
            // 
            this.kitchenwareHeadingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchenwareHeadingLbl.Location = new System.Drawing.Point(292, 184);
            this.kitchenwareHeadingLbl.Name = "kitchenwareHeadingLbl";
            this.kitchenwareHeadingLbl.Size = new System.Drawing.Size(224, 24);
            this.kitchenwareHeadingLbl.TabIndex = 3;
            this.kitchenwareHeadingLbl.Text = "Kitchen-ware";
            this.kitchenwareHeadingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ingredientsListView
            // 
            this.ingredientsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ingredientsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsListView.HideSelection = false;
            this.ingredientsListView.Location = new System.Drawing.Point(56, 216);
            this.ingredientsListView.Name = "ingredientsListView";
            this.ingredientsListView.Size = new System.Drawing.Size(173, 174);
            this.ingredientsListView.TabIndex = 4;
            this.ingredientsListView.UseCompatibleStateImageBehavior = false;
            this.ingredientsListView.View = System.Windows.Forms.View.List;
            // 
            // kitchenwareListView
            // 
            this.kitchenwareListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kitchenwareListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchenwareListView.HideSelection = false;
            this.kitchenwareListView.Location = new System.Drawing.Point(316, 216);
            this.kitchenwareListView.Name = "kitchenwareListView";
            this.kitchenwareListView.Size = new System.Drawing.Size(173, 174);
            this.kitchenwareListView.TabIndex = 5;
            this.kitchenwareListView.UseCompatibleStateImageBehavior = false;
            this.kitchenwareListView.View = System.Windows.Forms.View.List;
            // 
            // instructionsTxtBx
            // 
            this.instructionsTxtBx.BackColor = System.Drawing.Color.White;
            this.instructionsTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionsTxtBx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.instructionsTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsTxtBx.Location = new System.Drawing.Point(0, 422);
            this.instructionsTxtBx.Multiline = true;
            this.instructionsTxtBx.Name = "instructionsTxtBx";
            this.instructionsTxtBx.ReadOnly = true;
            this.instructionsTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.instructionsTxtBx.Size = new System.Drawing.Size(759, 324);
            this.instructionsTxtBx.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Steps";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RecipeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 746);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructionsTxtBx);
            this.Controls.Add(this.kitchenwareListView);
            this.Controls.Add(this.ingredientsListView);
            this.Controls.Add(this.kitchenwareHeadingLbl);
            this.Controls.Add(this.ingredientsHeadingLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RecipeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ingredientsHeadingLbl;
        private System.Windows.Forms.Label kitchenwareHeadingLbl;
        private System.Windows.Forms.ListView ingredientsListView;
        private System.Windows.Forms.ListView kitchenwareListView;
        private System.Windows.Forms.TextBox instructionsTxtBx;
        private System.Windows.Forms.Label label1;
    }
}