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
    public partial class frmVerification : Form
    {
        public frmVerification()
        {
            InitializeComponent();
        }

        int o = 6;
    
        private void frmVerification_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                con.Open();
                using (OleDbCommand com = new OleDbCommand("select UserID,Password from Verify ", con))
                {
                    OleDbDataReader r = com.ExecuteReader();
                    while (r.Read())
                    {
                        if (txtUserID.Text == r.GetString(0) && txtPassword.Text == r.GetString(1))
                        {
                            this.Hide();
                            frmStart g = new frmStart();
                            g.ShowDialog();
                            r.Close(); break;
                        }
                    }                  
                }
             }
        }
    }
}
