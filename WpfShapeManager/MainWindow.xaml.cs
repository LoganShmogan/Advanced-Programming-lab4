using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapeManagerWPF
{
    public partial class MainWindow : Window
    {
        private Shape selectedShape;
        private Point offset;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddCircleButton_Click(object sender, RoutedEventArgs e)
        {
            AddShape(new Ellipse { Width = 50, Height = 50, Fill = Brushes.Blue, Stroke = Brushes.Black, StrokeThickness = 2 });
        }

        private void AddRectangleButton_Click(object sender, RoutedEventArgs e)
        {
            AddShape(new Rectangle { Width = 60, Height = 40, Fill = Brushes.Red, Stroke = Brushes.Black, StrokeThickness = 2 });
        }

        private void AddTriangleButton_Click(object sender, RoutedEventArgs e)
        {
            Polygon triangle = new Polygon
            {
                Points = new PointCollection { new Point(0, 50), new Point(25, 0), new Point(50, 50) },
                Fill = Brushes.Green,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            AddShape(triangle);
        }

        private void AddShape(Shape shape)
        {
            Canvas.SetLeft(shape, 100);
            Canvas.SetTop(shape, 100);

            shape.MouseLeftButtonDown += Shape_MouseLeftButtonDown;
            shape.MouseLeftButtonUp += Shape_MouseLeftButtonUp;
            shape.MouseMove += Shape_MouseMove;

            DrawingCanvas.Children.Add(shape);
        }

        private void Shape_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            selectedShape = sender as Shape;
            if (selectedShape != null)
            {
                offset = e.GetPosition(DrawingCanvas);
                offset.X -= Canvas.GetLeft(selectedShape);
                offset.Y -= Canvas.GetTop(selectedShape);
                selectedShape.CaptureMouse();
            }
        }

        private void Shape_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (selectedShape != null)
            {
                selectedShape.ReleaseMouseCapture();
                selectedShape = null;
            }
        }

        private void Shape_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedShape != null && e.LeftButton == MouseButtonState.Pressed)
            {
                Point newPos = e.GetPosition(DrawingCanvas);
                Canvas.SetLeft(selectedShape, newPos.X - offset.X);
                Canvas.SetTop(selectedShape, newPos.Y - offset.Y);
            }
        }
    }
}
