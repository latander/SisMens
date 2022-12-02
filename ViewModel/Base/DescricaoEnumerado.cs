using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMens.ViewModel.Base
{
    public class DescricaoEnumerado<T>
    {
        public DescricaoEnumerado(T valor, string descricao)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public string Descricao { get; private set; }
        public T Valor { get; private set;}
    }
}
