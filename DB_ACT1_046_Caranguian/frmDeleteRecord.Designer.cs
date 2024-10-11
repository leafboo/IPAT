
namespace DB_ACT1_046_Caranguian
{
    partial class frmDeleteRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(44, 88);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 2;
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
            this.cboBrand.Location = new System.Drawing.Point(202, 88);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(121, 21);
            this.cboBrand.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(141, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 220);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDeleteRecord";
            this.Text = "frmDeleteRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Button btnDelete;
    }
}