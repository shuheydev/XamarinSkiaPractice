using BalloonControl;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinSkiaPractice.Models
{
    public class Message
    {
        public string Text { get; set; }
        public bool IsMe { get; set; }
        public Color Color { get; set; }
        public MouthDirection MouthDirection { get; set; }
    }
}
