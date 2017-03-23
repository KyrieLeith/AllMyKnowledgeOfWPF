using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.Model
{
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
        public ObservableCollection<String> Copy { get; set; }
    }

    public class CType
    {
        public string Mime { get; set; }
        public string Charset { get; set; }
    }
}
