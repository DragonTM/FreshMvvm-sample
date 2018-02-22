using FreshMvvm;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace FMS.Core.UI.ViewModels
{
	public class MainViewModel : FreshBasePageModel
	{
		public string Title { get; set; }

		public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();

		public string SelectedItem { get; set; }

		protected override void ViewIsAppearing(object sender, System.EventArgs e)
		{
			base.ViewIsAppearing(sender, e);

			Title = "Hello there";

			Items.Clear();

			foreach (var item in LoadData())
			{
				Items.Add(item);
			}
		}

		private void OnSelectedItemChanged()
		{
			if (SelectedItem == null)
			{
				return;
			}

			var item = SelectedItem;
			SelectedItem = null;

			CoreMethods.PushPageModel<DetailsViewModel>(item);
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
