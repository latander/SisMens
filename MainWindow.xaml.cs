using SisMens.Model.Entidades.Participantes;
using SisMens.View.Entidades.Consulta;
using SisMens.View.Entidades.Participantes;
using SisMens.ViewModel.Base;
using SisMens.ViewModel.Consultas;
using SisMens.ViewModel.Entidades.Participantes;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SisMens
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

 
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            VSocio formSocio = new VSocio();
            this.DataContext = new VMSocio();

            pnlForm.Children.Clear();

            pnlForm.Children.Add(formSocio);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
