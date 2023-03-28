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
    public partial class Search_Student_by_Name : Form
    {

        String conn = @"Data Source=DESKTOP-3EU7UMS\SQLEXPRESS;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public Search_Student_by_Name()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String sql = $"Select * from STUDENT where Name like '%{txtSearch.Text}%'";
            adapter = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Search_Student_by_Name_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet1.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet1.STUDENT);

        }
    }
}
