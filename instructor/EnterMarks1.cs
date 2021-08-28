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
    public partial class EnterMarks1 : Form
    {
        public EnterMarks1()
        {
            InitializeComponent();
        }
        // this variable  displays The results of  Attendence_Degree and Projectdegree while selecting from combobox
        bool load = false;
        bool load1 = false;
        private void EnterMarks1_Load(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select group_ID from Groups", con))
                {
                    OleDbDataAdapter d = new OleDbDataAdapter(com);
                    DataTable dt = new DataTable();
                    d.Fill(dt);
                    comboGroupID.DataSource = dt;
                    comboGroupID.ValueMember = dt.Columns[0].ToString();
                    comboGroupID.DisplayMember = dt.Columns[0].ToString();
                }
            }
        }

        private void comboGroupID_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtWriting.Text = "";
            txtReading.Text = "";
            txtFinalExam.Text = "";
            txtListening.Text = "";
            txtGrade.Visible = false;
            lblGrade.Visible = false;
            //fill Combo box with student name
            try
            {

                if (load1)
                {
                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                    {
                        //string o = "select Attendence_Degree,Projectdegree,[level] from St s join Groups g on g.group_ID=s.group_ID where Stud_ID=" + comboName.SelectedValue + "";
                        string i = "select Attendence_Degree,Projectdegree from  St where Stud_ID=" + comboName.SelectedValue + "";
                        con.Open();
                        using (OleDbCommand com = new OleDbCommand(i, con))
                        {
                            OleDbDataReader r = com.ExecuteReader();
                            while (r.Read())
                            {
                                txtAttendence_Degree.Text = r.GetFloat(0).ToString();
                                txtProjectdegree.Text = r.GetInt32(1).ToString();
                                //comboLevel.Text = r.GetInt32(2).ToString();
                            }
                            r.Close();
                        }
                    }
                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                    {
                        //string o = "select Attendence_Degree,Projectdegree,[level] from St s join Groups g on g.group_ID=s.group_ID where Stud_ID=" + comboName.SelectedValue + "";
                        //string i = "select [level] from  Groups join St on Groups.group_ID=St.group_ID   where Stud_ID=" + comboName.SelectedValue + "";
                        string p = "select [level] from  Groups where group_ID=" + comboGroupID.SelectedValue + "";
                        con.Open();
                        using (OleDbCommand com = new OleDbCommand(p, con))
                        {
                            OleDbDataReader r = com.ExecuteReader();
                            while (r.Read())
                            {
                                //txtAttendence_Degree.Text = r.GetFloat(0).ToString();
                                //txtProjectdegree.Text = r.GetInt32(1).ToString();
                                comboLevel.Text = r.GetInt32(0).ToString();
                            }
                            r.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (comboLevel.Text == "4" || comboLevel.Text == "5" || comboLevel.Text == "6")
            {
                txtReading.Text = "";
                txtWriting.Text = "";
                txtWriting.Enabled = true;
                txtReading.Enabled = true;
            }
            else
            {
          
                txtReading.Text = "0";
                txtWriting.Text = "0";
                txtWriting.Enabled = false;
                txtReading.Enabled = false;
            }
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            if (comboLevel.Text == "4" || comboLevel.Text == "5" || comboLevel.Text == "6")
            {

                // Prevent to remain text box empty
                if (txtReading.Text == "" || txtWriting.Text == "" || txtFinalExam.Text == "" || txtListening.Text == "")
                {
                    MessageBox.Show("Please Insert Marks in Reading,Writing,Listening,FinalExam");
                    return;
                }

                // Prevent to enter >15 in Writing and Reading
                if (float.Parse(txtWriting.Text) > 15 || float.Parse(txtReading.Text) > 15)
                {
                    MessageBox.Show("Please insert at most 15 Marks in Writing and Reading");
                    return;
                }

                // Prevent to enter >10 in Listening
                if (float.Parse(txtListening.Text) > 10)
                {
                    MessageBox.Show("Please insert at most 10 Marks in Listening");
                    return;
                }

                // Prevent to enter >30 in FinalExam
                if (float.Parse(txtFinalExam.Text) > 30)
                {
                    MessageBox.Show("Please insert at most 30 Marks in Final Exam");
                    return;
                }


            }
            else
            {        

                // Prevent to remain text box empty
                if (txtFinalExam.Text == "" || txtListening.Text == "")
                {
                    MessageBox.Show("Please insert Marks in Listening,FinalExam");
                    return;
                }

                // Prevent to enter >10 in Listening
                if (float.Parse(txtListening.Text) > 10)
                {
                    MessageBox.Show("Please insert at most 10 Marks in Listening");
                    return;
                }

                // Prevent to enter >60 in FinalExam
                if (float.Parse(txtFinalExam.Text) > 60)
                {
                    MessageBox.Show("Please insert at most 60 Marks in Final Exam");
                    return;
                }
            }
            // insert Degress of Student
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                string l = "";
                con.Open();

                //string o = "update St set [Homework]=" + float.Parse(txtHomework.Text) + ",[Participation]=" + float.Parse(txtParticipation.Text) + ",[Exam_degree]=" + float.Parse(txtFinalExam.Text) + " where Stud_ID=" + comboName.SelectedValue + "";
                float k = float.Parse(txtWriting.Text) + float.Parse(txtReading.Text) + float.Parse(txtFinalExam.Text) + float.Parse(txtAttendence_Degree.Text) + float.Parse(txtProjectdegree.Text);

                //check
                if (k >= 90 && k <= 100)
                {
                    l = "Excellent";
                    txtGrade.Text = "Excellent";
                }
                else if (k < 90 && k >= 80)
                {
                    l = "Very Good";
                    txtGrade.Text = "Very Good";
                }
                else if (k < 80 && k >= 70)
                {
                    l = "Good";
                    txtGrade.Text = "Good";
                }
                else if (k < 70 && k >= 65)
                {
                    l = "Pass";
                    txtGrade.Text = "Pass";
                }
                else if (k < 65 && k >= 0)
                {
                    l = "Fail";
                    txtGrade.Text = "Fail";
                }
                string b = "update St set [Writing]=" + float.Parse(txtWriting.Text) + ",[Reading]=" + float.Parse(txtReading.Text) + ",listening=" + float.Parse(txtListening.Text) + ",[Exam_degree]=" + float.Parse(txtFinalExam.Text) + ",[Grade]=@Grade,[Finaldegree]=" + k + " where Stud_ID=" + comboName.SelectedValue + "";

                using (OleDbCommand com = new OleDbCommand(b, con))
                {
                    com.Parameters.AddWithValue("@Grade", txtGrade.Text);
                    int h = com.ExecuteNonQuery();
                    if (h > 0)
                    {
                        MessageBox.Show("Insertion Successed.");
                    }
                }

            }

            lblGrade.Visible = true;
            txtGrade.Visible = true;
           
        }

        private void EnterMarks1_Shown(object sender, EventArgs e)
        {
            load = true;

        }

        private void comboName_DropDown(object sender, EventArgs e)
        {
            load1 = true;

        }

        private void JustNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false || e.KeyChar == 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;

            }
        }
    }
}
