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

namespace SisMens.View.Entidades.Consulta
{
    /// <summary>
    /// Lógica interna para VConsulta.xaml
    /// </summary>
    public partial class VConsulta : Window
    {
        public VConsulta()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as ViewModel.Consultas.VMConsultaBase;

            if (vm != null)
            {
                if (!vm.IsResultadoSelecionado())
                    MessageBox.Show("Nenhum registro foi selecionado!");
                else
                {
                    DialogResult = true;
                    Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
