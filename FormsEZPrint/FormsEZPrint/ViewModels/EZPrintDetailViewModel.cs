using System;
namespace FormsEZPrint
{
	public class EZPrintDetailViewModel
	{
		public string Title { get; set; } = "EZ Print Detail";
		public string EZName { get; set; }
		public string EZDescr { get; set; }

		public EZPrintDetailViewModel(EZPrintModel model)
		{
			EZName = model.ModelName;
			EZDescr = model.ModelDescription;
		}
	}
}

