using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestFormPage : ContentPage
    {
        public TestFormPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Allert", "This is new allert", "yes", "no");
        }
    }
}