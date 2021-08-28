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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");
            OleDbCommand com = new OleDbCommand("insert into Verify values (@txtUserID,@txtPassword)", con);
            com.Parameters.AddWithValue("@txtUserID", txtUserID.Text);
            com.Parameters.AddWithValue("@txtPassword", txtPassword.Text);
            
            try
            {
                int x;

                con.Open();
                int n = com.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Insertion Successed.");
                }

            }
            catch (OleDbException ex)
            {
                //ex = new OleDbException();
                if (ex.Message == "The changes you requested to the table were not successful because they would create duplicate values in the index, primary key, or relationship.  Change the data in the field or fields that contain duplicate data, remove the index, or redefine the index to permit duplicate entries and try again.")
                {
                    MessageBox.Show("This UserID is recorded before");
                }
                else
                {
                    MessageBox.Show(ex.Message); 

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //تنبيه اضافة جديد
                DialogResult xx = MessageBox.Show("Do you want to add new user?", "Attention", MessageBoxButtons.YesNo);
                if (xx == DialogResult.Yes)
                {
                    this.Close();
                    frmAddUser  l = new frmAddUser();
                    l.Show();
                    //this.Show();
                }
                else
                {
                    this.Close();
                }
                //انتهى اضافة جديد

                con.Close();
            }

        }
    }
}
