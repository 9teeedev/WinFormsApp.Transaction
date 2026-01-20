namespace WinFormsApp.Transaction
{
    partial class addUser
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
            label1 = new Label();
            txtMail = new TextBox();
            txtFname = new TextBox();
            label2 = new Label();
            txtLname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPwd = new TextBox();
            label5 = new Label();
            txtCfPwd = new TextBox();
            label6 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            lbEmailErr = new Label();
            lbPwdErr = new Label();
            lbCfPwdErr = new Label();
            lbMsg = new Label();
            cboPosition = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 90);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "อีเมล์ : ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("TH SarabunPSK", 17.9999981F, FontStyle.Bold);
            txtMail.Location = new Point(161, 87);
            txtMail.Margin = new Padding(3, 5, 3, 5);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(338, 35);
            txtMail.TabIndex = 1;
            // 
            // txtFname
            // 
            txtFname.Font = new Font("TH SarabunPSK", 17.9999981F, FontStyle.Bold);
            txtFname.Location = new Point(161, 130);
            txtFname.Margin = new Padding(3, 5, 3, 5);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(338, 35);
            txtFname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 133);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 2;
            label2.Text = "ชื่อ : ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtLname
            // 
            txtLname.Font = new Font("TH SarabunPSK", 17.9999981F, FontStyle.Bold);
            txtLname.Location = new Point(161, 173);
            txtLname.Margin = new Padding(3, 5, 3, 5);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(338, 35);
            txtLname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 176);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "นามสกุล : ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 219);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 6;
            label4.Text = "ตำแหน่ง : ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPwd
            // 
            txtPwd.Font = new Font("TH SarabunPSK", 17.9999981F, FontStyle.Bold);
            txtPwd.Location = new Point(161, 259);
            txtPwd.Margin = new Padding(3, 5, 3, 5);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(338, 35);
            txtPwd.TabIndex = 9;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 262);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 8;
            label5.Text = "รหัสผ่าน : ";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCfPwd
            // 
            txtCfPwd.Font = new Font("TH SarabunPSK", 17.9999981F, FontStyle.Bold);
            txtCfPwd.Location = new Point(161, 302);
            txtCfPwd.Margin = new Padding(3, 5, 3, 5);
            txtCfPwd.Name = "txtCfPwd";
            txtCfPwd.Size = new Size(338, 35);
            txtCfPwd.TabIndex = 11;
            txtCfPwd.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("TH Baijam", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 305);
            label6.Name = "label6";
            label6.Size = new Size(137, 25);
            label6.TabIndex = 10;
            label6.Text = "ยืนยันรหัสผ่าน : ";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Font = new Font("TH Krub", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(267, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 41);
            btnSave.TabIndex = 12;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 255, 255);
            btnClear.Font = new Font("TH Krub", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlText;
            btnClear.Location = new Point(404, 358);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 41);
            btnClear.TabIndex = 13;
            btnClear.Text = "เคลียร์";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lbEmailErr
            // 
            lbEmailErr.AutoSize = true;
            lbEmailErr.Font = new Font("TH SarabunPSK", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmailErr.ForeColor = Color.Red;
            lbEmailErr.Location = new Point(530, 90);
            lbEmailErr.Name = "lbEmailErr";
            lbEmailErr.Size = new Size(20, 27);
            lbEmailErr.TabIndex = 14;
            lbEmailErr.Text = "*";
            // 
            // lbPwdErr
            // 
            lbPwdErr.AutoSize = true;
            lbPwdErr.Font = new Font("TH SarabunPSK", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPwdErr.ForeColor = Color.Red;
            lbPwdErr.Location = new Point(530, 265);
            lbPwdErr.Name = "lbPwdErr";
            lbPwdErr.Size = new Size(20, 27);
            lbPwdErr.TabIndex = 15;
            lbPwdErr.Text = "*";
            // 
            // lbCfPwdErr
            // 
            lbCfPwdErr.AutoSize = true;
            lbCfPwdErr.Font = new Font("TH SarabunPSK", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCfPwdErr.ForeColor = Color.Red;
            lbCfPwdErr.Location = new Point(530, 308);
            lbCfPwdErr.Name = "lbCfPwdErr";
            lbCfPwdErr.Size = new Size(20, 27);
            lbCfPwdErr.TabIndex = 16;
            lbCfPwdErr.Text = "*";
            // 
            // lbMsg
            // 
            lbMsg.AutoSize = true;
            lbMsg.Font = new Font("TH SarabunPSK", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMsg.ForeColor = Color.Green;
            lbMsg.Location = new Point(161, 413);
            lbMsg.Name = "lbMsg";
            lbMsg.Size = new Size(20, 27);
            lbMsg.TabIndex = 17;
            lbMsg.Text = "*";
            // 
            // cboPosition
            // 
            cboPosition.Font = new Font("TH SarabunPSK", 17.9999981F, FontStyle.Bold);
            cboPosition.FormattingEnabled = true;
            cboPosition.Location = new Point(161, 216);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(338, 35);
            cboPosition.TabIndex = 18;
            // 
            // addUser
            // 
            AutoScaleDimensions = new SizeF(8F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 449);
            Controls.Add(cboPosition);
            Controls.Add(lbMsg);
            Controls.Add(lbCfPwdErr);
            Controls.Add(lbPwdErr);
            Controls.Add(lbEmailErr);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtCfPwd);
            Controls.Add(label6);
            Controls.Add(txtPwd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLname);
            Controls.Add(label3);
            Controls.Add(txtFname);
            Controls.Add(label2);
            Controls.Add(txtMail);
            Controls.Add(label1);
            Font = new Font("TH Mali Grade 6", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "addUser";
            Text = "addUser";
            Load += addUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMail;
        private TextBox txtFname;
        private Label label2;
        private TextBox txtLname;
        private Label label3;
        private Label label4;
        private TextBox txtPwd;
        private Label label5;
        private TextBox txtCfPwd;
        private Label label6;
        private Button btnSave;
        private Button btnClear;
        private Label lbEmailErr;
        private Label lbPwdErr;
        private Label lbCfPwdErr;
        private Label lbMsg;
        private ComboBox cboPosition;
    }
}