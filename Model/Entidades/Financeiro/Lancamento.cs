using SisMens.Model.Entidades.Interfaces;
using SisMens.Model.Entidades.Participantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SisMens.Model.Enumerados.Enumerados;

namespace SisMens.Model.Entidades.Financeiro
{
    public class Lancamento : EComum, IDescEComum
    {
        private TipoLancamento tipo;
        private decimal valor;
        private Socio socio;
        private string descricao;
        private bool pago;
        private DateTime dtpagto;
        
        public Lancamento()
        {

        }

        public virtual TipoLancamento Tipo { get => tipo; set => tipo = value; }
        public virtual decimal Valor { get => valor; set => valor = value; }
        public virtual Socio Socio { get => socio; set => socio = value; }
        public virtual string Descricao { get => descricao; set => descricao = value; }
        public virtual bool Pago { get => pago; set => pago = value; }
        public virtual DateTime Dtpagto { get => dtpagto; set => dtpagto = value; }

        public virtual string GetDescricao()
        {
            return descricao;
        }
    }
}
