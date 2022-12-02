using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SisMens.Model.Enumerados.Enumerados;

namespace SisMens.Model.Entidades.Participantes
{
    public abstract class Pessoa : EComum
    {

        #region Fields
        private string nome, cpf, email, endereco, telefone;
        private DateTime dtNasc;
        private Genero genero;
        #endregion
        #region Constructor
        public Pessoa()
        {

        }
        #endregion
        #region Properties
        public virtual string Nome { get => nome; set => nome = value; }
        public virtual string Cpf { get => cpf; set => cpf = value; }
        public virtual string Email { get => email; set => email = value; }
        public virtual string Endereco { get => endereco; set => endereco = value; }
        public virtual string Telefone { get => telefone; set => telefone = value; }
        public virtual DateTime DtNasc { get => dtNasc; set => dtNasc = value; }
        public virtual Genero Genero { get => genero; set => genero = value; }
        #endregion
    }
}
