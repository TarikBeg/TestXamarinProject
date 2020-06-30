<<<<<<< HEAD
﻿//using Autofac;
//using JoesBurgerStore.Contracts.ViewModels;
//using JoesBurgerStore.ViewModels;
//using Xamarin.Forms;

//namespace JoesBurgerStore.Views
//{
//    public partial class CartView : ContentPage
//    {
//        private ICartViewModel viewModel;
//        public CartView()
//        {
//            InitializeComponent();
//            viewModel = AppContainer.Container.Resolve<ICartViewModel>();
=======
﻿using TestXamarinApp.ViewModels;
using Xamarin.Forms;

namespace TestXamarinApp.Views
{
    public partial class CartView : ContentPage
    {
        public CartView()
        {
            InitializeComponent();
            var viewModel = new CartViewModel();
>>>>>>> 5e3612f8f1933c973af1d9ebcfb6b5747ecfe2c6

//            this.BindingContext = viewModel;
//        }
//    }
//}
