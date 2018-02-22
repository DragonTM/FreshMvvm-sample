using FreshMvvm;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
namespace FMS.Core.UI.ViewModels
{
	public class MainViewModel : FreshBasePageModel
	{
		public string Title { get; set; }

		public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();

		protected override void ViewIsAppearing(object sender, System.EventArgs e)
		{
			base.ViewIsAppearing(sender, e);

			Task.Delay(1000).ContinueWith(t =>
			{
				Title = "Hello there";
			});

			foreach (var item in LoadData())
			{
				Items.Add(item);
			}
		}

		private IEnumerable<string> LoadData()
		{
			return new[]
			{
				"List item1",
				"List item2",
				"List item3",
				"List item4",
				"List item5",
				"List item6",
				"List item7",
			};
		}
	}
}
