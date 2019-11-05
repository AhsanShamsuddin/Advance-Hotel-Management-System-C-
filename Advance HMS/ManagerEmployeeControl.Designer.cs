namespace ISDProject
{
    partial class ManagerEmployeeControl
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
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.txtEemail = new System.Windows.Forms.TextBox();
            this.txtEPhNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEPost = new System.Windows.Forms.ComboBox();
            this.cbHID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEAdd = new System.Windows.Forms.TextBox();
            this.txtELN = new System.Windows.Forms.TextBox();
            this.txtEFN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.Crimson;
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.ForeColor = System.Drawing.Color.White;
            this.btnAddEmp.Location = new System.Drawing.Point(468, 395);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(383, 92);
            this.btnAddEmp.TabIndex = 61;
            this.btnAddEmp.Text = "Add Employee !";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // txtEemail
            // 
            this.txtEemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEemail.Location = new System.Drawing.Point(230, 447);
            this.txtEemail.Name = "txtEemail";
            this.txtEemail.Size = new System.Drawing.Size(201, 30);
            this.txtEemail.TabIndex = 60;
            // 
            // txtEPhNum
            // 
            this.txtEPhNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEPhNum.Location = new System.Drawing.Point(230, 378);
            this.txtEPhNum.Name = "txtEPhNum";
            this.txtEPhNum.Size = new System.Drawing.Size(201, 30);
            this.txtEPhNum.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(31, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 58;
            this.label3.Text = "Email :";
            // 
            // cbEPost
            // 
            this.cbEPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEPost.FormattingEnabled = true;
            this.cbEPost.Items.AddRange(new object[] {
            "Staff",
            "Receptionist",
            "Manager"});
            this.cbEPost.Location = new System.Drawing.Point(230, 243);
            this.cbEPost.Name = "cbEPost";
            this.cbEPost.Size = new System.Drawing.Size(201, 33);
            this.cbEPost.TabIndex = 57;
            // 
            // cbHID
            // 
            this.cbHID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHID.FormattingEnabled = true;
            this.cbHID.Location = new System.Drawing.Point(230, 49);
            this.cbHID.Name = "cbHID";
            this.cbHID.Size = new System.Drawing.Size(201, 33);
            this.cbHID.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(30, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 26);
            this.label9.TabIndex = 55;
            this.label9.Text = "Phone Number :";
            // 
            // txtEAdd
            // 
            this.txtEAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEAdd.Location = new System.Drawing.Point(230, 311);
            this.txtEAdd.Name = "txtEAdd";
            this.txtEAdd.Size = new System.Drawing.Size(201, 30);
            this.txtEAdd.TabIndex = 54;
            // 
            // txtELN
            // 
            this.txtELN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtELN.Location = new System.Drawing.Point(230, 177);
            this.txtELN.Name = "txtELN";
            this.txtELN.Size = new System.Drawing.Size(201, 30);
            this.txtELN.TabIndex = 53;
            // 
            // txtEFN
            // 
            this.txtEFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEFN.Location = new System.Drawing.Point(230, 110);
            this.txtEFN.Name = "txtEFN";
            this.txtEFN.Size = new System.Drawing.Size(201, 30);
            this.txtEFN.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(31, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 51;
            this.label4.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(31, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 50;
            this.label5.Text = "Emp Post :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(31, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 26);
            this.label6.TabIndex = 49;
            this.label6.Text = "Emp Last Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Emp First Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Hotel_Id :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ManagerEmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.txtEemail);
            this.Controls.Add(this.txtEPhNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEPost);
            this.Controls.Add(this.cbHID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEAdd);
            this.Controls.Add(this.txtELN);
            this.Controls.Add(this.txtEFN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManagerEmployeeControl";
            this.Size = new System.Drawing.Size(881, 537);
            this.Load += new System.EventHandler(this.ManagerEmployeeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.TextBox txtEemail;
        private System.Windows.Forms.TextBox txtEPhNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEPost;
        private System.Windows.Forms.ComboBox cbHID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEAdd;
        private System.Windows.Forms.TextBox txtELN;
        private System.Windows.Forms.TextBox txtEFN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
