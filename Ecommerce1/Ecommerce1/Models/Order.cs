//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecommerce1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public int UserId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string ProcessType { get; set; }
        public Nullable<int> PacketId { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
