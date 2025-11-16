using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    internal class Apartamento : Alojamento
    {
        #region Attributes
        private int numeroQuartos;
        #endregion

        #region Constructors
        public Apartamento(
            int id,
            string nome,
            int capacidade,
            decimal precoNoite,
            int numeroQuartos,
            bool temCozinha)
            : base(id, nome, capacidade, precoNoite)
        {
            NumeroQuartos = numeroQuartos;
        }
        #endregion

        #region Methods
        public override void ExibirInformacoes()
        {
            Console.WriteLine("=== Alojamento: Apartamento ===");
            base.ExibirInformacoes();

            Console.WriteLine($"Número de Quartos: {NumeroQuartos}");
        }
        #endregion

        #region Properties
        public int NumeroQuartos { get; set; }
        #endregion
    }
}
