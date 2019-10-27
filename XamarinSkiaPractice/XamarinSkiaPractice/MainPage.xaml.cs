using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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


        }

        private void canvasView_PaintSurface(object sender,SKPaintSurfaceEventArgs e)
        {
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear(SKColors.CornflowerBlue);
        }

        //public void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        //{
        //    SKImageInfo info = args.Info;
        //    SKSurface surface = args.Surface;
        //    SKCanvas canvas = surface.Canvas;

        //    canvas.Clear();

        //    string str = "Hello SkiaSharp!";

        //    SKPaint textPaint = new SKPaint
        //    {
        //        Color = SKColors.Chocolate
        //    };

        //    float textWidth = textPaint.MeasureText(str);
        //    textPaint.TextSize = 0.9f * info.Width * textPaint.TextSize / textWidth;

        //    SKRect textBounds = new SKRect();
        //    textPaint.MeasureText(str, ref textBounds);

        //    // Calculate offsets to center the text on the screen
        //    float xText = info.Width / 2 - textBounds.MidX;
        //    float yText = info.Height / 2 - textBounds.MidY;

        //    // And draw the text
        //    canvas.DrawText(str, xText, yText, textPaint);


        //    // Create a new SKRect object for the frame around the text
        //    SKRect frameRect = textBounds;
        //    frameRect.Offset(xText, yText);
        //    frameRect.Inflate(10, 10);

        //    // Create an SKPaint object to display the frame
        //    SKPaint framePaint = new SKPaint
        //    {
        //        Style = SKPaintStyle.Stroke,
        //        StrokeWidth = 5,
        //        Color = SKColors.Blue
        //    };

        //    // Draw one frame
        //    canvas.DrawRoundRect(frameRect, 20, 20, framePaint);

        //    // Inflate the frameRect and draw another
        //    frameRect.Inflate(10, 10);
        //    framePaint.Color = SKColors.DarkBlue;
        //    canvas.DrawRoundRect(frameRect, 30, 30, framePaint);
        //}
    }

}


