namespace _046_Caranguian_Obordo_L3
{
    partial class Form1
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
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnSaveForm = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgMain = new System.Windows.Forms.DataGridView();
            this.openExcel = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExcelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.importTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openText = new System.Windows.Forms.OpenFileDialog();
            this.saveText = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(666, 349);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 0;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnSaveForm
            // 
            this.btnSaveForm.Location = new System.Drawing.Point(560, 349);
            this.btnSaveForm.Name = "btnSaveForm";
            this.btnSaveForm.Size = new System.Drawing.Size(75, 23);
            this.btnSaveForm.TabIndex = 1;
            this.btnSaveForm.Text = "Save Form";
            this.btnSaveForm.UseVisualStyleBackColor = true;
            this.btnSaveForm.Click += new System.EventHandler(this.btnSaveForm_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(32, 49);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(222, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(32, 102);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(222, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(32, 161);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(222, 21);
            this.cmbDepartment.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add to Form";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(127, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Department";
            // 
            // dtgMain
            // 
            this.dtgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMain.Location = new System.Drawing.Point(321, 33);
            this.dtgMain.Name = "dtgMain";
            this.dtgMain.Size = new System.Drawing.Size(420, 276);
            this.dtgMain.TabIndex = 10;
            // 
            // openExcel
            // 
            this.openExcel.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSourceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataSourceToolStripMenuItem
            // 
            this.dataSourceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importExcelFile,
            this.importTextFile});
            this.dataSourceToolStripMenuItem.Name = "dataSourceToolStripMenuItem";
            this.dataSourceToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dataSourceToolStripMenuItem.Text = "Data Source";
            // 
            // importExcelFile
            // 
            this.importExcelFile.Name = "importExcelFile";
            this.importExcelFile.Size = new System.Drawing.Size(122, 22);
            this.importExcelFile.Text = "Excel File";
            this.importExcelFile.Click += new System.EventHandler(this.importExcelFile_Click);
            // 
            // importTextFile
            // 
            this.importTextFile.Name = "importTextFile";
            this.importTextFile.Size = new System.Drawing.Size(122, 22);
            this.importTextFile.Text = "Text File";
            this.importTextFile.Click += new System.EventHandler(this.importTextFile_Click);
            // 
            // openText
            // 
            this.openText.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 415);
            this.Controls.Add(this.dtgMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnSaveForm);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnSaveForm;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgMain;
        private System.Windows.Forms.OpenFileDialog openExcel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importExcelFile;
        private System.Windows.Forms.ToolStripMenuItem importTextFile;
        private System.Windows.Forms.OpenFileDialog openText;
        private System.Windows.Forms.SaveFileDialog saveText;
    }
}

