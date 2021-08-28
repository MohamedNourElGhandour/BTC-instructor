namespace Eng1
{
    partial class frmDeleteStu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteStu));
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtStudent_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNameDel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(355, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 37);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStudent_Name
            // 
            this.txtStudent_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudent_Name.Enabled = false;
            this.txtStudent_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtStudent_Name.Location = new System.Drawing.Point(355, 214);
            this.txtStudent_Name.Name = "txtStudent_Name";
            this.txtStudent_Name.Size = new System.Drawing.Size(237, 23);
            this.txtStudent_Name.TabIndex = 24;
            this.txtStudent_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(116, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "English Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(116, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "English Name";
            // 
            // comboNameDel
            // 
            this.comboNameDel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNameDel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboNameDel.FormattingEnabled = true;
            this.comboNameDel.Location = new System.Drawing.Point(355, 160);
            this.comboNameDel.Name = "comboNameDel";
            this.comboNameDel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboNameDel.Size = new System.Drawing.Size(237, 24);
            this.comboNameDel.TabIndex = 34;
            this.comboNameDel.SelectedIndexChanged += new System.EventHandler(this.comboNameDel_SelectedIndexChanged);
            // 
            // frmDeleteStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 383);
            this.Controls.Add(this.comboNameDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudent_Name);
            this.Controls.Add(this.btnDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeleteStu";
            this.Text = "Delete Trainee";
            this.Load += new System.EventHandler(this.frmDeleteStu_Load);
            this.Shown += new System.EventHandler(this.frmDeleteStu_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtStudent_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNameDel;
    }
}