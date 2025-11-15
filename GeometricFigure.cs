using System.Windows;

namespace GeometricFigures
{
    public abstract class GeometricFigure
    {
        public Point Center { get; set; }

        // Конструктор базового класса
        protected GeometricFigure(double centerX, double centerY)
        {
            Center = new Point(centerX, centerY);
        }

        // Абстрактный метод для рисования
        public abstract void Draw(System.Windows.Controls.Canvas canvas);
    }
}

