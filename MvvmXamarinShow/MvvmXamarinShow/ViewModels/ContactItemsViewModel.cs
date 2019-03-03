using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MvvmXamarinShow.Views;
using Xamarin.Forms;

namespace MvvmXamarinShow.ViewModels
{
    class ContactItemsViewModel : BaseViewModel
    {
        private string title;
        private string message;
        private bool isBusy;

        public ContactItemsViewModel() 
        {
            ShowMessageCommand = new Command(ShowInputMessage, 
                                        (state) => !IsBusy );
            GoToInfoPageCommand = new Command(() => GoToInfoPage());
        }

        public Command GoToInfoPageCommand { get; set; }

        public async Task GoToInfoPage() 
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InfoPage());
        }

        async private void ShowInputMessage(object obj) 
        {
            IsBusy = true;
            await Task.Delay(4000);
            IsBusy = false;
            Application.Current.MainPage.DisplayAlert("Message", $"The input message is: {Message}", "Ok");
        }

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
                if (message == "mohammad")
                    IsBusy = true;
                else
                    IsBusy = false;

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
                ShowMessageCommand.ChangeCanExecute();
            }
        }

        public Command ShowMessageCommand { get; }

        void ShowMessage() 
        {

        }
    }
}
