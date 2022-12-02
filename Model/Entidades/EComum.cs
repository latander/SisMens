using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMens.Model.Entidades
{
    public class EComum
    {
        private long id;

        public virtual long ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
