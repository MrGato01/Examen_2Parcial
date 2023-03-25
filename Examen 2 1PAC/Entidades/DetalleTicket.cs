﻿using System;

namespace Entidades
{
    public class DetalleTicket
    {
        public int IdDetalleTicket { get; set; }
        public int IdTicket { get; set; }
        public string TipoSoporte { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string DescripcionRespuesta { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }

        public DetalleTicket()
        {
        }

        public DetalleTicket(int idDetalleTicket, int idTicket, string tipoSoporte, string descripcionSolicitud, string descripcionRespuesta, decimal precio, decimal total)
        {
            IdDetalleTicket = idDetalleTicket;
            IdTicket = idTicket;
            TipoSoporte = tipoSoporte;
            DescripcionSolicitud = descripcionSolicitud;
            DescripcionRespuesta = descripcionRespuesta;
            Precio = precio;
            Total = total;
        }
    }
}
