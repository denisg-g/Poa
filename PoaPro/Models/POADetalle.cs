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
    
    public partial class POADetalle
    {
        public POADetalle()
        {
            this.IndicadorAnual = new HashSet<IndicadorAnual>();
            this.POA = new HashSet<POA>();
        }
    
        public int IdPOADetalle { get; set; }
        public int IdPOA { get; set; }
        public int IdResultado { get; set; }
        public int IdObjetivoOperativo { get; set; }
        public string Indice { get; set; }
        public Nullable<int> Orden { get; set; }
    
        public virtual ICollection<IndicadorAnual> IndicadorAnual { get; set; }
        public virtual ObjetivoOperativo ObjetivoOperativo { get; set; }
        public virtual ICollection<POA> POA { get; set; }
        public virtual POA POA1 { get; set; }
        public virtual Resultado Resultado { get; set; }
    }
}
