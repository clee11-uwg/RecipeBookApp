﻿using RecipeBookApp.Controller;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBookApp.UserControls
{

    public partial class AddRecipeDetailUserControl : UserControl
    {

        private List<Recipe> recipeList;
        private List<Nutrition> nutritionList;
        private Nutrition addNutrition;
        private List<Kitchenware> kitchenWareList;
        private List<MealType> mealTypeList;
        private List<FoodType> foodTypeList;
        private List<Ethnic> ethnicList;
        private List<Ingredient> ingredientList;
        private RecipeController recipeController;
        private readonly AllergenController allergenController;
        private readonly IngredientsController ingredientsController;
        private readonly KitchenwareController kitchenController;
        private readonly NutritionController nutritionController;
        private readonly TypeOfMealController mealController;
        private readonly EthnicOriginController ethnicController;
        private List<string> recipeIngredients;
        private List<string> recipeKitchenWare;
        private string displayMessage;

        private readonly TypeOfFoodController foodController;
        public AddRecipeDetailUserControl()
        {
            InitializeComponent();
            this.allergenController = new AllergenController();
            this.ingredientsController = new IngredientsController();
            this.kitchenController = new KitchenwareController();
            this.mealController = new TypeOfMealController();
            this.foodController = new TypeOfFoodController();
            this.ethnicController = new EthnicOriginController();
            this.recipeController = new RecipeController(); ;
            this.kitchenWareList = new List<Kitchenware>();
            this.mealTypeList = new List<MealType>();
            this.foodTypeList = new List<FoodType>();
            this.ethnicList = new List<Ethnic>();
            this.ingredientList = new List<Ingredient>();
            this.recipeIngredients = new List<string>();
            this.recipeKitchenWare= new List<string>();


        }


        /// <summary>
        /// Loads the ComboBox for furniture category and style.
        /// </summary>
        private void LoadComboBox()
        {
            try
            {
          
                this.CreateMealTypeDropDown();
                this.CreateIngredientsDropDown();
                this.CreateMealTypeDropDown();
                this.CreateKitchenWareDropDown();
                this.CreateFoodTypeDropDown();
                this.CreateEthnicDropDown();
                this.recipeList = this.recipeController.GetRecipes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Database transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       



        private void CreateIngredientsDropDown()
        {
            try
            {
                this.addIngredientCombobox.DataSource = null;
                this.ingredientList = this.ingredientsController.GetIngredients();
                this.ingredientList.Add(new Ingredient
                {
                    IngredientId = -1,
                    IngredientName = "Select the Ingredient"
                });
                this.addIngredientCombobox.DataSource = this.ingredientList;
                this.addIngredientCombobox.DisplayMember = "IngredientName";
                this.addIngredientCombobox.ValueMember = "IngredientId";
                this.addIngredientCombobox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Apply Filter Ingredients transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateMealTypeDropDown()
        {
            try
            {
                this.addRecipeMealTypeComboBox.DataSource = null;
                this.mealTypeList = this.mealController.GetMealTypes();
                this.mealTypeList.Add(new MealType
                {
                    mealTypeID = -1,
                    type = "Select the MealType"
                });
                this.addRecipeMealTypeComboBox.DataSource = this.mealTypeList;
                this.addRecipeMealTypeComboBox.DisplayMember = "type";
                this.addRecipeMealTypeComboBox.ValueMember = "mealTypeID";
                this.addRecipeMealTypeComboBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Apply Filter meal type transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateKitchenWareDropDown()
        {
            try
            {
                this.addKitchenWareComboBox.DataSource = null;
                this.kitchenWareList = this.kitchenController.GetKitchenware();
                this.kitchenWareList.Add(new Kitchenware
                {
                    KitchenwareId = -1,
                    KitchenwareDetails = "Select the KitchenWare"
                });
                this.addKitchenWareComboBox.DataSource = this.kitchenWareList;
                this.addKitchenWareComboBox.DisplayMember = "KitchenwareDetails";
                this.addKitchenWareComboBox.ValueMember = "KitchenwareId";
                this.addKitchenWareComboBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Apply Filter Ingredients transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateFoodTypeDropDown()
        {
            try
            {
                this.addFoodTypeComboBox.DataSource = null;
                this.foodTypeList = this.foodController.GetFoodTypes();
                this.foodTypeList.Add(new FoodType
                {
                    FoodId = -1,
                    TypeOfFood = "Select the Food type"
                });
                this.addFoodTypeComboBox.DataSource = this.foodTypeList;
                this.addFoodTypeComboBox.DisplayMember = "TypeOfFood";
                this.addFoodTypeComboBox.ValueMember = "FoodId";
                this.addFoodTypeComboBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Apply Filter meal type transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateEthnicDropDown()
        {
            try
            {

                this.addEthnicCombobox.DataSource = null;
                this.ethnicList = this.ethnicController.GetEthnicOrigins();
                this.ethnicList.Add(new Ethnic
                {
                    EthnicId = -1,
                    Ethnicity = "Select the Ethnicity"
                });
                this.addEthnicCombobox.DataSource = this.ethnicList;
                this.addEthnicCombobox.DisplayMember = "Ethnicity";
                this.addEthnicCombobox.ValueMember = "EthnicId";
                this.addEthnicCombobox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Apply Filter Ethnic transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRecipeDetailUserControl_Load(object sender, EventArgs e)
        {
            this.LoadComboBox();
        }

        private void AddIngredientCombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddKitchenWareComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddRecipeMealTypeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddFoodTypeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddEthnicCombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            this.erroLabel.Visible = false;
            this.erroLabel.Visible = false;
            if (!ValidateRecipeName())
            {
                DisplayError(true);
                return;
            }
            else if (!ValidateNutritions()) {
                DisplayError(true);
                return;
            }

            this.CollectNutritionData();

        }
        private void CollectNutritionData()
        {
            this.addNutrition = new Nutrition
            {
                Carbohydrate = int.Parse(this.calorieTextBox.Text),
                Protein = int.Parse(this.proteinTextBox.Text),
                Fat = int.Parse(this.fattextBox.Text),
                Alcohol = int.Parse(this.calorieTextBox.Text),
                Calories = int.Parse(this.calorieTextBox.Text),
                ServingSize = this.servingtextBox.Text
            };

        }
        private bool ValidateRecipeName() {

            string recipName = this.addRecipenameTextBox.Text;
            bool nameExists = this.recipeList.Any(name => name.RecipeName == recipName);
            if (string.IsNullOrEmpty(recipName) )
            {
                this.displayMessage = "Recipe Name cannot be empty";
                return false;
            }

            else if (nameExists)
            {
                this.displayMessage = this.addRecipenameTextBox.Text + " - Recipe with this name already Exists, plesae choose different name";
                return false;
            }
            return true;
        }
        private bool ValidateNutritions()
        {
            if (string.IsNullOrEmpty(this.carbTextBox.Text) || string.IsNullOrEmpty(this.proteinTextBox.Text) || 
                string.IsNullOrEmpty(this.fattextBox.Text) || string.IsNullOrEmpty(this.alchoholTextBox.Text) 
                || string.IsNullOrEmpty(this.calorieTextBox.Text))
            {
                this.displayMessage = "Carbohydrate,Protein,Fat,Alcohol,Calories - should be a valid number or cannot be empty";
                return false;
            }

            else if (!Regex.IsMatch(this.carbTextBox.Text, @"^\d+$"))
            {
                this.displayMessage = "Carbohydrate should be a valid number !";
                return false;
            }
            else if(!Regex.IsMatch(this.proteinTextBox.Text, @"^\d+$"))
            {
                this.displayMessage = "Protein should be a valid number !";
                return false;
            }
            else if(!Regex.IsMatch(this.fattextBox.Text, @"^\d+$"))
            {
                this.displayMessage = "Fats should be a valid number !";
                return false;
            }
            if (!Regex.IsMatch(this.alchoholTextBox.Text, @"^\d+$"))
            {
                this.displayMessage = "Alcohol should be a valid number !";
                return false;
            }
            else if(!Regex.IsMatch(this.calorieTextBox.Text, @"^\d+$"))
            {
                this.displayMessage = "Calorie should be a valid number !";
                return false;
            }

           
            return true;
        }
        private void DisplayError( bool isError)
        {
            if (string.IsNullOrEmpty(this.displayMessage))
            {
                throw new ArgumentException("Message cannot be null or empty");
            }
            if (isError)
            {
                this.erroLabel.ForeColor = Color.Red;
            }
            else
            {
                this.erroLabel.ForeColor = Color.Green;
            }
            this.erroLabel.Text = this.displayMessage;
            this.erroLabel.Visible = true;
        }

        private void AddIngredients_Click(object sender, EventArgs e)
        {
            if (this.recipeIngredients.Contains(this.addIngredientCombobox.Text))
            {
                MessageBox.Show(this.addIngredientCombobox.Text + "already added. Please select something else.",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.addIngredientCombobox.Text == "Select the Ingredient")
            {
                MessageBox.Show("Please select valid Ingredients to add",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeIngredients.Add(this.addIngredientCombobox.Text.ToString());
            this.DisplayIngredients();

        }
        private void DisplayIngredients()
        {
            this.addIngredIentsRichBox.Text=  string.Join(",", this.recipeIngredients);
            this.addIngredIentsRichBox.Refresh();
        }

        private void RemoveIngrdients_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.addIngredientCombobox.Text))
            {
                MessageBox.Show("No Ingredient present. Please add Ingredients",
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.addIngredientCombobox.Text == "Select the Ingredient")
            {
                MessageBox.Show("Please select valid Ingredients to Remove",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!this.recipeIngredients.Contains(this.addIngredientCombobox.Text))
            {
                MessageBox.Show(this.addIngredientCombobox.Text + "Cannot be removed as it was never added",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                   
            this.recipeIngredients.Remove(this.addIngredientCombobox.Text);           
            this.DisplayIngredients();
          
        }

        private void AddKitchennware_Click(object sender, EventArgs e)
        {
            if (this.recipeKitchenWare.Contains(this.addKitchenWareComboBox.Text))
            {
                MessageBox.Show(this.addKitchenWareComboBox.Text + "already added. Please select something else.",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.addKitchenWareComboBox.Text == "Select the KitchenWare")
            {
                MessageBox.Show("Please select valid kitchenware to add",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.recipeKitchenWare.Add(this.addKitchenWareComboBox.Text.ToString());
            this.DisplayKitchenwares();

        }

        private void RemovKitchenware_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.addKitchenWareComboBox.Text))
            {
                MessageBox.Show("No kitchenware present. Please add kitchenware",
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.addKitchenWareComboBox.Text == "Select the KitchenWare")
            {
                MessageBox.Show("Please select valid kitchenware to Remove",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!this.recipeKitchenWare.Contains(this.addKitchenWareComboBox.Text))
            {
                MessageBox.Show(this.addKitchenWareComboBox.Text + "Cannot be removed as it was never added",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeKitchenWare.Remove(this.addKitchenWareComboBox.Text);
            this.DisplayKitchenwares();
        }
        private void DisplayKitchenwares()
        {
            this.addKitchenwareRichTextBox.Text = string.Join(",", this.recipeIngredients);
            this.addKitchenwareRichTextBox.Refresh();
        }

    }
}
