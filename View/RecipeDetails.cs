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
        private User currentUser;
        private List<Nutrition> recipeNutrition;
        private RecipeController recipeController;
        private IngredientsController ingredientsController;
        private KitchenwareController kitchenwareController;
        private TypeOfMealController typeOfMealController;
        private AllergenController allergenController;
        private NutritionController nutritionController;
        private UserController userController;
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
            this.currentUser = new User();
            this.recipeNutrition = new List<Nutrition>();
            this.recipeController = new RecipeController();
            this.ingredientsController = new IngredientsController();
            this.kitchenwareController = new KitchenwareController();
            this.typeOfMealController = new TypeOfMealController();
            this.allergenController = new AllergenController();
            this.nutritionController = new NutritionController();
            this.userController = new UserController();

            //this.recipeIngredients = new List<string>();
            //this.recipeKitchenware = new List<string>();
            //this.recipeAllergens = new List<string>();
            //this.recipeMealTypes = new List<string>();
        }

        /// <summary>
        /// Method to display update and delete buttons if a user is current signed in
        /// </summary>
        public void ShowButtons()
        {
            if (this.currentUser == null || string.IsNullOrEmpty(this.currentUser.Name))
            {
                this.updateButton.Visible = false;
                this.deleteButton.Visible = false;
            }
            else
            {
                this.updateButton.Visible = true;
                this.deleteButton.Visible = true;
            }
        }

        /// <summary>
        /// Method to set the Recipe to the selected recipe
        /// </summary>
        /// <param name="userSelectedRecipe">Selected recipe from user</param>
        public void SetRecipe(Recipe userSelectedRecipe)
        {
            this.selectedRecipe = userSelectedRecipe;
            GetRecipeDetails();
        }

        /// <summary>
        /// Method to set the User to the current user
        /// </summary>
        /// <param name="currentUser">Current logged in user</param>
        public void SetUser (User currentUser)
        {
            this.currentUser = currentUser;            
        }

        private void GetRecipeDetails()
        {
            Recipe updatedRecipe = this.recipeController.GetRecipe(this.selectedRecipe.RecipeId);
            this.titleLbl.Text = updatedRecipe.RecipeName;
            this.cookingTimeLbl.Text = updatedRecipe.CookingTime.ToString() + " min";
            GetNutrition();
            GetIngredients();
            GetKitchenware();
            GetInstructions();
            GetMealTypes();
            GetAllergens();
        }

        private void GetNutrition()
        {
            this.recipeNutrition = this.nutritionController.GetNutrition(this.selectedRecipe.RecipeId);
            this.calorieLbl.Text = null;
            this.carbLbl.Text = null;
            this.proteinLbl.Text = null;
            this.fatLbl.Text = null;
            this.alcoholLbl.Text = null;
            this.servingSizeLbl.Text = null;

            this.calorieLbl.Text = "Calories: " + this.recipeNutrition[0].Calories;
            this.carbLbl.Text = "Carbs: " + this.recipeNutrition[0].Carbohydrate;
            this.proteinLbl.Text = "Protein: " + this.recipeNutrition[0].Protein;
            this.fatLbl.Text = "Fat: " + this.recipeNutrition[0].Fat;
            this.alcoholLbl.Text = "Acohol: " + this.recipeNutrition[0].Alcohol;
            this.servingSizeLbl.Text = "Serving Size: " + this.recipeNutrition[0].ServingSize;
        }

        private void GetIngredients()
        {
            this.recipeIngredients = new List<string>();
            List<Ingredient> ingredientList = this.ingredientsController.GetIngredient(selectedRecipe.RecipeId);
            this.ingredientsRchBx.Text = null;
            for (int i = 0; i < ingredientList.Count; i++)
            {
                if (i == (ingredientList.Count - 1))
                    this.ingredientsRchBx.Text += ingredientList[i].IngredientName + ": " + ingredientList[i].Amount;
                else
                    this.ingredientsRchBx.Text += ingredientList[i].IngredientName + ": " + ingredientList[i].Amount + "\n";
            }
            this.ingredientsRchBx.Refresh();
        }

        private void GetKitchenware()
        {
            this.recipeKitchenware = new List<string>();
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
            this.recipeMealTypes = new List<string>();
            List <MealType> mealTypeList = this.typeOfMealController.GetMealTypes(selectedRecipe.RecipeId);
            for (int i = 0; i < mealTypeList.Count; i++)
            {
                this.recipeMealTypes.Add(mealTypeList[i].type);
            }
            this.typeOfMealLbl.Text = string.Join(" | ", this.recipeMealTypes);
        }

        private void GetAllergens()
        {
            this.recipeAllergens = new List<string>();
            List <Allergen> allergenList = this.allergenController.GetAllergen(selectedRecipe.RecipeId);
            for (int i = 0; i < allergenList.Count; i++)
            {
                this.recipeAllergens.Add(allergenList[i].AllergenDetails);                
            }
            this.allergenListLbl.Text = string.Join(" | ", this.recipeAllergens);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateRecipeForm updateRecipeForm = new UpdateRecipeForm();
            updateRecipeForm.SetRecipe(this.selectedRecipe);
            updateRecipeForm.SetUser(this.currentUser);
            updateRecipeForm.ShowDialog();
            SetRecipe(this.selectedRecipe);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this recipe?", "Delete Recipe", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Add code to call delete recipe method from RecipeController once available
                try
                {
                    bool isRecipeDeleted = this.recipeController.DeleteRecipe(this.currentUser, this.selectedRecipe);
                    if (isRecipeDeleted)
                    {
                        MessageBox.Show(this.selectedRecipe.RecipeName + " has been successfully deleted");                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Could not delete recipe");
                    }
                }
                catch (UnauthorizedAccessException uae)
                {
                    MessageBox.Show(uae.Message);
                }
                catch (ArgumentException ae)
                {
                    MessageBox.Show(ae.Message);
                }
            }
        }

        private void AddToFavoritesLnkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                bool isAddedToFavorites = this.userController.AddNewFavoriteRecipe(this.currentUser.ID, this.selectedRecipe.RecipeId);
                if (isAddedToFavorites)
                {
                    MessageBox.Show(this.selectedRecipe.RecipeName + " has been added to your favorites list");
                    this.removeFromFavoritesLnkLbl.Visible = true;
                    this.addToFavoritesLnkLbl.Visible = false;
                }
                else
                {
                    MessageBox.Show("Failed to add this recipe to your favorites list");
                }
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show(aoore.Message);
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show(nre.Message);
            }
        }

        private void RemoveFromFavoritesLnkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                bool isRemovedFromFavorites = this.userController.DeleteFavoriteRecipe(this.currentUser.ID, this.selectedRecipe.RecipeId);
                if (isRemovedFromFavorites)
                {
                    MessageBox.Show(this.selectedRecipe.RecipeName + " has been removed from your favorites list");
                    this.removeFromFavoritesLnkLbl.Visible = false;
                    this.addToFavoritesLnkLbl.Visible = true;
                }
                else
                {
                    MessageBox.Show("Failed to remove this recipe to your favorites list");
                }
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show(aoore.Message);
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show(nre.Message);
            }
        }
    }
}
