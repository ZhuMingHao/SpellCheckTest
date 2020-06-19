using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Geometry;
using Microsoft.Graphics.Canvas.UI.Xaml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SpellCheckTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TestPage : Page
    {
     

        public TestPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CanvasVirtualControl canvasVirtualControl = new CanvasVirtualControl();
            canvasVirtualControl.Width = 1486;
            canvasVirtualControl.Height = 610;
            MyCanvas.Children.Add(canvasVirtualControl);
            Canvas.SetLeft(canvasVirtualControl, 100);
            Canvas.SetTop(canvasVirtualControl, 100);
            canvasVirtualControl.RegionsInvalidated += CanvasVirtualControl_RegionsInvalidated;
        }

        private void CanvasVirtualControl_RegionsInvalidated(CanvasVirtualControl sender, CanvasRegionsInvalidatedEventArgs args)
        {
            CanvasDrawingSession drawingSession;
            Rect rect = new Rect(args.InvalidatedRegions[0].Left, args.InvalidatedRegions[0].Top, args.InvalidatedRegions[0].Width, args.InvalidatedRegions[0].Height);

            using (drawingSession = sender.CreateDrawingSession(rect))
            {
                var dashedStroke = new CanvasStrokeStyle()
                {
                    LineJoin = CanvasLineJoin.Round
                };
                drawingSession.DrawRectangle(new Rect(20, 20, 200, 200), Windows.UI.Color.FromArgb(255, 255, 0, 0),40,dashedStroke);
            }
        }
    }
}
