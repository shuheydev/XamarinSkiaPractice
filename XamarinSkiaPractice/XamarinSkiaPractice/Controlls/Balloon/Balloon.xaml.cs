using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSkiaPractice.Controlls.Balloon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Balloon : ContentView
    {
        #region Properties
        public string Text { get; set; }
        public static readonly BindableProperty TextProperty = BindableProperty.Create(
                propertyName:"Text",
                returnType:typeof(string),
                declaringType:typeof(Balloon),
                defaultValue: "",
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: TitlePropertyChanged
            );
        private static void TitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (Balloon)bindable;
            control.label.Text = newValue.ToString();
        }

        public MouthDirection MouthDirection { get; set; }
        public static readonly BindableProperty MouthDirectionProperty = BindableProperty.Create(
                propertyName:"MouthDirection",
                returnType: typeof(MouthDirection),
                declaringType:typeof(Balloon),
                defaultValue:MouthDirection.Right,
                defaultBindingMode:BindingMode.TwoWay,
                propertyChanged:MouthDirectionPropertyChanged
            );
        private static void MouthDirectionPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (Balloon)bindable;
            control.balloonMouth.MouthDirection = (MouthDirection)newValue;
        }

        #endregion

        public Balloon()
        {
            InitializeComponent();
        }
    }
}