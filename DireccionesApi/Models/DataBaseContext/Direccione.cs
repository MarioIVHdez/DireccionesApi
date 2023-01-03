using System;
using System.Collections.Generic;

#nullable disable

namespace DireccionesApi.Models
{
    public partial class Direccione
    {
        public long DireccionesId { get; set; }
        public string AliasDireccion { get; set; }
        public string NombrePersona { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string CalleNumero { get; set; }
        public string Colonia { get; set; }
        public string Referencia { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaEdicion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public bool Eliminacion { get; set; }
    }
}
