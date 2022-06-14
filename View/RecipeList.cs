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
        List<Recipe> recipeList;
        public RecipeList()
        {
            InitializeComponent();
            this.recipeController = new RecipeController();
            this.recipeList = new List<Recipe>();
            this.FillTempComboBox();
            this.PopulateItems();
        }

        private void FillTempComboBox()
        {
            
            this.recipeList = this.recipeController.GetRecipes();
            this.tempRecipeList.DataSource = recipeList;
            this.tempRecipeList.DisplayMember = "RecipeName";
            this.tempRecipeList.ValueMember = "RecipeId";
        }

        private void PopulateItems()
        {
            RecipeListItem[] recipeListItems = new RecipeListItem[this.recipeList.Count];

            for (int i = 0; i < recipeListItems.Length; i++)
            {
                recipeListItems[i] = new RecipeListItem();
                recipeListItems[i].RecipeName = this.recipeList[i].RecipeName;

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                flowLayoutPanel1.Controls.Add(recipeListItems[i]);
            }

            flowLayoutPanel1.Controls.RemoveAt(0);
        }
    }
}
