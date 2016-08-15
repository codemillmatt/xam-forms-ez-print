using System;
using Xamarin.Forms;

namespace FormsEZPrint
{
	public partial class FormsEZPrintPage : ContentPage
	{
		public FormsEZPrintPage()
		{
			InitializeComponent();
		}

		protected void Handle_Print(object sender, EventArgs e)
		{
			var printSvc = DependencyService.Get<IPrintService>();

			printSvc.Print(printWeb);
		}
	}
}

