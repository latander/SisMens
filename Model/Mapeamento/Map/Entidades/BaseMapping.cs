using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

using SisMens.Model.Entidades;

namespace SisMens.Model.Mapeamento.Map.Entidades
{
    public class BaseMapping<TEntidade> : ClassMapping<TEntidade>
        where TEntidade: EComum, new()
    {
        public BaseMapping(string tableName)
        {
            Table(tableName);
            Id(x => x.ID, m =>
            {
                m.Column("id");
                m.Access(Accessor.Field);
                m.UnsavedValue(0);
                m.Generator(Generators.Sequence, g => g.Params(new
                {
                    sequence = $"{tableName}_id_seq"
                }));
            });
        }
    }
}
