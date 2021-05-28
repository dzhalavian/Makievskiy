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
    /// Логика взаимодействия для InspectSpiski.xaml
    /// </summary>
    public partial class InspectSpiski : Window
    {
        public InspectSpiski()
        {
            InitializeComponent();
            OcenkaDataGrid.ItemsSource = ClassBD.bazaDannih.Ocenka.ToList();
        }
    }
}
