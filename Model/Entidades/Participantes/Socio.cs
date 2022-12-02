using SisMens.Model.Entidades.Financeiro;
using SisMens.Model.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMens.Model.Entidades.Participantes
{
    public class Socio : Pessoa, IDescEComum
    {
        private decimal valor_mensalidade;
        private IList<Lancamento> lancamentos;
        public Socio() { }


        public virtual decimal Valor_mensalidade { get => valor_mensalidade; set => valor_mensalidade = value; }
        public virtual IList<Lancamento> Lancamentos { get => lancamentos; set => lancamentos = value; }

        public virtual string GetDescricao()
        {
            return Nome;
        }
    }
}
