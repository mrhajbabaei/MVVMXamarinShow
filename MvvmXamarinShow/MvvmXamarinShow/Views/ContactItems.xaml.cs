using MvvmXamarinShow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmXamarinShow.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactItems : ContentPage
	{
		public ContactItems ()
		{
			InitializeComponent ();
            BindingContext = new ContactItemsViewModel();
        }
    }
}