namespace ISDProject
{
    partial class OwnerSearchControl
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
            this.btnClientSearch = new System.Windows.Forms.Button();
            this.dgClient = new System.Windows.Forms.DataGridView();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpSearch = new System.Windows.Forms.Button();
            this.dgEmp = new System.Windows.Forms.DataGridView();
            this.txtEmpSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientSearch
            // 
            this.btnClientSearch.BackColor = System.Drawing.Color.Crimson;
            this.btnClientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientSearch.Location = new System.Drawing.Point(716, 15);
            this.btnClientSearch.Name = "btnClientSearch";
            this.btnClientSearch.Size = new System.Drawing.Size(102, 41);
            this.btnClientSearch.TabIndex = 7;
            this.btnClientSearch.Text = "Search";
            this.btnClientSearch.UseVisualStyleBackColor = false;
            this.btnClientSearch.Click += new System.EventHandler(this.btnClientSearch_Click);
            // 
            // dgClient
            // 
            this.dgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClient.Location = new System.Drawing.Point(1, 65);
            this.dgClient.Name = "dgClient";
            this.dgClient.Size = new System.Drawing.Size(881, 194);
            this.dgClient.TabIndex = 6;
            this.dgClient.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClient_CellEndEdit);
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientSearch.Location = new System.Drawing.Point(260, 19);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.Size = new System.Drawing.Size(433, 33);
            this.txtClientSearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(85, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Client: ";
            // 
            // btnEmpSearch
            // 
            this.btnEmpSearch.BackColor = System.Drawing.Color.Crimson;
            this.btnEmpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmpSearch.Location = new System.Drawing.Point(719, 277);
            this.btnEmpSearch.Name = "btnEmpSearch";
            this.btnEmpSearch.Size = new System.Drawing.Size(102, 41);
            this.btnEmpSearch.TabIndex = 11;
            this.btnEmpSearch.Text = "Search";
            this.btnEmpSearch.UseVisualStyleBackColor = false;
            this.btnEmpSearch.Click += new System.EventHandler(this.btnEmpSearch_Click);
            // 
            // dgEmp
            // 
            this.dgEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmp.Location = new System.Drawing.Point(3, 334);
            this.dgEmp.Name = "dgEmp";
            this.dgEmp.Size = new System.Drawing.Size(881, 194);
            this.dgEmp.TabIndex = 10;
            this.dgEmp.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmp_CellEndEdit);
            // 
            // txtEmpSearch
            // 
            this.txtEmpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSearch.Location = new System.Drawing.Point(263, 281);
            this.txtEmpSearch.Name = "txtEmpSearch";
            this.txtEmpSearch.Size = new System.Drawing.Size(433, 33);
            this.txtEmpSearch.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search Employees: ";
            // 
            // OwnerSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.btnEmpSearch);
            this.Controls.Add(this.dgEmp);
            this.Controls.Add(this.txtEmpSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClientSearch);
            this.Controls.Add(this.dgClient);
            this.Controls.Add(this.txtClientSearch);
            this.Controls.Add(this.label1);
            this.Name = "OwnerSearchControl";
            this.Size = new System.Drawing.Size(881, 532);
            this.Load += new System.EventHandler(this.OwnerSearchControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientSearch;
        private System.Windows.Forms.DataGridView dgClient;
        private System.Windows.Forms.TextBox txtClientSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpSearch;
        private System.Windows.Forms.DataGridView dgEmp;
        private System.Windows.Forms.TextBox txtEmpSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}
