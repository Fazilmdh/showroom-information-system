//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Billing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Billing()
        {
            this.SoldProducts = new HashSet<SoldProduct>();
        }
    
        public int B_ID { get; set; }
        public int P_ID { get; set; }
        public string SelectedProducts { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int C_ID { get; set; }
        public string CustomerName { get; set; }
        public int phone { get; set; }
        public int PaymentID { get; set; }
        public string PaymentType { get; set; }
    
        public virtual CustomerMaster CustomerMaster { get; set; }
        public virtual Paymenttype Paymenttype1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoldProduct> SoldProducts { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
    }
}
