using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class UserControlListEmployee : UserControl, IResetUserControl
    {
        public UserControlListEmployee()
        {
            InitializeComponent();
        }

        public void Reset()
        {
        }

        private void UserControlListEmployee_LoadAsync(object sender, EventArgs e)
        {
            var employees = ApiRequest.GetAll<Employee>("/users");
            dgvListEmployees.DataSource = employees;
        }

        private void dgvListEmployees_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRows = dgvListEmployees.SelectedRows;

            if (selectedRows.Count == 0)
            {
                return;
            }

            var selectedRow = selectedRows[0];

            var employee = (Employee)selectedRow.DataBoundItem;
        }
    }
}
