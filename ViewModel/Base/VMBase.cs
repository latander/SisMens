using Mensalidades.Model.Database;
using NHibernate;
using SisMens.Model.Entidades;
using SisMens.Model.Entidades.Interfaces;
using SisMens.View.Entidades.Consulta;
using SisMens.ViewModel.Consultas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SisMens.ViewModel.Base
{
    public abstract class VMBase : INotifyPropertyChanged
    {
        private ISession sessao;

        protected void SetSessao(ISession sessao)
        {
            this.sessao = sessao;
        }

        protected ISession GetSessao()
        {
            if (sessao == null)
            {
                sessao = SessionFactory.AcessoSessionFactory.OpenSession();
            }

            return sessao;
        }

        public void OnPropertyChanged(string nomePropriedade)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nomePropriedade));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public T CarregarEntidade<T>(long id) where T : EComum
        {
            if (id==0)        
                return null;

            var entidade = GetSessao().Get<T>(id);

            if (entidade == null)
            {
                MessageBox.Show("Registro não encontrado.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return null;
            }
            else
                return entidade;
            
        }

        public bool ConsultarEntidade<T>(ref T resultadoSelecionado) where T : class, IDescEComum
        {
            var view = new VConsulta();
            var vm = new VMConsulta<T>(GetSessao());

            view.DataContext = vm;

            var result = view.ShowDialog();

            if (result.HasValue && result.Value == true)
            {
                resultadoSelecionado = vm.ResultadoSelecionado.Entidade;

                return true;
            }
            else
                return false;
        }

        public bool ConsultarTudo<T>(ref ObservableCollection<T> listaCompleta) where T : class, IDescEComum
        {
            ObservableCollection<T> newCollection = new ObservableCollection<T>(GetSessao().CreateCriteria<T>().List<T>());

            listaCompleta = newCollection;

            return (listaCompleta.Count > 0);
        }
    }
}
