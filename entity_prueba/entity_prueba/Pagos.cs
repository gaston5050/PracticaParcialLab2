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
    
    public partial class Pagos
    {
        public long IDPago { get; set; }
        public int IDMulta { get; set; }
        public decimal Importe { get; set; }
        public System.DateTime Fecha { get; set; }
        public byte IDMedioPago { get; set; }
    
        public virtual MediosPago MediosPago { get; set; }
        public virtual Multas Multas { get; set; }
    }
}
