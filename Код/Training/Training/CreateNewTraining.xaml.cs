﻿using System;
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
    /// Логика взаимодействия для CreateNewTraining.xaml
    /// </summary>
    public partial class CreateNewTraining : MetroWindow
    {
        public CreateNewTraining()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChooseTypeOfExcercise chtoe = new ChooseTypeOfExcercise();
            chtoe.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
       
        }

       
    }
}
