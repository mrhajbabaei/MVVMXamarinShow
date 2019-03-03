﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmXamarinShow.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmXamarinShow.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InfoPage : ContentPage
	{
		public InfoPage ()
		{
			InitializeComponent ();
            BindingContext = new InfoPageViewModel();
        }
    }
}