using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace FormsEZPrint
{
	public class EZPrintListViewModel
	{
		public ObservableCollection<EZPrintModel> ezPrints { get; set; } = new ObservableCollection<EZPrintModel>();
		public string Title { get; set; } = "Forms E-Z Print";

		public EZPrintListViewModel()
		{
			// Populate with some dummy data
			ezPrints.Add(new EZPrintModel() { ModelDescription = "Description 1", ModelName = "Name 1" });
			ezPrints.Add(new EZPrintModel() { ModelDescription = "Description 2", ModelName = "Name 2" });
			ezPrints.Add(new EZPrintModel() { ModelDescription = "Description 3", ModelName = "Name 3" });
		}
	}
}

