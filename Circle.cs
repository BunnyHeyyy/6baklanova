using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace GeometricFigures
{
    public class Circle : GeometricFigure
    {
        public double Radius { get; set; }
        public Brush FillColor { get; set; }
        public Brush StrokeColor { get; set; }
        public double StrokeThickness { get; set; }

        // Конструктор с вызовом базового конструктора
        public Circle(double centerX, double centerY, double radius,
                     Brush fillColor = null, Brush strokeColor = null,
                     double strokeThickness = 1)
            : base(centerX, centerY) 
        {
            Radius = radius;
            FillColor = fillColor ?? Brushes.LightBlue;
            StrokeColor = strokeColor ?? Brushes.DarkBlue;
            StrokeThickness = strokeThickness;
        }

        public override void Draw(Canvas canvas)
        {
            var ellipse = new Ellipse
            {
                Width = Radius * 2,
                Height = Radius * 2,
                Fill = FillColor,
                Stroke = StrokeColor,
                StrokeThickness = StrokeThickness
            };

            // Устанавливаем позицию на Canvas
            Canvas.SetLeft(ellipse, Center.X - Radius);
            Canvas.SetTop(ellipse, Center.Y - Radius);

            canvas.Children.Add(ellipse);
        }
    }
}

