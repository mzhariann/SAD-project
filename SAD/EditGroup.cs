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
    public partial class EditGroup : Form
    {
        int Gid;
        string name;
        DataTable preStd;
        DataTable preProf;
        DataTable preEval;
        public EditGroup(int id)
        {
            Gid = id;
            InitializeComponent();
            fillData();
        }
        
        public void fillData()
        {
            //DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            //groupsDataGridView.Columns.Add(col);
            name_txtbox.AppendText(dbConnection.getField("Group", Gid, "Name"));
            DataTable t = dbConnection.getStudentsInGroup(Gid);
            preStd = t.Copy();
            studentsGridView.DataSource = t;
            studentsGridView.Columns["bool"].Visible = false;
            StudentSelect.DataPropertyName = "bool";

            DataTable t2 = dbConnection.getProfsInGroup(Gid);
            preProf = t2.Copy();
            profGridView.DataSource = t2;
            profGridView.Columns["bool"].Visible = false;
            profSelect.DataPropertyName = "bool";
            
            DataTable t3 = dbConnection.getEvalsInGroup(Gid);
            preEval = t3.Copy();
            evalGridView.DataSource = t3;
            evalGridView.Columns["bool"].Visible = false;
            EvalSelect.DataPropertyName = "bool";
        }

        private void name_txtbox_TextChanged(object sender, EventArgs e)
        {
            name = name_txtbox.Text;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            dbConnection.updateGroup(name, Gid);

            foreach (DataGridViewRow row in studentsGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[StudentSelect.Name];
                
                Boolean b4 = Convert.ToBoolean(preStd.Rows[row.Index].ItemArray[0]);
                Boolean now = row.Cells[StudentSelect.Name].Value == DBNull.Value? false : Convert.ToBoolean(row.Cells[StudentSelect.Name].Value);

                if ( now == true && b4 == false)
                {
                    dbConnection.addGroupMember(Gid, Convert.ToInt32(row.Cells["Id"].Value) );
                    //MessageBox.Show("ADD STU : " + Convert.ToInt32(row.Cells["Id"].Value));
                }
                else if ( now == false && b4 == true)
                {
                    dbConnection.deleteGroupMember(Gid, Convert.ToInt32(row.Cells["Id"].Value));
                    //MessageBox.Show("DELETE STU : " + Convert.ToInt32(row.Cells["Id"].Value));
                }
            }

            foreach (DataGridViewRow row in profGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[profSelect.Name];

                Boolean b4 = Convert.ToBoolean(preProf.Rows[row.Index].ItemArray[0]);
                Boolean now = row.Cells[profSelect.Name].Value == DBNull.Value ? false : Convert.ToBoolean(row.Cells[profSelect.Name].Value);

                if (now == true && b4 == false)
                {
                    dbConnection.addGroupMember(Gid, Convert.ToInt32(row.Cells["Id"].Value));
                    //MessageBox.Show("ADD STU : " + Convert.ToInt32(row.Cells["Id"].Value));
                }
                else if (now == false && b4 == true)
                {
                    dbConnection.deleteGroupMember(Gid, Convert.ToInt32(row.Cells["Id"].Value));
                    //MessageBox.Show("DELETE STU : " + Convert.ToInt32(row.Cells["Id"].Value));
                }
            }

            foreach (DataGridViewRow row in evalGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[EvalSelect.Name];

                Boolean b4 = Convert.ToBoolean(preEval.Rows[row.Index].ItemArray[0]);
                Boolean now = row.Cells[EvalSelect.Name].Value == DBNull.Value ? false : Convert.ToBoolean(row.Cells[EvalSelect.Name].Value);

                if (now == true && b4 == false)
                {
                    dbConnection.addGroupMember(Gid, Convert.ToInt32(row.Cells["Id"].Value));
                    //MessageBox.Show("ADD STU : " + Convert.ToInt32(row.Cells["Id"].Value));
                }
                else if (now == false && b4 == true)
                {
                    dbConnection.deleteGroupMember(Gid, Convert.ToInt32(row.Cells["Id"].Value));
                    //MessageBox.Show("DELETE STU : " + Convert.ToInt32(row.Cells["Id"].Value));
                }
            }
            this.Close();
        }
    }
}
