//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace modelfirstnew
{
    using System;
    using System.Collections.Generic;
    
    public partial class pro
    {
        public int pid { get; set; }
        public string ptype { get; set; }
        public double price { get; set; }
        public int cid { get; set; }
    
        public virtual cat cat { get; set; }
    }
}