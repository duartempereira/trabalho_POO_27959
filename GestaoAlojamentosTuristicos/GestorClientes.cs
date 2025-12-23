using System;
using System.Collections.Generic;

namespace GestaoAlojamentosTuristicos
{
    internal class GestorClientes
    {
        #region Attributes
        private List<Cliente> clientes;
        #endregion

        #region Constructors
        public GestorClientes()
        {
            clientes = new List<Cliente>();
        }
        #endregion

        #region Properties
        public List<Cliente> Clientes
        {
            get { return clientes; }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Adiciona um novo cliente ao sistema.
        /// </summary>
        public void AdicionarCliente(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));

            if (ExisteClientePorNumeroIdentificacao(cliente.NumeroIdentificacao))
                throw new InvalidOperationException("Já existe um cliente com este número de identificação.");

            clientes.Add(cliente);
        }

        /// <summary>
        /// Obtém um cliente pelo seu ID.
        /// </summary>
        public Cliente ObterClientePorId(int idCliente)
        {
            foreach (Cliente c in clientes)
            {
                if (c.IdCliente == idCliente)
                    return c;
            }

            return null;
        }

        /// <summary>
        /// Obtém um cliente pelo número de identificação.
        /// </summary>
        public Cliente ObterClientePorNumeroIdentificacao(string numeroIdentificacao)
        {
            foreach (Cliente c in clientes)
            {
                if (c.NumeroIdentificacao == numeroIdentificacao)
                    return c;
            }

            return null;
        }

        /// <summary>
        /// Verifica se um cliente existe através do ID.
        /// </summary>
        public bool ExisteClientePorId(int idCliente)
        {
            return ObterClientePorId(idCliente) != null;
        }

        /// <summary>
        /// Verifica se um cliente existe através do número de identificação.
        /// </summary>
        public bool ExisteClientePorNumeroIdentificacao(string numeroIdentificacao)
        {
            return ObterClientePorNumeroIdentificacao(numeroIdentificacao) != null;
        }

        /// <summary>
        /// Remove um cliente pelo seu ID.
        /// </summary>
        public bool RemoverCliente(int idCliente)
        {
            Cliente cliente = ObterClientePorId(idCliente);

            if (cliente == null)
                return false;

            clientes.Remove(cliente);
            return true;
        }

        /// <summary>
        /// Devolve todos os clientes registados.
        /// </summary>
        public List<Cliente> ObterTodosClientes()
        {
            return clientes;
        }

        #endregion
    }
}
