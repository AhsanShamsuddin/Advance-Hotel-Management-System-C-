namespace ISDProject
{
    partial class OwnerRoomReportControl
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
            this.btnRRSearch = new System.Windows.Forms.Button();
            this.dgRoomReport = new System.Windows.Forms.DataGridView();
            this.txtRRSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRRSearch
            // 
            this.btnRRSearch.BackColor = System.Drawing.Color.Crimson;
            this.btnRRSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRRSearch.Location = new System.Drawing.Point(393, 97);
            this.btnRRSearch.Name = "btnRRSearch";
            this.btnRRSearch.Size = new System.Drawing.Size(147, 45);
            this.btnRRSearch.TabIndex = 7;
            this.btnRRSearch.Text = "Search";
            this.btnRRSearch.UseVisualStyleBackColor = false;
            this.btnRRSearch.Click += new System.EventHandler(this.btnRRSearch_Click);
            // 
            // dgRoomReport
            // 
            this.dgRoomReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoomReport.Location = new System.Drawing.Point(3, 164);
            this.dgRoomReport.Name = "dgRoomReport";
            this.dgRoomReport.Size = new System.Drawing.Size(874, 334);
            this.dgRoomReport.TabIndex = 6;
            // 
            // txtRRSearch
            // 
            this.txtRRSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRRSearch.Location = new System.Drawing.Point(260, 39);
            this.txtRRSearch.Name = "txtRRSearch";
            this.txtRRSearch.Size = new System.Drawing.Size(433, 41);
            this.txtRRSearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(132, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search : ";
            // 
            // OwnerRoomReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.btnRRSearch);
            this.Controls.Add(this.dgRoomReport);
            this.Controls.Add(this.txtRRSearch);
            this.Controls.Add(this.label1);
            this.Name = "OwnerRoomReportControl";
            this.Size = new System.Drawing.Size(881, 537);
            this.Load += new System.EventHandler(this.OwnerRoomReportControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRRSearch;
        private System.Windows.Forms.DataGridView dgRoomReport;
        private System.Windows.Forms.TextBox txtRRSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
