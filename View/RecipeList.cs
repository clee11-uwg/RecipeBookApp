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
        private List<Allergen> allergenList;
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
            this.mealController = new TypeOfMealController();
            this.foodController = new TypeOfFoodController();
            this.ethnicController = new EthnicOriginController();
            this.allergenList= new List<Allergen>();
            this.nutritionList = new List<Nutrition>();
            this.kitchenWareList =  new List<Kitchenware>();
            this.mealTypeList = new List<MealType>();
            this.foodTypeList = new List<FoodType>();
            this.ethnicList = new List<Ethnic>();
            this.ingredientList = new List<Ingredient>();

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
            this.allergenComboBox.SelectedValue = -1;
            this.ingredientsComboBox.SelectedValue = -1;
            this.ethnicComboBox.SelectedValue = -1;
            this.foodComboBox.SelectedValue = -1;
            this.mealTypeComboBox.SelectedValue = -1;
            this.nutritionComboBox.SelectedValue = -1;
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
                this.nutritionComboBox.DataSource = null;                
                this.kitchenWareComboBox.DataSource = null;           
                this.ingredientsComboBox.DataSource = null;               
                this.mealTypeComboBox.DataSource = null;                
                this.foodComboBox.DataSource = null;            
                this.ethnicComboBox.DataSource = null;
                
                this.allergenList= this.allergenController.GetAllergens();
                this.nutritionList = this.nutritionController.GetNutritions();
                this.kitchenWareList = this.kitchenController.GetKitchenware();
                this.ingredientList = this.ingredientsController.GetIngredients();
                this.mealTypeList = this.mealController.GetMealTypes();
                this.foodTypeList = this.foodController.GetFoodTypes();
                this.ethnicList = this.ethnicController.GetEthnicOrigins();
                this.allergenList.Add(new Allergen
                {
                    AllergenId = -1,
                    AllergenDetails = "Select the allergy"
                });
                this.allergenComboBox.DataSource = this.allergenList;
                this.allergenComboBox.DisplayMember = "AllergenDetails";
                this.allergenComboBox.ValueMember = "AllergenId" ;
                this.allergenComboBox.SelectedValue = -1;

                this.nutritionList.Add(new Nutrition
                {
                    NutritionId = -1,
                    NutritionDetails = "Select the Nutrition"
                });
                this.nutritionComboBox.DataSource = this.nutritionList;
                this.nutritionComboBox.ValueMember = "NutritionId";
                this.nutritionComboBox.DisplayMember = "NutritionDetails";
                this.nutritionComboBox.SelectedValue = -1;

                this.kitchenWareList.Add(new Kitchenware
                {
                    KitchenwareId = -1,
                    KitchenwareDetails = "Select the Kitchenware"
                });
                this.kitchenWareComboBox.DataSource = this.kitchenWareList;
                this.kitchenWareComboBox.DisplayMember = "KitchenwareDetails";
                this.kitchenWareComboBox.ValueMember = "KitchenwareId";
                this.kitchenWareComboBox.SelectedValue = -1;


                this.ingredientList.Add(new Ingredient
                {
                    IngredientId = -1,
                    IngredientName = "Select the Ingredient"
                });
                this.ingredientsComboBox.DataSource = this.ingredientList;
                this.ingredientsComboBox.DisplayMember = "IngredientName";
                this.ingredientsComboBox.ValueMember = "IngredientId";
                this.ingredientsComboBox.SelectedValue = -1;

                this.mealTypeList.Add(new MealType
                {
                    mealTypeID = -1,
                    type = "Select the MealType"
                });
                this.mealTypeComboBox.DataSource = this.mealTypeList;
                this.mealTypeComboBox.DisplayMember = "type";
                this.mealTypeComboBox.ValueMember = "mealTypeID";
                this.mealTypeComboBox.SelectedValue = -1;

                this.foodTypeList.Add(new FoodType
                {
                    FoodId = -1,
                    TypeOfFood = "Select the Food type"
                });
                this.foodComboBox.DataSource = this.foodTypeList;
                this.foodComboBox.DisplayMember = "TypeOfFood";
                this.foodComboBox.ValueMember = "FoodId";
                this.foodComboBox.SelectedValue = -1;

                this.ethnicList.Add(new Ethnic
                {
                    EthnicId = -1,
                    Ethnicity = "Select the Ethnicity"
                });
                this.ethnicComboBox.DataSource = this.ethnicList;
                this.ethnicComboBox.DisplayMember = "Ethnicity";
                this.ethnicComboBox.ValueMember = "EthnicId";
                this.ethnicComboBox.SelectedValue = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Database transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FilterButton_Click(object sender, EventArgs e)
        {
            int[] selectedAllergy;
            int[] selectedEthincity;
            int[] selectedIngredients;
            int[] selectedNutrition;
            int[] selectedKitchenWare;
            int[] selectedMealType;
            int[] selectedFoodType;
            bool isSelected = false;

            if (this.allergenComboBox.SelectedValue!=null && int.Parse(this.allergenComboBox.SelectedValue.ToString()) != -1)
            {
                 selectedAllergy = new int[] { int.Parse(this.allergenComboBox.SelectedValue.ToString()) };
                isSelected = true;
            }
            else
            {
                selectedAllergy = new int[] { -1 };
            }
            if (this.ethnicComboBox.SelectedValue != null &&  int.Parse(this.ethnicComboBox.SelectedValue.ToString()) != -1)
            {
                selectedEthincity = new int[] { int.Parse(this.ethnicComboBox.SelectedValue.ToString()) };
                isSelected = true;
            }
            else
            {
                selectedEthincity = new int[] { -1 };
            }
            if (this.ingredientsComboBox.SelectedValue != null && int.Parse(this.ingredientsComboBox.SelectedValue.ToString()) != -1)
            {
               selectedIngredients = new int[] { int.Parse(this.ingredientsComboBox.SelectedValue.ToString()) };
                isSelected = true;

            }
            else
            {
                selectedIngredients = new int[] { -1 };
            }
            if (this.nutritionComboBox.SelectedValue != null && int.Parse(this.nutritionComboBox.SelectedValue.ToString()) != -1)
            {
               selectedNutrition = new int[] { int.Parse(this.nutritionComboBox.SelectedValue.ToString()) };
                isSelected = true;
            }
            else
            {
                selectedNutrition = new int[] { -1 };
            }
            if (this.kitchenWareComboBox.SelectedValue != null && int.Parse(this.kitchenWareComboBox.SelectedValue.ToString()) != -1)
            {
             selectedKitchenWare = new int[] { int.Parse(this.kitchenWareComboBox.SelectedValue.ToString()) };
                isSelected = true;
            }
            else
            {
                selectedKitchenWare = new int[] { -1 };
            }
            if (this.mealTypeComboBox.SelectedValue != null && int.Parse(this.mealTypeComboBox.SelectedValue.ToString()) != -1)
            {
                 selectedMealType = new int[] { int.Parse(this.mealTypeComboBox.SelectedValue.ToString()) };
                isSelected = true;
            }
            else
            {
                selectedMealType = new int[] { -1 };
            }
            if (this.foodComboBox.SelectedValue != null && int.Parse(this.foodComboBox.SelectedValue.ToString()) != -1)
            {
                 selectedFoodType = new int[] { 0 };
                isSelected = true;
            }
            else
            {
                selectedFoodType = new int[] { -1 };
            }
            if (!isSelected)
            {
                MessageBox.Show("Please select atleast one options to filter");
                return;
            }

            this.recipeList = this.recipeController.FilterRecipes(selectedAllergy, selectedEthincity, selectedFoodType,
               selectedIngredients,selectedKitchenWare, selectedMealType, selectedNutrition);

            this.flowLayoutPanel1.Controls.Clear();
            this.PopulateItems();


        }
    }
}
