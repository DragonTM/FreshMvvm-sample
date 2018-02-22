using FreshMvvm;
using System.Windows.Input;
using System.Threading.Tasks;

namespace FMS.Core.UI.ViewModels
{
	public class LoginViewModel : FreshBasePageModel
	{
		public LoginViewModel()
		{
			SignInCommand = new FreshAwaitCommand(OnSignInCommand);
		}

		public string UserName { get; set; }

		public string Password { get; set; }

		public ICommand SignInCommand { get; }

		private void OnSignInCommand(object sender, TaskCompletionSource<bool> source)
		{
			CoreMethods.SwitchOutRootNavigation(NavigationHelper.MainNavigationContainerName);

			source.SetResult(true);
		}
	}
}
