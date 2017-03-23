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

namespace lab3_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void MenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (((FrameworkElement)sender).Tag.ToString() == "white") 
                statbar1.Text="Выбрать белый цвет фона.";
            else if (((FrameworkElement)sender).Tag.ToString() == "blue")
                statbar1.Text = "Выбрать синий цвет фона.";
            else if (((FrameworkElement)sender).Tag.ToString() == "yellow")
                statbar1.Text = "Выбрать жёлтый цвет фона.";
            else if (((FrameworkElement)sender).Tag.ToString() == "red")
                statbar1.Text = "Выбрать красный цвет фона.";
            else if (((FrameworkElement)sender).Tag.ToString() == "green")
                statbar1.Text = "Выбрать зелёный цвет фона.";
            else if (((FrameworkElement)sender).Tag.ToString() == "orange")
                statbar1.Text = "Выбрать оранжевый цвет фона.";
            else if (((FrameworkElement)sender).Tag.ToString() == "black")
                statbar1.Text = "Выбрать чёрный цвет фона.";
            else if (((FrameworkElement)sender).Tag.ToString() == "color")
                statbar1.Text = "Выбрать цвет фона.";
            else if (((FrameworkElement)sender).Tag.ToString() == "file")
                statbar1.Text = "Открыть основное меню.";
            else if (((FrameworkElement)sender).Tag.ToString() == "close")
                statbar1.Text = "Закрыть программу.";
            else if (((FrameworkElement)sender).Tag.ToString() == "about")
                statbar1.Text = "Показать окно 'О программе'.";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Лабораторная работа №3. Задание 1.", "О программе");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if (((FrameworkElement)sender).Tag.ToString() == "white")
                window.Background = Brushes.White;
            else if (((FrameworkElement)sender).Tag.ToString() == "blue")
                window.Background = Brushes.Blue;
            else if (((FrameworkElement)sender).Tag.ToString() == "yellow")
                window.Background = Brushes.Yellow;
            else if (((FrameworkElement)sender).Tag.ToString() == "red")
                window.Background = Brushes.Red;
            else if (((FrameworkElement)sender).Tag.ToString() == "green")
                window.Background = Brushes.Green;
            else if (((FrameworkElement)sender).Tag.ToString() == "orange")
                window.Background = Brushes.Orange;
            else if (((FrameworkElement)sender).Tag.ToString() == "black")
                window.Background = Brushes.Black;
        }
    }
}
