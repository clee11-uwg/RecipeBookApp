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

        /// <summary>
        /// 0 parameter constructor for the RecipeList
        /// </summary>
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

            // Create new list item and add to the flow layout panel
            for (int i = 0; i < recipeListItems.Length; i++)
            {
                recipeListItems[i] = new RecipeListItem();
                recipeListItems[i].RecipeName = this.recipeList[i].RecipeName;
                recipeListItems[i].RecipeImage=this.recipeList[i].RecipeImage;
                
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                flowLayoutPanel1.Controls.Add(recipeListItems[i]);
            }

            // Removing the first one in the list since this is the one that was manually and statically added to UI
          //  flowLayoutPanel1.Controls.RemoveAt(0);
        }
    }
}
