using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFWorkshop.ViewModel;

namespace XFWorkshop
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.Main;
        }

        private void OnTestClicked(object sender, EventArgs e)
        {
            lblTest.Text = "Test is tapped";
        }
    }
}
