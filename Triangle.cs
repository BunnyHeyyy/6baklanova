using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace GeometricFigures
{
    public class Triangle : GeometricFigure
    {
        public double SideLength { get; set; }
        public Brush FillColor { get; set; }
        public Brush StrokeColor { get; set; }
        public double StrokeThickness { get; set; }

        // Конструктор с вызовом базового конструктора
        public Triangle(double centerX, double centerY, double sideLength,
                       Brush fillColor = null, Brush strokeColor = null,
                       double strokeThickness = 1)
            : base(centerX, centerY) 
        {
            SideLength = sideLength;
            FillColor = fillColor ?? Brushes.LightGreen;
            StrokeColor = strokeColor ?? Brushes.DarkGreen;
            StrokeThickness = strokeThickness;
        }

        public override void Draw(Canvas canvas)
        {
            // Вычисляем вершины равностороннего треугольника
            double height = SideLength * System.Math.Sqrt(3) / 2;

            Point point1 = new Point(Center.X, Center.Y - height / 2);
            Point point2 = new Point(Center.X - SideLength / 2, Center.Y + height / 2);
            Point point3 = new Point(Center.X + SideLength / 2, Center.Y + height / 2);

            var polygon = new Polygon
            {
                Fill = FillColor,
                Stroke = StrokeColor,
                StrokeThickness = StrokeThickness
            };
            polygon.Points.Add(point1);
            polygon.Points.Add(point2);
            polygon.Points.Add(point3);
            canvas.Children.Add(polygon);
        }
    }
}

