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

namespace RecipeBookApp.View
{
    public partial class AddRecipeInstructionDialog : Form
    {
        
        public AddRecipeInstructionDialog()
        {
            InitializeComponent();
           
        }

        private void SaveInstructionButton_Click(object sender, EventArgs e)
        {
            RecipeController.SetRecipeInstructions(this.addInstructtionTextBox.Text);
        }

        private void ClearInstructionButton_Click(object sender, EventArgs e)
        {
            this.addInstructtionTextBox.Text = "";
            return;
        }

    }
}
