using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Eng1
{
    public partial class frmViewDegree : Form
    {

        DataSet s;
        OleDbDataAdapter d;
        OleDbCommandBuilder cmdBldr;
        public frmViewDegree()
        {
            InitializeComponent();
        }

        private void frmViewDegree_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");
            s = new DataSet();
            string t = "select Student_Name_Ar,Attendence_Degree,listening,Reading,Writing,Exam_degree,Projectdegree,Finaldegree,Grade from St";
            d = new OleDbDataAdapter(t, con);
            cmdBldr = new OleDbCommandBuilder(d);
            d.Fill(s, "Student_attendance");
            dataGridView1.DataSource = s;
            dataGridView1.DataMember = "Student_attendance";
            con.Close();
        }
    }
}
