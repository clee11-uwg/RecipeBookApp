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
        private List<Kitchenware> kitchenWareList;
        private List<MealType> mealTypeList;
        private List<Ingredient> ingredientList;
        private List<string> recipeIngredients;
        private List<string> recipeKitchenware;
        private List<string> recipeMealTypes;

        public UpdateRecipeUserControl()
        {
            InitializeComponent();
            this.nutritionController = new NutritionController();
            this.foodTypeController = new TypeOfFoodController();
            this.mealTypeController = new TypeOfMealController();
            this.ethnicController = new EthnicOriginController();
            this.ingredientsController = new IngredientsController();
            this.kitchenwareController = new KitchenwareController();

            this.kitchenWareList = new List<Kitchenware>();
            this.mealTypeList = new List<MealType>();
            this.ingredientList = new List<Ingredient>();
            this.recipeIngredients = new List<string>();
            this.recipeKitchenware = new List<string>();
            this.recipeMealTypes = new List<string>();
        }

        /// <summary>
        /// Set the recipe of the user control to be the one passed in from the Update Recipe form from the Recipe Details page
        /// </summary>
        /// <param name="selectedRecipe">Recipe selected by the user</param>
        public void SetRecipe(Recipe selectedRecipe)
        {
            this.recipe = selectedRecipe;
            this.recipeNameTxtBx.Text = this.recipe.RecipeName;
            GetIngredientListForDropdown();
            GetKitchenwareListForDropdown();
            GetMealTypesListForDropdown();
            GetNutritionForRecipe();
            GetFoodTypeForRecipe();
            GetEthnicityForRecipe();
            GetMealTypesForRecipe();
            GetIngredientsForRecipe();
            GetKitchenwareForRecipe();
        }

        private void GetKitchenwareForRecipe()
        {
            List<Kitchenware> kitchenwareList = this.kitchenwareController.GetKitchenware(this.recipe.RecipeId);
            try
            {
                for (int i = 0; i < kitchenwareList.Count; i++)
                {
                    this.recipeKitchenware.Add(kitchenwareList[i].KitchenwareDetails);
                }
                this.kitchenwareRchBx.Text = string.Join(", ", this.recipeKitchenware);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - displaying kitchenware transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetIngredientsForRecipe()
        {
            List<Ingredient> ingredientList = this.ingredientsController.GetIngredient(this.recipe.RecipeId);
            try
            {
                for (int i = 0; i < ingredientList.Count; i++)
                {
                    this.recipeIngredients.Add(ingredientList[i].IngredientName);
                }
                this.ingredientsRchBx.Text = string.Join(", ", this.recipeIngredients);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - displaying ingredients transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetMealTypesListForDropdown()
        {
            try
            {
                this.mealTypeCmbBx.DataSource = null;
                this.mealTypeList = this.mealTypeController.GetMealTypes();
                this.mealTypeList.Add(new MealType
                {
                    mealTypeID = -1,
                    type = "-- Select the Meal Type --"
                });
                this.mealTypeCmbBx.DataSource = this.mealTypeList;
                this.mealTypeCmbBx.DisplayMember = "type";
                this.mealTypeCmbBx.ValueMember = "mealTypeID";
                this.mealTypeCmbBx.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - populating meal type dropdown transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetMealTypesForRecipe()
        {
            List<MealType> mealTypeList = this.mealTypeController.GetMealTypes(this.recipe.RecipeId);
            try
            {
                for (int i = 0; i < mealTypeList.Count; i++)
                {
                    this.recipeMealTypes.Add(mealTypeList[i].type);
                }
                this.mealTypeRchBx.Text = string.Join(", ", this.recipeMealTypes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - displaying meal types transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetKitchenwareListForDropdown()
        {
            try
            {
                this.kitchenwareCmbBx.DataSource = null;
                this.kitchenWareList = this.kitchenwareController.GetKitchenware();
                this.kitchenWareList.Add(new Kitchenware
                {
                    KitchenwareId = -1,
                    KitchenwareDetails = "-- Select the Kitchenware --"
                });
                this.kitchenwareCmbBx.DataSource = this.kitchenWareList;
                this.kitchenwareCmbBx.DisplayMember = "KitchenwareDetails";
                this.kitchenwareCmbBx.ValueMember = "KitchenwareId";
                this.kitchenwareCmbBx.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - populating kitchenware dropdown transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetIngredientListForDropdown()
        {
            try
            {
                this.ingredientCmbBx.DataSource = null;
                this.ingredientList = this.ingredientsController.GetIngredients();
                this.ingredientList.Add(new Ingredient
                {
                    IngredientId = -1,
                    IngredientName = "-- Select the Ingredient --"
                });
                this.ingredientCmbBx.DataSource = this.ingredientList;
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
                List<FoodType> foodType = this.foodTypeController.GetFoodTypes(this.recipe.RecipeId);
                //this.foodTypeCmbBx.SelectedValue = this.foodTypeController.GetFoodTypes(this.recipe.RecipeId)[0].FoodId;
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

        private void DisplayIngredients()
        {
            this.ingredientsRchBx.Text = string.Join(", ", this.recipeIngredients);
            this.ingredientsRchBx.Refresh();
        }

        private void DisplayKitchenwares()
        {
            this.kitchenwareRchBx.Text = string.Join(", ", this.recipeKitchenware);
            this.kitchenwareRchBx.Refresh();
        }

        private void DisplayMealTypes()
        {
            this.mealTypeRchBx.Text = string.Join(", ", this.recipeMealTypes);
            this.mealTypeRchBx.Refresh();
        }

        private void AddIngredientBtn_Click(object sender, EventArgs e)
        {
            if (this.recipeIngredients.Contains(this.ingredientCmbBx.Text))
            {
                MessageBox.Show(this.ingredientCmbBx.Text + "- already added. Please select something else.",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.ingredientCmbBx.Text == "-- Select the Ingredient --")
            {
                MessageBox.Show("Please select valid Ingredients to add",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeIngredients.Add(this.ingredientCmbBx.Text.ToString());
            this.DisplayIngredients();
        }

        private void RemoveIngredientBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ingredientsRchBx.Text))
            {
                MessageBox.Show("No Ingredient present. Please add Ingredients",
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.ingredientCmbBx.Text == "-- Select the Ingredient --")
            {
                MessageBox.Show("Please select valid Ingredients to Remove",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!this.recipeIngredients.Contains(this.ingredientCmbBx.Text))
            {
                MessageBox.Show(this.ingredientCmbBx.Text + " - Cannot be removed as it was never added",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeIngredients.Remove(this.ingredientCmbBx.Text);
            this.DisplayIngredients();
        }

        private void AddKitchenwareBtn_Click(object sender, EventArgs e)
        {
            if (this.recipeKitchenware.Contains(this.kitchenwareCmbBx.Text))
            {
                MessageBox.Show(this.kitchenwareCmbBx.Text + " - already added. Please select something else.",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.kitchenwareCmbBx.Text == "-- Select the Kitchenware --")
            {
                MessageBox.Show("Please select valid kitchenware to add",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.recipeKitchenware.Add(this.kitchenwareCmbBx.Text.ToString());
            this.DisplayKitchenwares();
        }

        private void RemoveKitchenwareBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.kitchenwareRchBx.Text))
            {
                MessageBox.Show("No kitchenware present. Please add kitchenware",
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.kitchenwareCmbBx.Text == "-- Select the Kitchenware --")
            {
                MessageBox.Show("Please select valid kitchenware to Remove",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!this.recipeKitchenware.Contains(this.kitchenwareCmbBx.Text))
            {
                MessageBox.Show(this.kitchenwareCmbBx.Text + "- Cannot be removed as it was never added",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeKitchenware.Remove(this.kitchenwareCmbBx.Text);
            this.DisplayKitchenwares();
        }

        private void AddMealTypeBtn_Click(object sender, EventArgs e)
        {
            if (this.recipeMealTypes.Contains(this.mealTypeCmbBx.Text))
            {
                MessageBox.Show(this.mealTypeCmbBx.Text + "- already added. Please select something else.",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.mealTypeCmbBx.Text == "-- Select the Meal Type --")
            {
                MessageBox.Show("Please select valid Meal Type to add",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeMealTypes.Add(this.mealTypeCmbBx.Text.ToString());
            this.DisplayMealTypes();
        }

        private void RemoveMealTypeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.mealTypeRchBx.Text))
            {
                MessageBox.Show("No meal types present. Please add a meal type",
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.mealTypeCmbBx.Text == "-- Select the Meal Type --")
            {
                MessageBox.Show("Please select valid meal type to Remove",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!this.recipeMealTypes.Contains(this.mealTypeCmbBx.Text))
            {
                MessageBox.Show(this.mealTypeCmbBx.Text + "- Cannot be removed as it was never added",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeMealTypes.Remove(this.mealTypeCmbBx.Text);
            this.DisplayMealTypes();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void UpdateRecipeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon...");
        }
    }
}
