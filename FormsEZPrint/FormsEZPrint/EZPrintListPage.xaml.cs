using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsEZPrint
{
	public partial class EZPrintListPage : ContentPage
	{
		EZPrintListViewModel ViewModel;

		public EZPrintListPage()
		{
			InitializeComponent();

			// Setup the view model
			ViewModel = new EZPrintListViewModel(Navigation);
			BindingContext = ViewModel;
		}

		protected async void EZListSelectedEvent(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;

			var selModel = e.SelectedItem as EZPrintModel;
			if (selModel == null)
				return;

			await ViewModel.ShowEZDetails(selModel);

			theList.SelectedItem = null;
		}
	}
}

