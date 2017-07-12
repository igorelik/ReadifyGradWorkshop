using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFWorkshop.ViewModel;

namespace XFWorkshop
{
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.Main;
        }
    }
}
