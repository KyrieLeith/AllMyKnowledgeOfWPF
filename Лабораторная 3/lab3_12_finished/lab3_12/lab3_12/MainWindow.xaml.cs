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

namespace lab3_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            RadioButton_Boot1.IsChecked = true;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Графический редактор 1.0.", "О программе");
        }

        private void RadioButton_Boot1_Click(object sender, RoutedEventArgs e)
        {
            if (((FrameworkElement)sender).Tag.ToString() == "draw")
            {
                statbar2.Text = "Выбран режим работы: Рисование.";
                inkcanvas1.EditingMode = InkCanvasEditingMode.Ink;
            }
            else if (((FrameworkElement)sender).Tag.ToString() == "edit")
            {
                statbar2.Text = "Выбран режим работы: Редактирование.";
                inkcanvas1.EditingMode = InkCanvasEditingMode.Select;
            }
            else if (((FrameworkElement)sender).Tag.ToString() == "del")
            {
                statbar2.Text = "Выбран режим работы: Удаление.";
                inkcanvas1.EditingMode = InkCanvasEditingMode.EraseByStroke;
            }
        }

        private void combobox1_DropDownClosed(object sender, EventArgs e)
        {
            switch (combobox1.SelectedIndex)
            {
                case 0: statbar1.Text = "Выбрана чёрная кисть.";
                    attrs.Color = Colors.Black;
                    break;
                case 1: statbar1.Text = "Выбрана белая кисть.";
                    attrs.Color = Colors.White;
                    break;
                case 2: statbar1.Text = "Выбрана красная кисть.";
                    attrs.Color = Colors.Red;
                    break;
                case 3: statbar1.Text = "Выбрана зелёная кисть.";
                    attrs.Color = Colors.Green;
                    break;
                case 4: statbar1.Text = "Выбрана синяя кисть.";
                    attrs.Color = Colors.Blue;
                    break;
                case 5: statbar1.Text = "Выбрана жёлтая кисть.";
                    attrs.Color = Colors.Yellow;
                    break;
                case 6: statbar1.Text = "Выбрана оранжевая кисть.";
                    attrs.Color = Colors.Orange;
                    break;
            }
        }

        private void slider1_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            statbar3.Content = "Размер кисти: " + ((int)slider1.Value).ToString() + ".";
            attrs.Height = (int)slider1.Value;
            attrs.Width = (int)slider1.Value / 2 + 1;
        }
    }
}
