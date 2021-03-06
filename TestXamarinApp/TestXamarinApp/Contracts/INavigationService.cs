﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestXamarinApp.Contracts
{
    public interface INavigationService
    {
        INavigation Navigation { get; set; }
        Task<Page> PopAsync();
        Task<Page> PopAsync(bool animated);
        Task PopToRootAsync();
        Task PopToMainView();
        Task PushAsync(string pageName);
        IReadOnlyList<Page> ModalStack { get; }
        IReadOnlyList<Page> NavigationStack { get; }
        void InsertPageBefore(string pageName, string beforeName);
        Task<Page> PopModalAsync();
        Task<Page> PopModalAsync(bool animated);
        Task PopToRootAsync(bool animated);
        Task PushAsync(string pageName, bool animated);
        Task PushModalAsync(string pageName);
        Task PushModalAsync(string pageName, object objectToPass);
        Task PushAsync(string pageName, object objectToPass);
        Task PushModalAsync(string pageName, bool animated);
        void RemovePage(string pageName);
        //void PushAsync(object burgerDetailView);
    }
}