using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;

namespace Eng1
{
    public partial class frmRepAll : Form
    {
        public frmRepAll()
        {
            InitializeComponent();
        }

        private void frmRepAll_Load(object sender, EventArgs e)
        {
            //ReportDocument r = new ReportDocument();         
            //r.Load(Application.StartupPath+"\\CrystalReport1.rpt");
            //crystalReportViewer1.ReportSource = r;
            //crystalReportViewer1.Refresh();
            FileInfo o = new FileInfo(Application.StartupPath + "\\CrystalReport2.rpt");
            //FileInfo o = new FileInfo(@"E:\ICDL Material\Eng1\Eng1\bin\Debug\CrystalReport3.rpt");
            ViewReport(o);
        }

        ReportDocument ReportSourceSetup(FileInfo crFileInfo, ConnectionInfo crConnectionInfo)
        {
            ReportDocument crDoc = new ReportDocument();
            TableLogOnInfos crTableLogonInfos = new TableLogOnInfos();
            TableLogOnInfo crTableLogonInfo = new TableLogOnInfo();
            Tables crTables;

            crDoc.Load(crFileInfo.FullName);

            // Each table in report needs to have logoninfo setup:
            crTables = crDoc.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table crTable in crTables)
            {
                crTableLogonInfo = crTable.LogOnInfo;
                crTableLogonInfo.ConnectionInfo = crConnectionInfo;
                crTable.ApplyLogOnInfo(crTableLogonInfo);
            }

            return crDoc;
        }

        public void ViewReport(FileInfo crFileInfo) // path\filename.rpt
        {
            ConnectionInfo crConnectionInfo = new ConnectionInfo();

            crConnectionInfo.ServerName = Application.StartupPath + "\\English_DB.mdb";
            //crConnectionInfo.ServerName = @"E:\ICDL Material\Eng1\Eng1\bin\Debug\English_DB.mdb";
            crConnectionInfo.DatabaseName = "";
            crConnectionInfo.UserID = "Admin";
            //crConnectionInfo.Password = "YOUR DATABASE PASSWORD";

            // CrystalReportViewer control
            crystalReportViewer1.ReportSource = ReportSourceSetup(crFileInfo, crConnectionInfo);
            crystalReportViewer1.Refresh();
        }
    }
  
}
