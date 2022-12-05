using SisMens.Model.Entidades.Financeiro;
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

namespace SisMens.View.Entidades.Consulta
{
    /// <summary>
    /// Interação lógica para VConsultaLancamento.xam
    /// </summary>
    public partial class VConsultaLancamento : UserControl
    {
        public VConsultaLancamento()
        {
            InitializeComponent();

        }

        public VMLancamento _Lancamento = new VMLancamento();
        public IList<VMLancamento> _Lista = new List<VMLancamento>();

        public void ManipulaLista(VMLancamento lancamento)
        {
            int i = -1;
            
            foreach (var item in _Lista)
            {
                i++;
                if (item.Id == lancamento.Id) { _Lista.RemoveAt(i); break; }            
            }

            _Lista.Add(lancamento);    
 
        }

        private void btnSelecionar_Click(object sender, RoutedEventArgs e)
        {
           foreach (var item in _Lista)
            {
                item.SalvarCadastro();
            }
        }

        private void dtgPesquisa_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            VMLancamento nLanc = new VMLancamento();
            nLanc.Id = (e.Row.DataContext as Lancamento).ID;

            nLanc.Pago = (e.EditingElement as CheckBox).IsChecked ?? false;
 
            ManipulaLista(nLanc);

        }

        private void dtgPesquisa_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {

           
        }

        private void txtPesquisar_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (var item in dtgPesquisa.Items)
            {
                string sPesquisa = (item as Lancamento).Socio.Nome + (item as Lancamento).Descricao;
                if (sPesquisa.ToLower().Contains((e.Source as TextBox).Text.ToLower()))
                {
                    dtgPesquisa.SelectedItem = item;
                }
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            VMLancamento view = new VMLancamento();
            view.CarregarTodos();
            DataContext = view.Todos;

            _Lista.Clear();
        }
    }
}
