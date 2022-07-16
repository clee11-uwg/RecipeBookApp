using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeBookApp.Controller;
using RecipeBookApp.Model;
using RecipeBookApp.View;

namespace RecipeBookApp.UserControls
{
    public partial class RecipeListItem : UserControl
    {
        private RecipeController recipeController;
        private RecipeDetails recipeDetailsScreen;
        private User currentUser;

        public RecipeListItem()
        {
            InitializeComponent();
            this.recipeController = new RecipeController();
            this.currentUser = new User();
        }

        #region Properties

        private string _name;
        private Image _image;

        [Category("Custom Props")]
        public int RecipeId { get; set; }

        [Category("Custom Props")]
        public string RecipeName
        {
            get { return _name; }
            set { _name = value; lblTile.Text = value;  }
        }

        [Category("Custom Props")]
        public Image RecipeImage
        {
            get { return _image; }
            set { _image = value; picBoxRecipeImage.Image = value;  }
        }

        /// <summary>
        /// Method to set the current user
        /// </summary>
        /// <param name="currentUser">Current loggin in user</param>
        public void SetUser(User currentUser)
        {
            this.currentUser = currentUser;
        }


        #endregion

        private void LblTile_Click(object sender, EventArgs e)
        {
            Recipe selectedRecipe = this.recipeController.GetRecipe(RecipeId);
            this.recipeDetailsScreen = new RecipeDetails();
            this.recipeDetailsScreen.SetUser(this.currentUser);
            this.recipeDetailsScreen.SetRecipe(selectedRecipe);
            this.recipeDetailsScreen.ShowButtons();
            this.ParentForm.Hide();
            this.recipeDetailsScreen.ShowDialog();
            this.ParentForm.Show();
        }

        private void PicBoxRecipeImage_Click(object sender, EventArgs e)
        {
            Recipe selectedRecipe = this.recipeController.GetRecipe(RecipeId);
            this.recipeDetailsScreen = new RecipeDetails();
            this.recipeDetailsScreen.SetUser(this.currentUser);
            this.recipeDetailsScreen.SetRecipe(selectedRecipe);
            this.recipeDetailsScreen.ShowButtons();
            this.ParentForm.Hide();
            this.recipeDetailsScreen.ShowDialog();
            this.ParentForm.Show();
        }
    }
}
