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
                
                this.allergenComboBox.DataSource = this.allergenController.GetAllergens();

                this.allergenComboBox.DisplayMember = "AllergenDetails";
                this.allergenComboBox.ValueMember = "AllergenId" ;
                this.allergenComboBox.SelectedValue = "Select";

                this.nutritionComboBox.DataSource = this.nutritionController.GetNutritions();
                this.nutritionComboBox.ValueMember = "NutritionId";
                this.nutritionComboBox.DisplayMember = "NutritionDetails";
                this.nutritionComboBox.SelectedValue = "Select";

                this.kitchenWareComboBox.DataSource = this.kitchenController.GetKitchenware();
                this.kitchenWareComboBox.DisplayMember = "KitchenwareDetails";
                this.kitchenWareComboBox.ValueMember = "KitchenwareId";
                this.kitchenWareComboBox.SelectedValue = "Select";

                this.ingredientsComboBox.DataSource = this.ingredientsController.GetIngredients();
                this.ingredientsComboBox.DisplayMember = "IngredientName";
                this.ingredientsComboBox.ValueMember = "IngredientId";
                this.ingredientsComboBox.SelectedValue = "Select";


                this.mealTypeComboBox.DataSource = this.mealController.GetMealTypes();
                this.mealTypeComboBox.DisplayMember = "type";
                this.mealTypeComboBox.ValueMember = "mealTypeID";
                this.mealTypeComboBox.SelectedValue = "Select";

                this.foodComboBox.DataSource = this.foodController.GetFoodTypes();
                this.foodComboBox.DisplayMember = "TypeOfFood";
                this.foodComboBox.ValueMember = "FoodId";
                this.foodComboBox.SelectedValue = "Select";

                this.ethnicComboBox.DataSource = this.ethnicController.GetEthnicOrigins();
                this.ethnicComboBox.DisplayMember = "Ethnicity";
                this.ethnicComboBox.ValueMember = "EthnicId";
                this.ethnicComboBox.SelectedValue = "Select";


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

            if (this.allergenComboBox.SelectedValue!=null)
            {
                 selectedAllergy = new int[] { int.Parse(this.allergenComboBox.SelectedValue.ToString()) };
            }
            else
            {
                selectedAllergy = new int[] { -1 };
            }
            if (this.ethnicComboBox.SelectedValue != null)
            {
                selectedEthincity = new int[] { int.Parse(this.ethnicComboBox.SelectedValue.ToString()) };
            }
            else
            {
                selectedEthincity = new int[] { -1 };
            }
            if (this.ingredientsComboBox.SelectedValue != null)
            {
               selectedIngredients = new int[] { int.Parse(this.ingredientsComboBox.SelectedValue.ToString()) };
               
            }
            else
            {
                selectedIngredients = new int[] { -1 };
            }
            if (this.nutritionComboBox.SelectedValue != null)
            {
               selectedNutrition = new int[] { int.Parse(this.nutritionComboBox.SelectedValue.ToString()) };
            }
            else
            {
                selectedNutrition = new int[] { -1 };
            }
            if (this.kitchenWareComboBox.SelectedValue != null)
            {
             selectedKitchenWare = new int[] { int.Parse(this.kitchenWareComboBox.SelectedValue.ToString()) };
            }
            else
            {
                selectedKitchenWare = new int[] { -1 };
            }
            if (this.mealTypeComboBox.SelectedValue != null)
            {
                 selectedMealType = new int[] { int.Parse(this.mealTypeComboBox.SelectedValue.ToString()) };
            }
            else
            {
                selectedMealType = new int[] { -1 };
            }
            if (this.foodComboBox.SelectedValue != null)
            {
                 selectedFoodType = new int[] { 0 }; 
            }
            else
            {
                selectedFoodType = new int[] { -1 };
            }

            this.recipeList = this.recipeController.FilterRecipes(selectedAllergy, selectedEthincity, selectedFoodType,
               selectedIngredients,selectedKitchenWare, selectedMealType, selectedNutrition);
            this.flowLayoutPanel1.Controls.Clear();
            this.PopulateItems();


        }
    }
}
