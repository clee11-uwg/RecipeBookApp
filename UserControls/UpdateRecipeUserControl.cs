using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeBookApp.Model;
using RecipeBookApp.Controller;

namespace RecipeBookApp.UserControls
{
    public partial class UpdateRecipeUserControl : UserControl
    {
        private Recipe recipe;
        private NutritionController nutritionController;
        private TypeOfFoodController foodTypeController;
        private TypeOfMealController mealTypeController;
        private EthnicOriginController ethnicController;
        private IngredientsController ingredientsController;
        private KitchenwareController kitchenwareController;

        public UpdateRecipeUserControl()
        {
            InitializeComponent();
            this.nutritionController = new NutritionController();
            this.foodTypeController = new TypeOfFoodController();
            this.mealTypeController = new TypeOfMealController();
            this.ethnicController = new EthnicOriginController();
            this.ingredientsController = new IngredientsController();
            this.kitchenwareController = new KitchenwareController();
        }

        /// <summary>
        /// Set the recipe of the user control to be the one passed in from the Update Recipe form from the Recipe Details page
        /// </summary>
        /// <param name="selectedRecipe">Recipe selected by the user</param>
        public void SetRecipe(Recipe selectedRecipe)
        {
            this.recipe = selectedRecipe;
            this.recipeNameTxtBx.Text = this.recipe.RecipeName;
            GetNutritionForRecipe();
            GetFoodTypeForRecipe();
            GetEthnicityForRecipe();
            GetIngredientListForDropdown();
            GetKitchenwareListForDropdown();
            GetMealTypesForRecipe();
        }

        private void GetMealTypesForRecipe()
        {
            List<MealType> mealTypeList = this.mealTypeController.GetMealTypes(this.recipe.RecipeId);
            string recipeMealTypes = "";
            try
            {
                for (int i = 0; i < mealTypeList.Count; i++)
                {
                    if (i < (mealTypeList.Count - 1))
                    {
                        recipeMealTypes += mealTypeList[i].type + ", ";
                    }
                    else
                    {
                        recipeMealTypes += mealTypeList[i].type;
                    }
                }
                this.mealTypeRchBx.Text = recipeMealTypes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Apply Filter meal type transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetKitchenwareListForDropdown()
        {
            List<Kitchenware> kitchenWareList;
            try
            {
                this.kitchenwareCmbBx.DataSource = null;
                kitchenWareList = this.kitchenwareController.GetKitchenware();
                kitchenWareList.Add(new Kitchenware
                {
                    KitchenwareId = -1,
                    KitchenwareDetails = "-- Select the Kitchenware --"
                });
                this.kitchenwareCmbBx.DataSource = kitchenWareList;
                this.kitchenwareCmbBx.DisplayMember = "KitchenwareDetails";
                this.kitchenwareCmbBx.ValueMember = "KitchenwareId";
                this.kitchenwareCmbBx.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Apply Filter Ingredients transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetIngredientListForDropdown()
        {
            List<Ingredient> ingredientList;
            try
            {
                this.ingredientCmbBx.DataSource = null;
                ingredientList = this.ingredientsController.GetIngredients();
                ingredientList.Add(new Ingredient
                {
                    IngredientId = -1,
                    IngredientName = "-- Select the Ingredient --"
                });
                this.ingredientCmbBx.DataSource = ingredientList;
                this.ingredientCmbBx.DisplayMember = "IngredientName";
                this.ingredientCmbBx.ValueMember = "IngredientId";
                this.ingredientCmbBx.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - populating ingredient dropdown transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetEthnicityForRecipe()
        {
            List<Ethnic> ethnicList;
            try
            {

                this.ethnicityCmbBx.DataSource = null;
                ethnicList = this.ethnicController.GetEthnicOrigins();
                this.ethnicityCmbBx.DataSource = ethnicList;
                this.ethnicityCmbBx.DisplayMember = "Ethnicity";
                this.ethnicityCmbBx.ValueMember = "EthnicId";
                this.ethnicityCmbBx.SelectedValue = this.ethnicController.GetEthnicOrigin(this.recipe.RecipeId)[0].EthnicId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - populating ethnic dropdown transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetFoodTypeForRecipe()
        {
            List<FoodType> foodTypeList;
            
            try
            {
                this.foodTypeCmbBx.DataSource = null;
                foodTypeList = this.foodTypeController.GetFoodTypes();
                this.foodTypeCmbBx.DataSource = foodTypeList;
                this.foodTypeCmbBx.DisplayMember = "TypeOfFood";
                this.foodTypeCmbBx.ValueMember = "FoodId";
                this.foodTypeCmbBx.SelectedValue = this.foodTypeController.GetFoodTypes(this.recipe.RecipeId)[0].FoodId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - populating food type dropdown transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetNutritionForRecipe()
        {
            List<Nutrition> nutritionList = this.nutritionController.GetNutrition(this.recipe.RecipeId);
            this.carbTxtBx.Text = nutritionList[0].Carbohydrate.ToString();
            this.proteinTxtBx.Text = nutritionList[0].Protein.ToString();
            this.alcoholTxtBx.Text = nutritionList[0].Alcohol.ToString();
            this.fatTxtBx.Text = nutritionList[0].Fat.ToString();
            this.calorieTxtBx.Text = nutritionList[0].Calories.ToString();
            this.servingTxtBx.Text = nutritionList[0].ServingSize;
        }
    }
}
