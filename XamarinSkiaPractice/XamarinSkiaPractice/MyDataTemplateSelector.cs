using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinSkiaPractice.Models;
using BalloonControl;

namespace XamarinSkiaPractice
{
    class MyDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FromLeftTemplate { get; set; }
        public DataTemplate FromRightTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = (Message)item;

            return message.MouthDirection == MouthDirection.Left ? FromLeftTemplate : FromRightTemplate;
        }
    }
}
