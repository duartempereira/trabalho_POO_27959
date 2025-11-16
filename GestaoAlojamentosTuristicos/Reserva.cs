using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    internal class Reserva
    {
        #region Attributes
        private int idReserva;
        private Cliente cliente;
        private Alojamento alojamento;
        private DateTime dataCheckIn;
        private DateTime dataCheckOut;
        private decimal valorTotal;
        #endregion

        #region Constructors
        public Reserva(
            int idReserva,
            Cliente cliente,
            Alojamento alojamento,
            DateTime dataCheckIn,
            DateTime dataCheckOut)
        {
            IdReserva = idReserva;
            Cliente = cliente;
            Alojamento = alojamento;
            DataCheckIn = dataCheckIn;
            DataCheckOut = dataCheckOut;

            ValorTotal = CalcularValorTotal();
        }
        #endregion

        #region Methods
        public decimal CalcularValorTotal()
        {
            int noites = (DataCheckOut - DataCheckIn).Days;

            if (noites <= 0)
                noites = 1;

            return noites * Alojamento.PrecoNoite;
        }
        #endregion

        #region Properties
        public int IdReserva { get; set; }
        public Cliente Cliente { get; set; }
        public Alojamento Alojamento { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public decimal ValorTotal { get; set; }
        #endregion

        #region Overrides
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine("===== Reserva =====");
            Console.WriteLine($"ID Reserva: {IdReserva}");
            Console.WriteLine($"Cliente: {Cliente.Nome}");
            Console.WriteLine($"Alojamento: {Alojamento.Nome}");
            Console.WriteLine($"Check-in: {DataCheckIn:dd/MM/yyyy}");
            Console.WriteLine($"Check-out: {DataCheckOut:dd/MM/yyyy}");
            Console.WriteLine($"Valor Total: {ValorTotal} €");
        }
        #endregion
    }
}
