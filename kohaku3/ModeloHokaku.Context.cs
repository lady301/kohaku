﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kohaku3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kohakuEntities3 : DbContext
    {
        public kohakuEntities3()
            : base("name=kohakuEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<asistencia> asistencia { get; set; }
        public virtual DbSet<bitacora> bitacora { get; set; }
        public virtual DbSet<clases> clases { get; set; }
        public virtual DbSet<documentacion> documentacion { get; set; }
        public virtual DbSet<estado_documentacion> estado_documentacion { get; set; }
        public virtual DbSet<estado_pago> estado_pago { get; set; }
        public virtual DbSet<estado_usuario> estado_usuario { get; set; }
        public virtual DbSet<pagos> pagos { get; set; }
        public virtual DbSet<rango_usuario> rango_usuario { get; set; }
        public virtual DbSet<tipo_documento> tipo_documento { get; set; }
        public virtual DbSet<tipo_usuario> tipo_usuario { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}