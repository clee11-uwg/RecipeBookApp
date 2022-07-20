using RecipeBookApp.Controller;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace RecipeBookApp.UserControls
{
    public partial class RecipeMainUserControl : UserControl
    {
        
        private RecipeController recipeController;
        private User currentUser;
        private List<Recipe> recipeList;
        private List<Allergen> allergenList;    
        private List<MealType> mealTypeList;
        private List<FoodType> foodTypeList;
        private List<Ethnic> ethnicList;
        private List<Ingredient> ingredientList;
        private readonly AllergenController allergenController;
        private readonly IngredientsController ingredientsController;        
        private readonly TypeOfMealController mealController;
        private readonly EthnicOriginController ethnicController;

        private readonly TypeOfFoodController foodController;

        /// <summary>
        /// 0 parameter constructor for the RecipeList
        /// </summary>
        public RecipeMainUserControl()
        {
            InitializeComponent();
            this.allergenController = new AllergenController();
            this.ingredientsController = new IngredientsController();         
            this.mealController = new TypeOfMealController();
            this.foodController = new TypeOfFoodController();
            this.ethnicController = new EthnicOriginController();
            this.allergenList = new List<Allergen>();      
            this.mealTypeList = new List<MealType>();
            this.foodTypeList = new List<FoodType>();
            this.ethnicList = new List<Ethnic>();
            this.ingredientList = new List<Ingredient>();         
            this.recipeController = new RecipeController();
            this.recipeList = new List<Recipe>();
            this.currentUser = new User();
            this.LoadComboBox();
            this.Reset();
        }

        /// <summary>
        /// Method to set the current user
        /// </summary>
        /// <param name="currentUser">Current logged in user</param>
        public void SetUser(User currentUser)
        {
            this.currentUser = currentUser;
        }

        private void PopulateItems()
        {
            try
            {
            
                RecipeListItem[] recipeListItems = new RecipeListItem[this.recipeList.Count];
                // Create new list item and add to the flow layout panel
                for (int i = 0; i < recipeListItems.Length; i++)
                {
                    recipeListItems[i] = new RecipeListItem();
                    recipeListItems[i].RecipeId = this.recipeList[i].RecipeId;
                    recipeListItems[i].RecipeName = this.recipeList[i].RecipeName;
                    recipeListItems[i].RecipeImage = this.recipeList[i].RecipeImage;
                    recipeListItems[i].SetUser(this.currentUser);

                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    flowLayoutPanel1.Controls.Add(recipeListItems[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Displaying recipe list items transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateSearchText()
        {
           

            if (this.searchTextBox.Text.Trim() == "")
            {

                MessageBox.Show("Recipe Search input cannot be empty.");
                return false;

            }
            else if (!Regex.IsMatch(this.searchTextBox.Text, "[a-zA-Z]"))
            {
                MessageBox.Show("Recipe Search input should be valid text, cannot be only number or special character");
                return false;
            }

            return true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!ValidateSearchText())
            {
                Reset();
                return;
            }

            this.ProcessUserSearchRecipe(this.searchTextBox.Text.Trim());
        }

        private void ProcessUserSearchRecipe(string recipeUserInput)
        {
            try
            {
               List<Recipe> recipeListSearch = this.recipeController.GetRecipeSearch(recipeUserInput);
                if (!recipeListSearch.Any())
                {
                    
                    MessageBox.Show("No Recipe found on the database");
                    this.Reset();
                    return;

                }
                this.recipeList = recipeListSearch;
                this.flowLayoutPanel1.Controls.Clear();
                this.PopulateItems();
            }

            catch (Exception exe)
            {
                MessageBox.Show("Error occured on - Database transaction -" + exe.Message,
                  "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Resets GUI elements and recipe list
        /// </summary>
        public void Reset()
        {
            this.searchTextBox.Text = "";
            
            this.allergenComboBox.SelectedValue = -1;
            this.ingredientsComboBox.SelectedValue = -1;
            this.ethnicComboBox.SelectedValue = -1;

            this.mealTypeComboBox.SelectedValue = -1;
            this.flowLayoutPanel1.Controls.Clear();
            this.recipeList = this.recipeController.GetRecipes();
            this.PopulateItems();


        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        /// <summary>
        /// Loads the ComboBox to apply filter.
        /// </summary>
        private void LoadComboBox()
        {
            try
            {
                this.CreateAllergenDropDown();
                this.CreateMealTypeDropDown();
                this.CreateIngredientsDropDown();
                this.CreateMealTypeDropDown();
                this.CreateEthnicDropDown();
                this.recipeList = this.recipeController.GetRecipes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Database transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchTextBox.Text = "";
                int[] selectedAllergy;
                int[] selectedEthincity;
                int[] selectedIngredients;
                int[] selectedNutrition = new int[] { -1 }; ;
                int[] selectedKitchenWare = new int[] { -1 }; ;
                int[] selectedMealType;
                int[] selectedFoodType = new int[] { -1 }; ;
                bool isSelected = false;

                if (this.allergenComboBox.SelectedValue != null && int.Parse(this.allergenComboBox.SelectedValue.ToString()) != -1)
                {
                    selectedAllergy = new int[] { int.Parse(this.allergenComboBox.SelectedValue.ToString()) };
                    isSelected = true;
                }
                else
                {
                    selectedAllergy = new int[] { -1 };
                }
                if (this.ethnicComboBox.SelectedValue != null && int.Parse(this.ethnicComboBox.SelectedValue.ToString()) != -1)
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

                if (this.mealTypeComboBox.SelectedValue != null && int.Parse(this.mealTypeComboBox.SelectedValue.ToString()) != -1)
                {
                    selectedMealType = new int[] { int.Parse(this.mealTypeComboBox.SelectedValue.ToString()) };
                    isSelected = true;
                }
                else
                {
                    selectedMealType = new int[] { -1 };
                }

                if (!isSelected)
                {
                    MessageBox.Show("Please select atleast one options to filter");
                    return;
                }


                this.recipeList = this.recipeController.FilterRecipes(selectedAllergy, selectedEthincity,
                    selectedFoodType, selectedIngredients, selectedKitchenWare, selectedMealType, selectedNutrition);

                this.flowLayoutPanel1.Controls.Clear();
                this.PopulateItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Apply Filter transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void KitchenWareComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void EthnicComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void IngredientsComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void FoodComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void MealTypeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AllergenComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CreateAllergenDropDown()
        {
            try
            {
                this.allergenComboBox.DataSource = null;
                this.allergenList = this.allergenController.GetAllergens();
                this.allergenList.Add(new Allergen
                {
                    AllergenId = -1,
                    AllergenDetails = "Select the allergy"
                });
                this.allergenComboBox.DataSource = this.allergenList;
                this.allergenComboBox.DisplayMember = "AllergenDetails";
                this.allergenComboBox.ValueMember = "AllergenId";
                this.allergenComboBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured on - Apply Filter Allergen transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CreateIngredientsDropDown()
        {
            try
            {
                this.ingredientsComboBox.DataSource = null;
                this.ingredientList = this.ingredientsController.GetIngredients();
                this.ingredientList.Add(new Ingredient
                {
                    IngredientId = -1,
                    IngredientName = "Select the Ingredient"
                });
                this.ingredientsComboBox.DataSource = this.ingredientList;
                this.ingredientsComboBox.DisplayMember = "IngredientName";
                this.ingredientsComboBox.ValueMember = "IngredientId";
                this.ingredientsComboBox.SelectedValue = -1;
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
                this.mealTypeComboBox.DataSource = null;
                this.mealTypeList = this.mealController.GetMealTypes();
                this.mealTypeList.Add(new MealType
                {
                    mealTypeID = -1,
                    type = "Select the MealType"
                });
                this.mealTypeComboBox.DataSource = this.mealTypeList;
                this.mealTypeComboBox.DisplayMember = "type";
                this.mealTypeComboBox.ValueMember = "mealTypeID";
                this.mealTypeComboBox.SelectedValue = -1;
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

                this.ethnicComboBox.DataSource = null;
                this.ethnicList = this.ethnicController.GetEthnicOrigins();
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
                MessageBox.Show("Error occured on - Apply Filter Ethnic transaction -" + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MealTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.searchTextBox.Text = "";
        }

        private void IngredientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.searchTextBox.Text = "";
        }

        private void AllergenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.searchTextBox.Text = "";
        }

        private void EthnicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.searchTextBox.Text = "";
        }

      private void RecipeMainUserControl_Load(object sender, EventArgs e)
        {
            this.LoadComboBox();          
            this.PopulateItems();           
        }

        private void RecipeMainUserControl_VisibleChanged(object sender, EventArgs e)
        {
            this.Reset();
            if (UserController.GetLoginUser() != null)
            {
                this.favLabel.Visible = true;

            }
        }

        private void FavLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (UserController.GetLoginUser() != null) { 
                List <Recipe> favList =this.recipeController.GetFavoriteRecipes(UserController.GetLoginUser().ID);
                if (favList.Any())
                {
                    this.recipeList = favList;
                    this.flowLayoutPanel1.Controls.Clear();
                    this.PopulateItems();
                }
                else
                {
                    MessageBox.Show("You have no favorites recipe, please add some");
                    this.Reset();
                    return;
                }
                
            }
            
        }
    }



}
