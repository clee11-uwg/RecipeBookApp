using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBookApp.UserControls
{
    public partial class RecipeListItem : UserControl
    {
        public RecipeListItem()
        {
            InitializeComponent();
        }

        #region Properties

        private string _name;
        private Image _image;

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


    }
}
