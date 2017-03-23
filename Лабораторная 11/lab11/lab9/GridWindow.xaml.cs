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
        public GridWindow()
        {
            InitializeComponent();
        }

        public GridWindowVM ViewModel
        {
            get
            {
                return DataContext as GridWindowVM;
            }
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var wnd = new MainWindow();
            wnd.DataContext = new MainWindowVM()
            {
                Model = ViewModel.emails[ViewModel.SelectedEmail],
                StatusChanged = ViewModel
        };            
            wnd.ShowDialog();
        }
    }
}
