using RecipeBookApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBookApp.View
{
    public partial class UpdateRecipeForm : Form
    {
        public UpdateRecipeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Passes the selected recipe from the RecipeDetails screen to the update recipe user control
        /// </summary>
        /// <param name="selectedRecipe">recipe selected to be updated by uer</param>
        public void SetRecipe(Recipe selectedRecipe)
        {
            this.updateRecipeUserControl1.SetRecipe(selectedRecipe);
        }
    }
}
