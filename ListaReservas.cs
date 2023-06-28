using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasMVC.Models
{
    public class ListaReservas
    {
        private List<Reserva> _reserva;

        /*public void PruebaListas()
        {
            _reserva = new List<Reserva>();
            foreach(var reserva in _reserva)
            {
                Console.WriteLine("Id: " + reserva.IdReserva);
            }
        }*/

        public void AniadirReserva()
        {
            _reserva.Add(new Reserva(1, DateTime.Parse("2023/01/22"), DateTime.Parse("2023/01/23"), 2000, 6, 1));
            _reserva.Add(new Reserva(2, DateTime.Parse("2023/01/25"), DateTime.Parse("2023/01/26"), 1300, 7, 3));

            foreach (var reserva in _reserva)
            {
                Console.WriteLine(reserva);
            }
        }

        public void BorrarReserva()
        {
            _reserva.Remove(_reserva[0]);
        }
    }
}
