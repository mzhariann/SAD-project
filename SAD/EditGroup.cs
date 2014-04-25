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
            //int rowCountEx = t.Rows.Count;
            
            studentsGridView.DataSource = t;
            studentsGridView.Columns[1].Visible = false;
            StudentSelect.DataPropertyName = "bool";

            DataTable t2 = dbConnection.getProfsInGroup(Gid);
            profGridView.DataSource = t2;
            profGridView.Columns[1].Visible = false;
            profSelect.DataPropertyName = "bool";
            
            DataTable t3 = dbConnection.getAllEvalsTable();
            evalGridView.DataSource = t3;
            evalGridView.Columns[1].Visible = false;
            EvalSelect.DataPropertyName = "bool";
        }

        private void name_txtbox_TextChanged(object sender, EventArgs e)
        {
            name = name_txtbox.Text;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            dbConnection.updateGroup(name, Gid);
            this.Close();
        }
    }
}
