using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWork.Properties;
using System.Diagnostics.CodeAnalysis;
using ArtLibrary.Sql;
using ArtLibrary.ControlLogic;

namespace TestWork
{
    public partial class MainForm : Form
    {
        private Checker checker;
        private ViewerInDataGrid viewerInDataGrid;

        private PromotedEmployees promotedEmployees;
        private EmployeeCard employeeCard;

        private List<EmployeeCard> employeeCards;

        private string startCmd = "SELECT Employees.Id, Employees.EmployeeNumber, Employees.Surname, Employees.Name, Employees.Patronymic, Employees.Sex, Employees.BirthdayDate, Departments.Department, Education.Education, Employees.HireDate,Employees.DismissalDate FROM Employees" +
            " INNER JOIN Departments ON Employees.DepartmentCode = Departments.Id INNER JOIN Education ON Employees.EducationCode = Education.Id";
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checker = new Checker();
            viewerInDataGrid = new ViewerInDataGrid();
            employeeCards = new List<EmployeeCard>();

            connectionStrTextBox.Text = Settings.Default.ConnectionStr;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            employeeCard = new EmployeeCard();
            employeeCard.UpdateButton.Enabled = false;
            employeeCard.NewEmployeeButton.Enabled = false;
            employeeCard.DeleteButton.Enabled = false;
            employeeCard.ShowDialog();
            employeeCards.Add(employeeCard);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            viewerInDataGrid.DeleteSelectedRows(mainDataGrid, Settings.Default.ConnectionStr, "Employees");
        }

        private void OpenPromotedButton_Click(object sender, EventArgs e)
        {
            promotedEmployees = new PromotedEmployees();
            promotedEmployees.ShowDialog();
        }

        private void CheckLoadButton_Click(object sender, EventArgs e)
        {
            checker.CheckConnection(connectionStrTextBox.Text);
            if (checker.ConnectionString != null)
            {
                viewerInDataGrid.ViewRequest(mainDataGrid, checker.ConnectionString,startCmd);

                checkLoadButton.Enabled = false;
                connectionStrTextBox.Enabled = false;
                reloadButton.Enabled = true;

                actionPanel.Enabled = true;
                requestPanel.Enabled = true;
                deletePanel.Enabled = true;
                refreshPanel.Enabled = true;
            }
        }

        private void MainDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeCard = new EmployeeCard
            {
                Id = mainDataGrid.CurrentRow.Cells["Id"].Value.ToString(),
                EmployeeNumber = mainDataGrid.CurrentRow.Cells["EmployeeNumber"].Value.ToString(),
                Surname = mainDataGrid.CurrentRow.Cells["Surname"].Value.ToString(),
                EmployeeName = mainDataGrid.CurrentRow.Cells["Name"].Value.ToString(),
                Patronymic = mainDataGrid.CurrentRow.Cells["Patronymic"].Value.ToString(),
                Sex = mainDataGrid.CurrentRow.Cells["Sex"].Value.ToString(),
                BirthdayDate = (DateTime)mainDataGrid.CurrentRow.Cells["BirthdayDate"].Value,
                Department = mainDataGrid.CurrentRow.Cells["Department"].Value.ToString(),
                Education = mainDataGrid.CurrentRow.Cells["Education"].Value.ToString(),
                HireDate = (DateTime)mainDataGrid.CurrentRow.Cells["HireDate"].Value,
                DismissalDate = (DateTime)mainDataGrid.CurrentRow.Cells["DismissalDate"].Value
            };

            employeeCard.InsertButton.Enabled = false;
            employeeCard.ShowDialog();

            if (!employeeCards.Contains(employeeCard)) employeeCards.Add(employeeCard);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.ConnectionStr = connectionStrTextBox.Text;
            Settings.Default.Save();
        }
      
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            viewerInDataGrid.ViewRequest(mainDataGrid, Settings.Default.ConnectionStr, startCmd);
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            DialogResult result =
              MessageBox.Show("Ввести другую строку подключения?", "Переподключиться?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    reloadButton.Enabled = false;
                    refreshButton.Enabled = false;
                    checkLoadButton.Enabled = true;
                    connectionStrTextBox.Enabled = true;
                    break;
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (requestTextBox.Text.Contains("INSERT") || requestTextBox.Text.Contains("Insert") || requestTextBox.Text.Contains("insert") || requestTextBox.Text.Contains("UPDATE") || requestTextBox.Text.Contains("Update") || requestTextBox.Text.Contains("update"))
            {
                MessageBox.Show("Запрос не введен или введён недопустимый запрос. Недопустимы INSERT и UPDATE запросы");       
            }
            else viewerInDataGrid.ViewRequest(mainDataGrid, Settings.Default.ConnectionStr, requestTextBox.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            viewerInDataGrid.ClearTable(mainDataGrid, Settings.Default.ConnectionStr, "Employees");
        }
    }
}
    
