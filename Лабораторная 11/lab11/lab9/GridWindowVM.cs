using lab9.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using lab9.src;

namespace lab9
{
    public class GridWindowVM : VMBase
    {
        public ObservableCollection<Email> emails { get; set; }
        public int SelectedEmail { get; set; }
        public ICommand DeleteCmd { get; set; }
        public ICommand SaveCmd { get; set; }
        public ICommand AddCmd { get; set; }
        public string json;
        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                NotifyPropertyChanged("Message");
            }
        }
        public GridWindowVM()
        {
            json = File.ReadAllText("email.json");
            emails = JsonConvert.DeserializeObject<ObservableCollection<Email>>(json);
            Message = "Данные загружены";
            DeleteCmd = new Command(arg => Delete());
            SaveCmd = new Command(arg => Save());
            AddCmd = new Command(arg => Add());
        }
        private void Save()
        {
            json = JsonConvert.SerializeObject(emails, Formatting.Indented);
            File.WriteAllText("email.json", json);
            Message = "Данные сохранены";
        }
        private void Delete()
        {
            if (emails.Count > SelectedEmail)
            {
                emails.RemoveAt(SelectedEmail);
                Message = "Запись была удалена";
            }
        }
        private void Add()
        {
            Email buf = new Email();
            buf.Copy = new ObservableCollection<string>();
            emails.Add(buf);
            SelectedEmail = emails.Count - 1;
            Message = "Новая запись добавлена";
        }
    }
}
