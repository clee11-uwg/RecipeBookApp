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
            this.instructionsTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ingredientsLbl = new System.Windows.Forms.Label();
            this.kitchenwareLbl = new System.Windows.Forms.Label();
            this.typeOfMealLbl = new System.Windows.Forms.Label();
            this.allergenHeadingLbl = new System.Windows.Forms.Label();
            this.allergenListLbl = new System.Windows.Forms.Label();
            this.mealTypeHeadingLbl = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
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
            // instructionsTxtBx
            // 
            this.instructionsTxtBx.BackColor = System.Drawing.Color.White;
            this.instructionsTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionsTxtBx.Cursor = System.Windows.Forms.Cursors.Default;
            this.instructionsTxtBx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.instructionsTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsTxtBx.ForeColor = System.Drawing.Color.Black;
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
            // ingredientsLbl
            // 
            this.ingredientsLbl.AutoSize = true;
            this.ingredientsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLbl.Location = new System.Drawing.Point(76, 213);
            this.ingredientsLbl.MinimumSize = new System.Drawing.Size(200, 100);
            this.ingredientsLbl.Name = "ingredientsLbl";
            this.ingredientsLbl.Size = new System.Drawing.Size(200, 100);
            this.ingredientsLbl.TabIndex = 8;
            // 
            // kitchenwareLbl
            // 
            this.kitchenwareLbl.AutoSize = true;
            this.kitchenwareLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchenwareLbl.Location = new System.Drawing.Point(325, 213);
            this.kitchenwareLbl.MinimumSize = new System.Drawing.Size(200, 100);
            this.kitchenwareLbl.Name = "kitchenwareLbl";
            this.kitchenwareLbl.Size = new System.Drawing.Size(200, 100);
            this.kitchenwareLbl.TabIndex = 9;
            // 
            // typeOfMealLbl
            // 
            this.typeOfMealLbl.AutoSize = true;
            this.typeOfMealLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfMealLbl.Location = new System.Drawing.Point(547, 293);
            this.typeOfMealLbl.MinimumSize = new System.Drawing.Size(200, 75);
            this.typeOfMealLbl.Name = "typeOfMealLbl";
            this.typeOfMealLbl.Size = new System.Drawing.Size(200, 75);
            this.typeOfMealLbl.TabIndex = 10;
            this.typeOfMealLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // allergenHeadingLbl
            // 
            this.allergenHeadingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allergenHeadingLbl.Location = new System.Drawing.Point(562, 184);
            this.allergenHeadingLbl.Name = "allergenHeadingLbl";
            this.allergenHeadingLbl.Size = new System.Drawing.Size(169, 24);
            this.allergenHeadingLbl.TabIndex = 11;
            this.allergenHeadingLbl.Text = "Allergens";
            this.allergenHeadingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allergenListLbl
            // 
            this.allergenListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allergenListLbl.Location = new System.Drawing.Point(547, 213);
            this.allergenListLbl.MinimumSize = new System.Drawing.Size(200, 40);
            this.allergenListLbl.Name = "allergenListLbl";
            this.allergenListLbl.Size = new System.Drawing.Size(200, 40);
            this.allergenListLbl.TabIndex = 12;
            this.allergenListLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mealTypeHeadingLbl
            // 
            this.mealTypeHeadingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealTypeHeadingLbl.Location = new System.Drawing.Point(562, 269);
            this.mealTypeHeadingLbl.Name = "mealTypeHeadingLbl";
            this.mealTypeHeadingLbl.Size = new System.Drawing.Size(169, 24);
            this.mealTypeHeadingLbl.TabIndex = 13;
            this.mealTypeHeadingLbl.Text = "Meal Type(s)";
            this.mealTypeHeadingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Tan;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(558, 136);
            this.editButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(56, 24);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Tan;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(619, 136);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(68, 24);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Tan;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(688, 136);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(59, 24);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RecipeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 746);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.mealTypeHeadingLbl);
            this.Controls.Add(this.allergenListLbl);
            this.Controls.Add(this.allergenHeadingLbl);
            this.Controls.Add(this.typeOfMealLbl);
            this.Controls.Add(this.kitchenwareLbl);
            this.Controls.Add(this.ingredientsLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructionsTxtBx);
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
        private System.Windows.Forms.TextBox instructionsTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ingredientsLbl;
        private System.Windows.Forms.Label kitchenwareLbl;
        private System.Windows.Forms.Label typeOfMealLbl;
        private System.Windows.Forms.Label allergenHeadingLbl;
        private System.Windows.Forms.Label allergenListLbl;
        private System.Windows.Forms.Label mealTypeHeadingLbl;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
    }
}