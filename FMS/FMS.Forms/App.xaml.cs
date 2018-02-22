using Xamarin.Forms;
using FreshMvvm;
using FMS.Core.UI.ViewModels;
using FMS.Forms.Pages;
using Xamarin.Forms.Xaml;
using FMS.Core.UI;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FMS.Forms
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			ConfigurePagesMapping();

			var loginContainer = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<LoginViewModel>(), NavigationHelper.LoginNavigationContainerName);
			var mainContainer = new FreshMasterDetailNavigationContainer(NavigationHelper.MainNavigationContainerName);

			mainContainer.Init("Menu");

			mainContainer.AddPage<MainViewModel>("Main");

			MainPage = loginContainer;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}

		private void ConfigurePagesMapping()
		{
			var mapper = new PageModelMapper();

			mapper.Register<LoginViewModel, LoginPage>();
			mapper.Register<MainViewModel, MainPage>();
			mapper.Register<MenuViewModel, MenuPage>();
			mapper.Register<DetailsViewModel, DetailsPage>();

			FreshPageModelResolver.PageModelMapper = mapper;
		}
	}
}
