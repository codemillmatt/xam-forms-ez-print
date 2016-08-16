using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsEZPrint
{
	public partial class EZPrintDetailPage : ContentPage
	{
		EZPrintDetailViewModel _vm;
		public EZPrintDetailViewModel ViewModel
		{
			get
			{
				return _vm;
			}
			set
			{
				_vm = value;
				BindingContext = _vm;
			}
		}

		public EZPrintDetailPage()
		{
			InitializeComponent();
		}
	}
}

