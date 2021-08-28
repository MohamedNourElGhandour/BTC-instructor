namespace Eng1
{
    partial class frmAddStu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStu));
            this.btnStu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudent_Name = new System.Windows.Forms.TextBox();
            this.comboGroupId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStu
            // 
            this.btnStu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnStu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStu.Location = new System.Drawing.Point(353, 358);
            this.btnStu.Name = "btnStu";
            this.btnStu.Size = new System.Drawing.Size(114, 38);
            this.btnStu.TabIndex = 0;
            this.btnStu.Text = "Enter";
            this.btnStu.UseVisualStyleBackColor = true;
            this.btnStu.Click += new System.EventHandler(this.btnStu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(66, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Identity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(66, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "English Name";
            // 
            // txtStudent_Name
            // 
            this.txtStudent_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudent_Name.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtStudent_Name.Location = new System.Drawing.Point(284, 233);
            this.txtStudent_Name.Name = "txtStudent_Name";
            this.txtStudent_Name.Size = new System.Drawing.Size(273, 22);
            this.txtStudent_Name.TabIndex = 19;
            this.txtStudent_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetter);
            // 
            // comboGroupId
            // 
            this.comboGroupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroupId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGroupId.FormattingEnabled = true;
            this.comboGroupId.Location = new System.Drawing.Point(284, 283);
            this.comboGroupId.Name = "comboGroupId";
            this.comboGroupId.Size = new System.Drawing.Size(273, 24);
            this.comboGroupId.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(66, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Group ID";
            // 
            // txtIdentity
            // 
            this.txtIdentity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtIdentity.Location = new System.Drawing.Point(284, 175);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdentity.Size = new System.Drawing.Size(273, 22);
            this.txtIdentity.TabIndex = 25;
            this.txtIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // frmAddStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 458);
            this.Controls.Add(this.txtIdentity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboGroupId);
            this.Controls.Add(this.txtStudent_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddStu";
            this.Text = "Add Trainee";
            this.Load += new System.EventHandler(this.frmAddStu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudent_Name;
        private System.Windows.Forms.ComboBox comboGroupId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentity;
    }
}

