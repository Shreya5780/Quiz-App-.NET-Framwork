//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quiz.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_CATEGORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_CATEGORY()
        {
            this.TBL_QUESTIONS = new HashSet<TBL_QUESTIONS>();
        }
    
        public int CAT_ID { get; set; }
        public string CAT_NAME { get; set; }
        public Nullable<int> CAT_FK_ADID { get; set; }
        public string CAT_ENCYPTEDSTRING { get; set; }
    
        public virtual TBL_ADMIN TBL_ADMIN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_QUESTIONS> TBL_QUESTIONS { get; set; }
    }
}
