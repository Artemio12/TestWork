using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ArtLibrary.Sql;
using TestWork.Properties;

namespace TestWork
{
    public enum EnumTables
    {
        Employee,
        PromotedEmployee
    }
   
    public partial class EmployeeCard : Form
    {
        private ViewerInDataGrid viewerInDataGrid;
        private MainForm mainForm;
     
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
        public Button PromoteButton => promoteButton;
        public DateTimePicker DismissTimePick => dismissalDatePicker;

        private string educationCmd = "SELECT Education FROM [Education]";
        private string departmentCmd = "SELECT Department FROM [Departments]";

        public EmployeeCard()
        {
            InitializeComponent();
        }

        private void EmployeeCard_Load(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            GetItems(educationComboBox, educationCmd);
            GetItems(departmentComboBox, departmentCmd);
        }

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            insertButton.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (tableComboBox.SelectedIndex != -1)
                viewerInDataGrid.DeleteSelectedRows(mainForm.MainDataGrid, Settings.Default.ConnectionStr, tableComboBox.Text);
            else MessageBox.Show("Выберите таблицу для удаления данных");
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            var departmentCode = departmentComboBox.SelectedIndex + 1;
            var educationCode = educationComboBox.SelectedIndex + 1;
            
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
                cmd.Parameters.AddWithValue("DepartmentCode", departmentCode);
                cmd.Parameters.AddWithValue("EducationCode", educationCode);
                cmd.Parameters.AddWithValue("HireDate", hireDatePicker.Value);
                if (dismissalDatePicker.Checked) cmd.Parameters.AddWithValue("DismissalDate", dismissalDatePicker.Value);
                else cmd.Parameters.AddWithValue("DismissalDate", DBNull.Value);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (tableComboBox.SelectedIndex != -1)
                UpdateSwitch(tableComboBox.Text);
            else MessageBox.Show("Выберите таблицу для обновления данных");
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
            if (promotionTextBlock.Text != string.Empty || nameTextBox.Text != string.Empty || surnameTextBox.Text != string.Empty || patronymicTextBox.Text !=string.Empty)
                AddPromotedEmployees();
            else MessageBox.Show("Не хватает данных.Укажите фамилию (Surname), имя (Name), отчество (Patronymic) и  процент повышения (PercentPromotion(%))");
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

        private void UpdateEmployeeDates()
        {
            var departmentCode = departmentComboBox.SelectedIndex + 1;
            var educationCode = departmentComboBox.SelectedIndex + 1;
            using (var connection = new SqlConnection(Settings.Default.ConnectionStr))
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "UPDATE [Employees] SET EmployeeNumber = @empNumber, Surname = @surname, Name = @name, Patronymic = @patronymic, Sex = @sex, BirthdayDate = @birthdayDate, DepartmentCode = @departmentCode, EducationCode = @educationCode, HireDate = @hire, DismissalDate = @dismissal WHERE Id = @id";
                
                cmd.Parameters.AddWithValue("@id", idTextBox.Text);
                cmd.Parameters.AddWithValue("@empNumber", employeeNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@surname", surnameTextBox.Text);
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@patronymic", patronymicTextBox.Text);
                cmd.Parameters.AddWithValue("@sex", sexComboBox.Text);
                cmd.Parameters.AddWithValue("@birthdayDate", birthdayDatePicker.Value);
                cmd.Parameters.AddWithValue("@departmentCode", departmentCode);
                cmd.Parameters.AddWithValue("@educationCode", educationCode);
                cmd.Parameters.AddWithValue("@hire", hireDatePicker.Value);
                cmd.Parameters.AddWithValue("@dismissal", dismissalDatePicker.Value);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void UpdatePromotedEmployee()
        {
            using (var connection = new SqlConnection(Settings.Default.ConnectionStr))
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = $"UPDATE [PromotedEmployees] SET PerсentPromotion = @percent WHERE Surname = @surname AND Name = @name AND Patronymic = @patronymic";
                cmd.Parameters.AddWithValue("@surname", surnameTextBox.Text);
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@patronymic", patronymicTextBox.Text);
                cmd.Parameters.AddWithValue("@percent", promotionTextBlock.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateSwitch(string tableName)
        {
            switch (tableName)
            {
                case nameof(EnumTables.Employee):
                    UpdateEmployeeDates();
                    break;
                case nameof(EnumTables.PromotedEmployee):
                    UpdatePromotedEmployee();
                    break;
            }
        }
    }
}
