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

        public UpdateRecipeUserControl()
        {
            InitializeComponent();
            this.nutritionController = new NutritionController();
            this.foodTypeController = new TypeOfFoodController();
        }

        /// <summary>
        /// Set the recipe of the user control to be the one passed in from the Update Recipe form from the Recipe Details page
        /// </summary>
        /// <param name="selectedRecipe">Recipe selected by the user</param>
        public void SetRecipe(Recipe selectedRecipe)
        {
            this.recipe = selectedRecipe;
            this.recipeNameTxtBx.Text = this.recipe.RecipeName;
            GetNutrition();
            GetFoodType();
        }

        private void GetFoodType()
        {
            List<FoodType> foodTypeList;
            
            try
            {
                this.foodTypeCmbBx.DataSource = null;
                foodTypeList = this.foodTypeController.GetFoodTypes();
                foodTypeList.Add(new FoodType
                {
                    FoodId = -1,
                    TypeOfFood = "Select the Food type"
                });
                this.foodTypeCmbBx.DataSource = foodTypeList;
                this.foodTypeCmbBx.DisplayMember = "TypeOfFood";
                this.foodTypeCmbBx.ValueMember = "FoodId";
                this.foodTypeCmbBx.SelectedValue = this.foodTypeController.GetFoodTypes(this.recipe.RecipeId)[0].FoodId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Apply Filter meal type transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetNutrition()
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
