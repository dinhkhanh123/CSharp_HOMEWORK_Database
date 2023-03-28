using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_DATABASE_CONNECTION_CSHARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet1.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet1.STUDENT);

        }

    
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int ind = e.RowIndex;
            DataGridViewRow selectedRows = dataGridView1.Rows[ind];
            txtStudentId.Text = selectedRows.Cells[0].Value.ToString();
            txtName.Text = selectedRows.Cells[1].Value.ToString();
            txtClassId.Text = selectedRows.Cells[2].Value.ToString();


        }
    }
}


//int position = -1;
//DataSet ds = new DataSet();


//if(dataGridView1.Rows.Count > 0)
//{
//    txtStudentId.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
//    txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
//    txtClassId.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
//}