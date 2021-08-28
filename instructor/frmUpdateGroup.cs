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
    public partial class frmUpdateGroup : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");        

        public frmUpdateGroup()
        {
            InitializeComponent();
        }

        private void frmUpdateGroup_Load(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select group_ID from Groups", con))
                {
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    comboID.DataSource = dt;
                    comboID.ValueMember = dt.Columns[0].ToString();
                }
            }

             // Fill combo box with instructor Names
                            
           using( OleDbCommand com1 = new OleDbCommand("select InstuctorID,InstructorName from Instructors", con))
           {
            OleDbDataAdapter d = new OleDbDataAdapter(com1);
            DataTable dt = new DataTable();
            d.Fill(dt);
            comboInstructor.DataSource = dt;
            comboInstructor.ValueMember = dt.Columns[0].ToString();
            comboInstructor.DisplayMember = dt.Columns[1].ToString();
           
              }

           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand("update  Groups set GroupDay=@txtGroupDay,GroupHours=@txtGroupHours,Class=@Class,[level]=@txtlevel,InstuctorID=@txtInstuctorID where group_ID="+double.Parse(comboID.Text)+"", con);
            com.Parameters.AddWithValue("@txtGroupDay", comboDays.Text);
            com.Parameters.AddWithValue("@txtGroupHours", comboHours.Text);
            //com.Parameters.AddWithValue("@txtGroupStart", DateTime.Now.Date);
            com.Parameters.AddWithValue("@Class", comboClass.Text);
            com.Parameters.AddWithValue("@txtlevel", Convert.ToInt32(comboLevel.Text));
            com.Parameters.AddWithValue("@txtInstuctorID", comboInstructor.SelectedValue);
            try
            {
                int n = com.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Update Successed.");
                }

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


    }
}
