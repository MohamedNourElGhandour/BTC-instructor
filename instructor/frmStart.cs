using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eng1
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStu y = new frmAddStu();
            y.ShowDialog();
        }

       

        

     

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteStu s = new frmDeleteStu();
            s.ShowDialog();
        }

       

        private void enterMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterMarks1  f = new EnterMarks1 ();
            f.ShowDialog();
        }

       

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepAll r = new frmRepAll();
            r.ShowDialog();
        }

      

       

       

        private void viewDegreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewDegree v = new frmViewDegree();
            v.ShowDialog();
        }

       

        private void frmStart_Load(object sender, EventArgs e)
        {

        }

      
        private void allEvaluationReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllEvaluationReport r = new frmAllEvaluationReport();
            r.ShowDialog();
        }

       

      

     

        private void updateGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateGroup f = new frmUpdateGroup();
            f.ShowDialog();
        }

        private void viewGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewGroup v = new frmViewGroup();
            v.ShowDialog();
        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateGroup n = new frmCreateGroup();
            n.ShowDialog();
        }

        private void ProjectDetailsStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProjectDetails y = new frmProjectDetails();
            y.ShowDialog();
        }

        private void attendenceStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAttend f = new frmAttend();
            f.ShowDialog();
        }

        private void evaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvaluation r = new frmEvaluation();
            r.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUpdateStu o = new frmUpdateStu();
            o.ShowDialog();
        }

     
       
        
     

     
        
    }
}
