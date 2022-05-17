using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Reflection;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1;
namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            CleanAllTextBoxes();
        }
        private void CleanAllTextBoxes()
        {
            foreach (Control box in grid.Children)
            {
                if (box.GetType() == typeof(TextBox))
                {
                    ((TextBox)box).Text = String.Empty;
                }
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Student student = getExampleStudent();
            showInfo(student);

        }

        private void showInfo(Student student)
        {
            txtBoxName.Text = student.Name;
            txtBoxFName.Text = student.FatherName;
            txtBoxFamily.Text = student.Family;
            txtBoxSpec.Text = student.Specialty;
            txtBoxStatus.Text = student.Status;
            txtBoxCourse.Text = student.Year.ToString();
            txtBoxClass.Text = student.Class.ToString();
            txtBoxGroup.Text = student.Group.ToString();
        }

        private Student getExampleStudent()
        {
            StudentData studentData = new StudentData();
            return studentData.GetStudents().First();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            foreach (Control box in grid.Children)
            {
                if (box.Name.Equals(btn4.Name))
                {
                    box.IsEnabled = true;
                }
                else
                {
                    box.IsEnabled = false;
                }
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            foreach (Control box in grid.Children)
            {
                box.IsEnabled = true;
            }
        }
    }
}
