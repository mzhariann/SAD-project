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
        }

        private void save_button_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount = studentsGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);


            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    string stdid = Convert.ToString(studentsGridView.Rows[studentsGridView.SelectedRows[i].Index].Cells["Id"].Value);
                    
                    //System.Diagnostics.Debug.WriteLine("DELETE DONE : ");
                }

            }

        }
    }
}
