namespace ISDProject
{
    partial class EmployeeRDamageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.btnAddDamage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbDPS = new System.Windows.Forms.ComboBox();
            this.cmbDT = new System.Windows.Forms.ComboBox();
            this.cmbRID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDA
            // 
            this.txtDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDA.Location = new System.Drawing.Point(345, 114);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(201, 30);
            this.txtDA.TabIndex = 76;
            // 
            // btnAddDamage
            // 
            this.btnAddDamage.BackColor = System.Drawing.Color.Crimson;
            this.btnAddDamage.FlatAppearance.BorderSize = 0;
            this.btnAddDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDamage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddDamage.Location = new System.Drawing.Point(145, 351);
            this.btnAddDamage.Name = "btnAddDamage";
            this.btnAddDamage.Size = new System.Drawing.Size(383, 92);
            this.btnAddDamage.TabIndex = 75;
            this.btnAddDamage.Text = "Add Room Damage !";
            this.btnAddDamage.UseVisualStyleBackColor = false;
            this.btnAddDamage.Click += new System.EventHandler(this.btnAddDamage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(120, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 26);
            this.label6.TabIndex = 74;
            this.label6.Text = "Damage Pay Status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(120, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 73;
            this.label3.Text = "Damage Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(120, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 26);
            this.label2.TabIndex = 72;
            this.label2.Text = "Damage Amount :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(120, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 71;
            this.label1.Text = "Room ID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbDPS
            // 
            this.cmbDPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDPS.FormattingEnabled = true;
            this.cmbDPS.Items.AddRange(new object[] {
            "Paid",
            "Un Paid"});
            this.cmbDPS.Location = new System.Drawing.Point(345, 250);
            this.cmbDPS.Name = "cmbDPS";
            this.cmbDPS.Size = new System.Drawing.Size(201, 33);
            this.cmbDPS.TabIndex = 79;
            // 
            // cmbDT
            // 
            this.cmbDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDT.FormattingEnabled = true;
            this.cmbDT.Items.AddRange(new object[] {
            "Window",
            "Furniture",
            "Appliances"});
            this.cmbDT.Location = new System.Drawing.Point(345, 181);
            this.cmbDT.Name = "cmbDT";
            this.cmbDT.Size = new System.Drawing.Size(201, 33);
            this.cmbDT.TabIndex = 78;
            // 
            // cmbRID
            // 
            this.cmbRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRID.FormattingEnabled = true;
            this.cmbRID.Location = new System.Drawing.Point(345, 51);
            this.cmbRID.Name = "cmbRID";
            this.cmbRID.Size = new System.Drawing.Size(201, 33);
            this.cmbRID.TabIndex = 77;
            // 
            // EmployeeRDamageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.btnAddDamage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDPS);
            this.Controls.Add(this.cmbDT);
            this.Controls.Add(this.cmbRID);
            this.Name = "EmployeeRDamageControl";
            this.Size = new System.Drawing.Size(716, 510);
            this.Load += new System.EventHandler(this.EmployeeRDamageControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.Button btnAddDamage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbDPS;
        private System.Windows.Forms.ComboBox cmbDT;
        private System.Windows.Forms.ComboBox cmbRID;
    }
}
