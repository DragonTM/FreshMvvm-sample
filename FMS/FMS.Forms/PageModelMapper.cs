using System;
using System.Collections.Generic;
using FreshMvvm;
using Xamarin.Forms;

namespace FMS.Forms
{
	public class PageModelMapper : IFreshPageModelMapper
	{
		private readonly IDictionary<Type, Type> _viewModelPageMapping = new Dictionary<Type,Type>();

		public string GetPageTypeName(Type pageModelType)
		{
			return _viewModelPageMapping[pageModelType].AssemblyQualifiedName;
		}

		public void Register<TVM, TP>() where TVM : FreshBasePageModel where TP : Page
		{
			_viewModelPageMapping.Add(typeof(TVM), typeof(TP));
		}
	}
}
