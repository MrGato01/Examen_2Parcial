using System;

namespace Entidades
{
    public class Ticket
    {
        public int IdTicket { get; set; }
        public DateTime Fecha { get; set; }
        public string IdentidadCliente { get; set; }
        public string CodigoUsuario { get; set; }
        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public Ticket()
        {
        }

        public Ticket(int idTicket, DateTime fecha, string identidadCliente, string codigoUsuario, decimal iSV, decimal descuento, decimal subTotal, decimal total)
        {
            IdTicket = idTicket;
            Fecha = fecha;
            IdentidadCliente = identidadCliente;
            CodigoUsuario = codigoUsuario;
            ISV = iSV;
            Descuento = descuento;
            SubTotal = subTotal;
            Total = total;
        }
    }


}
