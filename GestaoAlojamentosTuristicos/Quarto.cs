using System;

namespace GestaoAlojamentosTuristicos
{
    internal class Quarto : Alojamento
    {
        #region Attributes
        private int numeroCamas;
        private bool casaBanhoPrivada;
        #endregion

        #region Constructors
        public Quarto(
            int id,
            string nome,
            int capacidade,
            decimal precoNoite,
            int numeroCamas,
            bool casaBanhoPrivada)
            : base(id, nome, capacidade, precoNoite)
        {
            NumeroCamas = numeroCamas;
            CasaBanhoPrivada = casaBanhoPrivada;
        }
        #endregion

        #region Properties
        public int NumeroCamas
        {
            get { return numeroCamas; }
            set { numeroCamas = value; }
        }

        public bool CasaBanhoPrivada
        {
            get { return casaBanhoPrivada; }
            set { casaBanhoPrivada = value; }
        }
        #endregion

        #region Overrides
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Número de camas: {NumeroCamas}");
            Console.WriteLine($"Casa de banho privada: {(CasaBanhoPrivada ? "Sim" : "Não")}");
        }
        #endregion
    }
}
