using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;

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

		void PrintList(object sender, System.EventArgs e)
		{
			var printTemplate = new ListPrintTemplate();
			printTemplate.Model = ViewModel.ezPrints.ToList();

			var htmlSource = new HtmlWebViewSource();
			htmlSource.Html = printTemplate.GenerateString();

			var browser = new WebView();
			browser.Source = htmlSource;

			var printService = DependencyService.Get<IPrintService>();
			printService.Print(browser);
		}
	}
}

