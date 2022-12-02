using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMens.Model.Entidades.Interfaces
{
    public interface IDescEComum
    {
        long ID { get;}

        string GetDescricao();
    }
}
