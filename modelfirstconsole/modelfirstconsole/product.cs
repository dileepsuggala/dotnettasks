//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace modelfirstconsole
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int Pid { get; set; }
        public string Ptype { get; set; }
        public double Price { get; set; }
        public int category_cid { get; set; }
    
        public virtual category category { get; set; }
    }
}
