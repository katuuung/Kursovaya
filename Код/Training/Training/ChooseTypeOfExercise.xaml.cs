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
    public partial class ChooseTypeOfExercise : MetroWindow
    {
        public ChooseTypeOfExercise()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WeightExercises we = new WeightExercises();
            we.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FreeExercises fe = new FreeExercises();
            fe.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CardioExercises ce = new CardioExercises();
            ce.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CreateNewTraining cnt = new CreateNewTraining();
            cnt.Show();
            this.Close();
        }

    }
}
