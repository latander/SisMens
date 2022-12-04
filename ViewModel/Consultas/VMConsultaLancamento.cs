using NHibernate;
using SisMens.Model.Entidades.Financeiro;
using SisMens.Model.Entidades.Interfaces;
using SisMens.View.Entidades.Financeiro;
using SisMens.ViewModel.Base;
using SisMens.ViewModel.Entidades.Financeiro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SisMens.Model.Enumerados.Enumerados;

namespace SisMens.ViewModel.Consultas
{
    public class VMConsultaLancamento<T> : VMConsultaBase
        
    where T : VMLancamento

    {
        public VMConsultaLancamento()
        {
            

            Resultados = new ObservableCollection<ResultadoConsulta<VMLancamento>>();

            var query = GetSessao().QueryOver<Lancamento>();

            foreach (var item in query.List())
            {
                var x = new ResultadoConsulta<VMLancamento>(item);
                Resultados.Add(x);
            }

        }

        public ObservableCollection<ResultadoConsulta<VMLancamento>> Resultados { get; private set; }

        public override bool IsResultadoSelecionado()
        {
            throw new NotImplementedException();
        }
    }
    public class ResultadoConsulta<VMLancamento> : VMBase

    {
        public ResultadoConsulta(Lancamento entidade)
        {
            Entidade = entidade;
        }

        public Lancamento Entidade { get; private set; }

        public long Id { get { return Entidade.ID ; } }
        public string Descricao { get { return Entidade.GetDescricao(); } }

        public string NomeSocio { get { return Entidade.Socio.Nome;  } }

        public TipoLancamento TipoMensalidade { get { return Entidade.Tipo; } }

        public decimal Valor { get { return Entidade.Valor; } }

        public bool Pago
        {
            get { return Entidade.Pago; }
            set { Entidade.Pago = value; }
        }
    }

}
