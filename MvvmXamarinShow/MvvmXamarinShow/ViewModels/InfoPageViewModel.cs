using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using MvvmXamarinShow.Annotations;

namespace MvvmXamarinShow.ViewModels
{
    class InfoPageViewModel : BaseViewModel 
    {
        private string title = "Information Page";
        private string inutMessage;
        private string outputMessage;

        public string Title 
        {
            get { return title; }
            set 
            {
                title = value;
                OnPropertyChanged();
            }
        }

        public string InputMessage {
            get { return inutMessage; }
            set 
            {
                inutMessage = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(OutputMessage));
            }
        }

        public string OutputMessage {
            get { return $"This is input message: {inutMessage}"; }
        }

    }
}
