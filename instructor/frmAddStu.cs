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
    public partial class frmAddStu : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");        

        public frmAddStu()
        {
            InitializeComponent();
        }
        // This bool variable prevents message"Do You want to add new trainee?" when The ID message is repeated   
        bool u;

        private void btnStu_Click(object sender, EventArgs e)
        {
            u = false;
            if (txtIdentity.Text == "" || txtStudent_Name.Text == ""  )
            {
                MessageBox.Show("Please insert values");
                return;
            }

            OleDbCommand com = new OleDbCommand("Insert Into St (Stud_ID,Student_Name,group_ID) values (@Stud_ID,@txtStudent_Name,@group_ID)", con);

            com.Parameters.AddWithValue("@Stud_ID",Convert.ToInt64( txtIdentity.Text ));
            com.Parameters.AddWithValue("@txtStudent_Name", txtStudent_Name.Text);
            com.Parameters.AddWithValue("@group_ID",Convert.ToInt32( comboGroupId.Text ));

            try
            {
                int x;

                con.Open();
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
                    DialogResult xx = MessageBox.Show("Do you want to add new trainee?", "Attention", MessageBoxButtons.YesNo);
                    if (xx == DialogResult.Yes)
                    {
                        this.Close();
                        frmAddStu l = new frmAddStu();
                        l.Show();
                        //this.Show();
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

        private void frmAddStu_Load(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand("select group_ID from Groups", con);
            OleDbDataAdapter d = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            d.Fill(dt);
            comboGroupId.DataSource = dt;
            comboGroupId.ValueMember = dt.Columns[0].ToString();
            comboGroupId.DisplayMember = dt.Columns[0].ToString();
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
