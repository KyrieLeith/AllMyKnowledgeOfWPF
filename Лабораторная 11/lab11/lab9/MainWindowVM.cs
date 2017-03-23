using lab9.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using lab9.src;

namespace lab9
{
    public class MainWindowVM
    {
        public Email Model { get; set; }
        public ICommand DeleteCmd { get; set; }
        public ICommand AddCmd { get; set; }
        public int CopyIndex { get; set; }
        public string CopyItem { get; set; }
        public GridWindowVM StatusChanged { get; set; }
        public MainWindowVM()
        {
            DeleteCmd = new Command(arg => Delete());
            AddCmd = new Command(arg => Add());            
        }
        private void Delete()
        {
            if (Model.Copy.Count > CopyIndex)
            {
                Model.Copy.RemoveAt(CopyIndex);
                StatusChanged.Message = "Данные изменены";
            }
        }
        private void Add()
        {
            if (CopyItem != "")
            {
                Model.Copy.Add(CopyItem);
                StatusChanged.Message = "Данные изменены";
            }
        }
    }
}
