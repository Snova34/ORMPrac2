//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORMPract2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            this.ORDERS = new HashSet<ORDERS>();
        }
    
        public int CUST_CODE { get; set; }
        public string CUST_NAME { get; set; }
        public string CUST_CITY { get; set; }
        public string WORKING_AREA { get; set; }
        public string CUST_COUNTRY { get; set; }
        public int GRADE { get; set; }
        public decimal OPENING_AMT { get; set; }
        public decimal RECEIVE_AMT { get; set; }
        public decimal PAYMENT_AMT { get; set; }
        public decimal OUTSTANDING_AMT { get; set; }
        public string PHONE_NO { get; set; }
        public int AGENTSAGENT_CODE { get; set; }
    
        public virtual AGENTS AGENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDERS> ORDERS { get; set; }
    }
}