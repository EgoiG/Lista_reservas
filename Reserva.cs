using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReservasMVC.Models
{
    class Reserva
    {
        private int _idReserva;
        private DateTime _fechaEntrada;
        private DateTime _fechaSalida;
        private int _precio;
        private int _idCliente;
        private int _idAlojamiento;


        //constructor
        public Reserva()
        {
            _idReserva = 0;
            _fechaEntrada = DateTime.MinValue;
            _fechaSalida = DateTime.MinValue;
            _precio = 0;
            _idCliente = 0;
            _idAlojamiento = 0;

        }

        public Reserva(int idReserva, DateTime fechaEntrada, DateTime fechaSalida, int idPrecio, int idCliente, int idAlojamiento)
        {
            _idReserva = idReserva;
            _fechaEntrada = fechaEntrada;
            _fechaSalida = fechaSalida;
            _precio = idPrecio;
            _idCliente = idCliente;
            _idAlojamiento = idAlojamiento;
        }

        //propiedades
        public int IdReserva { get => _idReserva; set => _idReserva = value; }
        public DateTime FechaEntrada { get => _fechaEntrada; set => _fechaEntrada = value; }
        public DateTime FechaSalida { get => _fechaSalida; set => _fechaSalida = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdAlojamiento { get => _idAlojamiento; set => _idAlojamiento = value; }

        //metodos
        public override string ToString()//el metodo ToString ya existe, hay que usar override para sobreescribirlo
        {
            return "idReserva: " + _idReserva + " Fecha de entrada: " + _fechaEntrada + " Fecha de salida: " + _fechaSalida + " Precio: " + _precio + " idCliente: " + _idCliente + "idAlojamiento: " + IdAlojamiento;
        }
    }
}
