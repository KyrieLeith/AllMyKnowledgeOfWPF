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
using Newtonsoft.Json;
using System.IO;
using System.Globalization;
using lab9.Model;
using System.Collections.ObjectModel;

namespace lab9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Email> emails;
        public int SelectedIndex;
        public string json;
        public MainWindow(ObservableCollection<Email> inp_emails, int ind)
        {
            InitializeComponent();
            emails = inp_emails;
            SelectedIndex = ind;
            itemGrid.DataContext = emails[SelectedIndex];
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            json = JsonConvert.SerializeObject(emails, Formatting.Indented);
            File.WriteAllText("email.json", json);
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (btn.Content.ToString() == "Добавить копию")
            {
                emails[SelectedIndex].Copy.Add(copyItem.Text);
            }
            else if (btn.Content.ToString() == "Удалить копию")
            {
                if (lb.SelectedIndex >= 0)
                    emails[SelectedIndex].Copy.RemoveAt(lb.SelectedIndex);
            }
        }

        private void ListBox_GotFocus(object sender, RoutedEventArgs e)
        {
            btn.Content = "Удалить копию";
        }

        private void copyItem_GotFocus(object sender, RoutedEventArgs e)
        {
            btn.Content = "Добавить копию";
        }
    }  
}
