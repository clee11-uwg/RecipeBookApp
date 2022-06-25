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

        /// <summary>
        /// 0 param constructor
        /// </summary>
        public RecipeDetails()
        {
            InitializeComponent();
            this.selectedRecipe = new Recipe();
            this.recipeController = new RecipeController();
            this.ingredientsController = new IngredientsController();
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
            List<Ingredient> ingredientList = this.ingredientsController.GetIngredient(selectedRecipe.RecipeId);
            for (int i = 0; i < ingredientList.Count; i++)
            {
                string ingredient = ingredientList[i].IngredientName;
                var listViewItem = new ListViewItem(ingredient);
                ingredientsListView.Items.Add(listViewItem);
            }
        }
    }
}
