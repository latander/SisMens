using SisMens.Model.Entidades.Financeiro;
using SisMens.Model.Entidades.Participantes;
using SisMens.View.Entidades.Consulta;
using SisMens.View.Entidades.Financeiro;
using SisMens.View.Entidades.Participantes;
using SisMens.ViewModel.Base;
using SisMens.ViewModel.Consultas;
using SisMens.ViewModel.Entidades.Financeiro;
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

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            VLancamento f = new VLancamento();
            this.DataContext = new VMLancamento();

            pnlForm.Children.Clear(); 

            pnlForm.Children.Add(f);

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            VConsultaLancamento f = new VConsultaLancamento();
            VMLancamento view = new VMLancamento();
            view.CarregarTodos();
            this.DataContext = view.Todos;
            
     
            pnlForm.Children.Clear();   
            pnlForm.Children.Add(f);
        }
    }
}
