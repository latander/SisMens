using SisMens.Model.Entidades.Financeiro;
using SisMens.Model.Entidades.Participantes;
using SisMens.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SisMens.Model.Enumerados.Enumerados;

namespace SisMens.ViewModel.Entidades.Financeiro
{
    public class VMLancamento : VMBaseCadastro<Lancamento>
    {
        public VMLancamento()
        {
            InicializarEnumerados();
        }

        private void InicializarEnumerados()
        {
            TiposLancamento = new List<DescricaoEnumerado<TipoLancamento>>();
            TiposLancamento.Add(new DescricaoEnumerado<TipoLancamento>(SisMens.Model.Enumerados.Enumerados.TipoLancamento.Mensalidade, "Mensalidade"));
            TiposLancamento.Add(new DescricaoEnumerado<TipoLancamento>(SisMens.Model.Enumerados.Enumerados.TipoLancamento.Despesa, "Despesa"));
        }

        public void CarregarSocioPelaConsulta()
        {
            Socio socio = null;

            if (ConsultarEntidade(ref socio))
            {
                if (AlterarCadastro())
                {
                    Cadastro.Socio = socio;

                    OnPropertyChanged("IdSocio");
                    OnPropertyChanged("NomeSocio");
                }
            }
        }

        public List<DescricaoEnumerado<TipoLancamento>> TiposLancamento { get; set; }

        public TipoLancamento? TipoLancamento
        {
            get { return Cadastro == null ? null : (TipoLancamento?)Cadastro.Tipo; }
            set
            {
                if (AlterarCadastro() && value.HasValue)
                    Cadastro.Tipo = value.Value;
            }
        }

        public string DescricaoLancamento
        {
            get { return Cadastro == null ? null : Cadastro.Descricao; }
            set
            {
                if (AlterarCadastro())
                    Cadastro.Descricao = value;
            }
        }

        public decimal ValorLancamento
        {
            get { return Cadastro == null ? 0 : Cadastro.Valor; }
            set
            {
                if (AlterarCadastro())
                    Cadastro.Valor = value;
            }
        }

        public long IdSocio
        {
            get { return Cadastro == null || Cadastro.Socio == null ? 0 : Cadastro.Socio.ID; }
            set
            {
                if (AlterarCadastro())
                {
                    Cadastro.Socio = CarregarEntidade<Socio>(value);

                    OnPropertyChanged("Id");
                    OnPropertyChanged("Nome");
                }
            }
        }

        public string NomeSocio
        {
            get { return Cadastro == null || Cadastro.Socio == null ? null : Cadastro.Socio.Nome; }
        }

    }
}
