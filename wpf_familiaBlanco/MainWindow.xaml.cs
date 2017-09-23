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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfFamiliaBlanco
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

        
        private void btnUsuarios_Click(object sender, RoutedEventArgs e)
        {

            frameInicio.Content = new pageUsuarios();  //frame inicio es el cuadro donde se actualizan las pantallas en la ventana
            //principal del programa
        }

        private void cargar_pageInicio(object sender, EventArgs e)
        {
            frameInicio.Content = new pageInicio(); // en este caso se carga la imagen de ceibo - software al inicializarse el programa
        }

        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {
            frameInicio.Content = new pageProductos();
        }

        private void btnProveedores_Click(object sender, RoutedEventArgs e)
        {
            frameInicio.Content = new pageProveedores();
        }

        private void btnEntradas_Click(object sender, RoutedEventArgs e)
        {
            frameInicio.Content = new pageEntradas();
        }

        private void btnSalidas_Click(object sender, RoutedEventArgs e)
        {
            frameInicio.Content = new pageSalidas();
        }
    }
}
