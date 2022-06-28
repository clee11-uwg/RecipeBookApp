namespace RecipeBookApp
{
    partial class RecipeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.nutritionComboBox = new System.Windows.Forms.ComboBox();
            this.allergenComboBox = new System.Windows.Forms.ComboBox();
            this.kitchenWareComboBox = new System.Windows.Forms.ComboBox();
            this.ingredientsComboBox = new System.Windows.Forms.ComboBox();
            this.mealTypeComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.applyFiltertableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.foodLabel = new System.Windows.Forms.Label();
            this.ethnicLabel = new System.Windows.Forms.Label();
            this.kitchenLabel = new System.Windows.Forms.Label();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.allergenLabel = new System.Windows.Forms.Label();
            this.nutritionLabel = new System.Windows.Forms.Label();
            this.ethnicComboBox = new System.Windows.Forms.ComboBox();
            this.foodComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.applyFiltertableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 172);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1183, 172);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 284);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 12, 13, 12);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1183, 666);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(109, 178);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(186, 25);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Search Your Recipe";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(318, 182);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(435, 28);
            this.searchTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(776, 176);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 35);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(892, 174);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 37);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // nutritionComboBox
            // 
            this.nutritionComboBox.FormattingEnabled = true;
            this.nutritionComboBox.Location = new System.Drawing.Point(3, 23);
            this.nutritionComboBox.Name = "nutritionComboBox";
            this.nutritionComboBox.Size = new System.Drawing.Size(121, 24);
            this.nutritionComboBox.TabIndex = 8;
            this.nutritionComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NutritionComboBox_KeyPress);
            // 
            // allergenComboBox
            // 
            this.allergenComboBox.FormattingEnabled = true;
            this.allergenComboBox.Location = new System.Drawing.Point(151, 23);
            this.allergenComboBox.Name = "allergenComboBox";
            this.allergenComboBox.Size = new System.Drawing.Size(121, 24);
            this.allergenComboBox.TabIndex = 9;
            this.allergenComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllergenComboBox_KeyPress);
            // 
            // kitchenWareComboBox
            // 
            this.kitchenWareComboBox.FormattingEnabled = true;
            this.kitchenWareComboBox.Location = new System.Drawing.Point(595, 23);
            this.kitchenWareComboBox.Name = "kitchenWareComboBox";
            this.kitchenWareComboBox.Size = new System.Drawing.Size(121, 24);
            this.kitchenWareComboBox.TabIndex = 10;
            this.kitchenWareComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KitchenWareComboBox_KeyPress);
            // 
            // ingredientsComboBox
            // 
            this.ingredientsComboBox.FormattingEnabled = true;
            this.ingredientsComboBox.Location = new System.Drawing.Point(447, 23);
            this.ingredientsComboBox.Name = "ingredientsComboBox";
            this.ingredientsComboBox.Size = new System.Drawing.Size(121, 24);
            this.ingredientsComboBox.TabIndex = 11;
            this.ingredientsComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngredientsComboBox_KeyPress);
            // 
            // mealTypeComboBox
            // 
            this.mealTypeComboBox.FormattingEnabled = true;
            this.mealTypeComboBox.Location = new System.Drawing.Point(299, 23);
            this.mealTypeComboBox.Name = "mealTypeComboBox";
            this.mealTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.mealTypeComboBox.TabIndex = 12;
            this.mealTypeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MealTypeComboBox_KeyPress);
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.LightSalmon;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(1024, 23);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(132, 35);
            this.filterButton.TabIndex = 13;
            this.filterButton.Text = "Apply Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // applyFiltertableLayoutPanel
            // 
            this.applyFiltertableLayoutPanel.ColumnCount = 8;
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82052F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.applyFiltertableLayoutPanel.Controls.Add(this.foodLabel, 6, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.ethnicLabel, 5, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.kitchenLabel, 4, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.ingredientsLabel, 3, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.mealLabel, 2, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.allergenLabel, 1, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.nutritionComboBox, 0, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.allergenComboBox, 1, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.kitchenWareComboBox, 4, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.ingredientsComboBox, 3, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.mealTypeComboBox, 2, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.nutritionLabel, 0, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.ethnicComboBox, 5, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.foodComboBox, 6, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.filterButton, 7, 1);
            this.applyFiltertableLayoutPanel.Location = new System.Drawing.Point(12, 216);
            this.applyFiltertableLayoutPanel.Name = "applyFiltertableLayoutPanel";
            this.applyFiltertableLayoutPanel.RowCount = 2;
            this.applyFiltertableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.applyFiltertableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.applyFiltertableLayoutPanel.Size = new System.Drawing.Size(1159, 61);
            this.applyFiltertableLayoutPanel.TabIndex = 14;
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Location = new System.Drawing.Point(891, 0);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(71, 16);
            this.foodLabel.TabIndex = 20;
            this.foodLabel.Text = "FoodType";
            // 
            // ethnicLabel
            // 
            this.ethnicLabel.AutoSize = true;
            this.ethnicLabel.Location = new System.Drawing.Point(743, 0);
            this.ethnicLabel.Name = "ethnicLabel";
            this.ethnicLabel.Size = new System.Drawing.Size(43, 16);
            this.ethnicLabel.TabIndex = 18;
            this.ethnicLabel.Text = "Ethnic";
            // 
            // kitchenLabel
            // 
            this.kitchenLabel.AutoSize = true;
            this.kitchenLabel.Location = new System.Drawing.Point(595, 0);
            this.kitchenLabel.Name = "kitchenLabel";
            this.kitchenLabel.Size = new System.Drawing.Size(83, 16);
            this.kitchenLabel.TabIndex = 17;
            this.kitchenLabel.Text = "KitchenWare";
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Location = new System.Drawing.Point(447, 0);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(73, 16);
            this.ingredientsLabel.TabIndex = 16;
            this.ingredientsLabel.Text = "Ingredients";
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(299, 0);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(69, 16);
            this.mealLabel.TabIndex = 15;
            this.mealLabel.Text = "MealType";
            // 
            // allergenLabel
            // 
            this.allergenLabel.AutoSize = true;
            this.allergenLabel.Location = new System.Drawing.Point(151, 0);
            this.allergenLabel.Name = "allergenLabel";
            this.allergenLabel.Size = new System.Drawing.Size(57, 16);
            this.allergenLabel.TabIndex = 14;
            this.allergenLabel.Text = "Allergen";
            // 
            // nutritionLabel
            // 
            this.nutritionLabel.AutoSize = true;
            this.nutritionLabel.Location = new System.Drawing.Point(3, 0);
            this.nutritionLabel.Name = "nutritionLabel";
            this.nutritionLabel.Size = new System.Drawing.Size(55, 16);
            this.nutritionLabel.TabIndex = 13;
            this.nutritionLabel.Text = "Nutrition";
            // 
            // ethnicComboBox
            // 
            this.ethnicComboBox.FormattingEnabled = true;
            this.ethnicComboBox.Location = new System.Drawing.Point(743, 23);
            this.ethnicComboBox.Name = "ethnicComboBox";
            this.ethnicComboBox.Size = new System.Drawing.Size(114, 24);
            this.ethnicComboBox.TabIndex = 19;
            this.ethnicComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EthnicComboBox_KeyPress);
            // 
            // foodComboBox
            // 
            this.foodComboBox.FormattingEnabled = true;
            this.foodComboBox.Location = new System.Drawing.Point(891, 23);
            this.foodComboBox.Name = "foodComboBox";
            this.foodComboBox.Size = new System.Drawing.Size(114, 24);
            this.foodComboBox.TabIndex = 21;
            this.foodComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodComboBox_KeyPress);
            // 
            // RecipeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 956);
            this.Controls.Add(this.applyFiltertableLayoutPanel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecipeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Recipe App";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.applyFiltertableLayoutPanel.ResumeLayout(false);
            this.applyFiltertableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox nutritionComboBox;
        private System.Windows.Forms.ComboBox allergenComboBox;
        private System.Windows.Forms.ComboBox kitchenWareComboBox;
        private System.Windows.Forms.ComboBox ingredientsComboBox;
        private System.Windows.Forms.ComboBox mealTypeComboBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TableLayoutPanel applyFiltertableLayoutPanel;
        private System.Windows.Forms.Label allergenLabel;
        private System.Windows.Forms.Label nutritionLabel;
        private System.Windows.Forms.Label ethnicLabel;
        private System.Windows.Forms.Label kitchenLabel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.ComboBox ethnicComboBox;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.ComboBox foodComboBox;
    }
}

