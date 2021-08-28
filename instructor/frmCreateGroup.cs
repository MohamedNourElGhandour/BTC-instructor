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
    public partial class frmCreateGroup : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");        
        public frmCreateGroup()
        {
            InitializeComponent();
        }
        bool u;

        private void frmCreateGroup_Load(object sender, EventArgs e)
        {
            // Fill combo box with instructor Names
            OleDbCommand com = new OleDbCommand("select InstuctorID,InstructorName from Instructors", con);
            OleDbDataAdapter d = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            d.Fill(dt);
            comboInstructor.DataSource = dt;
            comboInstructor.ValueMember = dt.Columns[0].ToString();
            comboInstructor.DisplayMember = dt.Columns[1].ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            u = false;
            if (txtGroupID.Text == "" )
            {
                MessageBox.Show("Please insert Group ID");
                return;
            }
            if (comboClass.Text=="" ||comboDays.Text=="" ||comboHours.Text==""||comboLevel.Text=="")
            {
                MessageBox.Show("Please select values");
                return;
            }
            con.Open();
            OleDbCommand com = new OleDbCommand("Insert Into Groups (group_ID,GroupDay,GroupHours,GroupStart,Class,[level],InstuctorID) values (@group_ID,@txtGroupDay,@txtGroupHours,@txtGroupStart,@Class,@txtlevel,@txtInstuctorID)", con);

            com.Parameters.AddWithValue("@group_ID",double.Parse( txtGroupID.Text));
            com.Parameters.AddWithValue("@txtGroupDay", comboDays.Text );
            com.Parameters.AddWithValue("@txtGroupHours", comboHours.Text);
            com.Parameters.AddWithValue("@txtGroupStart", DateTime.Now.Date );
            com.Parameters.AddWithValue("@Class", comboClass.Text);
            com.Parameters.AddWithValue("@txtlevel", Convert.ToInt32(comboLevel.Text));
            com.Parameters.AddWithValue("@txtInstuctorID", comboInstructor.SelectedValue);
            try
            {
                u = true;

                int n = com.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Insertion Successed.");
                }

            }
            catch (OleDbException ex)
            {
                u = false;
                if (ex.Message == "The changes you requested to the table were not successful because they would create duplicate values in the index, primary key, or relationship.  Change the data in the field or fields that contain duplicate data, remove the index, or redefine the index to permit duplicate entries and try again.")
                {
                    MessageBox.Show("Sorry,This ID is repeated");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                u = false;

                MessageBox.Show(ex.Message);
            }
            finally
            {
                //تنبيه اضافة جديد
                if (u)
                {
                    DialogResult xx = MessageBox.Show("Do you need to add anew group", "تنبيه", MessageBoxButtons.YesNo);
                    if (xx == DialogResult.Yes)
                    {
                        this.Close();
                        frmCreateGroup l = new frmCreateGroup();
                        l.Show();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                //انتهى اضافة جديد

                con.Close();
            }
        }


        private void JustNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false || e.KeyChar == 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

       
    }
}
