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
    
    public partial class AspNetCustomerContact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetCustomerContact()
        {
            this.AspNetAgencies = new HashSet<AspNetAgency>();
            this.AspNetCustomers = new HashSet<AspNetCustomer>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Telephone1 { get; set; }
        public Nullable<int> Telephone2 { get; set; }
        public Nullable<int> Fax { get; set; }
        public string BussinessEmail { get; set; }
        public string Mobile { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetAgency> AspNetAgencies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetCustomer> AspNetCustomers { get; set; }
    }
}
