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
    public partial class frmEvaluation : Form
    {
        public frmEvaluation()
        {
            InitializeComponent();
        }
        //"Good" Or "Very Good" Or "Excellent"
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (comboFluency.Text == "" || comboPronunciation.Text == "" || comboSpeakingSkill.Text == "" || comboWritingSkill.Text == "" || comboReadingSkill.Text == "" || comboListeningSkill.Text ==""|| comboComprehension.Text == "" || comboAbilitytoLearn.Text == "" || comboLiabilitytoChange.Text == "" || comboBehaviorInside.Text == "" || comboBehaviorOutside.Text == "" || comboRelationWithOther.Text == "" || comboRelationWithTeacher.Text == "")
            {
                MessageBox.Show("Please Select Value","Attention");
                return;    
            }
            if (txtComments.Text=="" || txtDesire.Text=="" || txtPeriod.Text=="")
            {
                MessageBox.Show("Please Insert Value", "Attention");
                return;
            }
            //insert project degress
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                con.Open();
                string m = "update St set [Fluency]=@Fluency,[Pronunciation]=@Pronunciation,[Speaking_Skill]=@Speaking_Skill,[Writing_Skill]=@Writing_Skill,[Reading_Skill]=@Reading_Skill,[Listening_Skill]=@Listening_Skill,[Comprehension]=@Comprehension,Ability_Learn=@Ability_Learn,Liability_Change=@Liability_Change,BehaviorInClass=@BehaviorInClass,BehaviorOutClass=@BehaviorOutClass,RelationOthers=@RelationOthers,RelationTeacher=@RelationTeacher,DesireImprove=@DesireImprove,expectedPeriodImprove=@expectedPeriodImprove,GeneralComments=@GeneralComments  where Stud_ID=" + comboName.SelectedValue + "";//+ comboName.ValueMember +;
                using (OleDbCommand com = new OleDbCommand(m, con))
                {
                    com.Parameters.AddWithValue("@Fluency", comboFluency.Text);
                    com.Parameters.AddWithValue("@Pronunciation", comboPronunciation.Text);
                    com.Parameters.AddWithValue("@Speaking_Skill", comboSpeakingSkill.Text);
                    com.Parameters.AddWithValue("@txtWriting_Skill", comboWritingSkill.Text);
                    com.Parameters.AddWithValue("@Reading_Skill", comboReadingSkill .Text);
                    com.Parameters.AddWithValue("@Listening_Skill", comboListeningSkill.Text);
                    com.Parameters.AddWithValue("@Comprehension", comboComprehension.Text);
                    com.Parameters.AddWithValue("@Ability_Learn", comboAbilitytoLearn.Text);
                    com.Parameters.AddWithValue("@Liability_Change", comboLiabilitytoChange.Text);
                    com.Parameters.AddWithValue("@BehaviorInClass", comboBehaviorInside.Text);
                    com.Parameters.AddWithValue("@BehaviorOutClass", comboBehaviorOutside.Text);
                    com.Parameters.AddWithValue("@RelationOthers", comboRelationWithOther .Text);
                    com.Parameters.AddWithValue("@RelationTeacher", comboRelationWithTeacher .Text);
                    com.Parameters.AddWithValue("@DesireImprove", txtDesire.Text);
                    com.Parameters.AddWithValue("@expectedPeriodImprove", txtPeriod.Text);
                    com.Parameters.AddWithValue("@GeneralComments", txtComments.Text);
                    int g = com.ExecuteNonQuery();


                    if (g > 0)
                    {                     
                        con.Close();
                        MessageBox.Show("Insertion Successed.");
                    }

                }
            }
        }

        private void frmEvaluation_Load(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select Stud_ID,Student_Name_Ar from St", con))
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

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFluency.Text = String.Empty ;
        }
    }
}
