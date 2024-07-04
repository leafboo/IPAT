namespace _169_Caranguian_Romel_Pagunuran_Prem
{
    partial class frmViewPatients
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
            this.rdbDelete = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbCreate = new System.Windows.Forms.RadioButton();
            this.rdbSearch = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCellphoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dgPatients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbDelete
            // 
            this.rdbDelete.AutoSize = true;
            this.rdbDelete.Location = new System.Drawing.Point(456, 104);
            this.rdbDelete.Name = "rdbDelete";
            this.rdbDelete.Size = new System.Drawing.Size(56, 17);
            this.rdbDelete.TabIndex = 47;
            this.rdbDelete.TabStop = true;
            this.rdbDelete.Text = "Delete";
            this.rdbDelete.UseVisualStyleBackColor = true;
            this.rdbDelete.CheckedChanged += new System.EventHandler(this.rdbDelete_CheckedChanged);
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(456, 77);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(60, 17);
            this.rdbUpdate.TabIndex = 46;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Update";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            this.rdbUpdate.CheckedChanged += new System.EventHandler(this.rdbUpdate_CheckedChanged);
            // 
            // rdbCreate
            // 
            this.rdbCreate.AutoSize = true;
            this.rdbCreate.Location = new System.Drawing.Point(456, 54);
            this.rdbCreate.Name = "rdbCreate";
            this.rdbCreate.Size = new System.Drawing.Size(56, 17);
            this.rdbCreate.TabIndex = 45;
            this.rdbCreate.TabStop = true;
            this.rdbCreate.Text = "Create";
            this.rdbCreate.UseVisualStyleBackColor = true;
            this.rdbCreate.CheckedChanged += new System.EventHandler(this.rdbCreate_CheckedChanged);
            // 
            // rdbSearch
            // 
            this.rdbSearch.AutoSize = true;
            this.rdbSearch.Location = new System.Drawing.Point(456, 31);
            this.rdbSearch.Name = "rdbSearch";
            this.rdbSearch.Size = new System.Drawing.Size(59, 17);
            this.rdbSearch.TabIndex = 44;
            this.rdbSearch.TabStop = true;
            this.rdbSearch.Text = "Search";
            this.rdbSearch.UseVisualStyleBackColor = true;
            this.rdbSearch.CheckedChanged += new System.EventHandler(this.rdbSearch_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(422, 143);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(156, 23);
            this.btnConfirm.TabIndex = 43;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(50, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 20);
            this.txtID.TabIndex = 41;
            // 
            // txtCellphoneNumber
            // 
            this.txtCellphoneNumber.Location = new System.Drawing.Point(229, 164);
            this.txtCellphoneNumber.Name = "txtCellphoneNumber";
            this.txtCellphoneNumber.Size = new System.Drawing.Size(161, 20);
            this.txtCellphoneNumber.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Sex";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(229, 31);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(161, 20);
            this.txtSex.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Cellphone Number";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(229, 74);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(161, 20);
            this.txtAge.TabIndex = 35;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(229, 116);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(161, 20);
            this.txtAddress.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Birthday";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(49, 164);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(161, 20);
            this.txtBirthday.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(50, 115);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(161, 20);
            this.txtLastName.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(50, 74);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(161, 20);
            this.txtFirstName.TabIndex = 27;
            // 
            // dgPatients
            // 
            this.dgPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatients.Location = new System.Drawing.Point(38, 202);
            this.dgPatients.Name = "dgPatients";
            this.dgPatients.RowHeadersVisible = false;
            this.dgPatients.Size = new System.Drawing.Size(528, 165);
            this.dgPatients.TabIndex = 26;
            // 
            // frmViewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 389);
            this.Controls.Add(this.rdbDelete);
            this.Controls.Add(this.rdbUpdate);
            this.Controls.Add(this.rdbCreate);
            this.Controls.Add(this.rdbSearch);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCellphoneNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dgPatients);
            this.Name = "frmViewPatients";
            this.Text = "frmViewPatients";
            this.Load += new System.EventHandler(this.frmViewPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbDelete;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbCreate;
        private System.Windows.Forms.RadioButton rdbSearch;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCellphoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DataGridView dgPatients;
    }
}