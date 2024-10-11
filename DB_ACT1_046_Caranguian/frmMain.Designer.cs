
namespace DB_ACT1_046_Caranguian
{
    partial class frmMain
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
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grdResults = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addOrUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecord = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(44, 48);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(160, 20);
            this.txtKeyword.TabIndex = 0;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // cboBrand
            // 
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Items.AddRange(new object[] {
            "Acura",
            "Aston Martin",
            "Audi",
            "Bentley",
            "BMW",
            "Buick",
            "Cadillac",
            "Chevrolet",
            "Chrysler",
            "Dodge",
            "Eagle",
            "Ford",
            "Geo",
            "GMC",
            "Honda",
            "Hummer",
            "Hyundai",
            "Infiniti",
            "Isuzu",
            "Jeep",
            "Kia",
            "Land Rover",
            "Lexus",
            "Lincoln",
            "Lotus",
            "Maserati",
            "Mazda",
            "Mercedes-Benz",
            "Mercury",
            "Mitsubishi",
            "Nissan",
            "Oldsmobile",
            "Plymouth",
            "Pontiac",
            "Porsche",
            "Ram",
            "Saab",
            "Saturn",
            "Scion",
            "Shelby",
            "Spyker",
            "Subaru",
            "Suzuki",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.cboBrand.Location = new System.Drawing.Point(227, 48);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(121, 21);
            this.cboBrand.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(44, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(140, 88);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grdResults
            // 
            this.grdResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResults.Location = new System.Drawing.Point(44, 130);
            this.grdResults.MultiSelect = false;
            this.grdResults.Name = "grdResults";
            this.grdResults.ReadOnly = true;
            this.grdResults.RowHeadersVisible = false;
            this.grdResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResults.Size = new System.Drawing.Size(601, 281);
            this.grdResults.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrUpdate,
            this.deleteRecord});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addOrUpdate
            // 
            this.addOrUpdate.Name = "addOrUpdate";
            this.addOrUpdate.Size = new System.Drawing.Size(96, 20);
            this.addOrUpdate.Text = "Add or Update";
            this.addOrUpdate.Click += new System.EventHandler(this.addOrUpdate_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(92, 20);
            this.deleteRecord.Text = "Delete Record";
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.grdResults);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView grdResults;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addOrUpdate;
        private System.Windows.Forms.ToolStripMenuItem deleteRecord;
    }
}

