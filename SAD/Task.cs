using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD
{
    public class Task
    {
        public string subject { set; get; }
        public DateTime creationDate { set; get; }
        public string content { set; get; }
        public Boolean confirmation { set; get; }
        public PeriodicSend prdSend { set; get; }
        public DateTime sendingDate { set; get; }
        public List<string> receivers { set; get; }
        public Boolean periodicSend = false;
    }
}
