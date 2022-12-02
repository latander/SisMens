using SisMens.ViewModel.Base;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SisMens.View
{
    /// <summary>
    /// Interação lógica para BotoesCadastros.xam
    /// </summary>
    public partial class BotoesCadastros : UserControl
    {
        public BotoesCadastros()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as VMBaseCadastro;

            if (vm != null)
            {
                if (!vm.ValidarCadastro())
                    return;

                vm.SalvarCadastro();
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as VMBaseCadastro;

            if (vm != null)
            {
                vm.CancelarCadastro();
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as VMBaseCadastro;

            if (vm != null)
            {
                if (MessageBox.Show("Deseja excluir o registro?", "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    vm.ExcluirCadastro();
            }
        }
    }
}
