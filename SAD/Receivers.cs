using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD
{
    public partial class Receivers : Form
    {
        Task task;
        public Receivers(Task tsk)
        {
            InitializeComponent();
            task = tsk;
            Controls.OfType<Button>().First(x => x.Name == "showGrps").Enabled = true;
            Controls.OfType<Button>().First(x => x.Name == "addGrps").Enabled = false;
            Controls.OfType<Button>().First(x => x.Name == "showMembers").Enabled = false;
            Controls.OfType<Button>().First(x => x.Name == "addMembers").Enabled = false;

        }

        List<int> selectedGrpsIds = new List<int>();
        private void addGrps_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grpsGridView.SelectedRows.Count; i++)
                selectedGrpsIds.Add((int)grpsGridView.Rows[grpsGridView.SelectedRows[i].Index].Cells["Id"].Value);
            MessageBox.Show("گروه مورد نظر به لیست گیرنده‌ها اضافه شد");
        }
        private void showMembers_Click(object sender, EventArgs e)
        {
            grpsGridView.DataSource = dbConnection.getMembersInGroup((int)grpsGridView.Rows[grpsGridView.SelectedRows[0].Index].Cells["Id"].Value);
            Controls.OfType<Button>().First(x => x.Name == "showGrps").Enabled = true;
            Controls.OfType<Button>().First(x => x.Name == "addGrps").Enabled = false;
            Controls.OfType<Button>().First(x => x.Name == "showMembers").Enabled = false;
            Controls.OfType<Button>().First(x => x.Name == "addMembers").Enabled = true;


        }

        List<int> selectedPIds = new List<int>();

        private void done_Click(object sender, EventArgs e)
        {
            task.receivers = new List<int>();
            task.receivers.AddRange(selectedPIds);
            
            for (int i = 0; i < selectedGrpsIds.Count; i++)
            {
                DataTable d = dbConnection.getMembersInGroup(selectedGrpsIds[i]);
                task.receivers.AddRange( (from row in d.AsEnumerable()
         select row.Field<int>("Id")).ToList<int>());
            }
            this.Close();
        }

        private void showGrps_Click(object sender, EventArgs e)
        {
            DataTable t = dbConnection.getGroupsTable();
            grpsGridView.DataSource = t;
            Controls.OfType<Button>().First(x => x.Name == "showGrps").Enabled = false;
            Controls.OfType<Button>().First(x => x.Name == "addGrps").Enabled = true;
            Controls.OfType<Button>().First(x => x.Name == "showMembers").Enabled = true;
            Controls.OfType<Button>().First(x => x.Name == "addMembers").Enabled = false;

        }

        private void addMembers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grpsGridView.SelectedRows.Count; i++)
                selectedPIds.Add((int)grpsGridView.Rows[grpsGridView.SelectedRows[i].Index].Cells["Id"].Value);
            MessageBox.Show("افراد مورد نظر به لیست گیرنده‌ها اضافه شد");
        }
    }
}
