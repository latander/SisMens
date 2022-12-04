﻿using SisMens.Model.Entidades.Financeiro;
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

        public Lancamento _Lancamento = new Lancamento();
        public IList<Lancamento> _Lista = new List<Lancamento>();

        public int ExisteLancamento(Lancamento lancamento)
        {
            foreach (var (item, index) in _Lista)
            {
                if (item.ID == lancamento.ID) { return ; }
            }

            return false;
        }

        private void btnSelecionar_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void dtgPesquisa_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (((sender as DataGrid).SelectedItem as Lancamento) != _Lancamento)
            {
                
            }
        }

        private void dtgPesquisa_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            /* Ao preparar a célula para edição, salva o estado atual dela para verificar se foi modificada para eventual Update no banco de dados */
            _Lancamento = ((sender as DataGrid).SelectedItem as Lancamento);
           
        }
    }
}