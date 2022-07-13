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
        private AllergenController allergenController;
        private List<string> recipeIngredients;
        private List<string> recipeKitchenware;
        private List<string> recipeAllergens;
        private List<string> recipeMealTypes;

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
            this.allergenController = new AllergenController();

            this.recipeIngredients = new List<string>();
            this.recipeKitchenware = new List<string>();
            this.recipeAllergens = new List<string>();
            this.recipeMealTypes = new List<string>();
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
            GetMealTypes();
            GetAllergens();
        }

        private void GetIngredients()
        {
            List<Ingredient> ingredientList = this.ingredientsController.GetIngredient(selectedRecipe.RecipeId);
            for (int i = 0; i < ingredientList.Count; i++)
            {
                this.recipeIngredients.Add(ingredientList[i].IngredientName);
            }
            this.ingredientsLbl.Text = string.Join(" | ", this.recipeIngredients);
        }

        private void GetKitchenware()
        {
            List<Kitchenware> kitchenwareList = this.kitchenwareController.GetKitchenware(selectedRecipe.RecipeId);
            for (int i = 0; i < kitchenwareList.Count; i++)
            {
                this.recipeKitchenware.Add(kitchenwareList[i].KitchenwareDetails);                
            }
            this.kitchenwareLbl.Text = string.Join(" | ", this.recipeKitchenware);
        }

        private void GetInstructions()
        {
            this.instructionsTxtBx.Text = this.selectedRecipe.RecipeInstructions;
            this.instructionsTxtBx.SelectionLength = 0;
        }

        private void GetMealTypes()
        {
            List<MealType> mealTypeList = this.typeOfMealController.GetMealTypes(selectedRecipe.RecipeId);
            for (int i = 0; i < mealTypeList.Count; i++)
            {
                this.recipeMealTypes.Add(mealTypeList[i].type);
            }
            this.typeOfMealLbl.Text = string.Join(" | ", this.recipeMealTypes);
        }

        private void GetAllergens()
        {
            List<Allergen> allergenList = this.allergenController.GetAllergen(selectedRecipe.RecipeId);
            for (int i = 0; i < allergenList.Count; i++)
            {
                this.recipeAllergens.Add(allergenList[i].AllergenDetails);                
            }
            this.allergenListLbl.Text = string.Join(" | ", this.recipeAllergens);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Add check if this current recipe was created by this user. This can be done either here or
            // to determine if the button should show at all. The following is assuming the user created selected recipe
            UpdateRecipeForm updateRecipeForm = new UpdateRecipeForm();
            updateRecipeForm.SetRecipe(this.selectedRecipe);
            updateRecipeForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Add check if this current recipe was created by this user. This can be done either here or
            // to determine if the button should show at all. The following is assuming the user created selected recipe
            DialogResult result = MessageBox.Show("Are you sure you want to delete this recipe?", "Delete Recipe", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Add code to call delete recipe method from RecipeController once available
                MessageBox.Show("Coming soon......");
            }
        }
    }
}
