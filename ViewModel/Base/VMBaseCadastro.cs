using SisMens.Model.Entidades;
using SisMens.Model.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SisMens.ViewModel.Base
{
    public abstract class VMBaseCadastro : VMBase
    {
        public abstract bool ValidarCadastro();
        public abstract void SalvarCadastro();
        public abstract void CancelarCadastro();
        public abstract void ExcluirCadastro();
        public abstract void CarregarCadastroPelaConsulta();
    }


    public abstract class VMBaseCadastro<TCadastro> : VMBaseCadastro where TCadastro : EComum,
        IDescEComum, new()
    {
        public TCadastro Cadastro { get; protected set; }

        protected bool AlterarCadastro()
        {
            if (Cadastro == null)
            {
                Cadastro = new TCadastro();
            }
            return true;
        }

        public long? Id
        {
            get { return Cadastro == null ? null : (long?)Cadastro.ID; }
            set
            {
                if (value != null && value.Value != 0)
                {

                    var entidade = GetSessao().Get<TCadastro>(value);

                    if (entidade == null)
                    {
                        MessageBox.Show("Registro não encontrado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        return;
                    }

                    CarregarCadastro(entidade);


                }
            }
        }
        private void CarregarCadastro(TCadastro entidade)
        {
            Cadastro = entidade;

            OnPropertyChanged("");

            AoCarregarCadastro();
        }

        protected virtual void AoCarregarCadastro()
        {

        }

        public override bool ValidarCadastro()
        {
            return true;
        }

        public override void SalvarCadastro()
        {
            if (Cadastro == null)
                return;

            using (var tx = GetSessao().BeginTransaction())
            {
                GetSessao().SaveOrUpdate(Cadastro);
                tx.Commit();
            }

            CancelarCadastro();
        }
        public override void CancelarCadastro()
        {
            Cadastro = null;
            OnPropertyChanged("");

            AoCancelarCadastro();
        }

        protected virtual void AoCancelarCadastro()
        {

        }

        public override void ExcluirCadastro()
        {

            using (var tx = GetSessao().BeginTransaction())
            {
                GetSessao().Delete(Cadastro);
                tx.Commit();
            }

            CancelarCadastro();
        }

        public override void CarregarCadastroPelaConsulta()
        {
            TCadastro cadastro = null;

            if (ConsultarEntidade(ref cadastro))
                CarregarCadastro(cadastro);
        }
    }
}
