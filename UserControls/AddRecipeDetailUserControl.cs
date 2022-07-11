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

namespace RecipeBookApp.UserControls
{

    public partial class AddRecipeDetailUserControl : UserControl
    {

        private List<Recipe> recipeList;
        private List<Nutrition> nutritionList;
        private List<Kitchenware> kitchenWareList;
        private List<MealType> mealTypeList;
        private List<FoodType> foodTypeList;
        private List<Ethnic> ethnicList;
        private List<Ingredient> ingredientList;

        private readonly AllergenController allergenController;
        private readonly IngredientsController ingredientsController;
        private readonly KitchenwareController kitchenController;
        private readonly NutritionController nutritionController;
        private readonly TypeOfMealController mealController;
        private readonly EthnicOriginController ethnicController;

        private readonly TypeOfFoodController foodController;
        public AddRecipeDetailUserControl()
        {
            InitializeComponent();
            this.allergenController = new AllergenController();
            this.ingredientsController = new IngredientsController();
            this.kitchenController = new KitchenwareController();
            this.mealController = new TypeOfMealController();
            this.foodController = new TypeOfFoodController();
            this.ethnicController = new EthnicOriginController();           ;
            this.kitchenWareList = new List<Kitchenware>();
            this.mealTypeList = new List<MealType>();
            this.foodTypeList = new List<FoodType>();
            this.ethnicList = new List<Ethnic>();
            this.ingredientList = new List<Ingredient>();
        
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
    }
}
