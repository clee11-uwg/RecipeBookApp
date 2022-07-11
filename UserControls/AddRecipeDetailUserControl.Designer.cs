namespace RecipeBookApp.UserControls
{
    partial class AddRecipeDetailUserControl
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
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addNutritionLabel = new System.Windows.Forms.Label();
            this.nutritionLabel = new System.Windows.Forms.Label();
            this.kitchenWareLabel = new System.Windows.Forms.Label();
            this.addIngredientCombobox = new System.Windows.Forms.ComboBox();
            this.addKitchenWareComboBox = new System.Windows.Forms.ComboBox();
            this.addIngredIentsRichBox = new System.Windows.Forms.RichTextBox();
            this.addKitchenwareRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addRecipenameTextBox = new System.Windows.Forms.TextBox();
            this.foodTypeLabel = new System.Windows.Forms.Label();
            this.mealTypeLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.ethnicLabel = new System.Windows.Forms.Label();
            this.addRecipeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addEthnicCombobox = new System.Windows.Forms.ComboBox();
            this.ingredientsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kitchenWareTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addRecipeMealTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addFoodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.servingtextBox = new System.Windows.Forms.TextBox();
            this.fattextBox = new System.Windows.Forms.TextBox();
            this.calorieTextBox = new System.Windows.Forms.TextBox();
            this.alchoholTextBox = new System.Windows.Forms.TextBox();
            this.carbLabel = new System.Windows.Forms.Label();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.calorisLabel = new System.Windows.Forms.Label();
            this.servingLabel = new System.Windows.Forms.Label();
            this.alcoholLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.carbTextBox = new System.Windows.Forms.TextBox();
            this.proteinTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addRecipeTableLayoutPanel.SuspendLayout();
            this.ingredientsTableLayoutPanel.SuspendLayout();
            this.kitchenWareTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNameLabel
            // 
            this.addNameLabel.AutoSize = true;
            this.addNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNameLabel.Location = new System.Drawing.Point(3, 0);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(181, 67);
            this.addNameLabel.TabIndex = 0;
            this.addNameLabel.Text = "* RecipeName -";
            // 
            // addNutritionLabel
            // 
            this.addNutritionLabel.AutoSize = true;
            this.addNutritionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNutritionLabel.Location = new System.Drawing.Point(3, 67);
            this.addNutritionLabel.Name = "addNutritionLabel";
            this.addNutritionLabel.Size = new System.Drawing.Size(107, 20);
            this.addNutritionLabel.TabIndex = 1;
            this.addNutritionLabel.Text = "* Nutrition -";
            // 
            // nutritionLabel
            // 
            this.nutritionLabel.AutoSize = true;
            this.nutritionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutritionLabel.Location = new System.Drawing.Point(3, 151);
            this.nutritionLabel.Name = "nutritionLabel";
            this.nutritionLabel.Size = new System.Drawing.Size(128, 20);
            this.nutritionLabel.TabIndex = 2;
            this.nutritionLabel.Text = "* Ingredients -";
            // 
            // kitchenWareLabel
            // 
            this.kitchenWareLabel.AutoSize = true;
            this.kitchenWareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchenWareLabel.Location = new System.Drawing.Point(3, 199);
            this.kitchenWareLabel.Name = "kitchenWareLabel";
            this.kitchenWareLabel.Size = new System.Drawing.Size(138, 20);
            this.kitchenWareLabel.TabIndex = 3;
            this.kitchenWareLabel.Text = "* Kitchenware -";
            // 
            // addIngredientCombobox
            // 
            this.addIngredientCombobox.FormattingEnabled = true;
            this.addIngredientCombobox.Location = new System.Drawing.Point(366, 3);
            this.addIngredientCombobox.Name = "addIngredientCombobox";
            this.addIngredientCombobox.Size = new System.Drawing.Size(246, 24);
            this.addIngredientCombobox.TabIndex = 10;
            this.addIngredientCombobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddIngredientCombobox_KeyPress);
            // 
            // addKitchenWareComboBox
            // 
            this.addKitchenWareComboBox.FormattingEnabled = true;
            this.addKitchenWareComboBox.Location = new System.Drawing.Point(364, 3);
            this.addKitchenWareComboBox.Name = "addKitchenWareComboBox";
            this.addKitchenWareComboBox.Size = new System.Drawing.Size(221, 24);
            this.addKitchenWareComboBox.TabIndex = 11;
            this.addKitchenWareComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddKitchenWareComboBox_KeyPress);
            // 
            // addIngredIentsRichBox
            // 
            this.addIngredIentsRichBox.Location = new System.Drawing.Point(3, 3);
            this.addIngredIentsRichBox.Name = "addIngredIentsRichBox";
            this.addIngredIentsRichBox.ReadOnly = true;
            this.addIngredIentsRichBox.Size = new System.Drawing.Size(357, 36);
            this.addIngredIentsRichBox.TabIndex = 14;
            this.addIngredIentsRichBox.Text = "";
            // 
            // addKitchenwareRichTextBox
            // 
            this.addKitchenwareRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.addKitchenwareRichTextBox.Name = "addKitchenwareRichTextBox";
            this.addKitchenwareRichTextBox.ReadOnly = true;
            this.addKitchenwareRichTextBox.Size = new System.Drawing.Size(339, 38);
            this.addKitchenwareRichTextBox.TabIndex = 15;
            this.addKitchenwareRichTextBox.Text = "";
            // 
            // addRecipenameTextBox
            // 
            this.addRecipenameTextBox.Location = new System.Drawing.Point(190, 3);
            this.addRecipenameTextBox.Name = "addRecipenameTextBox";
            this.addRecipenameTextBox.Size = new System.Drawing.Size(378, 22);
            this.addRecipenameTextBox.TabIndex = 5;
            // 
            // foodTypeLabel
            // 
            this.foodTypeLabel.AutoSize = true;
            this.foodTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodTypeLabel.Location = new System.Drawing.Point(3, 333);
            this.foodTypeLabel.Name = "foodTypeLabel";
            this.foodTypeLabel.Size = new System.Drawing.Size(103, 20);
            this.foodTypeLabel.TabIndex = 17;
            this.foodTypeLabel.Text = "FoodType -";
            // 
            // mealTypeLabel
            // 
            this.mealTypeLabel.AutoSize = true;
            this.mealTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealTypeLabel.Location = new System.Drawing.Point(3, 249);
            this.mealTypeLabel.Name = "mealTypeLabel";
            this.mealTypeLabel.Size = new System.Drawing.Size(121, 20);
            this.mealTypeLabel.TabIndex = 18;
            this.mealTypeLabel.Text = "* Meal Type -";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLabel.Location = new System.Drawing.Point(3, 467);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(110, 20);
            this.imageLabel.TabIndex = 19;
            this.imageLabel.Text = "Add Image -";
            // 
            // ethnicLabel
            // 
            this.ethnicLabel.AutoSize = true;
            this.ethnicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ethnicLabel.Location = new System.Drawing.Point(3, 400);
            this.ethnicLabel.Name = "ethnicLabel";
            this.ethnicLabel.Size = new System.Drawing.Size(75, 20);
            this.ethnicLabel.TabIndex = 20;
            this.ethnicLabel.Text = "Ethnic -";
            // 
            // addRecipeTableLayoutPanel
            // 
            this.addRecipeTableLayoutPanel.ColumnCount = 2;
            this.addRecipeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.34712F));
            this.addRecipeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.65288F));
            this.addRecipeTableLayoutPanel.Controls.Add(this.addNameLabel, 0, 0);
            this.addRecipeTableLayoutPanel.Controls.Add(this.addNutritionLabel, 0, 1);
            this.addRecipeTableLayoutPanel.Controls.Add(this.nutritionLabel, 0, 2);
            this.addRecipeTableLayoutPanel.Controls.Add(this.addRecipenameTextBox, 1, 0);
            this.addRecipeTableLayoutPanel.Controls.Add(this.imageLabel, 0, 7);
            this.addRecipeTableLayoutPanel.Controls.Add(this.ethnicLabel, 0, 6);
            this.addRecipeTableLayoutPanel.Controls.Add(this.addEthnicCombobox, 1, 6);
            this.addRecipeTableLayoutPanel.Controls.Add(this.ingredientsTableLayoutPanel, 1, 2);
            this.addRecipeTableLayoutPanel.Controls.Add(this.kitchenWareTableLayoutPanel, 1, 3);
            this.addRecipeTableLayoutPanel.Controls.Add(this.addRecipeMealTypeComboBox, 1, 4);
            this.addRecipeTableLayoutPanel.Controls.Add(this.addFoodTypeComboBox, 1, 5);
            this.addRecipeTableLayoutPanel.Controls.Add(this.foodTypeLabel, 0, 5);
            this.addRecipeTableLayoutPanel.Controls.Add(this.kitchenWareLabel, 0, 3);
            this.addRecipeTableLayoutPanel.Controls.Add(this.mealTypeLabel, 0, 4);
            this.addRecipeTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.addRecipeTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 1, 8);
            this.addRecipeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRecipeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.addRecipeTableLayoutPanel.Name = "addRecipeTableLayoutPanel";
            this.addRecipeTableLayoutPanel.RowCount = 9;
            this.addRecipeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.addRecipeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.71165F));
            this.addRecipeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.057302F));
            this.addRecipeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.363296F));
            this.addRecipeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.73034F));
            this.addRecipeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.addRecipeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.addRecipeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.addRecipeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.addRecipeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addRecipeTableLayoutPanel.Size = new System.Drawing.Size(1149, 585);
            this.addRecipeTableLayoutPanel.TabIndex = 1;
            // 
            // addEthnicCombobox
            // 
            this.addEthnicCombobox.FormattingEnabled = true;
            this.addEthnicCombobox.Location = new System.Drawing.Point(190, 403);
            this.addEthnicCombobox.Name = "addEthnicCombobox";
            this.addEthnicCombobox.Size = new System.Drawing.Size(278, 24);
            this.addEthnicCombobox.TabIndex = 25;
            this.addEthnicCombobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddEthnicCombobox_KeyPress);
            // 
            // ingredientsTableLayoutPanel
            // 
            this.ingredientsTableLayoutPanel.ColumnCount = 4;
            this.ingredientsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.02439F));
            this.ingredientsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.97561F));
            this.ingredientsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.ingredientsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.ingredientsTableLayoutPanel.Controls.Add(this.button6, 3, 0);
            this.ingredientsTableLayoutPanel.Controls.Add(this.addIngredIentsRichBox, 0, 0);
            this.ingredientsTableLayoutPanel.Controls.Add(this.button3, 2, 0);
            this.ingredientsTableLayoutPanel.Controls.Add(this.addIngredientCombobox, 1, 0);
            this.ingredientsTableLayoutPanel.Location = new System.Drawing.Point(190, 154);
            this.ingredientsTableLayoutPanel.Name = "ingredientsTableLayoutPanel";
            this.ingredientsTableLayoutPanel.RowCount = 1;
            this.ingredientsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ingredientsTableLayoutPanel.Size = new System.Drawing.Size(778, 42);
            this.ingredientsTableLayoutPanel.TabIndex = 28;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(699, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 36);
            this.button6.TabIndex = 3;
            this.button6.Text = "Remove";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // kitchenWareTableLayoutPanel
            // 
            this.kitchenWareTableLayoutPanel.ColumnCount = 4;
            this.kitchenWareTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.40434F));
            this.kitchenWareTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.17232F));
            this.kitchenWareTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.kitchenWareTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.kitchenWareTableLayoutPanel.Controls.Add(this.button5, 3, 0);
            this.kitchenWareTableLayoutPanel.Controls.Add(this.addKitchenwareRichTextBox, 0, 0);
            this.kitchenWareTableLayoutPanel.Controls.Add(this.button4, 2, 0);
            this.kitchenWareTableLayoutPanel.Controls.Add(this.addKitchenWareComboBox, 1, 0);
            this.kitchenWareTableLayoutPanel.Location = new System.Drawing.Point(190, 202);
            this.kitchenWareTableLayoutPanel.Name = "kitchenWareTableLayoutPanel";
            this.kitchenWareTableLayoutPanel.RowCount = 1;
            this.kitchenWareTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kitchenWareTableLayoutPanel.Size = new System.Drawing.Size(778, 44);
            this.kitchenWareTableLayoutPanel.TabIndex = 29;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(685, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 38);
            this.button5.TabIndex = 2;
            this.button5.Text = "Remove";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(591, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 35);
            this.button4.TabIndex = 1;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // addRecipeMealTypeComboBox
            // 
            this.addRecipeMealTypeComboBox.FormattingEnabled = true;
            this.addRecipeMealTypeComboBox.Location = new System.Drawing.Point(190, 252);
            this.addRecipeMealTypeComboBox.Name = "addRecipeMealTypeComboBox";
            this.addRecipeMealTypeComboBox.Size = new System.Drawing.Size(278, 24);
            this.addRecipeMealTypeComboBox.TabIndex = 24;
            this.addRecipeMealTypeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddRecipeMealTypeComboBox_KeyPress);
            // 
            // addFoodTypeComboBox
            // 
            this.addFoodTypeComboBox.FormattingEnabled = true;
            this.addFoodTypeComboBox.Location = new System.Drawing.Point(190, 336);
            this.addFoodTypeComboBox.Name = "addFoodTypeComboBox";
            this.addFoodTypeComboBox.Size = new System.Drawing.Size(278, 24);
            this.addFoodTypeComboBox.TabIndex = 26;
            this.addFoodTypeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddFoodTypeComboBox_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.05442F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.23129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Controls.Add(this.servingtextBox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.fattextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.calorieTextBox, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.alchoholTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.carbLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.proteinLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.calorisLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.servingLabel, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.alcoholLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.fatLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.carbTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.proteinTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(190, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 78);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // servingtextBox
            // 
            this.servingtextBox.Location = new System.Drawing.Point(546, 42);
            this.servingtextBox.Name = "servingtextBox";
            this.servingtextBox.Size = new System.Drawing.Size(93, 22);
            this.servingtextBox.TabIndex = 11;
            // 
            // fattextBox
            // 
            this.fattextBox.Location = new System.Drawing.Point(392, 42);
            this.fattextBox.Name = "fattextBox";
            this.fattextBox.Size = new System.Drawing.Size(49, 22);
            this.fattextBox.TabIndex = 10;
            // 
            // calorieTextBox
            // 
            this.calorieTextBox.Location = new System.Drawing.Point(546, 3);
            this.calorieTextBox.Name = "calorieTextBox";
            this.calorieTextBox.Size = new System.Drawing.Size(93, 22);
            this.calorieTextBox.TabIndex = 9;
            // 
            // alchoholTextBox
            // 
            this.alchoholTextBox.Location = new System.Drawing.Point(392, 3);
            this.alchoholTextBox.Name = "alchoholTextBox";
            this.alchoholTextBox.Size = new System.Drawing.Size(49, 22);
            this.alchoholTextBox.TabIndex = 8;
            // 
            // carbLabel
            // 
            this.carbLabel.AutoSize = true;
            this.carbLabel.Location = new System.Drawing.Point(3, 0);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(95, 16);
            this.carbLabel.TabIndex = 0;
            this.carbLabel.Text = "Carbohydrate :";
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Location = new System.Drawing.Point(3, 39);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(55, 16);
            this.proteinLabel.TabIndex = 1;
            this.proteinLabel.Text = "Protien :";
            // 
            // calorisLabel
            // 
            this.calorisLabel.AutoSize = true;
            this.calorisLabel.Location = new System.Drawing.Point(447, 0);
            this.calorisLabel.Name = "calorisLabel";
            this.calorisLabel.Size = new System.Drawing.Size(63, 16);
            this.calorisLabel.TabIndex = 4;
            this.calorisLabel.Text = "Calories :";
            // 
            // servingLabel
            // 
            this.servingLabel.AutoSize = true;
            this.servingLabel.Location = new System.Drawing.Point(447, 39);
            this.servingLabel.Name = "servingLabel";
            this.servingLabel.Size = new System.Drawing.Size(85, 16);
            this.servingLabel.TabIndex = 5;
            this.servingLabel.Text = "Serving Size:";
            // 
            // alcoholLabel
            // 
            this.alcoholLabel.AutoSize = true;
            this.alcoholLabel.Location = new System.Drawing.Point(282, 0);
            this.alcoholLabel.Name = "alcoholLabel";
            this.alcoholLabel.Size = new System.Drawing.Size(58, 16);
            this.alcoholLabel.TabIndex = 3;
            this.alcoholLabel.Text = "Alcohol :";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(282, 39);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(39, 16);
            this.fatLabel.TabIndex = 2;
            this.fatLabel.Text = "Fats :";
            // 
            // carbTextBox
            // 
            this.carbTextBox.Location = new System.Drawing.Point(143, 3);
            this.carbTextBox.Name = "carbTextBox";
            this.carbTextBox.Size = new System.Drawing.Size(100, 22);
            this.carbTextBox.TabIndex = 6;
            // 
            // proteinTextBox
            // 
            this.proteinTextBox.Location = new System.Drawing.Point(143, 42);
            this.proteinTextBox.Name = "proteinTextBox";
            this.proteinTextBox.Size = new System.Drawing.Size(99, 22);
            this.proteinTextBox.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.00529F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.99471F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 520F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(190, 537);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(845, 45);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(136, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 39);
            this.button2.TabIndex = 32;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(327, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Please note all * marked are mandatory data";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 39);
            this.button1.TabIndex = 31;
            this.button1.Text = "Add Recipe";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddRecipeDetailUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addRecipeTableLayoutPanel);
            this.Name = "AddRecipeDetailUserControl";
            this.Size = new System.Drawing.Size(1149, 585);
            this.Load += new System.EventHandler(this.AddRecipeDetailUserControl_Load);
            this.addRecipeTableLayoutPanel.ResumeLayout(false);
            this.addRecipeTableLayoutPanel.PerformLayout();
            this.ingredientsTableLayoutPanel.ResumeLayout(false);
            this.kitchenWareTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.Label addNutritionLabel;
        private System.Windows.Forms.Label nutritionLabel;
        private System.Windows.Forms.Label kitchenWareLabel;
        private System.Windows.Forms.ComboBox addIngredientCombobox;
        private System.Windows.Forms.ComboBox addKitchenWareComboBox;
        private System.Windows.Forms.RichTextBox addIngredIentsRichBox;
        private System.Windows.Forms.RichTextBox addKitchenwareRichTextBox;
        private System.Windows.Forms.TextBox addRecipenameTextBox;
        private System.Windows.Forms.Label foodTypeLabel;
        private System.Windows.Forms.Label mealTypeLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label ethnicLabel;
        private System.Windows.Forms.TableLayoutPanel addRecipeTableLayoutPanel;
        private System.Windows.Forms.ComboBox addRecipeMealTypeComboBox;
        private System.Windows.Forms.ComboBox addEthnicCombobox;
        private System.Windows.Forms.ComboBox addFoodTypeComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label carbLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Label alcoholLabel;
        private System.Windows.Forms.Label calorisLabel;
        private System.Windows.Forms.Label servingLabel;
        private System.Windows.Forms.TextBox servingtextBox;
        private System.Windows.Forms.TextBox fattextBox;
        private System.Windows.Forms.TextBox calorieTextBox;
        private System.Windows.Forms.TextBox alchoholTextBox;
        private System.Windows.Forms.TextBox carbTextBox;
        private System.Windows.Forms.TextBox proteinTextBox;
        private System.Windows.Forms.TableLayoutPanel ingredientsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel kitchenWareTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
    }
}
