using Prism.Unity;
using PrismExample.Views;

namespace PrismExample
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			//NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
			NavigationService.NavigateAsync("LoginView?user=renantoniolo@gmail.com");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<LoginView>();
			Container.RegisterTypeForNavigation<HomeView>();
		}
	}
}

