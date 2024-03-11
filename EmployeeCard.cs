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
using ArtLibrary.ControlLogic;
using TestWork.Properties;
using Columns = TestWork.EnumEmpoyeesColumnNames;

namespace TestWork
{
    public enum EnumTags
    {
        EmployeeDataControls

    }
    public partial class EmployeeCard : Form
    {
        private List<Control> controls;
        private VisibilityInverter<Control> inverter;

        public string Id { get => idTextBox.Text; set => idTextBox.Text = value; }
        public string EmployeeNumber { get => employeeNumberTextBox.Text; set => employeeNumberTextBox.Text = value; }
        public string Surname { get => surnameTextBox.Text; set => surnameTextBox.Text = value; }
        public string EmployeeName { get => nameTextBox.Text; set => nameTextBox.Text = value; }
        public string Patronymic { get => patronymicTextBox.Text; set => patronymicTextBox.Text = value; }
        public string Sex { get => sexComboBox.Text; set => sexComboBox.Text = value; }
        public DateTime BirthdayDate { get => birthdayDatePicker.Value; set => birthdayDatePicker.Value = value; }
        public string Department { get => departmentComboBox.Text; set => departmentComboBox.Text = value; }
        public string Education { get => educationComboBox.Text; set => educationComboBox.Text = value; }
        public DateTime HireDate { get => hireDatePicker.Value; set => hireDatePicker.Value = value; }
        public DateTime DismissalDate { get => dismissalDatePicker.Value; set => dismissalDatePicker.Value = value; }
        public string PromotionTextBox { get => promotionTextBlock.Text; set => promotionTextBlock.Text = value; }

        public Button InsertButton => insertButton;
        public Button UpdateButton => updateButton;
        public Button NewEmployeeButton => newEmployeeButton;
        public Button DeleteButton => deleteButton;

        public EmployeeCard()
        {
            InitializeComponent();
        }

        private void EmployeeCard_Load(object sender, EventArgs e)
        {
            var educationCmd = "SELECT Education FROM [Education]";
            var departmentCmd = "SELECT Department FROM [Departments]";
            GetItems(educationComboBox, educationCmd);
            GetItems(departmentComboBox, departmentCmd);

            controls = new List<Control>();
            inverter = new VisibilityInverter<Control>();
           
            
            controls = (from Control v in cardGroupBox.Controls
                       where v.Tag?.ToString() == nameof(EnumTags.EmployeeDataControls)
                       select v).ToList();
        }

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            foreach (var element in controls)
            {
                element.Text = string.Empty;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using(var connection = new SqlConnection(Settings.Default.ConnectionStr))
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = $"DELETE [Employees] WHERE Id = {idTextBox.Text}";
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection (Settings.Default.ConnectionStr))
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO [Employees] (EmployeeNumber, Surname, Name, Patronymic, Sex, BirthdayDate, DepartmentCode, EducationCode, HireDate, DismissalDate)  VALUES (@EmployeeNumber,@Surname, @Name, @Patronymic, @Sex, @BirthdayDate, @DepartmentCode, @EducationCode, @HireDate, @DismissalDate)";
                cmd.Parameters.AddWithValue("EmployeeNumber", employeeNumberTextBox.Text);
                cmd.Parameters.AddWithValue("Surname", surnameTextBox.Text);
                cmd.Parameters.AddWithValue("Name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("Patronymic", patronymicTextBox.Text);
                cmd.Parameters.AddWithValue("Sex", sexComboBox.Text);
                cmd.Parameters.AddWithValue("BirthdayDate", birthdayDatePicker.Value);
                cmd.Parameters.AddWithValue("DepartmentCode", departmentComboBox.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("EducationCode", educationComboBox.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("HireDate", hireDatePicker.Value);
                cmd.Parameters.AddWithValue("DismissalDate", dismissalDatePicker.Value);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateDates();
            

        }

        private void AddPromotedEmployees()
        {
            using (var connection = new SqlConnection(Settings.Default.ConnectionStr))
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO [PromotedEmployees] VALUES (@Surname, @Name, @Patronymic, @PerсentPromotion)";
                cmd.Parameters.AddWithValue("Surname", surnameTextBox.Text);
                cmd.Parameters.AddWithValue("Name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("Patronymic", patronymicTextBox.Text);
                cmd.Parameters.AddWithValue("PerсentPromotion", promotionTextBlock.Text);
               
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void EmployeeNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Допустимы только числа от 00000 до 99999");
            }
        }

        private void PromotionTextBlock_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
                MessageBox.Show("Допустимы только числа и символ (,)");
            }
        }

        private void PromoteButton_Click(object sender, EventArgs e)
        {
            if (promotionTextBlock.Text != string.Empty)
                AddPromotedEmployees();
            else MessageBox.Show("Укажите процент повышения");
        }

        private void GetItems(ComboBox comboBox, string command)
        {
            using(var connection = new SqlConnection(Settings.Default.ConnectionStr))
            using(var cmd = connection.CreateCommand())
            {
                cmd.CommandText = command; 
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var item = reader.GetString(0);
                    comboBox.Items.Add(item);
                }
            }
        }

        private void UpdateDates()
        {
            using (var connection = new SqlConnection(Settings.Default.ConnectionStr))
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "UPDATE [Employees] SET ";

            }

        }
    }
}
