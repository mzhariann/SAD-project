using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD
{
    
    public class PeriodicSend
    {
        public DateTime startDate { set; get; }
        public DateTime endDate { set; get; }
        public KeyValuePair<int,int > period { set; get; }
    }
    public enum Periods {Week, Month, Year};
}
