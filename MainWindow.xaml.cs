using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Game2DEngineApp
{
    class GameObject : UIElement
    {
        private double x;
        private double y;
        private BitmapImage sprite;

        public GameObject(double x, double y, string sprite)
        {
            this.X = x;
            this.Y = y;
            this.Sprite = GetSprite(sprite);
        }

        public GameObject(string sprite)
        {
            this.Sprite = GetSprite(sprite);
        }

        protected BitmapImage GetSprite(string sprite)
        {
            return new BitmapImage(new Uri("pack://application:,,,/Resources/" + sprite));
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public BitmapImage Sprite { get => sprite; set => sprite = value; }

        public void ChangeSprite(BitmapImage sprite)
        {
            Sprite = sprite;
        }
        public void Move(double x, double y)
        {
            DoubleAnimation animX = new DoubleAnimation
            {
                From = X,
                To = x,
                Duration = TimeSpan.FromSeconds(5)
            };
            DoubleAnimation animY = new DoubleAnimation
            {
                From = Y,
                To = y,
                Duration = TimeSpan.FromSeconds(5)
            };
            TranslateTransform translate = new TranslateTransform();
            RenderTransform = translate;
            BeginAnimation(TranslateTransform.XProperty, animX);
            BeginAnimation(TranslateTransform.YProperty, animY);
        }
    }
    class Background : GameObject
    {
        private readonly Grid grid;
        public Background(string sprite) : base(sprite)
        {
            Window window = new Window
            {
                Width = GetSprite(sprite).Width,
                Height = GetSprite(sprite).Height
            };
            grid = new Grid
            {
                Name = "MainGrid",
            };

            grid.Children.Add(new Image
            {
                Source = GetSprite(sprite)
            });

            window.Content = grid;
            window.Show();
        }
        public void AddObject(GameObject gameObject)
        {
            grid.Children.Add(
                new Image
                {
                    Source = gameObject.Sprite,
                    Margin = new Thickness(gameObject.X, gameObject.Y, 0, 0),
                    Width = gameObject.X,
                    Height = gameObject.Y
                });
        }
    }
    class Wall : GameObject
    {
        public Wall(double x, double y, string sprite) : base(x, y, sprite)
        {
        }
    }
    class Obstacle : Wall
    {
        public Obstacle(double x, double y, string sprite) : base(x, y, sprite)
        {
        }
    }
    class Player : GameObject
    {
        public Player(double x, double y, string sprite) : base(x, y, sprite)
        {
        }

        public void Move(double x, double y, double angle)
        {

        }
        public void Jump()
        {

        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Hide();
            Background bg = new Background("background.jpg");

            Wall wall = new Wall(20, 30, "wall_1.png");

            bg.AddObject(new Wall(20, 20, "wall_1.png"));
            wall.Move(40, 50);
        }
    }
}
