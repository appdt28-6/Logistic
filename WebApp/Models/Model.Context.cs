﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AppDTEntities : DbContext
    {
        public AppDTEntities()
            : base("name=AppDTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DESTINO_LOGISTIC> DESTINO_LOGISTIC { get; set; }
        public virtual DbSet<TRANS_LOGISTIC> TRANS_LOGISTIC { get; set; }
        public virtual DbSet<GUIA_LOGISTIC> GUIA_LOGISTIC { get; set; }
        public virtual DbSet<vis_GUIAS> vis_GUIAS { get; set; }
        public virtual DbSet<DESTINO_LOGISTIC_COSTO> DESTINO_LOGISTIC_COSTO { get; set; }
        public virtual DbSet<vis_Tarifas> vis_Tarifas { get; set; }
        public virtual DbSet<USUARIOS_LOGISTIC> USUARIOS_LOGISTIC { get; set; }
    
        public virtual int sp_SET_HORARIO(Nullable<int> barbid)
        {
            var barbidParameter = barbid.HasValue ?
                new ObjectParameter("barbid", barbid) :
                new ObjectParameter("barbid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SET_HORARIO", barbidParameter);
        }
    
        public virtual ObjectResult<ps_GUIAS_RESUMEN_Result> ps_GUIAS_RESUMEN(string ini, string end)
        {
            var iniParameter = ini != null ?
                new ObjectParameter("Ini", ini) :
                new ObjectParameter("Ini", typeof(string));
    
            var endParameter = end != null ?
                new ObjectParameter("End", end) :
                new ObjectParameter("End", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ps_GUIAS_RESUMEN_Result>("ps_GUIAS_RESUMEN", iniParameter, endParameter);
        }
    }
}