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

        public RecipeListItem()
        {
            InitializeComponent();
            this.recipeController = new RecipeController();
            this.recipeDetailsScreen = new RecipeDetails();
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


        #endregion

        private void LblTile_Click(object sender, EventArgs e)
        {
            Recipe selectedRecipe = this.recipeController.GetRecipe(RecipeId);
            this.recipeDetailsScreen.SetRecipe(selectedRecipe);
            this.ParentForm.Hide();
            this.recipeDetailsScreen.ShowDialog();
            this.ParentForm.Show();
        }

        private void PicBoxRecipeImage_Click(object sender, EventArgs e)
        {
            Recipe selectedRecipe = this.recipeController.GetRecipe(RecipeId);
            this.recipeDetailsScreen.SetRecipe(selectedRecipe);
            this.ParentForm.Hide();
            this.recipeDetailsScreen.ShowDialog();
            this.ParentForm.Show();
        }
    }
}
