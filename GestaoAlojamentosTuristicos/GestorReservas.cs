using System;
using System.Collections.Generic;
using System.IO;

namespace GestaoAlojamentosTuristicos
{
    internal class GestorReservas
    {
        #region Attributes
        private List<Reserva> reservas;
        private static int ultimoIdReserva = 0;
        #endregion

        #region Constructors
        public GestorReservas()
        {
            reservas = new List<Reserva>();
        }
        #endregion

        #region Properties
        public List<Reserva> Reservas
        {
            get { return reservas; }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Cria e adiciona uma nova reserva ao sistema.
        /// </summary>
        public Reserva CriarReserva(
            Cliente cliente,
            Alojamento alojamento,
            DateTime checkIn,
            DateTime checkOut)
        {
            // Validações básicas
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));

            if (alojamento == null)
                throw new ArgumentNullException(nameof(alojamento));

            if (checkIn >= checkOut)
                throw new InvalidOperationException("A data de check-out tem de ser posterior ao check-in.");

            if (checkIn.Date < DateTime.Today)
                throw new InvalidOperationException("Não é possível criar reservas no passado.");

            // Verificar disponibilidade
            if (!AlojamentoDisponivel(alojamento, checkIn, checkOut))
                throw new InvalidOperationException("Alojamento indisponível para essas datas.");

            // Gerar ID automático
            ultimoIdReserva++;

            Reserva reserva = new Reserva(
                ultimoIdReserva,
                cliente,
                alojamento,
                checkIn,
                checkOut
            );

            reservas.Add(reserva);
            return reserva;
        }

        /// <summary>
        /// Verifica se um alojamento está disponível num intervalo de datas.
        /// </summary>
        public bool AlojamentoDisponivel(Alojamento alojamento, DateTime checkIn, DateTime checkOut)
        {
            foreach (Reserva r in reservas)
            {
                if (r.Alojamento == alojamento)
                {
                    bool sobrepoe =
                        checkIn < r.DataCheckOut &&
                        checkOut > r.DataCheckIn;

                    if (sobrepoe)
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Obtém uma reserva através do seu ID.
        /// </summary>
        public Reserva ObterReservaPorId(int idReserva)
        {
            foreach (Reserva r in reservas)
            {
                if (r.IdReserva == idReserva)
                    return r;
            }

            return null;
        }

        /// <summary>
        /// Obtém todas as reservas de um determinado cliente.
        /// </summary>
        public List<Reserva> ObterReservasDoCliente(Cliente cliente)
        {
            List<Reserva> resultado = new List<Reserva>();

            foreach (Reserva r in reservas)
            {
                if (r.Cliente == cliente)
                    resultado.Add(r);
            }

            return resultado;
        }

        /// <summary>
        /// Obtém todas as reservas de um determinado alojamento.
        /// </summary>
        public List<Reserva> ObterReservasDoAlojamento(Alojamento alojamento)
        {
            List<Reserva> resultado = new List<Reserva>();

            foreach (Reserva r in reservas)
            {
                if (r.Alojamento == alojamento)
                    resultado.Add(r);
            }

            return resultado;
        }

        /// <summary>
        /// Cancela (remove) uma reserva pelo seu ID.
        /// </summary>
        public bool CancelarReserva(int idReserva)
        {
            Reserva reserva = ObterReservaPorId(idReserva);

            if (reserva == null)
                return false;

            reservas.Remove(reserva);
            return true;
        }

        /// <summary>
        /// Devolve todas as reservas existentes.
        /// </summary>
        public List<Reserva> ObterTodasReservas()
        {
            return reservas;
        }

        #endregion


    }
}
