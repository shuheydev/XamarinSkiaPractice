using BalloonControl;
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

            vm.Messages.Add(new Message { Text = "こんにちは", Color = Color.Blue, MouthDirection = MouthDirection.Left });
            vm.Messages.Add(new Message { Text = "吾輩は猫である。名前はまだ無い。どこで生れたかとんと見当がつかぬ。何でも薄暗いじめじめした所でニャーニャー泣いていた事だけは記憶している。", Color = Color.Red, MouthDirection = MouthDirection.Right });
            vm.Messages.Add(new Message { Text = "さようなら", Color = Color.Blue, MouthDirection = MouthDirection.Left });
        }
    }

}


