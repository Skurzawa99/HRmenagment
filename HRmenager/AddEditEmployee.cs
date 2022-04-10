using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRmenager
{
    public partial class AddEditEmployee : Form
    {
        private int _employeeId;
        private Employee _employee;
        
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);

        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();
            _employeeId = id;

            GetEmployeeData();
        }

        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                Text = "Edytowanie danych pracownika";

                var employees = _fileHelper.DeserializeFromFile();
                _employee = employees.FirstOrDefault(x => x.EmployeeId == _employeeId);
                
                if (_employee == null)
                {
                    MessageBox.Show("Brak pracownika o podanym id");
                }

                FillTextBoxes();
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            if (_employeeId != 0 )
            {
                employees.RemoveAll(x => x.EmployeeId == _employeeId);
            }
            else
            {
                var highestId = employees.OrderByDescending(x => x.EmployeeId).FirstOrDefault();

                _employeeId = highestId == null ? 1 : highestId.EmployeeId + 1; 
            }

            var employee = new Employee
            {
                EmployeeId = _employeeId,
                Name = tbName.Text,
                LastName = tbLastName.Text,
                DateToEmployee = dtpToEmployee.Text,
                Money = GetMoney(),
                Comments = tbComments.Text,
                GroupId = 1,
            };
            employees.Add(employee);

            _fileHelper.SerializeToFile(employees);
            Close();
        }

        private void FillTextBoxes()
        {
            tbName.Text = _employee.Name;
            tbLastName.Text = _employee.LastName;
            dtpToEmployee.Text = _employee.DateToEmployee;
            tbMoney.Text = _employee.Money.ToString();
            tbComments.Text = _employee.Comments;
        }

        private int GetMoney()
        {
            if (!int.TryParse(tbMoney.Text, out int Money))
            {
                return 0;
            }
            return Money;
        }
    }
}
