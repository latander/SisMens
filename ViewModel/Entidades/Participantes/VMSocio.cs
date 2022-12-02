using SisMens.Model.Entidades.Participantes;
using SisMens.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SisMens.Model.Enumerados.Enumerados;

namespace SisMens.ViewModel.Entidades.Participantes
{
    public class VMSocio : VMBaseCadastro<Socio>
    {
        public VMSocio()
        {
          
            InicializarEnumerados();
        }

        private void InicializarEnumerados()
        {
            Generos = new List<DescricaoEnumerado<Genero>>
            {
                new DescricaoEnumerado<Genero>(SisMens.Model.Enumerados.Enumerados.Genero.Masculino, "Masculino"),
                new DescricaoEnumerado<Genero>(SisMens.Model.Enumerados.Enumerados.Genero.Feminino, "Feminino"),
                new DescricaoEnumerado<Genero>(SisMens.Model.Enumerados.Enumerados.Genero.NBinario, "Não Binário"),
                new DescricaoEnumerado<Genero>(SisMens.Model.Enumerados.Enumerados.Genero.Transgenero, "Transgenero"),
            };
        }

        public string Nome
        {
            get { return Cadastro == null ? null : Cadastro.Nome; }
            set
            {
                if (AlterarCadastro())
                    Cadastro.Nome = value;
            }
        }


        public DateTime? DtNasc
        {
            get { return Cadastro == null ? null : (DateTime?)Cadastro.DtNasc; }
            set
            {
                if (AlterarCadastro() && value.HasValue)
                    Cadastro.DtNasc = value.Value;
            }
        }

        public List<DescricaoEnumerado<Genero>> Generos { get; set; }

        public Genero? Genero
        {
            get { return Cadastro == null ? null : (Genero?)Cadastro.Genero; }
            set
            {
                if (AlterarCadastro() && value.HasValue)
                    Cadastro.Genero = value.Value;
            }
        }

        public string Cpf
        {
            get { return Cadastro == null ? null : Cadastro.Cpf; }
            set
            {
                if (AlterarCadastro())
                    Cadastro.Cpf = value;
            }
        }


        public string Email
        {
            get { return Cadastro == null ? null : Cadastro.Email; }
            set
            {
                if (AlterarCadastro())
                    Cadastro.Email = value;
            }
        }

        public string Endereco
        {
            get { return Cadastro == null ? null : Cadastro.Endereco; }
            set
            {
                if (AlterarCadastro())
                    Cadastro.Endereco = value;
            }
        }


        public string Telefone
        {
            get { return Cadastro == null ? null : Cadastro.Telefone; }
            set
            {
                if (AlterarCadastro())
                    Cadastro.Telefone = value;
            }
        }


        public decimal ValorMensalidade
        {
            get { return Cadastro == null ? 0 : Cadastro.Valor_mensalidade; }
            set
            {
                if (AlterarCadastro())
                    Cadastro.Valor_mensalidade = value;
            }
        }

        protected override void AoCancelarCadastro()
        {
            base.AoCancelarCadastro();

        }
    }
}
