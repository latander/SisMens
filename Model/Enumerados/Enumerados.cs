using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMens.Model.Enumerados
{
    public class Enumerados
    {
        public enum Genero
        {
            [Description("Masculino")]
            Masculino = 1,
            [Description("Feminino")]
            Feminino = 2,
            [Description("Não Binário")]
            NBinario = 3,
            [Description("Transgênero")]
            Transgenero = 4,
        }

        public enum TipoLancamento
        {
            [Description("Mensalidade")]
            Mensalidade = 1,
            [Description("Despesa")]
            Despesa = 2,
        }
    }
}
