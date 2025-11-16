using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    internal class Cliente : Pessoa
    {
        #region Attributes
        static private int numeroAtualClientes = 0;
        #endregion

        #region Constructors
        public Cliente(
            string nome,
            DateTime dataNascimento,
            string numeroIdentificacao,
            string telefone,
            string email) : base(
                nome,
                dataNascimento,
                numeroIdentificacao,
                telefone,
                email)
        {
            numeroAtualClientes++;
            IdCliente = numeroAtualClientes;
        }
        #endregion

        #region Methods
        #endregion

        #region Properties
        public int IdCliente { get; private set; }
        #endregion

        #region Overrides
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"ID Cliente: {IdCliente}");
            base.ExibirInformacoes(); // Chama o método da classe base para exibir informações adicionais.
        }
        #endregion

        #region Destructor
        ~Cliente()
        {
        }
        #endregion
    }
}
