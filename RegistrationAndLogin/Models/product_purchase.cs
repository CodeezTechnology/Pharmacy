//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationAndLogin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product_purchase
    {
        public int purchase_id { get; set; }
        public int supplier_id { get; set; }
        public Nullable<System.DateTime> purchase_date { get; set; }
        public Nullable<decimal> total_amount { get; set; }
    
        public virtual supplier supplier { get; set; }
    }
}
