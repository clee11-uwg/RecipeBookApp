using RecipeBookApp.Controller;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RecipeBookApp.UserControls
{

    public partial class AddRecipeDetailUserControl : UserControl
    {

        private List<Recipe> recipeList;
        
        private Nutrition addNutrition;
        private List<Kitchenware> kitchenWareList;
        private List<MealType> mealTypeList;
        private List<FoodType> foodTypeList;
        private List<Ethnic> ethnicList;
        private List<Ingredient> ingredientList;
        private RecipeController recipeController;
        private readonly AllergenController allergenController;
        private readonly IngredientsController ingredientsController;
        private readonly KitchenwareController kitchenController;
        private readonly NutritionController nutritionController;
        private readonly TypeOfMealController mealController;
        private readonly EthnicOriginController ethnicController;
        private List<string> recipeIngredients;
        private List<string> recipeMealtype;
        private List<string> recipeKitchenWare;
        private string displayMessage;
        private const int MaxLength = 2000;


        private readonly TypeOfFoodController foodController;
        public AddRecipeDetailUserControl()
        {
            InitializeComponent();
            this.allergenController = new AllergenController();
            this.ingredientsController = new IngredientsController();
            this.kitchenController = new KitchenwareController();
            this.mealController = new TypeOfMealController();
            this.foodController = new TypeOfFoodController();
            this.ethnicController = new EthnicOriginController();
            this.recipeController = new RecipeController(); ;
            this.kitchenWareList = new List<Kitchenware>();
            this.mealTypeList = new List<MealType>();
            this.foodTypeList = new List<FoodType>();
            this.ethnicList = new List<Ethnic>();
            this.ingredientList = new List<Ingredient>();
            this.recipeIngredients = new List<string>();
            this.recipeKitchenWare = new List<string>();
            this.recipeMealtype = new List<string>();

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
               
                this.CreateEthnicDropDown();
                this.recipeList = this.recipeController.GetRecipes();
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
            this.ErrorReset();
        }

        private void AddIngredientCombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddKitchenWareComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddRecipeMealTypeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddFoodTypeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddEthnicCombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ErrorReset(){


            this.erroLabel.Visible = false;
            this.erroLabel.Visible = false;
            this.recipeNameError.Visible = false;
            this.addErrorNutritionLabel.Visible = false;
            this.addErrorIngredientsLabel.Visible = false;
            this.addErrorKitchenwareLabel.Visible = false;
            this.addErrorMealTypeLabel.Visible = false;
            this.cookError.Visible = false;
            this.instructionErrorLabel.Visible = false;
        }
        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            this.ErrorReset();
            bool isError = false;
            if (!ValidateRecipeName())
            {
                isError=true;
            }
            if (!ValidateNutritions()) {
                isError = true;
            }
            if (!ValidateIngredients())
            {
                isError = true;
            }
            if (!ValidateKitchenWare())
            {
                isError = true;
            }
            if (!ValidateMealType())
            {
                isError = true;
            }
            if (!ValidateInstructions())
            {
                isError = true;
            }
            if (!ValidateCookingTime())
            {
                isError = true;
            }
            if (isError)
            {
                return;
            }
                this.CollectNutritionData();
                this.ProcessNewRecipe();
            

        }
        private void ProcessNewRecipe()
        {
            string message = "Do you want to proceed adding new recipe?";
       
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, "New recipe", buttons);

       
        Recipe newRecipe = new Recipe
            {
                RecipeName = this.addRecipenameTextBox.Text,
                RecipeInstructions= this.recipeInstructions.Text,


            };

            if (result == DialogResult.OK)
            {

               
             //this.recipeController.AddRecipe(UserController.GetLoginUser(),)
                //  this.recipeController.AddRecipe(this.addRecipenameTextBox.Text, this.addNutrition,this.recipeIngredients,this.mealTypeList,this.nutritionList);
                this.displayMessage = "Congratulations..! You have succeessfully added new Recipe!!";
                this.DisplayError(false);
            }
            else
            {
                return;
            }


        }
        private void CollectNutritionData()
        {
            this.addNutrition = new Nutrition
            {
                Carbohydrate = int.Parse(this.calorieTextBox.Text),
                Protein = int.Parse(this.proteinTextBox.Text),
                Fat = int.Parse(this.fattextBox.Text),
                Alcohol = int.Parse(this.calorieTextBox.Text),
                Calories = int.Parse(this.calorieTextBox.Text),
                ServingSize = this.servingtextBox.Text
            };

        }
        private bool ValidateIngredients() {

            if (string.IsNullOrEmpty(this.addIngredIentsRichBox.Text))
            {
                this.addErrorIngredientsLabel.ForeColor = Color.Red;
                this.addErrorIngredientsLabel.Text = "Ingredients Name cannot be empty";
                this.addErrorIngredientsLabel.Visible = true;
             
                return false;
            }
            return true;
        }

        private bool ValidateKitchenWare()
        {


            if (string.IsNullOrEmpty(this.addKitchenwareRichTextBox.Text))
            {
                this.addErrorKitchenwareLabel.ForeColor = Color.Red;
                this.addErrorKitchenwareLabel.Text = "KitchenWare is Mandatoryy";
                this.addErrorKitchenwareLabel.Visible = true;

                return false;
            }
            return true;
        }

        private bool ValidateCookingTime()
        {


            if (!string.IsNullOrEmpty(this.cooktimeBox.Text) && !Regex.IsMatch(this.cooktimeBox.Text, @"^\d+$"))
            {
                this.cookError.ForeColor = Color.Red;
                this.cookError.Text = "Cooking time should be a valid number !";
                this.cookError.Visible = true;
                return false;

            }
            return true;
        }

        private bool ValidateMealType()
        {


            if (this.addRecipeMealTypeComboBox.Text == "Select the MealType")
            {
                this.addErrorMealTypeLabel.ForeColor = Color.Red;
                this.addErrorMealTypeLabel.Text = "Meal Type is Mandatory";
                this.addErrorMealTypeLabel.Visible = true;

                return false;
            }
            return true;
        }
        private bool ValidateRecipeName()
        {

            string recipName = this.addRecipenameTextBox.Text;
            bool nameExists = this.recipeList.Any(name => name.RecipeName == recipName);
            if (string.IsNullOrEmpty(recipName) || recipName.Trim() == "")
            {
                this.recipeNameError.ForeColor = Color.Red;
                this.recipeNameError.Text = "Recipe Name cannot be empty";
                this.recipeNameError.Visible = true;
                return false;
            }

            else if (nameExists)
            {
                this.recipeNameError.ForeColor = Color.Red;
                this.recipeNameError.Text = this.addRecipenameTextBox.Text + " - Recipe with this name already Exists, plesae choose different name";
                this.recipeNameError.Visible = true;
                return false;
            }
          
            else if (!Regex.IsMatch(recipName, "[a-zA-Z]"))
            {
               
                this.recipeNameError.ForeColor = Color.Red;
                this.recipeNameError.Text = this.addRecipenameTextBox.Text + " - Recipe Name should be valid text, cannot be only number or special character";
                this.recipeNameError.Visible = true;
                return false;
            }

            return true;
        }

        private bool ValidateInstructions()
        {
            string recipeInstructions = this.recipeInstructions.Text;
            if (string.IsNullOrEmpty(recipeInstructions))
            {
                this.instructionErrorLabel.ForeColor = Color.Red;
                this.instructionErrorLabel.Text = "Recipe Instructions cannot be empty";
                this.instructionErrorLabel.Visible = true;
                return false;
            }

            else if (recipeInstructions.Length > MaxLength)
            {
                this.instructionErrorLabel.ForeColor = Color.Red;
                this.instructionErrorLabel.Text = this.addRecipenameTextBox.Text + " - Recipe Instructions exceeding 2000 char limit. Cannot save this data";
                this.instructionErrorLabel.Visible = true;
                return false;
            }
            return true;
        }
        private bool ValidateNutritions()
        {
            this.displayMessage = "Carbohydrate,Protein,Fats,Alcohol,Calorie should be a valid number !";
            if (string.IsNullOrEmpty(this.carbTextBox.Text) || string.IsNullOrEmpty(this.proteinTextBox.Text) || 
                string.IsNullOrEmpty(this.fattextBox.Text) || string.IsNullOrEmpty(this.alchoholTextBox.Text) 
                || string.IsNullOrEmpty(this.calorieTextBox.Text))
            {
                this.displayMessage = "Carbohydrate,Protein,Fat,Alcohol,Calories - should be a valid number or cannot be empty";
                this.addErrorNutritionLabel.ForeColor = Color.Red;
                this.addErrorNutritionLabel.Text = this.displayMessage;
                this.addErrorNutritionLabel.Visible = true;
                return false;
            }

            else if (!Regex.IsMatch(this.carbTextBox.Text, @"^\d+$"))
            {
              
                this.addErrorNutritionLabel.ForeColor = Color.Red;
                this.addErrorNutritionLabel.Text = this.displayMessage;
                this.addErrorNutritionLabel.Visible = true;
                this.carbTextBox.Focus();
              
            }
             if(!Regex.IsMatch(this.proteinTextBox.Text, @"^\d+$"))
            {
                this.addErrorNutritionLabel.ForeColor = Color.Red;
                this.addErrorNutritionLabel.Text = this.displayMessage;
                this.addErrorNutritionLabel.Visible = true;
                this.proteinTextBox.Focus();
            
            }
             if(!Regex.IsMatch(this.fattextBox.Text, @"^\d+$"))
            {
                this.addErrorNutritionLabel.ForeColor = Color.Red;
                this.addErrorNutritionLabel.Text = this.displayMessage;
                this.addErrorNutritionLabel.Visible = true;
                this.fattextBox.Focus();
            
            }
            if (!Regex.IsMatch(this.alchoholTextBox.Text, @"^\d+$"))
            {
                this.addErrorNutritionLabel.ForeColor = Color.Red;
                this.addErrorNutritionLabel.Text = this.displayMessage;
                this.addErrorNutritionLabel.Visible = true;
                this.alchoholTextBox.Focus();
            
            }
             if(!Regex.IsMatch(this.calorieTextBox.Text, @"^\d+$"))
            {
                this.addErrorNutritionLabel.ForeColor = Color.Red;
                this.addErrorNutritionLabel.Text = this.displayMessage;
                this.addErrorNutritionLabel.Visible = true;
                this.calorieTextBox.Focus();
           
            }           
            return true;
        }
        private void DisplayError( bool isError)
        {
            if (string.IsNullOrEmpty(this.displayMessage))
            {
                throw new ArgumentException("Message cannot be null or empty");
            }
            if (isError)
            {
                this.erroLabel.ForeColor = Color.Red;
            }
            else
            {
                this.erroLabel.ForeColor = Color.Green;
            }
            this.erroLabel.Text = this.displayMessage;
            this.erroLabel.Visible = true;
        }

        private void AddIngredients_Click(object sender, EventArgs e)
        {
            if (this.recipeIngredients.Contains(this.addIngredientCombobox.Text))
            {
                MessageBox.Show(this.addIngredientCombobox.Text + "- already added. Please select something else.",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.addIngredientCombobox.Text == "Select the Ingredient")
            {
                MessageBox.Show("Please select valid Ingredients to add",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeIngredients.Add(this.addIngredientCombobox.Text.ToString());
            this.DisplayIngredients();

        }
        private void DisplayIngredients()
        {
            this.addIngredIentsRichBox.Text=  string.Join(",", this.recipeIngredients);
            this.addIngredIentsRichBox.Refresh();
        }

        private void RemoveIngrdients_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.addIngredIentsRichBox.Text))
            {
                MessageBox.Show("No Ingredient present. Please add Ingredients",
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.addIngredientCombobox.Text == "Select the Ingredient")
            {
                MessageBox.Show("Please select valid Ingredients to Remove",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!this.recipeIngredients.Contains(this.addIngredientCombobox.Text))
            {
                MessageBox.Show(this.addIngredientCombobox.Text + " - Cannot be removed as it was never added",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                   
            this.recipeIngredients.Remove(this.addIngredientCombobox.Text);           
            this.DisplayIngredients();
          
        }

        private void AddmealButton_Click(object sender, EventArgs e)
        {
            if (this.recipeMealtype.Contains(this.addRecipeMealTypeComboBox.Text))
            {
                MessageBox.Show(this.addRecipeMealTypeComboBox.Text + "- already added. Please select something else.",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.addRecipeMealTypeComboBox.Text == "Select the MealType")
            {
                MessageBox.Show("Please select valid Meal Type to add",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeMealtype.Add(this.addRecipeMealTypeComboBox.Text.ToString());
            this.DisplayMeals();

        }
        private void DisplayMeals()
        {
            this.addMealTypeRichText.Text = string.Join(",", this.recipeMealtype);
            this.addMealTypeRichText.Refresh();
        }
        private void RemoveMealButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.addRecipeMealTypeComboBox.Text))
            {
                MessageBox.Show("No Meal Type present. Please add Meal Type",
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.addRecipeMealTypeComboBox.Text == "Select the MealType")
            {
                MessageBox.Show("Please select valid Meal Type to Remove",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!this.recipeMealtype.Contains(this.addRecipeMealTypeComboBox.Text))
            {
                MessageBox.Show(this.addRecipeMealTypeComboBox.Text + "- Cannot be removed as it was never added",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeMealtype.Remove(this.addRecipeMealTypeComboBox.Text);
            this.DisplayMeals();
        }

        private void AddKitchennware_Click(object sender, EventArgs e)
        {
            if (this.recipeKitchenWare.Contains(this.addKitchenWareComboBox.Text))
            {
                MessageBox.Show(this.addKitchenWareComboBox.Text + " - already added. Please select something else.",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.addKitchenWareComboBox.Text == "Select the KitchenWare")
            {
                MessageBox.Show("Please select valid kitchenware to add",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.recipeKitchenWare.Add(this.addKitchenWareComboBox.Text.ToString());
            this.DisplayKitchenwares();

        }

        private void RemovKitchenware_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.addKitchenWareComboBox.Text))
            {
                MessageBox.Show("No kitchenware present. Please add kitchenware",
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.addKitchenWareComboBox.Text == "Select the KitchenWare")
            {
                MessageBox.Show("Please select valid kitchenware to Remove",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!this.recipeKitchenWare.Contains(this.addKitchenWareComboBox.Text))
            {
                MessageBox.Show(this.addKitchenWareComboBox.Text + "- Cannot be removed as it was never added",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.recipeKitchenWare.Remove(this.addKitchenWareComboBox.Text);
            this.DisplayKitchenwares();
        }
        private void DisplayKitchenwares()
        {
            this.addKitchenwareRichTextBox.Text = string.Join(",", this.recipeKitchenWare);
            this.addKitchenwareRichTextBox.Refresh();
        }

        private void AddRecipeResetButton_Click(object sender, EventArgs e)
        {
            this.ErrorReset();
            this.addRecipenameTextBox.Clear();
            this.carbTextBox.Clear();
            this.proteinTextBox.Clear();
            this.fattextBox.Clear();
            this.calorieTextBox.Clear();
            this.alchoholTextBox.Clear();
            this.addKitchenwareRichTextBox.Text = "";
            this.addIngredIentsRichBox.Text = "";
            this.addRecipeMealTypeComboBox.Text = "Select the MealType";
            this.addIngredientCombobox.Text = "Select the Ingredient";
            this.addKitchenWareComboBox.Text = "Select the KitchenWare";
            this.addEthnicCombobox.Text = "Select the Ethnicity";
        }

        private void Uploadbutton_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog open = new OpenFileDialog();             
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
          
                this.imageTextBox.Text = open.FileName;
            }
        }

        private void AddInstructionlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Form instructionDialog = new View.AddRecipeInstructionDialog(this.recipeInstructions.Text))
            {
                DialogResult result = instructionDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.recipeInstructions.Text = RecipeController.GetRecipeInstructions();
                }else
                {
                    this.recipeInstructions.Text = "";
                }
            }
        }

        
    }
}
