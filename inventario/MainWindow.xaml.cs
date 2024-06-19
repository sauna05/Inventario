﻿using inventario.Models;
using inventario.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace inventario
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            getElementos();
            frame_principal.Navigate(new Categoria_todos());
        }

        public void getElementos()
        {
            //using (SenaInventarioContext db = new SenaInventarioContext())
            //{
            //    var query = from elementos in db.Elementos
            //                join categoria in db.Categorias on elementos.IdCategoria equals categoria.Id
            //                join persona in db.Personas on elementos.IdPersonaEncargada equals persona.Id
            //                join estado in db.EstadoElementos on elementos.IdEstado equals estado.Id
            //                select new
            //                {
            //                    id = elementos.Id,
            //                    cd = elementos.CodigoElemento,
            //                    nm = elementos.NombreElemento,
            //                    ec = elementos.Cantidad,
            //                    pn = persona.Nombre,
            //                    es = estado.NombreEstadoElemento,
            //                    cg = categoria.NombreCategoria

            //                };
            //    dataproductos.ItemsSource = query.ToList();

            //};

        }



        public void buscarDatos()
        {
            //var txtbuscar = txtbuscado.Text.Trim(); // Obtener el texto del cuadro de búsqueda
            //using (SenaInventarioContext db = new SenaInventarioContext())
            //{
            //    // Construir la consulta con filtro por código y nombre
            //    var query = from elementos in db.Elementos
            //                join categoria in db.Categorias on elementos.IdCategoria equals categoria.Id
            //                join persona in db.Personas on elementos.IdPersonaEncargada equals persona.Id
            //                join estado in db.EstadoElementos on elementos.IdEstado equals estado.Id
            //                where elementos.CodigoElemento.Contains(txtbuscar) || elementos.NombreElemento.Contains(txtbuscar)
            //                select new
            //                {
            //                    cd = elementos.CodigoElemento,
            //                    nm = elementos.NombreElemento,
            //                    ec = elementos.Cantidad,
            //                    pn = persona.Nombre,
            //                    es = estado.NombreEstadoElemento,
            //                    cg = categoria.NombreCategoria
            //                };
            //    dataproductos.ItemsSource = query.ToList(); // Asignar los resultados al origen de datos
            //}

        }

        private void txtbuscado_TextChanged(object sender, TextChangedEventArgs e)
        {
            buscarDatos(); // Llamar al método de búsqueda cada vez que se modifica el texto
        }

        private void btn_informatica(object sender, RoutedEventArgs e)
        {
            frame_principal.Navigate(new Categoria_informatica());
        }
    }
}


