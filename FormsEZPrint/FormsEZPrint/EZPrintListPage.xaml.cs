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
			// New up the Razor template
			var printTemplate = new ListPrintTemplate();

			// Set the model property (ViewModel is a custom property within containing view - FYI)
			printTemplate.Model = ViewModel.ezPrints.ToList();

			// Generate the HTML
			var htmlString = printTemplate.GenerateString();

			// Create a source for the webview
			var htmlSource = new HtmlWebViewSource();
			htmlSource.Html = htmlString;

			// Create and populate the Xamarin.Forms.WebView
			var browser = new WebView();
			browser.Source = htmlSource;

			var printService = DependencyService.Get<IPrintService>();
			printService.Print(browser);
		}
	}
}

