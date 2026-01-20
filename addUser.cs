using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp.Transaction
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void addUser_Load(object sender, EventArgs e)
        {
            setPosition();
            lbEmailErr.Visible = false;
            lbPwdErr.Visible = false;
            lbCfPwdErr.Visible = false;
            lbMsg.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkInputForm() == -1) return;
            if (addNewUser() == 0)
            {
                lbEmailErr.Text = "Email ซ้ำ!! มีผู้ใช้นี้ในระบบแล้ว";
                txtMail.Focus();
                lbMsg.Visible = false;
                txtMail.SelectAll();
            }
            else
            {
                lbMsg.Text = "เพิ่มข้อมูลสำเร็จ";
                lbMsg.Visible = true;
                clearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        private int addNewUser()
        {
            SqlConnection conn = DBConnect.Company_DB_Connect();
            SqlCommand cmd = new SqlCommand("sp_AddNewUser_Transaction", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userID", txtMail.Text);
            cmd.Parameters.AddWithValue("@firstname", txtFname.Text);
            cmd.Parameters.AddWithValue("@lastname", txtLname.Text);
            cmd.Parameters.AddWithValue("@position", cboPosition.Text);
            cmd.Parameters.AddWithValue("@password", txtPwd.Text);

            SqlParameter result = new SqlParameter("@Result", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(result);
            cmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToInt32(result.Value);

        }
        public void setPosition()
        {
            cboPosition.Items.Add("Manager");
            cboPosition.Items.Add("IT Developers");
            cboPosition.Items.Add("Project Manager");
            cboPosition.Items.Add("UX/UI Designer");
            cboPosition.Items.Add("Database Admin");
        }
        public void clearForm()
        {
            txtMail.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtPwd.Clear();
            txtCfPwd.Clear();
            cboPosition.SelectedIndex = 0;
            lbEmailErr.Visible = false;
            lbPwdErr.Visible = false;
            lbCfPwdErr.Visible = false;
        }
        public int checkInputForm()
        {
            int status = 0;
            if (txtMail.Text == "" || txtMail.Text == null)
            {
                lbEmailErr.Text = "อีเมล์ไม่ถูกต้อง";
                lbEmailErr.Visible = true;
                txtMail.Focus();
                status = -1;
                return status;
            }
            else
            {
                lbEmailErr.Text = "✅";
                lbEmailErr.Visible = true;
                status = 0;
            }

            if (txtPwd.Text == "" || txtPwd.Text == null)
            {
                lbPwdErr.Text = "รหัสผ่านขั้นต่ำ 6 ตัว";
                lbPwdErr.Visible = true;
                txtPwd.Focus();
                status = -1;
                return status;
            }
            else
            {
                lbPwdErr.Text = "✅";
                lbPwdErr.Visible = true;
                status = 0;
            }
            if (!txtCfPwd.Text.Equals(txtPwd.Text))
            {
                lbCfPwdErr.Text = "รหัสผ่านไม่ตรงกัน";
                lbCfPwdErr.Visible = true;
                txtCfPwd.Focus();
                status = -1;
                return status;
            }
            else
            {
                lbCfPwdErr.Text = "✅";
                lbCfPwdErr.Visible = true;
                status = 0;
            }
            return status;
        }

     
    }
}
