using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    internal class Pessoa
    {
        #region Attributes
        private string nome;
        private DateTime dataNascimento;
        private string numeroIdentificacao;
        private string telefone;
        private string email;
        #endregion

        #region Constructors
        public Pessoa(
            string nome,
            DateTime dataNascimento,
            string numeroIdentificacao,
            string telefone,
            string email)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            NumeroIdentificacao = numeroIdentificacao;
            Telefone = telefone;
            Email = email;
        }
        #endregion

        #region Methods
        #endregion

        #region Properties
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NumeroIdentificacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        #endregion

        #region Overrides
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento.ToShortDateString()}");
            Console.WriteLine($"Idade: {CalcularIdade()} anos");
            Console.WriteLine($"Nº Identificação: {NumeroIdentificacao}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");
        }
        #endregion

        #region OtherMethods
        public int CalcularIdade()
        {
            DateTime hoje = DateTime.Today;  // Data de hoje
            int idade = hoje.Year - DataNascimento.Year;  // Subtrai os anos

            // Verifica se a pessoa já fez aniversário este ano
            if (hoje.Month < DataNascimento.Month || (hoje.Month == DataNascimento.Month && hoje.Day < DataNascimento.Day))
            {
                idade--;  // Se ainda não fez aniversário, subtrai 1
            }

            return idade;
        }
        #endregion
    }
}