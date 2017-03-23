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

namespace lab9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Email email;
        public string json;
        public MainWindow()
        {
            InitializeComponent();
            json = File.ReadAllText("email.json");
            email = JsonConvert.DeserializeObject<Email>(json);
            itemGrid.DataContext = email;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            json = JsonConvert.SerializeObject(email, Formatting.Indented);
            File.WriteAllText("email.json", json);
        }
    }

    public class Email
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }        
        public string Text { get; set; }
        public CType CType { get; set; }
        public DateTime Date { get; set; }
        public string Folder { get; set; }
        public bool Sent { get; set; }
        public double Mid { get; set; }
        public string Subject { get; set; }
        public List<String> Copy { get; set; }
    }

    public class CType
    {
        public string Mime { get; set; }
        public string Charset { get; set; }
    }
}
