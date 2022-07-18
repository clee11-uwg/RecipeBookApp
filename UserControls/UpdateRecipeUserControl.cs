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
        private Nutrition nutrition;
        private RecipeController recipeController;
        private NutritionController nutritionController;
        private TypeOfFoodController foodTypeController;
        private TypeOfMealController mealTypeController;
        private EthnicOriginController ethnicController;
        private IngredientsController ingredientsController;
        private KitchenwareController kitchenwareController;
        private List<Kitchenware> kitchenWareList;
        private List<MealType> mealTypeList;
        private List<Ingredient> ingredientList;
        private List<Ingredient> recipeIngredientList;
        private List<Kitchenware> recipeKitchenwareList;
        private List<MealType> recipeMealTypesList;
        private List<string> recipeFoodTypes;
        private User currentUser;

        public UpdateRecipeUserControl()
        {
            InitializeComponent();
            this.recipeController = new RecipeController();
            this.nutritionController = new NutritionController();
            this.foodTypeController = new TypeOfFoodController();
            this.mealTypeController = new TypeOfMealController();
            this.ethnicController = new EthnicOriginController();
            this.ingredientsController = new IngredientsController();
            this.kitchenwareController = new KitchenwareController();

            this.kitchenWareList = new List<Kitchenware>();
            this.mealTypeList = new List<MealType>();
            this.ingredientList = new List<Ingredient>();
            this.recipeIngredientList = new List<Ingredient>();
            this.recipeKitchenwareList = new List<Kitchenware>();
            this.recipeMealTypesList = new List<MealType>();
            this.recipeFoodTypes = new List<string>();
            this.currentUser = new User();
            this.nutrition = new Nutrition();
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

        /// <summary>
        /// Method to set the current user
        /// </summary>
        /// <param name="currentUser">current logged in user</param>
        public void SetUser(User currentUser)
        {
            this.currentUser = currentUser;
        }

        private void GetKitchenwareForRecipe()
        {
            this.recipeKitchenwareList = this.kitchenwareController.GetKitchenware(this.recipe.RecipeId);
            try
            {
                for (int i = 0; i < this.recipeKitchenwareList.Count; i++)
                {
                    if (i == (this.recipeKitchenwareList.Count - 1))
                        this.kitchenwareRchBx.Text += this.recipeKitchenwareList[i].KitchenwareDetails;
                    else
                        this.kitchenwareRchBx.Text += this.recipeKitchenwareList[i].KitchenwareDetails + ",";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - displaying kitchenware transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetIngredientsForRecipe()
        {
            this.recipeIngredientList = this.ingredientsController.GetIngredient(this.recipe.RecipeId);
            try
            {
                for (int i = 0; i < this.recipeIngredientList.Count; i++)
                {
                    if (i == (this.recipeIngredientList.Count - 1))
                        this.ingredientsRchBx.Text += this.recipeIngredientList[i].IngredientName;
                    else
                        this.ingredientsRchBx.Text += this.recipeIngredientList[i].IngredientName + ",";
                }
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
            this.recipeMealTypesList = this.mealTypeController.GetMealTypes(this.recipe.RecipeId);
            try
            {
                for (int i = 0; i < this.recipeMealTypesList.Count; i++)
                {
                    if (i == (this.recipeMealTypesList.Count - 1))
                        this.mealTypeRchBx.Text += this.recipeMealTypesList[i].type;
                    else
                        this.mealTypeRchBx.Text += this.recipeMealTypesList[i].type + ",";
                }
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
            List<FoodType> foodTypeList = this.foodTypeController.GetFoodTypes(this.recipe.RecipeId);
            try
            {
                for (int i = 0; i < foodTypeList.Count; i++)
                {
                    this.recipeFoodTypes.Add(foodTypeList[i].TypeOfFood);
                }
                this.foodTypeRchBx.Text = string.Join(", ", this.recipeFoodTypes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - displaying food types transaction -" + ex.Message,
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

            this.nutrition.NutritionId = nutritionList[0].NutritionId;
        }

        private void DisplayIngredients()
        {
            this.ingredientsRchBx.Text = null;
            for (int i = 0; i < this.recipeIngredientList.Count; i++)
            {
                if (i == (this.recipeIngredientList.Count - 1))
                    this.ingredientsRchBx.Text += this.recipeIngredientList[i].IngredientName;
                else
                    this.ingredientsRchBx.Text += this.recipeIngredientList[i].IngredientName + ",";
            }
            this.ingredientsRchBx.Refresh();
        }

        private void DisplayKitchenwares()
        {
            this.kitchenwareRchBx.Text = null;
            for (int i = 0; i < this.recipeKitchenwareList.Count; i++)
            {
                if (i == (this.recipeKitchenwareList.Count - 1))
                    this.kitchenwareRchBx.Text += this.recipeKitchenwareList[i].KitchenwareDetails;
                else
                    this.kitchenwareRchBx.Text += this.recipeKitchenwareList[i].KitchenwareDetails + ",";
            }
            this.kitchenwareRchBx.Refresh();
        }

        private void DisplayMealTypes()
        {
            this.mealTypeRchBx.Text = null;
            for (int i = 0; i < this.recipeMealTypesList.Count; i++)
            {
                if (i == (this.recipeMealTypesList.Count - 1))
                    this.mealTypeRchBx.Text += this.recipeMealTypesList[i].type;
                else
                    this.mealTypeRchBx.Text += this.recipeMealTypesList[i].type + ",";
            }
            this.mealTypeRchBx.Refresh();
        }

        private void AddIngredientBtn_Click(object sender, EventArgs e)
        {
            Ingredient selectedIngredient = this.ingredientsController.GetIngredientByIngredientID(this.ingredientCmbBx.Text);
            if (selectedIngredient != null)
            {
                int index = this.recipeIngredientList.FindIndex(ingredient => ingredient.IngredientName == selectedIngredient.IngredientName);
                if (index > 0)
                {
                    MessageBox.Show(this.ingredientCmbBx.Text + "- already added. Please select something else.",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }            
            else if (this.ingredientCmbBx.Text == "-- Select the Ingredient --")
            {
                MessageBox.Show("Please select valid Ingredients to add",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*else if (string.IsNullOrEmpty(this.amountTxtBx.Text))
            {
                MessageBox.Show("Please enter an amount (i.e. 1 tbsp, 2 cups)",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            */
            
            this.recipeIngredientList.Add(selectedIngredient);
            this.DisplayIngredients();
        }

        private void RemoveIngredientBtn_Click(object sender, EventArgs e)
        {
            Ingredient selectedIngredient = this.ingredientsController.GetIngredientByIngredientID(this.ingredientCmbBx.Text);
            if (selectedIngredient != null)
            {
                int index = this.recipeIngredientList.FindIndex(ingredient => ingredient.IngredientName == selectedIngredient.IngredientName);
                if (index < 0)
                {
                    MessageBox.Show(this.ingredientCmbBx.Text + " - Cannot be removed as it was never added",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    this.recipeIngredientList.RemoveAt(index);
                }
            }            
            else if (this.ingredientCmbBx.Text == "-- Select the Ingredient --")
            {
                MessageBox.Show("Please select valid Ingredients to Remove",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(this.ingredientsRchBx.Text))
            {
                MessageBox.Show("No Ingredient present. Please add Ingredients",
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            this.DisplayIngredients();
        }

        private void AddKitchenwareBtn_Click(object sender, EventArgs e)
        {
            Kitchenware selectedKitchenware = this.kitchenwareController.GetKitchenwareByName(this.kitchenwareCmbBx.Text);
            if (selectedKitchenware != null)
            {
                int index = this.recipeKitchenwareList.FindIndex(kitchenware => kitchenware.KitchenwareDetails == selectedKitchenware.KitchenwareDetails);
                if (index > 0)
                {
                    MessageBox.Show(this.kitchenwareCmbBx.Text + " - already added. Please select something else.",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }            
            else if (this.kitchenwareCmbBx.Text == "-- Select the Kitchenware --")
            {
                MessageBox.Show("Please select valid kitchenware to add",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.recipeKitchenwareList.Add(selectedKitchenware);
            this.DisplayKitchenwares();
        }

        private void RemoveKitchenwareBtn_Click(object sender, EventArgs e)
        {
            Kitchenware selectedKitchenware = this.kitchenwareController.GetKitchenwareByName(this.kitchenwareCmbBx.Text);
            if (selectedKitchenware != null)
            {
                int index = this.recipeKitchenwareList.FindIndex(kitchenware => kitchenware.KitchenwareDetails == selectedKitchenware.KitchenwareDetails);
                if (index < 0)
                {
                    MessageBox.Show(this.kitchenwareCmbBx.Text + "- Cannot be removed as it was never added",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    this.recipeKitchenwareList.RemoveAt(index);
                }
            }
            else if (string.IsNullOrEmpty(this.kitchenwareRchBx.Text))
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
            
            this.DisplayKitchenwares();
        }

        private void AddMealTypeBtn_Click(object sender, EventArgs e)
        {
            MealType selectedMealType = this.mealTypeController.GetMealTypeByName(this.mealTypeCmbBx.Text);
            if (selectedMealType != null)
            {
                int index = this.recipeMealTypesList.FindIndex(mealType => mealType.type == selectedMealType.type);
                if (index > 0)
                {
                    MessageBox.Show(this.mealTypeCmbBx.Text + "- already added. Please select something else.",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }            
            else if (this.mealTypeCmbBx.Text == "-- Select the Meal Type --")
            {
                MessageBox.Show("Please select valid Meal Type to add",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeMealTypesList.Add(selectedMealType);
            this.DisplayMealTypes();
        }

        private void RemoveMealTypeBtn_Click(object sender, EventArgs e)
        {
            MealType selectedMealType = this.mealTypeController.GetMealTypeByName(this.mealTypeCmbBx.Text);
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
            else if (!this.recipeMealTypesList.Contains(selectedMealType))
            {
                MessageBox.Show(this.mealTypeCmbBx.Text + "- Cannot be removed as it was never added",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeMealTypesList.Remove(selectedMealType);
            this.DisplayMealTypes();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void UpdateRecipeButton_Click(object sender, EventArgs e)
        {
            this.recipe.RecipeName = this.recipeNameTxtBx.Text;
            this.recipe.EthnicId = Convert.ToInt32(this.ethnicityCmbBx.SelectedValue);

            this.nutrition.Carbohydrate = Convert.ToInt32(this.carbTxtBx.Text);
            this.nutrition.Protein = Convert.ToInt32(this.proteinTxtBx.Text);
            this.nutrition.Alcohol = Convert.ToInt32(this.alcoholTxtBx.Text);
            this.nutrition.Fat = Convert.ToInt32(this.fatTxtBx.Text);
            this.nutrition.Calories = Convert.ToInt32(this.calorieTxtBx.Text);
            this.nutrition.ServingSize = this.servingTxtBx.Text;

            try
            {
                bool result = this.recipeController.UpdateRecipe(this.currentUser, this.recipe, this.recipeIngredientList, this.recipeMealTypesList, this.recipeKitchenwareList, this.nutrition);
                if (result)
                {
                    MessageBox.Show("The recipe was updated");
                }
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
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

        private void UpdateAmountBtn_Click(object sender, EventArgs e)
        {
            Ingredient selectedIngredient = this.ingredientsController.GetIngredientByIngredientID(this.ingredientCmbBx.SelectedText);
            if (this.recipeIngredientList.Contains(selectedIngredient))
            {
                if (this.amountTxtBx.Text.Trim() == selectedIngredient.Amount)
                {
                    MessageBox.Show("The amount entered is the same as the current saved amount", "Error!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        bool result = this.recipeController.UpdateAmountOfIngredient(this.currentUser, this.recipe, selectedIngredient);
                        if (result)
                            MessageBox.Show("Ingredient amount was updated successfully");
                    }
                    catch(ArgumentNullException ane)
                    {
                        MessageBox.Show("Failed to update ingredient amount - " + ane.Message, ane.GetType().Name);
                    }
                    catch (UnauthorizedAccessException uae)
                    {
                        MessageBox.Show("Failed to update ingredient amount - " + uae.Message, uae.GetType().Name);
                    }
                }
            }
        }
    }
}
