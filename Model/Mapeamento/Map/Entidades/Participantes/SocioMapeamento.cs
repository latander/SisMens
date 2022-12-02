using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisMens.Model.Entidades.Participantes ;
using NHibernate.Mapping.ByCode;
using static SisMens.Model.Enumerados.Enumerados;

namespace SisMens.Model.Mapeamento.Map.Entidades.Participantes
{
    public class SocioMapeamento : BaseMapping<Socio>
    {

        public SocioMapeamento() : base("socio")
        {
            Property(x => x.Nome, m =>
            {
                m.Column("nome");
                m.Access(Accessor.Field);
         
            });
            Property(x => x.Cpf, m =>
            {
                m.Column("cpf");
                m.Access(Accessor.Field);
            });
            Property(x => x.Email, m =>
            {
                m.Column("email");
                m.Access(Accessor.Field);
            });
            Property(x => x.Endereco, m =>
            {
                m.Column("endereco");
                m.Access(Accessor.Field);
            });
            Property(x => x.Telefone, m =>
            {
                m.Column("telefone");
                m.Access(Accessor.Field);
            });

            Property(x => x.DtNasc, m =>
            {
                m.Column("dtnasc");
                m.Access(Accessor.Field);
            });

            Property(x => x.Genero, m =>
            {
                m.Column("genero");
                m.Access(Accessor.Field);
            });

            Property(x => x.Valor_mensalidade, m =>
            {
                m.Column("valor_mensalidade");
                m.Access(Accessor.Field);
            });


        }
    }
}
