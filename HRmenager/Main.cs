using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace HRmenager
{
    public partial class Main : Form
    {
        private List<Group> _group;
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);

        public Main()
        {
            InitializeComponent();
            _group = GroupHelper.GetGroup();
            InitGroupCombobox();

            RefreshEmployee();
            
            SetColumnsHeader();
            HideColumns();
        }

        private void HideColumns()
        {
            dgvEmployee.Columns[nameof(Employee.GroupId)].Visible = false;
        }

        private void InitGroupCombobox()
        {
            cmbGroup.DataSource = _group;
            cmbGroup.DisplayMember = "Name";
            cmbGroup.ValueMember = "Id";
        }

        private void SetColumnsHeader()
        {
            dgvEmployee.Columns[nameof(Employee.EmployeeId)].HeaderText = "Numer pracownika";
            dgvEmployee.Columns[nameof(Employee.Name)].HeaderText = "Imie";
            dgvEmployee.Columns[nameof(Employee.LastName)].HeaderText = "Nazwisko";
            dgvEmployee.Columns[nameof(Employee.DateToEmployee)].HeaderText = "Data zatrudnienia";
            dgvEmployee.Columns[nameof(Employee.DateDismiss)].HeaderText = "Data zwolnienia";
            dgvEmployee.Columns[nameof(Employee.Money)].HeaderText = "Wysokość zarobków";
            dgvEmployee.Columns[nameof(Employee.Comments)].HeaderText = "Uwagi";
        }

        private void btToEmployee_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if( dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Prosze wybrać pracownika");
                return;
            }

            var addEditEmployee = new AddEditEmployee(Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells[0].Value));
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void btDismiss_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Prosze wybrać pracownika");
                return;
            }

            var dismissEmployee = new DismissEmployee(Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells[0].Value));
            dismissEmployee.FormClosing += dismissEmployee_FormClosing;
            dismissEmployee.ShowDialog();
        }

        private void RefreshEmployee()
        {
            var employees = _fileHelper.DeserializeFromFile();

            var selectedGroup = (cmbGroup.SelectedItem as Group).Id;

            if (selectedGroup != 0)
            {
                employees = employees.Where(x => x.GroupId == selectedGroup).ToList();
            }

            dgvEmployee.DataSource = employees;
        }

        private void AddEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshEmployee();
        }

        private void dismissEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshEmployee();
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshEmployee();
        }
    }
}
