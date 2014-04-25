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
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
            FillData();
        }
        public void FillData()
        {
            //DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            //groupsDataGridView.Columns.Add(col);

            DataTable t = dbConnection.getAllStudentsTable();
            studentsGridView.DataSource = t;

            DataTable t2 = dbConnection.getAllProfsTable();
            profGridView.DataSource = t2;
            DataTable t3 = dbConnection.getAllEvalsTable();
            evalGridView.DataSource = t3;
        }
        private void save_button_Click(object sender, EventArgs e)
        {
            int gId = dbConnection.addGroup(name_txtbox.Text);

            Int32 rowCount = studentsGridView.Rows.Count;


            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    if (Convert.ToBoolean(studentsGridView.Rows[i].Cells["StudentSelect"].Value) == false)
                        continue;
                    int stdId = Convert.ToInt32(studentsGridView.Rows[i].Cells["Id"].Value);
                    dbConnection.addGroupMember(gId , stdId);
                    //System.Diagnostics.Debug.WriteLine("DELETE DONE : ");
                }

            }

            rowCount = profGridView.Rows.Count;


            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    if (Convert.ToBoolean(profGridView.Rows[i].Cells["ProfSelect"].Value) == false)
                        continue;
                    int stdId = Convert.ToInt32(profGridView.Rows[i].Cells["Id"].Value);
                    dbConnection.addGroupMember(gId, stdId);
                    //System.Diagnostics.Debug.WriteLine("DELETE DONE : ");
                }

            }


            rowCount = evalGridView.Rows.Count;


            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    if (Convert.ToBoolean(evalGridView.Rows[i].Cells["EvalSelect"].Value) == false)
                        continue;
                    int stdId = Convert.ToInt32(evalGridView.Rows[i].Cells["Id"].Value);
                    dbConnection.addGroupMember(gId, stdId);
                    //System.Diagnostics.Debug.WriteLine("DELETE DONE : ");
                }

            }
            this.Close();
        }
    }
}
