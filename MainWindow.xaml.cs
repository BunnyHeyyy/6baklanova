using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeometricFigures
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void DrawFiguresBtn_Click(object sender, RoutedEventArgs e)
        {

            Circle circle = new Circle(150, 150, 80,
                Brushes.LightGreen, Brushes.LightGreen, 2);

            Triangle triangle = new Triangle(400, 200, 120,
                Brushes.Purple, Brushes.Purple, 2);

            Circle smallCircle = new Circle(280, 350, 40,
                Brushes.LightPink, Brushes.LightPink, 1.5);

            Triangle smallTriangle = new Triangle(550, 120, 80,
                Brushes.Yellow, Brushes.Yellow, 2);

            circle.Draw(DrawingCanvas);
            triangle.Draw(DrawingCanvas);
            smallCircle.Draw(DrawingCanvas);
            smallTriangle.Draw(DrawingCanvas);

            AddInfoLabels();
        }

        private void AddInfoLabels()
        {
            AddLabel("Окружность: Center(150,150), Radius=80", 100, 250);
            AddLabel("Треугольник: Center(400,200), Side=120", 350, 270);
            AddLabel("Маленькая окружность: Center(280,350), Radius=40", 210, 400);
            AddLabel("Маленький треугольник: Center(550,120), Side=80", 480, 150);
        }

        private void AddLabel(string text, double left, double top)
        {
            var textBlock = new System.Windows.Controls.TextBlock
            {
                Text = text,
                FontSize = 10,
                Foreground = Brushes.DarkSlateGray,
                Background = Brushes.White
            };

            Canvas.SetLeft(textBlock, left);
            Canvas.SetTop(textBlock, top);
            DrawingCanvas.Children.Add(textBlock);
        }

        private void ClearCanvasBtn_Click(object sender, RoutedEventArgs e)
        {
            DrawingCanvas.Children.Clear();
        }
    }
}

