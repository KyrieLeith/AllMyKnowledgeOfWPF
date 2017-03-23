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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab7_2
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

        Random rnd = new Random();

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            //Work out where the button is going to move to.
            double newLeft = rnd.Next(Convert.ToInt32(cnv.ActualWidth - btn.ActualWidth));
            double newTop = rnd.Next(Convert.ToInt32(cnv.ActualHeight - btn.ActualHeight));

            //Create the animations for left and top
            DoubleAnimation animLeft = new DoubleAnimation(Canvas.GetLeft(btn), newLeft, new Duration(TimeSpan.FromSeconds(1)));
            DoubleAnimation animTop = new DoubleAnimation(Canvas.GetTop(btn), newTop, new Duration(TimeSpan.FromSeconds(1)));

            //Start the animation.
            btn.BeginAnimation(Canvas.LeftProperty, animLeft, HandoffBehavior.SnapshotAndReplace);
            btn.BeginAnimation(Canvas.TopProperty, animTop, HandoffBehavior.SnapshotAndReplace);
        }
    }
}
