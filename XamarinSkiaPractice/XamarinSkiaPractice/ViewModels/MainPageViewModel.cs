using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinSkiaPractice.Models;

namespace XamarinSkiaPractice.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Message> _messages;
        public ObservableCollection<Message> Messages 
        { 
            get=>_messages;
            set
            {
                if (_messages == value) return;
                _messages = value;

                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            this.Messages = new ObservableCollection<Message>();
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
