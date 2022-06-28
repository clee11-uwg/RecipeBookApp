using RecipeBookApp.Model;
using RecipeBookApp.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeBookApp.UserControls;

namespace RecipeBookApp
{
    public partial class RecipeList : Form
    {
        private RecipeController recipeController;
        private List<Recipe> recipeList;
        private List<string> allergenList;
        private List<string> nutritionList;
        private List<string> kitchenWareList;
        private List<string> mealTypeList;
        private List<string> foodTypeList;
        private List<string> ethnicList;
        private List<string> IngredientList;
        private readonly AllergenController allergenController;
        private readonly IngredientsController ingredientsController;
        private readonly KitchenwareController kitchenController;
        private readonly NutritionController nutritionController;
        private readonly MealTypeController mealController;

        /// <summary>
        /// 0 parameter constructor for the RecipeList
        /// </summary>
        public RecipeList()
        {
            InitializeComponent();
            this.allergenController = new AllergenController();
            this.ingredientsController = new IngredientsController();
            this.kitchenController = new KitchenwareController();
            this.nutritionController = new NutritionController();
            this.mealController = new MealTypeController();
            this.LoadComboBox();
            this.recipeController = new RecipeController();
            this.recipeList = new List<Recipe>();
            this.recipeList = this.recipeController.GetRecipes();
            this.PopulateItems();
        }         

        private void PopulateItems()
        {
            RecipeListItem[] recipeListItems = new RecipeListItem[this.recipeList.Count];

            // Create new list item and add to the flow layout panel
            for (int i = 0; i < recipeListItems.Length; i++)
            {
                recipeListItems[i] = new RecipeListItem();
                recipeListItems[i].RecipeId = this.recipeList[i].RecipeId;
                recipeListItems[i].RecipeName = this.recipeList[i].RecipeName;
                recipeListItems[i].RecipeImage = this.recipeList[i].RecipeImage;
                
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                flowLayoutPanel1.Controls.Add(recipeListItems[i]);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
          

            this.ProcessUserSearchRecipe(this.searchTextBox.Text);
        }

        private void ProcessUserSearchRecipe(string recipeUserInput)
        {
            try
            {
                this.recipeList=this.recipeController.GetRecipeSearch(recipeUserInput);
                if (!this.recipeList.Any())
                {
                    MessageBox.Show("No Recipe found on the database");
                    return;

                }
                //flowLayoutPanel1.Controls;
                this.flowLayoutPanel1.Controls.Clear();
                this.PopulateItems();
            }

            catch (Exception exe)
            {
                MessageBox.Show("Error occured on - Database transaction -" + exe.Message,
                  "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.searchTextBox.Text = "";
            this.recipeList = this.recipeController.GetRecipes();
            this.flowLayoutPanel1.Controls.Clear();
            this.PopulateItems();

        }

        /// <summary>
        /// Loads the ComboBox for furniture category and style.
        /// </summary>
        private void LoadComboBox()
        {
            try
            {
                this.allergenComboBox.DataSource = null;
                this.allergenList = new List<string>();
                this.nutritionComboBox.DataSource = null;
                this.nutritionList = new List<string>();
                this.kitchenWareComboBox.DataSource = null;
                this.kitchenWareList = new List<string>();
                this.ingredientsComboBox.DataSource = null;
                 this.IngredientList = new List<string>();
                this.mealTypeComboBox.DataSource = null;
                this.mealTypeList = new List<string>();
                this.foodComboBox.DataSource = null;
                this.foodTypeList = new List<string>();
                this.ethnicComboBox.DataSource = null;
                this.ethnicList = new List<string>();

                PopulateList();
                this.allergenComboBox.DataSource = this.allergenList;
                
                this.nutritionComboBox.DataSource = this.nutritionList;
              
                this.kitchenWareComboBox.DataSource = this.kitchenWareList;

               this.ingredientsComboBox.DataSource = this.IngredientList;

                this.mealTypeComboBox.DataSource = this.mealTypeList;

                this.foodComboBox.DataSource= this.foodTypeList;

                this.ethnicComboBox.DataSource = this.ethnicList;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Database transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateList()
        {
            foreach (Allergen allergy in this.allergenController.GetAllergens())
            {
                this.allergenList.Add(allergy.AllergenDetails);
            }
            this.allergenList.Sort();

            foreach (Kitchenware kitchen in this.kitchenController.GetKitchenware())
            {
                this.kitchenWareList.Add(kitchen.KitchenwareDetails);
            }
            this.kitchenWareList.Sort();

            foreach (Ingredient ingredient in this.ingredientsController.GetIngredients())
           {
                this.IngredientList.Add(ingredient.IngredientName);
            }
            this.IngredientList.Sort();

            foreach (Nutrition nutrition in this.nutritionController.GetNutritions())
            {
               this.nutritionList.Add(nutrition.NutritionDetails);
            }
           this.nutritionList.Sort();

            foreach (MealType meal in this.mealController.GetMeals())
            {
                this.mealTypeList.Add(meal.type);
            }
            this.mealTypeList.Sort();






        }

        private void FilterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
