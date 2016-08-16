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
			ViewModel = new EZPrintListViewModel();
			BindingContext = ViewModel;
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

