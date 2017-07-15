using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTest
{
    public partial class MainPage : ContentPage
    {
        ViewModel vm;

        public MainPage()
        {
            InitializeComponent();
            vm = new ViewModel();
            BindingContext = vm;
        }

        private async void MainButton_Clicked(object sender, EventArgs e)
        {
            vm.LabelText = "This button was clicked.";
        }
    }
}
