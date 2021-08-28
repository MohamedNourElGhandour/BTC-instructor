namespace Eng1
{
    partial class frmUpdateStu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateStu));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudent_Name = new System.Windows.Forms.TextBox();
            this.comboGroupID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboNewGroupID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(331, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 36);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboName
            // 
            this.comboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(241, 159);
            this.comboName.Name = "comboName";
            this.comboName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboName.Size = new System.Drawing.Size(237, 24);
            this.comboName.TabIndex = 38;
            this.comboName.SelectedIndexChanged += new System.EventHandler(this.comboName_SelectedIndexChanged);
            this.comboName.DropDown += new System.EventHandler(this.comboName_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(23, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "English Name";
            // 
            // txtStudent_Name
            // 
            this.txtStudent_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudent_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtStudent_Name.Location = new System.Drawing.Point(241, 253);
            this.txtStudent_Name.Name = "txtStudent_Name";
            this.txtStudent_Name.Size = new System.Drawing.Size(237, 23);
            this.txtStudent_Name.TabIndex = 35;
            this.txtStudent_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetter);
            // 
            // comboGroupID
            // 
            this.comboGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroupID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboGroupID.FormattingEnabled = true;
            this.comboGroupID.Location = new System.Drawing.Point(241, 102);
            this.comboGroupID.Name = "comboGroupID";
            this.comboGroupID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboGroupID.Size = new System.Drawing.Size(237, 24);
            this.comboGroupID.TabIndex = 39;
            this.comboGroupID.SelectedIndexChanged += new System.EventHandler(this.comboGroupID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Group ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(23, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "New English Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(23, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "New Group ID";
            // 
            // comboNewGroupID
            // 
            this.comboNewGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNewGroupID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboNewGroupID.FormattingEnabled = true;
            this.comboNewGroupID.Location = new System.Drawing.Point(241, 309);
            this.comboNewGroupID.Name = "comboNewGroupID";
            this.comboNewGroupID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboNewGroupID.Size = new System.Drawing.Size(237, 24);
            this.comboNewGroupID.TabIndex = 45;
            // 
            // frmUpdateStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.comboNewGroupID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboGroupID);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudent_Name);
            this.Controls.Add(this.btnUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateStu";
            this.Text = "frmUpdateStu";
            this.Load += new System.EventHandler(this.frmUpdateStu_Load);
            this.Shown += new System.EventHandler(this.frmUpdateStu_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudent_Name;
        private System.Windows.Forms.ComboBox comboGroupID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboNewGroupID;
    }
}