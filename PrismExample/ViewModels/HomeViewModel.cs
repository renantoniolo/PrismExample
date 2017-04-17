using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace PrismExample.ViewModels
{
	public class HomeViewModel : BindableBase, INavigationAware
	{
		public HomeViewModel()
		{

		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			throw new NotImplementedException();
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			throw new NotImplementedException();
		}
	}
}
