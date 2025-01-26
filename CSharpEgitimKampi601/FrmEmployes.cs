using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class FrmEmployes : Form
    {
        public FrmEmployes()
        {
            InitializeComponent();
        }

        string connectionString = "Server= localhost; port=5432; Database= CustomerDb; Trusted_Connection=True; user Id = postgres; Password=486759";
        private object cmbEmployeeDepartment;

        void EmployeeList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Departmens";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        void DepartmentList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Deparments";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            // cmbEmployeeDepartment.DisplayMember = "DepartmentName";
            // cmbEmployeeDepartment.ValueMember = "DepartmentId";
            // cmbEmployeeDepartment.DataSource = dataTable;
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void FrmEmployes_Load(object sender, EventArgs e)
        {
            EmployeeList();
        }

        private void btnEmployesList_Click(object sender, EventArgs e)
        {
            EmployeeList();
            DepartmentList();
        }

        private void btnEmployesCreate_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployesName.Text;
            string employeeSurname = txtEmployesSurname.Text;
            decimal employeeSalary = decimal.Parse(txtEmployeeSalary.Text);
            int departmentId = int.Parse(cmbEmployeeDepartment.ToString());
            
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Insert Into Employees (EmployeeName, EmployeeSurname, EmployeeSalary, DepartmentId) values (@employeeName, @employeeSurname, @employeeSalary, @departmentId)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeeName", employeeName);
            command.Parameters.AddWithValue("@employeeSurname", employeeSurname);
            command.Parameters.AddWithValue("@employeeSalary", employeeSalary);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.ExecuteNonQuery();
            MessageBox.Show("Ekleme İşlemi Başarılı");
            connection.Close();

        }

        private void btnEmployesUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
