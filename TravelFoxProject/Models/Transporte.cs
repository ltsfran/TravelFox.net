//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelFoxProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transporte
    {
        public int idTransporte { get; set; }
        public string nroPlaca { get; set; }
        public int capacidad { get; set; }
        public string tipoTransporte { get; set; }
        public Nullable<int> idRuta { get; set; }
        public Nullable<int> idCompañia { get; set; }
    
        public virtual Compañia Compañia { get; set; }
        public virtual Ruta Ruta { get; set; }
    }
}
