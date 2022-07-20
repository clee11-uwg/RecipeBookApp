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
    /// <summary>
    /// This will help user adding the instruction on recipe
    /// </summary>
    public partial class AddRecipeInstructionDialog : Form
    {
        /// <summary>
        /// Constructor to intialize the components
        /// </summary>
        public AddRecipeInstructionDialog()
        {
            InitializeComponent();
           
        }
        /// <summary>
        /// Constructor to intialize the components
        /// </summary>
        /// <param name="curentInstruction"></param>
        public AddRecipeInstructionDialog(string curentInstruction)
        {
            InitializeComponent();
            this.addInstructtionTextBox.Text = curentInstruction;

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
