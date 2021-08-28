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
    public partial class frmDeleteStu : Form
    {
        bool loaded = false;
        public frmDeleteStu()
        {
            InitializeComponent();
        }
        #region Fill combo box with StudentName
        private void frmDeleteStu_Load(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select Stud_ID,Student_Name from St", con))
                {
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    comboNameDel.DataSource = dt;
                    comboNameDel.ValueMember = dt.Columns[0].ToString();
                    comboNameDel.DisplayMember = dt.Columns[1].ToString();
                }
            }
        }
        
        #endregion

        #region Delete specific student  
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Are you sure deleting the the student
            DialogResult xx = MessageBox.Show("Are you sure deleting this student", "Attention", MessageBoxButtons.YesNo);
            if (xx==DialogResult.No )
            {
                return;
            }
            //Finish
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                con.Open();
                using (OleDbCommand com = new OleDbCommand("delete from St where Stud_ID=" + comboNameDel.SelectedValue + "", con))
                {
                   int i= com.ExecuteNonQuery();
                   MessageBox.Show( i.ToString() + " Record is eliminated", "Attention", MessageBoxButtons.OK);
                }
            }
        }
        #endregion
       

        private void comboNameDel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                {
                    con.Open();
                    using (OleDbCommand com = new OleDbCommand("select Student_Name from St where Stud_ID=" + comboNameDel.SelectedValue + "", con))
                    {
                        OleDbDataReader rr = com.ExecuteReader(CommandBehavior.SingleRow);
                        while (rr.Read())
                        {
                            txtStudent_Name.Text = rr["Student_Name"].ToString();
                           
                        }
                    }
                }
            }
        }

        private void frmDeleteStu_Shown(object sender, EventArgs e)
        {
            loaded = true;
        }

        private void JustLetter(object sender, KeyPressEventArgs e)
        {
            //Enter Just Leters in textbox Arabic Name,English Name,Nationality
            if (Char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
            }
            //8 bachspace , 32 space
            if (e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;

            }
        }

       
    }
}
