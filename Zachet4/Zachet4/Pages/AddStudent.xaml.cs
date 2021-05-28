using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Zachet4.BD;

namespace Zachet4
{
    /// <summary>
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
            CbSpec.SelectedValuePath = "id";
            CbSpec.DisplayMemberPath = "SpecName";
            CbSpec.ItemsSource = ClassBD.bazaDannih.Spec.ToList();
            CbForma.SelectedValuePath = "id";
            CbForma.DisplayMemberPath = "Forma1";
            CbForma.ItemsSource = ClassBD.bazaDannih.Forma.ToList();
            CbNameGroup.SelectedValuePath = "id";
            CbNameGroup.DisplayMemberPath = "GroupName";
            CbNameGroup.ItemsSource = ClassBD.bazaDannih.Group.ToList();
        }

        private void ClickNazad(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void DobavitStudenta(object sender, RoutedEventArgs e)
        {
            try
            {
                Student student = new Student()
                {
                    StudentName = TbFIO.Text,
                    IDGroup = (int)CbNameGroup.SelectedValue,
                    IDForma = (int)CbForma.SelectedValue,
                    Date = TbData.SelectedDate,
                    IDSpec = (int)CbSpec.SelectedValue,
                };
                ClassBD.bazaDannih.Student.Add(student);
                ClassBD.bazaDannih.SaveChanges();
                MessageBox.Show("Студент добавлен", "Поздравляю!", MessageBoxButton.OK);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
