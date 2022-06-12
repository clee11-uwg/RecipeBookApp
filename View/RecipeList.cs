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

namespace RecipeBookApp
{
    public partial class RecipeList : Form
    {
       private RecipeController recipeController;
        public RecipeList()
        {
            InitializeComponent();
            this.recipeController = new RecipeController();
            this.FillTempComboBox();
        }

        private void FillTempComboBox()
        {
            List<Recipe> recipeList = new List<Recipe>();
            recipeList = this.recipeController.GetRecipes();
            this.tempRecipeList.DataSource = recipeList;
            this.tempRecipeList.DisplayMember = "Name";
            this.tempRecipeList.ValueMember = "ID";
        }
    }
}
