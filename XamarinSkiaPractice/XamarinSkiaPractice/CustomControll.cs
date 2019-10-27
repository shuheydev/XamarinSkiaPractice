using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinSkiaPractice
{
    public class CustomControll:SKCanvasView
    {
        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPath path = new SKPath();

            path.MoveTo(0, 50);
            path.LineTo(100, 50);
            path.LineTo(100, 135);
            path.Close();

            SKPaint strokePaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Magenta,
                StrokeWidth = 1
            };

            SKPaint fillPaint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = SKColors.Bisque
            };

            //canvas.DrawPath(path, strokePaint);
            canvas.DrawPath(path,fillPaint);
        }
    }
}
