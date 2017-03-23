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
using System.Windows.Shapes;
using lab9.Model;
using Newtonsoft.Json;
using System.IO;
using System.Collections.ObjectModel;

namespace lab9
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public ObservableCollection<Email> emails;
        public string json;
        public GridWindow()
        {
            InitializeComponent();
            json = File.ReadAllText("email.json");
            emails = JsonConvert.DeserializeObject<ObservableCollection<Email>>(json);
            grid.ItemsSource = emails;
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow mwind = new MainWindow(emails,grid.SelectedIndex);
            mwind.ShowDialog();
        }
    }
}
