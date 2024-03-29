//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Multas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Multas()
        {
            this.Pagos = new HashSet<Pagos>();
        }
    
        public int IdMulta { get; set; }
        public int IdTipoInfraccion { get; set; }
        public int IDLocalidad { get; set; }
        public Nullable<int> IdAgente { get; set; }
        public string Patente { get; set; }
        public System.DateTime FechaHora { get; set; }
        public decimal Monto { get; set; }
        public bool Pagada { get; set; }
    
        public virtual Agentes Agentes { get; set; }
        public virtual Localidades Localidades { get; set; }
        public virtual TipoInfracciones TipoInfracciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos> Pagos { get; set; }
    }
}
