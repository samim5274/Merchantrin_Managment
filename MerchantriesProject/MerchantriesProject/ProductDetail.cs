//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MerchantriesProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductDetail
    {
        public int Id { get; set; }
        public Nullable<int> Barcode { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> ManufactureId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<decimal> SalesPrice { get; set; }
    
        public virtual CategoryDetail CategoryDetail { get; set; }
        public virtual ManufactureDetail ManufactureDetail { get; set; }
    }
}
