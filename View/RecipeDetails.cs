using RecipeBookApp.Controller;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBookApp.View
{
    public partial class RecipeDetails : Form
    {
        private Recipe selectedRecipe;
        private RecipeController recipeController;
        private IngredientsController ingredientsController;
        private KitchenwareController kitchenwareController;
        private TypeOfMealController typeOfMealController;

        /// <summary>
        /// 0 param constructor
        /// </summary>
        public RecipeDetails()
        {
            InitializeComponent();
            this.selectedRecipe = new Recipe();
            this.recipeController = new RecipeController();
            this.ingredientsController = new IngredientsController();
            this.kitchenwareController = new KitchenwareController();
            this.typeOfMealController = new TypeOfMealController();
        }

        /// <summary>
        /// Method to set the Recipe to the selected recipe
        /// </summary>
        /// <param name="userSelectedRecipe">Selected recipe from user</param>
        public void SetRecipe(Recipe userSelectedRecipe)
        {
            this.selectedRecipe = userSelectedRecipe;
            this.titleLbl.Text = this.selectedRecipe.RecipeName;
            GetRecipeDetails(this.selectedRecipe);
        }

        private void GetRecipeDetails(Recipe selectedRecipe)
        {
            GetIngredients();
            GetKitchenware();
            GetInstructions();
            GetTypeOfFood();
        }

        private void GetIngredients()
        {
            List<Ingredient> ingredientList = this.ingredientsController.GetIngredient(selectedRecipe.RecipeId);
            for (int i = 0; i < ingredientList.Count; i++)
            {
                string ingredient = ingredientList[i].IngredientName;
                this.ingredientsLbl.Text += ingredient + "\n";
            }
        }

        private void GetKitchenware()
        {
            List<Kitchenware> kitchenwareList = this.kitchenwareController.GetKitchenware(selectedRecipe.RecipeId);
            for (int i = 0; i < kitchenwareList.Count; i++)
            {
                string kitchenware = kitchenwareList[i].KitchenwareDetails;
                this.kitchenwareLbl.Text += kitchenware + "\n";
            }
        }

        private void GetInstructions()
        {
            this.instructionsTxtBx.Text = this.selectedRecipe.RecipeInstructions;
        }

        private void GetTypeOfFood()
        {
            List<MealType> mealTypeList = this.typeOfMealController.GetMealTypes(selectedRecipe.RecipeId);
            for (int i = 0; i < mealTypeList.Count; i++)
            {
                string mealType = mealTypeList[i].type;
                this.typeOfMealLbl.Text += mealType + "\n";
            }
        }
    }
}
