using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace PrismExample.ViewModels
{
	public class LoginViewModel : BindableBase, INavigationAware
	{

		private INavigationService _navigationService;
		public DelegateCommand EntrarCommand { get; set; }

		public LoginViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			EntrarCommand = new DelegateCommand(NavigateToHomeView);
		}

		private void NavigateToHomeView()
		{
			_navigationService.NavigateAsync("MainPage");
		}

		private string _textUser;
		public string TextUser
		{
			get
			{
				return _textUser;
			}

			set
			{
				SetProperty(ref _textUser, value);
			}
		}

		private string _textSenha;
		public string TextSenha
		{
			get
			{
				return _textSenha;
			}

			set
			{
				SetProperty(ref _textSenha, value);
			}
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			throw new NotImplementedException();
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("user"))
				TextUser = (string)parameters["user"];

		}
	}
}
