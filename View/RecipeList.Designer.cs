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
            this.allergenComboBox = new System.Windows.Forms.ComboBox();
            this.ingredientsComboBox = new System.Windows.Forms.ComboBox();
            this.mealTypeComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.applyFiltertableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ethnicLabel = new System.Windows.Forms.Label();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.allergenLabel = new System.Windows.Forms.Label();
            this.ethnicComboBox = new System.Windows.Forms.ComboBox();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 172);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1245, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 284);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(13, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 12, 13, 12);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1245, 666);
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
            this.searchTextBox.Location = new System.Drawing.Point(317, 182);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(435, 28);
            this.searchTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(776, 176);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(109, 34);
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
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(157, 37);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // allergenComboBox
            // 
            this.allergenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allergenComboBox.FormattingEnabled = true;
            this.allergenComboBox.Location = new System.Drawing.Point(3, 23);
            this.allergenComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allergenComboBox.Name = "allergenComboBox";
            this.allergenComboBox.Size = new System.Drawing.Size(121, 24);
            this.allergenComboBox.TabIndex = 9;
            this.allergenComboBox.SelectedIndexChanged += new System.EventHandler(this.AllergenComboBox_SelectedIndexChanged);
            this.allergenComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllergenComboBox_KeyPress);
            // 
            // ingredientsComboBox
            // 
            this.ingredientsComboBox.FormattingEnabled = true;
            this.ingredientsComboBox.Location = new System.Drawing.Point(481, 23);
            this.ingredientsComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingredientsComboBox.Name = "ingredientsComboBox";
            this.ingredientsComboBox.Size = new System.Drawing.Size(121, 24);
            this.ingredientsComboBox.TabIndex = 11;
            this.ingredientsComboBox.SelectedIndexChanged += new System.EventHandler(this.IngredientsComboBox_SelectedIndexChanged);
            this.ingredientsComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngredientsComboBox_KeyPress);
            // 
            // mealTypeComboBox
            // 
            this.mealTypeComboBox.FormattingEnabled = true;
            this.mealTypeComboBox.Location = new System.Drawing.Point(242, 23);
            this.mealTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealTypeComboBox.Name = "mealTypeComboBox";
            this.mealTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.mealTypeComboBox.TabIndex = 12;
            this.mealTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.MealTypeComboBox_SelectedIndexChanged);
            this.mealTypeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MealTypeComboBox_KeyPress);
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.LightSalmon;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(959, 23);
            this.filterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(177, 34);
            this.filterButton.TabIndex = 13;
            this.filterButton.Text = "Apply Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // applyFiltertableLayoutPanel
            // 
            this.applyFiltertableLayoutPanel.ColumnCount = 5;
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.19288F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.19288F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.19288F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.19288F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.22847F));
            this.applyFiltertableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applyFiltertableLayoutPanel.Controls.Add(this.ethnicLabel, 3, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.ingredientsLabel, 2, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.mealLabel, 1, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.allergenLabel, 0, 0);
            this.applyFiltertableLayoutPanel.Controls.Add(this.allergenComboBox, 0, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.ingredientsComboBox, 2, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.mealTypeComboBox, 1, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.ethnicComboBox, 3, 1);
            this.applyFiltertableLayoutPanel.Controls.Add(this.filterButton, 4, 1);
            this.applyFiltertableLayoutPanel.Location = new System.Drawing.Point(12, 217);
            this.applyFiltertableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyFiltertableLayoutPanel.Name = "applyFiltertableLayoutPanel";
            this.applyFiltertableLayoutPanel.RowCount = 2;
            this.applyFiltertableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.applyFiltertableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.applyFiltertableLayoutPanel.Size = new System.Drawing.Size(1187, 62);
            this.applyFiltertableLayoutPanel.TabIndex = 14;
            // 
            // ethnicLabel
            // 
            this.ethnicLabel.AutoSize = true;
            this.ethnicLabel.Location = new System.Drawing.Point(720, 0);
            this.ethnicLabel.Name = "ethnicLabel";
            this.ethnicLabel.Size = new System.Drawing.Size(43, 16);
            this.ethnicLabel.TabIndex = 18;
            this.ethnicLabel.Text = "Ethnic";
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Location = new System.Drawing.Point(481, 0);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(73, 16);
            this.ingredientsLabel.TabIndex = 16;
            this.ingredientsLabel.Text = "Ingredients";
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(242, 0);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(69, 16);
            this.mealLabel.TabIndex = 15;
            this.mealLabel.Text = "MealType";
            // 
            // allergenLabel
            // 
            this.allergenLabel.AutoSize = true;
            this.allergenLabel.Location = new System.Drawing.Point(3, 0);
            this.allergenLabel.Name = "allergenLabel";
            this.allergenLabel.Size = new System.Drawing.Size(57, 16);
            this.allergenLabel.TabIndex = 14;
            this.allergenLabel.Text = "Allergen";
            // 
            // ethnicComboBox
            // 
            this.ethnicComboBox.FormattingEnabled = true;
            this.ethnicComboBox.Location = new System.Drawing.Point(720, 23);
            this.ethnicComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ethnicComboBox.Name = "ethnicComboBox";
            this.ethnicComboBox.Size = new System.Drawing.Size(113, 24);
            this.ethnicComboBox.TabIndex = 19;
            this.ethnicComboBox.SelectedIndexChanged += new System.EventHandler(this.EthnicComboBox_SelectedIndexChanged);
            this.ethnicComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EthnicComboBox_KeyPress);
            // 
            // RecipeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 956);
            this.Controls.Add(this.applyFiltertableLayoutPanel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox allergenComboBox;
        private System.Windows.Forms.ComboBox ingredientsComboBox;
        private System.Windows.Forms.ComboBox mealTypeComboBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TableLayoutPanel applyFiltertableLayoutPanel;
        private System.Windows.Forms.Label allergenLabel;
        private System.Windows.Forms.Label ethnicLabel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.ComboBox ethnicComboBox;
    }
}

