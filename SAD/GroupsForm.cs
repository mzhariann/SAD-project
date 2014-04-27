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
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            InitializeComponent();
            FillData();
        }
        public void FillData() {

            DataTable t = dbConnection.getGroupsTable();
            groupsDataGridView.DataSource = t;
        }

        private void new_group_btn_Click(object sender, EventArgs e)
        {
            AddGroupForm newGroup = new AddGroupForm();
            newGroup.Show();
            FillData();
            groupsDataGridView.Refresh();
        }

        private void edit_group_btn_Click(object sender, EventArgs e)
        {
            int grpid = Convert.ToInt32(groupsDataGridView.Rows[groupsDataGridView.SelectedRows[0].Index].Cells["Id"].Value);
            EditGroupForm e2 = new EditGroupForm(grpid);
            e2.Show();
            FillData();
            groupsDataGridView.Refresh();
        }

        private void delete_group_btn_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = groupsDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                     string grpid = Convert.ToString(groupsDataGridView.Rows[groupsDataGridView.SelectedRows[i].Index].Cells["Id"].Value);

                     dbConnection.delete("Group", Convert.ToInt32(grpid));

                     FillData();   
                     groupsDataGridView.Refresh();
                }

            }
        }
    }
}
