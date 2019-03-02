using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MvvmXamarinShow.ViewModels
{
    class ContactItemsViewModel : INotifyPropertyChanged
    {
        private string title;
        private string message;
        private bool isBusy;

        public string Title { get { return title; }
            set 
            {
                title = value;
                OnPropertyChanged();
            }

        }
        public string Message {
            get { return message; }
            set 
            {
                message = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }
        public string DisplayMessage {
            get 
            {
                return $"The message from user is: {Message}";
            }
        }
        public bool IsBusy {
            get { return isBusy; }
            set 
            {
                isBusy = value;
                OnPropertyChanged();

            }
        }

        public ContactItemsViewModel() 
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "" ) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        void ShowMessage() 
        {

        }
    }
}
