using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using XFWorkshop.Services;

namespace XFWorkshop.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private IPlatformName _platformName;
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IPlatformName platformName)
        {
            _platformName = platformName;
            MainTitle = _platformName.PlatformSpecificName;
            TestCommand = new RelayCommand(()=>MainTitle = "I am changed in ViewModel");
        }

        private string _mainTitle;
        public string MainTitle
        {
            get => _mainTitle;
            set
            {
                _mainTitle = value;
                RaisePropertyChanged();
            }
        }
 
        public ICommand TestCommand { get; set; }
    }
}