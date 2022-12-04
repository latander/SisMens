using SisMens.Model.Entidades.Participantes;
using SisMens.ViewModel.Base;
using SisMens.ViewModel.Entidades.Financeiro;
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

namespace SisMens.View.Entidades.Financeiro
{
    /// <summary>
    /// Interação lógica para VLancamento.xam
    /// </summary>
    public partial class VLancamento : UserControl
    {
        public VLancamento()
        {
            InitializeComponent();
        }

        private void txtIdSocio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                var vm = (Parent as StackPanel).DataContext as VMLancamento;

                if (vm != null)
                {
                    vm.CarregarSocioPelaConsulta();
                }
            }
        }

        private void txtId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                var vm = (Parent as StackPanel).DataContext as VMBaseCadastro;

                if (vm != null)
                {
                    vm.CarregarCadastroPelaConsulta();
                }
            }
        }
    }
}
