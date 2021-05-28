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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zachet4.Properties;
using Zachet4.BD;

namespace Zachet4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClassBD.bazaDannih = new BD.BDzachetEntities();
        }

        private void AddStudent(object sender, RoutedEventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
            Hide();
        }

        private void AddMark(object sender, RoutedEventArgs e)
        {
            AddMark addMark = new AddMark();
            addMark.Show();
            Hide();
        }

        private void InspectSpisok(object sender, RoutedEventArgs e)
        {
            InspectSpiski inspectSpiski = new InspectSpiski();
            inspectSpiski.Show();
            Hide();
        }
        
    }
}
