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
    
    public partial class AspNetCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetCustomer()
        {
            this.AspNetAgencies = new HashSet<AspNetAgency>();
            this.AspNetComanyServices = new HashSet<AspNetComanyService>();
            this.AspNetCustomer_SubCatageory = new HashSet<AspNetCustomer_SubCatageory>();
            this.AspNetDiscounts = new HashSet<AspNetDiscount>();
            this.AspNetInvoices = new HashSet<AspNetInvoice>();
        }
    
        public int Id { get; set; }
        public Nullable<int> DetailId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> ContactId { get; set; }
        public Nullable<int> BussinessID { get; set; }
        public Nullable<int> GalleryID { get; set; }
        public Nullable<int> RegionID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public Nullable<int> SmsID { get; set; }
        public string UserID { get; set; }
        public Nullable<int> WorkingID { get; set; }
        public Nullable<int> SocialID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetAgency> AspNetAgencies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetComanyService> AspNetComanyServices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetCustomer_SubCatageory> AspNetCustomer_SubCatageory { get; set; }
        public virtual AspNetCustomerBusinessDetail AspNetCustomerBusinessDetail { get; set; }
        public virtual AspNetCustomerContact AspNetCustomerContact { get; set; }
        public virtual AspNetCustomerDetail AspNetCustomerDetail { get; set; }
        public virtual AspNetCustomerGallery AspNetCustomerGallery { get; set; }
        public virtual AspNetCustomerLocation AspNetCustomerLocation { get; set; }
        public virtual AspNetCustomerRegion AspNetCustomerRegion { get; set; }
        public virtual AspNetSocial AspNetSocial { get; set; }
        public virtual AspNetCustomerSM AspNetCustomerSM { get; set; }
        public virtual AspNetCustomerType AspNetCustomerType { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetWorkingWeekTime AspNetWorkingWeekTime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetDiscount> AspNetDiscounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetInvoice> AspNetInvoices { get; set; }
    }
}
