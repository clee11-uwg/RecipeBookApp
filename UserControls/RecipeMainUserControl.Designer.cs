namespace RecipeBookApp.UserControls
{
    partial class RecipeMainUserControl
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
            this.ethnicLabel = new System.Windows.Forms.Label();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.ingredientsComboBox = new System.Windows.Forms.ComboBox();
            this.applyFiltertableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.allergenLabel = new System.Windows.Forms.Label();
            this.allergenComboBox = new System.Windows.Forms.ComboBox();
            this.mealTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ethnicComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.applyFiltertableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ethnicLabel
            // 
            this.ethnicLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ethnicLabel.AutoSize = true;
            this.ethnicLabel.Location = new System.Drawing.Point(664, 1);
            this.ethnicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ethnicLabel.Name = "ethnicLabel";
            this.ethnicLabel.Size = new System.Drawing.Size(37, 13);
            this.ethnicLabel.TabIndex = 18;
            this.ethnicLabel.Text = "Ethnic";
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Location = new System.Drawing.Point(458, 1);
            this.ingredientsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(59, 13);
            this.ingredientsLabel.TabIndex = 16;
            this.ingredientsLabel.Text = "Ingredients";
            // 
            // mealLabel
            // 
            this.mealLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(265, 1);
            this.mealLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(54, 13);
            this.mealLabel.TabIndex = 15;
            this.mealLabel.Text = "MealType";
            // 
            // ingredientsComboBox
            // 
            this.ingredientsComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingredientsComboBox.FormattingEnabled = true;
            this.ingredientsComboBox.Location = new System.Drawing.Point(441, 20);
            this.ingredientsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ingredientsComboBox.Name = "ingredientsComboBox";
            this.ingredientsComboBox.Size = new System.Drawing.Size(92, 21);
            this.ingredientsComboBox.TabIndex = 11;
            this.ingredientsComboBox.SelectedIndexChanged += new System.EventHandler(this.IngredientsComboBox_SelectedIndexChanged);
            // 
            // applyFiltertableLayoutPanel
            // 
            this.applyFiltertableLayoutPanel.ColumnCount = 5;
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.19288F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.19288F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.19288F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.19288F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.22847F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.applyFiltertableLayoutPanel.Controls.Add(this.ethnicLabel, 3, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.ingredientsLabel, 2, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.mealLabel, 1, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.allergenLabel, 0, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.allergenComboBox, 0, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.mealTypeComboBox, 1, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.ethnicComboBox, 3, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.filterButton, 4, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.ingredientsComboBox, 2, 1);
            this.applyFiltertableLayoutPanel.Location = new System.Drawing.Point(26, 43);
            this.applyFiltertableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.applyFiltertableLayoutPanel.Name = "applyFiltertableLayoutPanel";
            this.applyFiltertableLayoutPanel.RowCount = 2;
            this.applyFiltertableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.applyFiltertableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.applyFiltertableLayoutPanel.Size = new System.Drawing.Size(968, 46);
            this.applyFiltertableLayoutPanel.TabIndex = 21;
            // 
            // allergenLabel
            // 
            this.allergenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allergenLabel.AutoSize = true;
            this.allergenLabel.Location = new System.Drawing.Point(75, 1);
            this.allergenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allergenLabel.Name = "allergenLabel";
            this.allergenLabel.Size = new System.Drawing.Size(45, 13);
            this.allergenLabel.TabIndex = 14;
            this.allergenLabel.Text = "Allergen";
            // 
            // allergenComboBox
            // 
            this.allergenComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allergenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allergenComboBox.FormattingEnabled = true;
            this.allergenComboBox.Location = new System.Drawing.Point(51, 20);
            this.allergenComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allergenComboBox.Name = "allergenComboBox";
            this.allergenComboBox.Size = new System.Drawing.Size(92, 21);
            this.allergenComboBox.TabIndex = 9;
            this.allergenComboBox.SelectedIndexChanged += new System.EventHandler(this.AllergenComboBox_SelectedIndexChanged);
            // 
            // mealTypeComboBox
            // 
            this.mealTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealTypeComboBox.FormattingEnabled = true;
            this.mealTypeComboBox.Location = new System.Drawing.Point(246, 20);
            this.mealTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mealTypeComboBox.Name = "mealTypeComboBox";
            this.mealTypeComboBox.Size = new System.Drawing.Size(92, 21);
            this.mealTypeComboBox.TabIndex = 12;
            this.mealTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.MealTypeComboBox_SelectedIndexChanged);
            // 
            // ethnicComboBox
            // 
            this.ethnicComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ethnicComboBox.FormattingEnabled = true;
            this.ethnicComboBox.Location = new System.Drawing.Point(639, 20);
            this.ethnicComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ethnicComboBox.Name = "ethnicComboBox";
            this.ethnicComboBox.Size = new System.Drawing.Size(86, 21);
            this.ethnicComboBox.TabIndex = 19;
            this.ethnicComboBox.SelectedIndexChanged += new System.EventHandler(this.EthnicComboBox_SelectedIndexChanged);
            // 
            // filterButton
            // 
            this.filterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filterButton.BackColor = System.Drawing.Color.LightSalmon;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(807, 17);
            this.filterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(133, 27);
            this.filterButton.TabIndex = 13;
            this.filterButton.Text = "Apply Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(726, 4);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(82, 28);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(828, 3);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 31);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(187, 6);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(519, 24);
            this.searchTextBox.TabIndex = 18;
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(16, 8);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(152, 20);
            this.searchLabel.TabIndex = 17;
            this.searchLabel.Text = "Search Your Recipe";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 94);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(35, 10, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1002, 434);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.56284F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.30054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49798F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49798F));
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(946, 37);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // RecipeMainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.applyFiltertableLayoutPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RecipeMainUserControl";
            this.Size = new System.Drawing.Size(1002, 533);
            this.Load += new System.EventHandler(this.RecipeMainUserControl_Load);
            this.applyFiltertableLayoutPanel.ResumeLayout(false);
            this.applyFiltertableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ethnicLabel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.ComboBox ingredientsComboBox;
        private System.Windows.Forms.TableLayoutPanel applyFiltertableLayoutPanel;
        private System.Windows.Forms.Label allergenLabel;
        private System.Windows.Forms.ComboBox allergenComboBox;
        private System.Windows.Forms.ComboBox mealTypeComboBox;
        private System.Windows.Forms.ComboBox ethnicComboBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
