using System;
using System.Collections.Generic;

namespace GestaoAlojamentosTuristicos
{
    internal class GestorAlojamentos
    {
        #region Attributes
        private List<Alojamento> alojamentos;
        #endregion

        #region Constructors
        public GestorAlojamentos()
        {
            alojamentos = new List<Alojamento>();
        }
        #endregion

        #region Properties
        public List<Alojamento> Alojamentos
        {
            get { return alojamentos; }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Adiciona um novo alojamento ao sistema.
        /// </summary>
        public void AdicionarAlojamento(Alojamento alojamento)
        {
            if (alojamento == null)
                throw new ArgumentNullException(nameof(alojamento));

            if (ExisteAlojamento(alojamento.Id))
                throw new InvalidOperationException("Já existe um alojamento com este ID.");

            alojamentos.Add(alojamento);
        }

        /// <summary>
        /// Obtém um alojamento através do seu ID.
        /// </summary>
        public Alojamento ObterAlojamentoPorId(int idAlojamento)
        {
            foreach (Alojamento a in alojamentos)
            {
                if (a.Id == idAlojamento)
                    return a;
            }

            return null;
        }

        /// <summary>
        /// Verifica se um alojamento existe no sistema.
        /// </summary>
        public bool ExisteAlojamento(int idAlojamento)
        {
            return ObterAlojamentoPorId(idAlojamento) != null;
        }

        /// <summary>
        /// Remove um alojamento pelo seu ID.
        /// </summary>
        public bool RemoverAlojamento(int idAlojamento)
        {
            Alojamento alojamento = ObterAlojamentoPorId(idAlojamento);

            if (alojamento == null)
                return false;

            alojamentos.Remove(alojamento);
            return true;
        }

        /// <summary>
        /// Devolve todos os alojamentos registados.
        /// </summary>
        public List<Alojamento> ObterTodosAlojamentos()
        {
            return alojamentos;
        }

        /// <summary>
        /// Obtém alojamentos com capacidade mínima.
        /// </summary>
        public List<Alojamento> ObterAlojamentosPorCapacidade(int capacidadeMinima)
        {
            List<Alojamento> resultado = new List<Alojamento>();

            foreach (Alojamento a in alojamentos)
            {
                if (a.Capacidade >= capacidadeMinima)
                    resultado.Add(a);
            }

            return resultado;
        }

        /// <summary>
        /// Obtém alojamentos até um preço máximo por noite.
        /// </summary>
        public List<Alojamento> ObterAlojamentosPorPrecoMaximo(decimal precoMaximo)
        {
            List<Alojamento> resultado = new List<Alojamento>();

            foreach (Alojamento a in alojamentos)
            {
                if (a.PrecoNoite <= precoMaximo)
                    resultado.Add(a);
            }

            return resultado;
        }

        #endregion
    }
}
