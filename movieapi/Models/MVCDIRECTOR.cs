//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MVCDIRECTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MVCDIRECTOR()
        {
            this.MVCMOVIES = new HashSet<MVCMOVy>();
        }
    
        public int DIRID { get; set; }
        public string DIRNAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MVCMOVy> MVCMOVIES { get; set; }
    }
}
