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
    /// Логика взаимодействия для AddMark.xaml
    /// </summary>
    public partial class AddMark : Window
    {
        public AddMark()
        {
            InitializeComponent();
            CbGroup.SelectedValuePath = "id";
            CbGroup.DisplayMemberPath = "GroupName";
            CbGroup.ItemsSource = ClassBD.bazaDannih.Group.ToList();

            CbStudent.SelectedValuePath = "id";
            CbStudent.DisplayMemberPath = "StudentName";
            CbStudent.ItemsSource = ClassBD.bazaDannih.Student.ToList();

            CbDisciplina.SelectedValuePath = "id";
            CbDisciplina.DisplayMemberPath = "PredmetName";
            CbDisciplina.ItemsSource = ClassBD.bazaDannih.Predmet.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void Dobavit_Ocenky(object sender, RoutedEventArgs e)
        {
            try
            {
                 Ocenka ocenka = new Ocenka()
                {
                    IDStudent = (int)CbStudent.SelectedValue,
                    IDPredmet = (int)CbDisciplina.SelectedValue,
                    Ocenki = Convert.ToInt32(TbOcenka.Text),

                };
                ClassBD.bazaDannih.Ocenka.Add(ocenka);
                ClassBD.bazaDannih.SaveChanges();
                MessageBox.Show("Оценка студенту поставлена", "Поздравляю!", MessageBoxButton.OK);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
