using RecipeBookApp.View;
using System;
using System.Windows.Forms;

namespace RecipeBookApp
{
   public  static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       public  static void Main()
        {
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new RecipeList());
       //  Application.Run(new HomeScreen());
            Application.Run(new MainForm());
            //  Application.Run(new UserControls.AddRecipeDetailUserControl());
        }
    }
}
