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
    public partial class frmUpdateStu : Form
    {
        public frmUpdateStu()
        {
            InitializeComponent();
        }

        bool load = false,load1=false;
        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
          if (load1 == true && load == true)

            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                {
                    con.Open();
                    using (OleDbCommand com = new OleDbCommand("select Student_Name,group_ID from St where Stud_ID=" + comboName.SelectedValue + "", con))
                    {
                        OleDbDataReader r = com.ExecuteReader();
                        while (r.Read())
                        {
                            txtStudent_Name.Text = r.GetString(0);
                            comboNewGroupID.Text = r.GetInt32(1).ToString();
                        }
                        r.Close();

                    }
                }
            }

        }

        private void frmUpdateStu_Load(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select group_ID from Groups", con))
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboGroupID.DataSource = dt;
                    comboGroupID.ValueMember = dt.Columns[0].ToString();
                    comboGroupID.DisplayMember = dt.Columns[0].ToString();

                    
                }
            }
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select group_ID from Groups", con))
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboNewGroupID.DataSource = dt;
                    comboNewGroupID.ValueMember = dt.Columns[0].ToString();
                    comboNewGroupID.DisplayMember = dt.Columns[0].ToString();

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtStudent_Name.Text == "")
            {
                MessageBox.Show("Please insert in New English Name");
                return;
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");
            con.Open();
            OleDbCommand com = new OleDbCommand("update  St set Student_Name=@Student_Name,group_ID=@group_ID where Stud_ID=" + comboName.SelectedValue + "", con);
            com.Parameters.AddWithValue("@txtStudent_Name", txtStudent_Name.Text);
            com.Parameters.AddWithValue("@group_ID", Convert.ToInt32(comboNewGroupID.Text));
            
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

        private void frmUpdateStu_Shown(object sender, EventArgs e)
        {
            load = true;
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

        private void comboGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (load == true)
                {
                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                    {
                        using (OleDbCommand com = new OleDbCommand("select Stud_ID,Student_Name from St where group_ID=" + comboGroupID.SelectedValue + "", con))
                        {
                            OleDbDataAdapter adap = new OleDbDataAdapter(com);
                            DataTable dt = new DataTable();
                            adap.Fill(dt);
                            comboName.DataSource = dt;
                            comboName.ValueMember = dt.Columns[0].ToString();
                            comboName.DisplayMember = dt.Columns[1].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "No value given for one or more required parameters.")
                {
                    MessageBox.Show("Click OK");
                }
                else { MessageBox.Show(ex.Message); }
            }
        }

        

        private void comboName_DropDown(object sender, EventArgs e)
        {
            load1 = true;

        }
    }
}
