using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    public class Alojamento
    {
        #region Attributes
        private int id;
        private string nome;
        private int capacidade;
        private decimal precoNoite;
        private bool disponivel;
        #endregion

        #region Constructors
        public Alojamento(
            int id,
            string nome,
            int capacidade,
            decimal precoNoite)
        {
            Id = id;
            Nome = nome;
            Capacidade = capacidade;
            PrecoNoite = precoNoite;
            Disponivel = true;
        }
        #endregion

        #region Methods
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public decimal PrecoNoite { get; set; }
        public bool Disponivel { get; set; }
        #endregion


        #region Overrides
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Capacidade: {Capacidade} pessoas");
            Console.WriteLine($"Preço por noite: {PrecoNoite} €");
            Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
        }
        #endregion

        #region OtherMethods
        #endregion

    }
}
