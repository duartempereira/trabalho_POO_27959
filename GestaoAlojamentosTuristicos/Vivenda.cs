using System;

namespace GestaoAlojamentosTuristicos
{
    internal class Vivenda : Alojamento
    {
        #region Attributes
        private bool piscina;
        private decimal areaExterior;
        #endregion

        #region Constructors
        public Vivenda(
            int id,
            string nome,
            int capacidade,
            decimal precoNoite,
            bool piscina,
            decimal areaExterior)
            : base(id, nome, capacidade, precoNoite)
        {
            Piscina = piscina;
            AreaExterior = areaExterior;
        }
        #endregion

        #region Properties
        public bool Piscina
        {
            get { return piscina; }
            set { piscina = value; }
        }

        public decimal AreaExterior
        {
            get { return areaExterior; }
            set { areaExterior = value; }
        }
        #endregion

        #region Overrides
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Piscina: {(Piscina ? "Sim" : "Não")}");
            Console.WriteLine($"Área exterior: {AreaExterior} m²");
        }
        #endregion
    }
}
