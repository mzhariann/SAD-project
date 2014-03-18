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
        public string date { set; get; }
        public string content { set; get; }
        public string confirmation { set; get; }
        public string sendingOption { set; get; }
        public List<string> receivers { set; get; }
    }
}
