using System;
using FreshMvvm;
namespace FMS.Core.UI.ViewModels
{
	public class DetailsViewModel : FreshBasePageModel
	{
		public string Title { get; set; }

		public override void Init(object initData)
		{
			base.Init(initData);

			var title = initData as string;

			if (title != null)
			{
				Title = title;
			}
		}
	}
}
