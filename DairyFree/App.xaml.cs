using System;
using DairyFree.Repositories;
using DairyFree.Services;
using DairyFree.ViewModels;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DairyFree
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override  async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync($"NavigationPage/{nameof(MainPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainViewModel>();



            containerRegistry.Register<ILocalDataBaseRepository, LocalDataBaseRepository>();
            containerRegistry.Register<IRecipeService, RecipeService>();

        }

    }
}
