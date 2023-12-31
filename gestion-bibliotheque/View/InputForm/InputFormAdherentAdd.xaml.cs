﻿using ControlzEx.Standard;
using gestion_bibliotheque.DataModel;
using gestion_bibliotheque.ViewModel;
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

namespace gestion_bibliotheque.View.InputForm
{
    /// <summary>
    /// Interaction logic for InputFormAdherentAdd.xaml
    /// </summary>
    public partial class InputFormAdherentAdd : Window
    {
        
        public InputFormAdherentAdd()
        {
            InitializeComponent();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void closeForm(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



     



        private void OnAjouterButtonClick(object sender, RoutedEventArgs e)
        {
            
            DatabaseHelper databaseHelper = new DatabaseHelper();
            Adherents adherents = new Adherents();



            // Successfully parsed the date, now you can use dateInscription
            databaseHelper.InsertAdherentData(
                txtPrenom.Text,
                txtNom.Text,
                txtEmail.Text,
                txtTelephone.Text,
                txtAddress.Text,
                txtMotDePasse.Text,
                txtDescription.Text
                );
            this.Close();
        }
    }
}

