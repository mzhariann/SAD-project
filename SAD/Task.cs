using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace SAD
{
    public class Task
    {
        public int id { set; get; }
        public string subject { set; get; }
        public DateTime creationDate { set; get; }
        public string content { set; get; }
        public Boolean confirmation { set; get; }
        public PeriodicSend prdSend { set; get; }
        public DateTime sendingDate { set; get; }
        public List<int> receivers { set; get; }
        public Boolean periodicSend = false;
        public Task()
        {
            prdSend = new PeriodicSend();
            receivers = new List<int>();
        }
        public void saveToDB()
        {
            TaskDAO.insert(this);
        }
        public void updateInDB()
        {
        }
        public void deleteFromDB()
        {
            TaskDAO.delete(this);
        }
        public void addReceivers()
        {
            TaskDAO.insertReceivers(this);
        }
        public static DataTable getSubjectTable()
        {           
            return TaskDAO.getSubjectTable();
        }
        public static Task getById(int id)
        {
            return TaskDAO.getById(id);
        }
    }
}
