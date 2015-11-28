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
using MahApps.Metro.Controls;

namespace Training
{
    /// <summary>
    /// Логика взаимодействия для ChooseTypeOfExcercise.xaml
    /// </summary>
    public partial class ChooseTypeOfExcercise : MetroWindow
    {
        public ChooseTypeOfExcercise()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
