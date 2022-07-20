using RecipeBookApp.Controller;
using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private List<Ingredient> recipeIngredients;
        private List<MealType> recipeMealtype;
        private List<Kitchenware> recipeKitchenWare;
        private string displayMessage;
        private const int maxLength = 2000;
        private Image recipeImage ;


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
            this.recipeIngredients = new List<Ingredient>();
            this.recipeKitchenWare = new List<Kitchenware>();
            this.recipeMealtype = new List<MealType>();
            this.recipeImage = null;
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
            this.imageFailureLabel.Visible = false;
        }
        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            this.ErrorReset();
            bool isError = false;
            this.recipeList = this.recipeController.GetRecipes();
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
            if (!this.UploadFileImageSucess())
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
            try
            {
                string message = "Do you want to proceed adding new recipe?";

                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, "New recipe", buttons);


                Recipe newRecipe = new Recipe();
                newRecipe.RecipeName = this.addRecipenameTextBox.Text;
                newRecipe.RecipeInstructions = this.recipeInstructions.Text;
                if (this.recipeImage != null)
                {
                    newRecipe.RecipeImage = this.recipeImage;
                }
              
                newRecipe.CookingTime = int.Parse(this.cooktimeBox.Text);
                newRecipe.UserWhoCreated = UserController.GetLoginUser().Name;              


                if (result == DialogResult.OK)
                {
                    try
                    {
                        this.recipeController.AddRecipe(UserController.GetLoginUser(), newRecipe, 
                            recipeIngredients, recipeMealtype, recipeKitchenWare, this.addNutrition);
                            //  this.recipeController.AddRecipe(this.addRecipenameTextBox.Text, this.addNutrition,this.recipeIngredients,this.mealTypeList,this.nutritionList);
                        this.displayMessage = "Congratulations..! You have succeessfully added new Recipe!!";
                        this.DisplayError(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured on - adding recipe -" + ex.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
             
            catch(Exception e){
                this.erroLabel.ForeColor = Color.Red;
                this.erroLabel.Text = e.Message;
                this.erroLabel.Visible = true;
            }


}
        private void CollectNutritionData()
        {
            try
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
            catch( Exception e){
                this.addErrorNutritionLabel.ForeColor = Color.Red;
                this.addErrorNutritionLabel.Text = e.Message;
                this.addErrorNutritionLabel.Visible = true;
            }

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


            if (string.IsNullOrEmpty(this.addMealTypeRichText.Text))
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

            else if (recipeInstructions.Length > maxLength)
            {
                this.instructionErrorLabel.ForeColor = Color.Red;
                this.instructionErrorLabel.Text = this.addRecipenameTextBox.Text + " - Recipe Instructions exceeding 2000 char limit. Cannot save this data";
                this.instructionErrorLabel.Visible = true;
                return false;
            }
            return true;
        }

        private bool UploadFileImageSucess()
        {

            if (string.IsNullOrEmpty(this.imageTextBox.Text))
            {
                this.imageFailureLabel.ForeColor = Color.Red;
                this.imageFailureLabel.Text = "Please upload the image file";
                this.imageFailureLabel.Visible = true;
                return false;
            }
            else 
            {
                bool fileExist = File.Exists(this.imageTextBox.Text);
                if (fileExist)
                {
                    this.recipeImage = Image.FromFile(this.imageTextBox.Text);
                    return true;
                }
                else
                {
                    this.imageFailureLabel.ForeColor = Color.Red;
                    this.imageFailureLabel.Text = this.imageTextBox.Text + " - File does not existis";
                    this.imageFailureLabel.Visible = true;
                    return false;
                }
            }
         
           
            
        }
        private bool ValidateNutritions()
        {
            this.displayMessage = "Carbohydrate,Protein,Fats,Alcohol,Calorie should be a valid number !";
            if (string.IsNullOrEmpty(this.carbTextBox.Text) || string.IsNullOrEmpty(this.proteinTextBox.Text) || 
                string.IsNullOrEmpty(this.fattextBox.Text) || string.IsNullOrEmpty(this.alchoholTextBox.Text) 
                || string.IsNullOrEmpty(this.calorieTextBox.Text) ||  string.IsNullOrEmpty(this.servingtextBox.Text))
            {
                this.displayMessage = "Carbohydrate,Protein,Fat,Alcohol,Calories, Serving Size - should be a valid number or cannot be empty";
                this.addErrorNutritionLabel.ForeColor = Color.Red;
                this.addErrorNutritionLabel.Text = this.displayMessage;
                this.addErrorNutritionLabel.Visible = true;
                return false;
            }

             if (!Regex.IsMatch(this.carbTextBox.Text, @"^\d+$"))
            {
              
                this.addErrorNutritionLabel.ForeColor = Color.Red;
                this.addErrorNutritionLabel.Text = this.displayMessage;
                this.addErrorNutritionLabel.Visible = true;
               
              
            }
             if(!Regex.IsMatch(this.proteinTextBox.Text, @"^\d+$"))
            {
                this.addErrorNutritionLabel.ForeColor = Color.Red;
                this.addErrorNutritionLabel.Text = this.displayMessage;
                this.addErrorNutritionLabel.Visible = true;
               
            
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
               
            
            }
             if(!Regex.IsMatch(this.calorieTextBox.Text, @"^\d+$"))
            {
                this.addErrorNutritionLabel.ForeColor = Color.Red;
                this.addErrorNutritionLabel.Text = this.displayMessage;
                this.addErrorNutritionLabel.Visible = true;
               
           
            } 
             if (this.servingtextBox.Text.Length > 15)
            {
                this.addErrorNutritionLabel.ForeColor = Color.Red;
                this.addErrorNutritionLabel.Text =  "Serving size cannot exceed length of 15 char)";
                this.addErrorNutritionLabel.Visible = true;
             
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

            var recipeName = this.recipeIngredients.FirstOrDefault(x => x.IngredientName == this.addIngredientCombobox.Text);
            if (recipeName != null)
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

            Ingredient selectedIngredient = this.ingredientList.SingleOrDefault(a => a.IngredientId == int.Parse(this.addIngredientCombobox.SelectedValue.ToString()));
            this.recipeIngredients.Add(selectedIngredient);
            this.DisplayIngredients();

        }
        private void DisplayIngredients()
        {
            string displayList = "";
            foreach (Ingredient selectIngredient in this.recipeIngredients )
            {
                displayList += selectIngredient.IngredientName + ',';
            }
            displayList = displayList.Remove(displayList.Length - 1);
            this.addIngredIentsRichBox.Text= displayList;
            this.addIngredIentsRichBox.Refresh();
        }

        private void RemoveIngrdients_Click(object sender, EventArgs e)
        {
            var recipeName = this.recipeIngredients.FirstOrDefault(x => x.IngredientName == this.addIngredientCombobox.Text);
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
            else if (recipeName is null)
            {
                MessageBox.Show(this.addIngredientCombobox.Text + " - Cannot be removed as it was never added",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.recipeIngredients.RemoveAll(x => x.IngredientName == recipeName.IngredientName);
          
            this.DisplayIngredients();
          
        }

        private void AddmealButton_Click(object sender, EventArgs e)
        {
            var recipeMeal = this.recipeMealtype.FirstOrDefault(x => x.type == this.addRecipeMealTypeComboBox.Text);
            if (recipeMeal != null)
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
            MealType selectedmeal = this.mealTypeList.SingleOrDefault(a => a.mealTypeID == int.Parse(this.addRecipeMealTypeComboBox.SelectedValue.ToString()));
            this.recipeMealtype.Add(selectedmeal);

            this.DisplayMeals();

        }
        private void DisplayMeals()
        {
            string displayList = "";
            foreach (MealType selectMeal in this.recipeMealtype)
            {
                displayList += selectMeal.type + ',';
            }
            displayList = displayList.Remove(displayList.Length - 1);
           

            this.addMealTypeRichText.Text = displayList;
            this.addMealTypeRichText.Refresh();
        }
        private void RemoveMealButton_Click(object sender, EventArgs e)
        {
            var recipeMeal = this.recipeMealtype.FirstOrDefault(x => x.type == this.addRecipeMealTypeComboBox.Text);
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
            else if (recipeMeal is null)
            {
                MessageBox.Show(this.addRecipeMealTypeComboBox.Text + "- Cannot be removed as it was never added",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.recipeMealtype.RemoveAll(x => x.type == recipeMeal.type);
            this.DisplayMeals();
        }

        private void AddKitchennware_Click(object sender, EventArgs e)
        {
            var recipeKitchen = this.recipeKitchenWare.FirstOrDefault(x => x.KitchenwareDetails == this.addKitchenWareComboBox.Text);
            if (recipeKitchen !=null)
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
            Kitchenware selectedkitchen = this.kitchenWareList.SingleOrDefault(a => a.KitchenwareId == int.Parse(this.addKitchenWareComboBox.SelectedValue.ToString()));
            this.recipeKitchenWare.Add(selectedkitchen);
           
            this.DisplayKitchenwares();

        }

        private void RemovKitchenware_Click(object sender, EventArgs e)
        {
            var recipeKitchenware = this.recipeKitchenWare.FirstOrDefault(x => x.KitchenwareDetails == this.addKitchenWareComboBox.Text);
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
            else if (recipeKitchenware is null)
            {
                MessageBox.Show(this.addKitchenWareComboBox.Text + "- Cannot be removed as it was never added",
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.recipeKitchenWare.RemoveAll(x => x.KitchenwareDetails == recipeKitchenware.KitchenwareDetails);

      
            this.DisplayKitchenwares();
        }
        private void DisplayKitchenwares()
        {
            string displayList = "";
            foreach (Kitchenware select in this.recipeKitchenWare)
            {
                displayList += select.KitchenwareDetails + ',';
            }
            displayList = displayList.Remove(displayList.Length - 1);


            this.addKitchenwareRichTextBox.Text = displayList;
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
            this.addMealTypeRichText.Text = "";
            this.recipeInstructions.Text = "";
            this.imageTextBox.Text = "";
            this.addRecipeMealTypeComboBox.Text = "Select the MealType";
            this.addIngredientCombobox.Text = "Select the Ingredient";
            this.addKitchenWareComboBox.Text = "Select the KitchenWare";
            this.addEthnicCombobox.Text = "Select the Ethnicity";
            this.servingtextBox.Text = "";
            this.cooktimeBox.Text = "";
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

        private void AddRecipeDetailUserControl_VisibleChanged(object sender, EventArgs e)
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
            this.addMealTypeRichText.Text = "";
            this.recipeInstructions.Text = "";
            this.imageTextBox.Text = "";
            this.addRecipeMealTypeComboBox.Text = "Select the MealType";
            this.addIngredientCombobox.Text = "Select the Ingredient";
            this.addKitchenWareComboBox.Text = "Select the KitchenWare";
            this.servingtextBox.Text = "";
            this.cooktimeBox.Text = "";
            this.addEthnicCombobox.Text = "Select the Ethnicity";
        }
    }
}
