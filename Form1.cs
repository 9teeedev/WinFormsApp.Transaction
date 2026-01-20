using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp.Transaction
{
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }
        string dept_id = "";
        string action = "";

        private void ShowAllDepartment()
        {
            SqlConnection conn = DBConnect.Company_DB_Connect();

            string sql = "SELECT * FROM Department Order By dept_id";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDepartment.DataSource = dt;
            conn.Close();

            dgvDepartment.Columns[0].Visible = true;
            dgvDepartment.Columns[1].Visible = true;
            dgvDepartment.Columns[2].Visible = false;
            dgvDepartment.Columns[3].Visible = false;
            dgvDepartment.Columns[4].Visible = false;

            dgvDepartment.Columns[0].HeaderText = "รหัสแผนก";
            dgvDepartment.Columns[1].HeaderText = "ชื่อแผนก";

            dgvDepartment.Columns[0].Width = 100;
            dgvDepartment.Columns[1].Width = 220;

            dgvDepartment.RowsDefaultCellStyle.BackColor = Color.Beige;
            dgvDepartment.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvDepartment.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            dgvDepartment.DefaultCellStyle.Font = new Font("Tahoma", 11);
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            ShowAllDepartment();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dept_id = "";
            action = "insert";

            txtID.Clear();
            txtName.Clear();
            txtDesc.Clear();
            txtPhone.Clear();
            txtMail.Clear();
            txtID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (action!="" && txtID.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกรหัสแผนก");
                txtID.Focus();
                return;
            }
            if (action == "insert")
            {
                InsertRecord();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dept_id == "")
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบข้อมูล");
                return;
            }
            if(MessageBox.Show("คุณต้องการลบแผนก รหัส : "+dept_id+" ใช่หรือไม่", "ยืนยันการทำงาน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteRecord();
            }
        }

        private void dgvDepartment_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            dept_id = dgvDepartment.Rows[row].Cells[0].Value.ToString();
            action = "update";
            txtID.Text = dgvDepartment.Rows[row].Cells[1].Value.ToString();
            txtName.Text = dgvDepartment.Rows[row].Cells[2].Value.ToString();
            txtPhone.Text = dgvDepartment.Rows[row].Cells[3].Value.ToString();
            txtMail.Text = dgvDepartment.Rows[row].Cells[4].Value.ToString();
        }

        private void DeleteRecord()
        {
            SqlConnection tr;
            SqlConnection conn = DBConnect.Company_DB_Connect();
            tr = conn.BeginTransaction();
            try
            {
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.Transaction = tr;
                com.CommandText = "Delete from Department Where dept_id = @id";
                com.Parameters.AddWithValue("@id", dept_id);
                com.ExecuteNonQuery();

                tr.Commit();
                ShowAllDepartment();

                dept_id = "";
                txtID.Clear();
                txtName.Clear();
                txtDesc.Clear();
                txtPhone.Clear();
                txtMail.Clear();
                txtID.Focus();
            }
            catch
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการลบข้อมูล", "แจ้งข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tr.RollBack();
            }
            conn.Close();
        }
        private void InsertRecord()
        {
            SqlConnection conn = DBConnect.Company_DB_Connect();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "Insert_Department";
        }
    }
}
