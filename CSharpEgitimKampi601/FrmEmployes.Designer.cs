namespace CSharpEgitimKampi601
{
    partial class FrmEmployes
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEmployesGetByID = new System.Windows.Forms.Button();
            this.btnEmployesUpdate = new System.Windows.Forms.Button();
            this.btnEmployesDelete = new System.Windows.Forms.Button();
            this.btnEmployesCreate = new System.Windows.Forms.Button();
            this.btnEmployesList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.txtEmployesSurname = new System.Windows.Forms.TextBox();
            this.txtEmployesName = new System.Windows.Forms.TextBox();
            this.txtEmployesId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpoleeDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(49, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "Personel Maaşı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(40, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "Personel  Soyadı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(66, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "Personel Adı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(70, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Personel  ID:";
            // 
            // btnEmployesGetByID
            // 
            this.btnEmployesGetByID.BackColor = System.Drawing.Color.Lime;
            this.btnEmployesGetByID.Location = new System.Drawing.Point(159, 386);
            this.btnEmployesGetByID.Name = "btnEmployesGetByID";
            this.btnEmployesGetByID.Size = new System.Drawing.Size(177, 38);
            this.btnEmployesGetByID.TabIndex = 49;
            this.btnEmployesGetByID.Text = "ID\'ye Göre Getir";
            this.btnEmployesGetByID.UseVisualStyleBackColor = false;
            // 
            // btnEmployesUpdate
            // 
            this.btnEmployesUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnEmployesUpdate.Location = new System.Drawing.Point(159, 343);
            this.btnEmployesUpdate.Name = "btnEmployesUpdate";
            this.btnEmployesUpdate.Size = new System.Drawing.Size(177, 38);
            this.btnEmployesUpdate.TabIndex = 48;
            this.btnEmployesUpdate.Text = "Güncelle";
            this.btnEmployesUpdate.UseVisualStyleBackColor = false;
            this.btnEmployesUpdate.Click += new System.EventHandler(this.btnEmployesUpdate_Click);
            // 
            // btnEmployesDelete
            // 
            this.btnEmployesDelete.BackColor = System.Drawing.Color.Lime;
            this.btnEmployesDelete.Location = new System.Drawing.Point(159, 300);
            this.btnEmployesDelete.Name = "btnEmployesDelete";
            this.btnEmployesDelete.Size = new System.Drawing.Size(177, 38);
            this.btnEmployesDelete.TabIndex = 47;
            this.btnEmployesDelete.Text = "Sil";
            this.btnEmployesDelete.UseVisualStyleBackColor = false;
            // 
            // btnEmployesCreate
            // 
            this.btnEmployesCreate.BackColor = System.Drawing.Color.Lime;
            this.btnEmployesCreate.Location = new System.Drawing.Point(159, 257);
            this.btnEmployesCreate.Name = "btnEmployesCreate";
            this.btnEmployesCreate.Size = new System.Drawing.Size(177, 38);
            this.btnEmployesCreate.TabIndex = 46;
            this.btnEmployesCreate.Text = "Ekle";
            this.btnEmployesCreate.UseVisualStyleBackColor = false;
            this.btnEmployesCreate.Click += new System.EventHandler(this.btnEmployesCreate_Click);
            // 
            // btnEmployesList
            // 
            this.btnEmployesList.BackColor = System.Drawing.Color.Lime;
            this.btnEmployesList.Location = new System.Drawing.Point(159, 214);
            this.btnEmployesList.Name = "btnEmployesList";
            this.btnEmployesList.Size = new System.Drawing.Size(177, 38);
            this.btnEmployesList.TabIndex = 45;
            this.btnEmployesList.Text = "Listele";
            this.btnEmployesList.UseVisualStyleBackColor = false;
            this.btnEmployesList.Click += new System.EventHandler(this.btnEmployesList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 401);
            this.dataGridView1.TabIndex = 44;
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.Location = new System.Drawing.Point(159, 142);
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.Size = new System.Drawing.Size(177, 20);
            this.txtEmployeeSalary.TabIndex = 43;
            // 
            // txtEmployesSurname
            // 
            this.txtEmployesSurname.Location = new System.Drawing.Point(159, 103);
            this.txtEmployesSurname.Name = "txtEmployesSurname";
            this.txtEmployesSurname.Size = new System.Drawing.Size(177, 20);
            this.txtEmployesSurname.TabIndex = 42;
            // 
            // txtEmployesName
            // 
            this.txtEmployesName.Location = new System.Drawing.Point(159, 65);
            this.txtEmployesName.Name = "txtEmployesName";
            this.txtEmployesName.Size = new System.Drawing.Size(177, 20);
            this.txtEmployesName.TabIndex = 41;
            // 
            // txtEmployesId
            // 
            this.txtEmployesId.Location = new System.Drawing.Point(159, 30);
            this.txtEmployesId.Name = "txtEmployesId";
            this.txtEmployesId.Size = new System.Drawing.Size(177, 20);
            this.txtEmployesId.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Personel Departmanı:";
            // 
            // cmbEmpoleeDepartment
            // 
            this.cmbEmpoleeDepartment.FormattingEnabled = true;
            this.cmbEmpoleeDepartment.Location = new System.Drawing.Point(159, 174);
            this.cmbEmpoleeDepartment.Name = "cmbEmpoleeDepartment";
            this.cmbEmpoleeDepartment.Size = new System.Drawing.Size(177, 21);
            this.cmbEmpoleeDepartment.TabIndex = 56;
            // 
            // FrmEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 562);
            this.Controls.Add(this.cmbEmpoleeDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnEmployesGetByID);
            this.Controls.Add(this.btnEmployesUpdate);
            this.Controls.Add(this.btnEmployesDelete);
            this.Controls.Add(this.btnEmployesCreate);
            this.Controls.Add(this.btnEmployesList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEmployeeSalary);
            this.Controls.Add(this.txtEmployesSurname);
            this.Controls.Add(this.txtEmployesName);
            this.Controls.Add(this.txtEmployesId);
            this.Name = "FrmEmployes";
            this.Text = "FrmEmployes";
            this.Load += new System.EventHandler(this.FrmEmployes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEmployesGetByID;
        private System.Windows.Forms.Button btnEmployesUpdate;
        private System.Windows.Forms.Button btnEmployesDelete;
        private System.Windows.Forms.Button btnEmployesCreate;
        private System.Windows.Forms.Button btnEmployesList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmployeeSalary;
        private System.Windows.Forms.TextBox txtEmployesSurname;
        private System.Windows.Forms.TextBox txtEmployesName;
        private System.Windows.Forms.TextBox txtEmployesId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmpoleeDepartment;
    }
}