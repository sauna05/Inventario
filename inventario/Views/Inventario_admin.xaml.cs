using inventario.Models;
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

namespace inventario.Views
{
    /// <summary>
    /// Interaction logic for Inventario_admin.xaml
    /// </summary>
    public partial class Inventario_admin : Window
    {
        public Inventario_admin()
        {

            InitializeComponent();
            frame_principal.Navigate(new Categoria_todos_admin());

        }
       
    }
}
