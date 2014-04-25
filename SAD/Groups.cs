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
    public partial class Groups : Form
    {
        public Groups()
        {
            InitializeComponent();
            FillData();
        }
        public void FillData() {
            //DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            //groupsDataGridView.Columns.Add(col);

            DataTable t = dbConnection.getGroupsTable();
            groupsDataGridView.DataSource = t;
        }

        private void new_group_btn_Click(object sender, EventArgs e)
        {
            AddGroup newGroup = new AddGroup();
            newGroup.Show();
        }

        private void edit_group_btn_Click(object sender, EventArgs e)
        {

        }

        private void delete_group_btn_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("DELETE BEGIN : ");
            //MessageBox.Show("DELETE BEGIN");
            
            Int32 selectedRowCount = groupsDataGridView.Rows
        .GetRowCount(DataGridViewElementStates.Selected);



            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                     string grpid = Convert.ToString(groupsDataGridView.Rows[groupsDataGridView.SelectedRows[i].Index].Cells["Id"].Value);

                     dbConnection.delete("Group", Convert.ToInt32(grpid));
                    //System.Diagnostics.Debug.WriteLine("DELETE DONE : ");
                     FillData();   
                     groupsDataGridView.Refresh();
                }

            }
        }
    }
}
