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
using SisMens.ViewModel.Base;

namespace SisMens.View.Entidades.Participantes
{
    /// <summary>
    /// Lógica interna para VSocio.xaml
    /// </summary>
    public partial class VSocio : UserControl
    {
        public VSocio()
        {
            InitializeComponent();
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
