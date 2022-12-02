using NHibernate;
using SisMens.Model.Entidades.Interfaces;
using SisMens.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMens.ViewModel.Consultas
{
    public abstract class VMConsultaBase : VMBase
    {
        public abstract bool IsResultadoSelecionado();
    }

    public class VMConsulta<T> : VMConsultaBase
        where T : class, IDescEComum
    {
        public VMConsulta(ISession sessao)
        {
            SetSessao(sessao);

            Resultados = new ObservableCollection<ResultadoVisao<T>>();

            var query = GetSessao().QueryOver<T>();

            foreach (var item in query.List())
            {
                var x = new ResultadoVisao<T>(item);
                Resultados.Add(x);
            }

        }

        public ObservableCollection<ResultadoVisao<T>> Resultados { get; private set; }

        public ResultadoVisao<T> ResultadoSelecionado { get; set; }

        public override bool IsResultadoSelecionado()
        {
            return ResultadoSelecionado != null;
        }

    }


    public class ResultadoVisao<T> : VMBase
        where T : IDescEComum
    {
        public ResultadoVisao(T entidade)
        {
            Entidade = entidade;
        }

        public T Entidade { get; private set; }

        public long Id { get { return Entidade.ID; } }
        public string Descricao { get { return Entidade.GetDescricao(); } }
    }
}
