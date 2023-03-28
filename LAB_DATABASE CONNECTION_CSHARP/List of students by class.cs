using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_DATABASE_CONNECTION_CSHARP
{
    public partial class List_of_students_by_class : Form
    {
        string conn = global::LAB_DATABASE_CONNECTION_CSHARP.Properties.Settings.Default.STUDENT_MANAGEMENTConnectionString;
        DataSet ds = null;
        SqlDataAdapter adapter = null;
        String str;

        public List_of_students_by_class()
        {
            InitializeComponent();
        }

        private void List_of_students_by_class_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet1.CLASS' table. You can move, or remove it, as needed.
            this.cLASSTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet1.CLASS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = $"Select * from Student where ClassID = '{cboClassID.Text}' ";
            adapter = new SqlDataAdapter(str,conn);
            ds = new DataSet(); 
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
