//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace schematask
{
    using System;
    using System.Collections.Generic;
    
    public partial class invigilator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public invigilator()
        {
            this.arrangements = new HashSet<arrangement>();
        }
    
        public int invigilatorid { get; set; }
        public string iname { get; set; }
        public string workingschool { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arrangement> arrangements { get; set; }
    }
}