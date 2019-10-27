using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinSkiaPractice.Models;
using XamarinSkiaPractice.ViewModels;

namespace XamarinSkiaPractice
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var vm = new MainPageViewModel();
            this.BindingContext = vm;

            vm.Messages.Add(new Message { Text = "はろー", Color = Color.Blue });
            vm.Messages.Add(new Message { Text = "はろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろーはろー", Color = Color.Green });
        }
    }

}


