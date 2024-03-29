//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kredi_Kartı_Takip.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CreditCard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CreditCard()
        {
            this.AddExpense = new HashSet<AddExpense>();
        }
    
        public int id { get; set; }
        public string bankName { get; set; }
        public string nameSurname { get; set; }
        public string number { get; set; }
        public string expireDate { get; set; }
        public Nullable<int> ccv { get; set; }
        public Nullable<System.DateTime> cutDate { get; set; }
        public Nullable<System.DateTime> paymentDueDate { get; set; }
        public string balance { get; set; }
        public Nullable<int> busniss { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AddExpense> AddExpense { get; set; }
    }
}
