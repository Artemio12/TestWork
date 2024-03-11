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
using ArtLibrary.Sql;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestWork
{
    public enum EnumEmpoyeesColumnNames
    {
        Surname,
        Name,
        Patronymic,
        PerсentPromotion
    }

    public partial class PromotedEmployees : Form
    {
        public MainForm mainForm;
        public ViewerInDataGrid viewerInDataGrid;
        private Excel.Application ExcelApp;

        private string startCmd = "SELECT * FROM [PromotedEmployees]";
        public PromotedEmployees()
        {
            InitializeComponent();
        }

        private void PromotedEmployees_Load(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            ExcelApp = new Excel.Application();
            viewerInDataGrid = new ViewerInDataGrid();
            GetEmployees(startCmd);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            viewerInDataGrid.ClearTable(promotedDataGrid, Settings.Default.ConnectionStr, "PromotedEmployees");
        }

        private void ExcelOutputButton_Click(object sender, EventArgs e)
        {
            if (promotedDataGrid.Rows.Count != 0)
            {
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 15;

                ExcelApp.Cells[1, 1] = "№п/п";
                ExcelApp.Cells[1, 2] = nameof(EnumEmpoyeesColumnNames.Surname);
                ExcelApp.Cells[1, 3] = nameof(EnumEmpoyeesColumnNames.Name);
                ExcelApp.Cells[1, 4] = nameof(EnumEmpoyeesColumnNames.Patronymic);
                ExcelApp.Cells[1, 5] = nameof(EnumEmpoyeesColumnNames.PerсentPromotion);

                for (int i = 0; i < promotedDataGrid.ColumnCount; i++)
                {
                    for (int j = 0; j < promotedDataGrid.RowCount; j++)
                    {
                        ExcelApp.Cells[j + 2, i + 1] = promotedDataGrid[i, j].Value.ToString();
                    }
                }
                ExcelApp.Visible = true;

            }
            else MessageBox.Show("promotedDataGrid пуст, заполните его данными");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            viewerInDataGrid.DeleteSelectedRows(promotedDataGrid, Settings.Default.ConnectionStr, "PromotedEmployees");
        }

        private void GetEmployees(string cmd)
        {
            viewerInDataGrid.ViewRequest(promotedDataGrid, Settings.Default.ConnectionStr, cmd);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            GetEmployees(startCmd);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            GetEmployees(requestTextBox.Text);
        }
    }
}
