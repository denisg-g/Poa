﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class POAEntities : DbContext
    {
        public POAEntities()
            : base("name=POAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActividadEstrategica> ActividadEstrategica { get; set; }
        public virtual DbSet<Entidad> Entidad { get; set; }
        public virtual DbSet<IndicadorAnual> IndicadorAnual { get; set; }
        public virtual DbSet<IndicadorMensual> IndicadorMensual { get; set; }
        public virtual DbSet<IndicadorTrimestral> IndicadorTrimestral { get; set; }
        public virtual DbSet<ObjetivoEstrategico> ObjetivoEstrategico { get; set; }
        public virtual DbSet<ObjetivoOperativo> ObjetivoOperativo { get; set; }
        public virtual DbSet<POA> POA { get; set; }
        public virtual DbSet<POADetalle> POADetalle { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Resultado> Resultado { get; set; }
        public virtual DbSet<UnidadAdministrativa> UnidadAdministrativa { get; set; }
        public virtual DbSet<UnidadOperativa> UnidadOperativa { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
