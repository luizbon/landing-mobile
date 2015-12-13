using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace LandingMobileApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _token;
        private string _label;

        public MainViewModel()
        {
            SetToken = new RelayCommand(() => Label = Token);
        }

        public string Token
        {
            get { return _token; }
            set { Set(() => Token, ref _token, value); }
        }

        public string Label
        {
            get { return _label; }
            set { Set(() => Label, ref _label, value); }
        }

        public RelayCommand SetToken { get; set; }
    }
}