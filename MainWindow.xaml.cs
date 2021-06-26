using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Game2DEngineApp
{
    class GameObject
    {
        private double x;
        private double y;
        private BitmapImage sprite;

        public GameObject(double x, double y, BitmapImage sprite)
        {
            this.x = x;
            this.y = y;
            this.sprite = sprite;
        }
        public void ChangeSprite(BitmapImage sprite)
        {
            this.sprite = sprite;
        }
        public void Move(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
    class Wall : GameObject
    {
        public Wall(double x, double y, BitmapImage sprite) : base(x, y, sprite)
        {
        }
    }
    class Obstacle : Wall
    {
        public Obstacle(double x, double y, BitmapImage sprite) : base(x, y, sprite)
        {
        }
    }
    class Player : GameObject
    {
        public Player(double x, double y, BitmapImage sprite) : base(x, y, sprite)
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
        }
    }
}
