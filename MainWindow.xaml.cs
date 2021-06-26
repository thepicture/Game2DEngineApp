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
    class Obstacle : GameObject
    {
        public Obstacle(double x, double y, BitmapImage sprite) : base(x, y, sprite)
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
