//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TShirts.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Design
    {
        public Design()
        {
            this.OrderLines = new HashSet<OrderLine>();
            this.Pictures = new HashSet<Picture>();
            this.Texts = new HashSet<Text>();
        }
    
        public int ID { get; set; }
        public int ProductColorID { get; set; }
        public string Notes { get; set; }
    
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ProductColor ProductColor { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual ICollection<Text> Texts { get; set; }
    }
}
