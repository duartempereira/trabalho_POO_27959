using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    internal class GestorReservas
    {
        #region Attributes
        private List<Reserva> reservas;
        #endregion

        #region Constructors
        public GestorReservas()
        {
            reservas = new List<Reserva>();
        }
        #endregion

        #region Properties
        public List<Reserva> Reservas { get; set; }
        #endregion

        #region Methods
        public void AdicionarReserva(Reserva r)
        {
            // TODO: validar disponibilidade do alojamento na Fase 2
            reservas.Add(r);
        }

        public List<Reserva> ObterTodasReservas()
        {
            return reservas;
        }

        public bool AlojamentoDisponivel(Alojamento aloj, DateTime checkIn, DateTime checkOut)
        {
            // TODO: implementar validação de datas na Fase 2
            return true;
        }
        #endregion
    }
}
