﻿using System;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace LightningGraph.Views
{
    public class ChartView : SKCanvasView
    {
        public ChartView()
        {
            this.BackgroundColor = Color.Transparent;
            this.PaintSurface += OnPaintCanvas;
        }

        public static readonly BindableProperty ChartProperty = BindableProperty.Create(nameof(Chart), typeof(Chart), typeof(ChartView), null, propertyChanged: OnChartChanged);

        public Chart Chart
        {
            get { return (Chart)GetValue(ChartProperty); }
            set { SetValue(ChartProperty, value); }
        }

        private static void OnChartChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((ChartView)bindable).InvalidateSurface();
        }

        private void OnPaintCanvas(object sender, SKPaintSurfaceEventArgs e)
        {
            if (this.Chart != null)
            {
                this.Chart.Draw(e.Surface.Canvas, e.Info.Width, e.Info.Height);
            }
        }
    }
}
