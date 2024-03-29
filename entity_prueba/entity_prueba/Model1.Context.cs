﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entity_prueba
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AgenciaTransitoEntities : DbContext
    {
        public AgenciaTransitoEntities()
            : base("name=AgenciaTransitoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agentes> Agentes { get; set; }
        public virtual DbSet<Localidades> Localidades { get; set; }
        public virtual DbSet<MediosPago> MediosPago { get; set; }
        public virtual DbSet<Multas> Multas { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoInfracciones> TipoInfracciones { get; set; }
        public virtual DbSet<VW_multass> VW_multass { get; set; }
    
        public virtual int sp_agregarMulta(Nullable<int> idTipoInfraccion, Nullable<int> idlocalidad, Nullable<int> idagente, string patente, Nullable<decimal> monto)
        {
            var idTipoInfraccionParameter = idTipoInfraccion.HasValue ?
                new ObjectParameter("idTipoInfraccion", idTipoInfraccion) :
                new ObjectParameter("idTipoInfraccion", typeof(int));
    
            var idlocalidadParameter = idlocalidad.HasValue ?
                new ObjectParameter("idlocalidad", idlocalidad) :
                new ObjectParameter("idlocalidad", typeof(int));
    
            var idagenteParameter = idagente.HasValue ?
                new ObjectParameter("idagente", idagente) :
                new ObjectParameter("idagente", typeof(int));
    
            var patenteParameter = patente != null ?
                new ObjectParameter("patente", patente) :
                new ObjectParameter("patente", typeof(string));
    
            var montoParameter = monto.HasValue ?
                new ObjectParameter("monto", monto) :
                new ObjectParameter("monto", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_agregarMulta", idTipoInfraccionParameter, idlocalidadParameter, idagenteParameter, patenteParameter, montoParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int SP_descalificar(Nullable<int> idfotografia)
        {
            var idfotografiaParameter = idfotografia.HasValue ?
                new ObjectParameter("idfotografia", idfotografia) :
                new ObjectParameter("idfotografia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_descalificar", idfotografiaParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_multasVehiculo_Result> sp_multasVehiculo(string patente)
        {
            var patenteParameter = patente != null ?
                new ObjectParameter("patente", patente) :
                new ObjectParameter("patente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_multasVehiculo_Result>("sp_multasVehiculo", patenteParameter);
        }
    
        public virtual ObjectResult<string> SP_NOMBREAGENTE(Nullable<int> iDAGENTE)
        {
            var iDAGENTEParameter = iDAGENTE.HasValue ?
                new ObjectParameter("IDAGENTE", iDAGENTE) :
                new ObjectParameter("IDAGENTE", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_NOMBREAGENTE", iDAGENTEParameter);
        }
    
        public virtual int SP_procesarPagos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_procesarPagos");
        }
    
        public virtual int SP_procesarPagos2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_procesarPagos2");
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int SP_SALUDITO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_SALUDITO");
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
