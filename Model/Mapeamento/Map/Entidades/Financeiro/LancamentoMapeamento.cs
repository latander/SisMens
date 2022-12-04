using SisMens.Model.Entidades.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping;
using SisMens.Model.Entidades.Participantes;

namespace SisMens.Model.Mapeamento.Map.Entidades.Financeiro
{
    public class LancamentoMapeamento : BaseMapping<Lancamento>
    {
        public LancamentoMapeamento() : base("lancamento")
        {
            Property(x => x.Tipo, m =>
            {
                m.Column("tipo");
                m.Access(Accessor.Field);
            });

            Property(x => x.Valor, m =>
            {
                m.Column("valor");
                m.Access(Accessor.Field);
            });

        
            Property(x => x.Descricao, m =>
            {
                m.Column("descricao");
                m.Access(Accessor.Field);
            });

            Property(x => x.Pago, m =>
            {
                m.Column("pago");
                m.Access(Accessor.Field);
            });

            Property(x => x.Dtpagto, m =>
            {
                m.Column("dtpagto");
                m.Access(Accessor.Field);
            });

            ManyToOne(x => x.Socio, m =>
            {
                m.Column("idsocio");
                m.Class(typeof(Socio));
                m.Cascade(Cascade.None);                
                m.Fetch(FetchKind.Join);
                m.Access(Accessor.Field);
                m.Update(true);
                m.Insert(true);
                m.ForeignKey("fk_socio");
                m.UniqueKey("id");
            });
        }
    }
}
