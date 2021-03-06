﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinNubankClone.Controls;
using XamarinNubankClone.ViewModels;

namespace XamarinNubankClone.Helpers
{
    public class NavigationService
    {
        static Lazy<NavigationService> LazyNavi = new Lazy<NavigationService>(() => new NavigationService());
        public static NavigationService Current => LazyNavi.Value;

        public NavigationService()
        {
            mapeamento = new Dictionary<Type, Type>();
            Navigation = ((TransitionNavigationPage)App.Current.MainPage).Navigation;
        }

        //INavigation Navigation => ((TransitionNavigationPage)App.Current.MainPage).Navigation;
        public INavigation Navigation { get; set; }

        async Task NavigateTo(Page page)
        {
            var firstPage = Navigation.NavigationStack[0];

            Navigation.InsertPageBefore(page, firstPage);

            await Navigation.PopToRootAsync();
        }

        public async Task PushAsync<TViewModel>(TransitionType type = TransitionType.Default, params object[] args) where TViewModel : BaseViewModel
        {
            ((TransitionNavigationPage)App.Current.MainPage).TransitionType = type;

            var page = Locator<TViewModel>();

            await Navigation.PushAsync(page);


            await (page.BindingContext as BaseViewModel).InitializeAsync(args);
        }
        Page Locator<TViewModel>() where TViewModel : BaseViewModel
        {
            var viewModelType = typeof(TViewModel);
            var viewType = VerificarPage(viewModelType);
            Page page;
            if (viewType == null)
            {
                var nameSolution = viewModelType.AssemblyQualifiedName.Split('.')[0];
                var nameDirFile = viewModelType.FullName.Replace($"{nameSolution}.ViewModels.", "");
                nameDirFile = nameDirFile.Replace("ViewModel", "Page");
                var viewTypeName = $"{nameSolution}.Views.{nameDirFile}";
                viewType = Type.GetType(viewTypeName);
                page = Activator.CreateInstance(viewType) as Page;
                CriarMapeamento(page.GetType(), viewModelType);
            }
            else
                page = Activator.CreateInstance(viewType) as Page;


            var viewModel = Activator.CreateInstance(viewModelType);

            if (page != null)
                page.BindingContext = viewModel;

            return page;
        }

        public async Task PopAsync() =>
            await Application.Current.MainPage.Navigation.PopAsync();

        public async Task PopToRootAsync() =>
            await Application.Current.MainPage.Navigation.PopToRootAsync();

        public async Task PushModalAsync<TViewModel>(TransitionType type = TransitionType.Default, params object[] args) where TViewModel : BaseViewModel
        {
            ((TransitionNavigationPage)App.Current.MainPage).TransitionType = type;
            var page = Locator<TViewModel>();

            await Navigation.PushModalAsync(page);
            await (page.BindingContext as BaseViewModel).InitializeAsync(args);
        }



        public async Task PopModalAsync()
            => await Application.Current.MainPage.Navigation.PopModalAsync();

        public Task RemovePage(Type page)
        {
            var listaPagina = new List<Page>();
            var pagina = Application.Current.MainPage.Navigation.NavigationStack;
            foreach (var item in pagina)
            {
                if (item.GetType() == page)
                    listaPagina.Add(item);
            }
            foreach (var item in listaPagina)
                Application.Current.MainPage.Navigation.RemovePage(item);

            return Task.FromResult(true);
        }

        public void SetarMainPage<TViewModel>(object[] args = null) where TViewModel : BaseViewModel
        {
            var page = Locator<TViewModel>();

            if (App.Current.MainPage is null)
            {
                App.Current.MainPage = new NavigationPage(page);

                (page.BindingContext as BaseViewModel).InitializeAsync(args);
            }
        }

        protected readonly Dictionary<Type, Type> mapeamento;

        void CriarMapeamento(Type page, Type vm) =>
            mapeamento.Add(vm, page);

        Type VerificarPage(Type vm)
        {
            if (!mapeamento.ContainsKey(vm))
                return null;

            return mapeamento[vm];
        }
    }
}
