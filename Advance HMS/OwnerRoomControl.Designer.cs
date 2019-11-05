namespace ISDProject
{
    partial class OwnerRoomControl
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
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.txtPRE = new System.Windows.Forms.TextBox();
            this.txtDEL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHotelID = new System.Windows.Forms.ComboBox();
            this.txtSTD = new System.Windows.Forms.TextBox();
            this.cbRType = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.Crimson;
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddRoom.Location = new System.Drawing.Point(258, 397);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(383, 92);
            this.btnAddRoom.TabIndex = 42;
            this.btnAddRoom.Text = "Add Room !";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtPRE
            // 
            this.txtPRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRE.Location = new System.Drawing.Point(445, 338);
            this.txtPRE.Name = "txtPRE";
            this.txtPRE.Size = new System.Drawing.Size(201, 30);
            this.txtPRE.TabIndex = 32;
            // 
            // txtDEL
            // 
            this.txtDEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDEL.Location = new System.Drawing.Point(445, 269);
            this.txtDEL.Name = "txtDEL";
            this.txtDEL.Size = new System.Drawing.Size(201, 30);
            this.txtDEL.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(246, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Prem Room Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(246, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 26);
            this.label6.TabIndex = 25;
            this.label6.Text = "Delux Room Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(246, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Std Room Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(246, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Room Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(246, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hotel ID :";
            // 
            // cbHotelID
            // 
            this.cbHotelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHotelID.FormattingEnabled = true;
            this.cbHotelID.Location = new System.Drawing.Point(445, 65);
            this.cbHotelID.Name = "cbHotelID";
            this.cbHotelID.Size = new System.Drawing.Size(201, 33);
            this.cbHotelID.TabIndex = 43;
            // 
            // txtSTD
            // 
            this.txtSTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTD.Location = new System.Drawing.Point(445, 197);
            this.txtSTD.Name = "txtSTD";
            this.txtSTD.Size = new System.Drawing.Size(201, 30);
            this.txtSTD.TabIndex = 44;
            // 
            // cbRType
            // 
            this.cbRType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRType.FormattingEnabled = true;
            this.cbRType.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Premium"});
            this.cbRType.Location = new System.Drawing.Point(445, 131);
            this.cbRType.Name = "cbRType";
            this.cbRType.Size = new System.Drawing.Size(201, 33);
            this.cbRType.TabIndex = 45;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OwnerRoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.cbRType);
            this.Controls.Add(this.txtSTD);
            this.Controls.Add(this.cbHotelID);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.txtPRE);
            this.Controls.Add(this.txtDEL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OwnerRoomControl";
            this.Size = new System.Drawing.Size(881, 523);
            this.Load += new System.EventHandler(this.OwnerRoomControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox txtPRE;
        private System.Windows.Forms.TextBox txtDEL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHotelID;
        private System.Windows.Forms.TextBox txtSTD;
        private System.Windows.Forms.ComboBox cbRType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
