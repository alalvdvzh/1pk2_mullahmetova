// MainWindow.xaml.cs
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace StudentApp
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Student> students = new ObservableCollection<Student>();
        private const string FileName = "students.xml";

        public MainWindow()
        {
            InitializeComponent();
            StudentsListBox.ItemsSource = students;
            LoadStudents();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var student = new Student
            {
                LastName = LastNameTextBox.Text,
                FirstName = FirstNameTextBox.Text,
                MiddleName = MiddleNameTextBox.Text,
                Group = GroupTextBox.Text,
                Gender = (GenderComboBox.SelectedItem as ComboBoxItem)?.Content.ToString(),
                BirthDate = BirthDatePicker.SelectedDate ?? DateTime.Now
            };

            students.Add(student);
            ClearFields();
        }

        private void ClearFields()
        {
            LastNameTextBox.Clear();
            FirstNameTextBox.Clear();
            MiddleNameTextBox.Clear();
            GroupTextBox.Clear();
            GenderComboBox.SelectedIndex = 0;
            BirthDatePicker.SelectedDate = DateTime.Now;
        }

        private void LoadStudents()
        {
            if (File.Exists(FileName))
            {
                try
                {
                    var serializer = new XmlSerializer(typeof(ObservableCollection<Student>));
                    using (var reader = new StreamReader(FileName))
                    {
                        var loadedStudents = (ObservableCollection<Student>)serializer.Deserialize(reader);
                        students.Clear();
                        foreach (var student in loadedStudents)
                        {
                            students.Add(student);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                        MessageBoxButton.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(ObservableCollection<Student>));
                using (var writer = new StreamWriter(FileName))
                {
                    serializer.Serialize(writer, students);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка",
                    MessageBoxButton.OK, MessageBoxIcon.Error);
            }
        }
    }

    [Serializable]
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Group { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}, {Group}, {Gender}, {BirthDate:dd.MM.yyyy}";
        }
    }
}
