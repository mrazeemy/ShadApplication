//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shad_BookingApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetCustomerSM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetCustomerSM()
        {
            this.AspNetAgencies = new HashSet<AspNetAgency>();
            this.AspNetCustomers = new HashSet<AspNetCustomer>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<int> RemainingSMS { get; set; }
        public string SmsPackageName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetAgency> AspNetAgencies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetCustomer> AspNetCustomers { get; set; }
        public virtual AspNetItem AspNetItem { get; set; }
    }
}
