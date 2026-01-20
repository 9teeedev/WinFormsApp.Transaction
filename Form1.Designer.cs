namespace WinFormsApp.Transaction
{
    partial class frmDepartment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvDepartment = new DataGridView();
            label2 = new Label();
            txtID = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtDesc = new TextBox();
            txtPhone = new TextBox();
            txtMail = new TextBox();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 32);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 0;
            label1.Text = "ข้อมูลแผนก";
            // 
            // dgvDepartment
            // 
            dgvDepartment.BackgroundColor = Color.FromArgb(255, 255, 192);
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Location = new Point(46, 50);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.Size = new Size(310, 362);
            dgvDepartment.TabIndex = 1;
            dgvDepartment.CellMouseUp += dgvDepartment_CellMouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(387, 68);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 2;
            label2.Text = "รหัสแผนก";
            // 
            // txtID
            // 
            txtID.Location = new Point(459, 67);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(393, 108);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 4;
            label3.Text = "ชื่อแผนก";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(393, 145);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 5;
            label4.Text = "หมายเหตุ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(396, 277);
            label5.Name = "label5";
            label5.Size = new Size(57, 17);
            label5.TabIndex = 6;
            label5.Text = "โทรศัพท์";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(408, 309);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 7;
            label6.Text = "อีเมลล์";
            // 
            // txtName
            // 
            txtName.Location = new Point(459, 108);
            txtName.Name = "txtName";
            txtName.Size = new Size(314, 23);
            txtName.TabIndex = 8;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(459, 145);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(314, 125);
            txtDesc.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(459, 276);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(314, 23);
            txtPhone.TabIndex = 10;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(459, 309);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(314, 23);
            txtMail.TabIndex = 11;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(255, 255, 192);
            btnNew.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Lime;
            btnNew.Location = new Point(459, 349);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 63);
            btnNew.TabIndex = 12;
            btnNew.Text = "➕";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 255, 192);
            btnSave.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Cyan;
            btnSave.Location = new Point(579, 349);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 63);
            btnSave.TabIndex = 13;
            btnSave.Text = "✅";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 255, 192);
            btnDelete.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(698, 349);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 63);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "❌";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(txtMail);
            Controls.Add(txtPhone);
            Controls.Add(txtDesc);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(dgvDepartment);
            Controls.Add(label1);
            Name = "frmDepartment";
            Text = "Form1";
            Load += frmDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDepartment;
        private Label label2;
        private TextBox txtID;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtDesc;
        private TextBox txtPhone;
        private TextBox txtMail;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
    }
}
