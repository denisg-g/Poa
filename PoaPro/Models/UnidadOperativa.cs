//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoaPro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UnidadOperativa
    {
        public UnidadOperativa()
        {
            this.IndicadorAnual = new HashSet<IndicadorAnual>();
        }
    
        public int IdUnidadOperativa { get; set; }
        public int IdUnidadAdministrativa { get; set; }
        public string Nombre { get; set; }
        public string Siglas { get; set; }
        public string Indice { get; set; }
        public Nullable<int> Orden { get; set; }
    
        public virtual ICollection<IndicadorAnual> IndicadorAnual { get; set; }
        public virtual UnidadAdministrativa UnidadAdministrativa { get; set; }
    }
}
