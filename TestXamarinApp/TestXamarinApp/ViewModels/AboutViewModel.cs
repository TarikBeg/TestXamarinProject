using System;
using System.Windows.Input;
using TestXamarinApp.ViewModels.Base;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestXamarinApp.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        public ICommand OpenWebCommand { get; }

        private string _general;
        private string _copyright;
        private string _moreInfo;
        //private string _link;

        public string General
        {
            get { return _general; }
            set { _general = value; OnPropertyChanged("General"); }
        }

        public string Copyright
        {
            get { return _copyright; }
            set { _copyright = value; OnPropertyChanged("Copyright"); }
        }

        public string MoreInfo
        {
            get { return _moreInfo; }
            set { _moreInfo = value; OnPropertyChanged("MoreInfo"); }
        }

        public ICommand MoreInfoCommand { get; set; }

        public AboutViewModel()
        {
            InitializeData();
            try
            {
                OpenWebCommand = new Command(() =>
                {
                    Device.OpenUri(new Uri("http://www.google.be"));
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void InitializeData()
        {
            //TODO: get from resx
            General = "App from Joe's Hamburgers";
            Copyright = "Copyright 2016 Joe - All rights reserved";
            MoreInfo = "Visit us on our website";

        }
    }
}