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
    public partial class DismissEmployee : Form
    {
        private int _dismissEmployeeId;
        private Employee _dismissEmployee;

        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);

        public DismissEmployee(int dismissId)
        {
            InitializeComponent();

            _dismissEmployeeId = dismissId;

            GetEmployeeDismissId();
        }

        private void GetEmployeeDismissId()
        {
            var employees = _fileHelper.DeserializeFromFile();
            _dismissEmployee = employees.FirstOrDefault(x => x.EmployeeId == _dismissEmployeeId);
            
            FillDismissTextBoxes();
        }

        private void FillDismissTextBoxes()
        {
            tbIdEmployeeDismiss.Text = _dismissEmployeeId.ToString();
            tbNameDismiss.Text = _dismissEmployee.Name;
            tbLastNameDismiss.Text = _dismissEmployee.LastName;
        }

        private void btConfirmDismiss_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            foreach(var employee in employees)
            {
                if(employee.EmployeeId == _dismissEmployeeId)
                {
                    employee.DateDismiss = dtpDateDimsiss.Text;
                    employee.GroupId = 2; 
                }
            }

            _fileHelper.SerializeToFile(employees);
            Close();
        }   
    }
}

