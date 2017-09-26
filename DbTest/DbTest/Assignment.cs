//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assignment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Assignment()
        {
            this.Solutions = new HashSet<Solution>();
        }
    
        public int AssignmentId { get; set; }
        public string Title { get; set; }
        public System.DateTime PostedDate { get; set; }
        public string TeacherName { get; set; }
        public System.DateTime Deadline { get; set; }
        public Nullable<int> BatchId { get; set; }
        public string Document { get; set; }
    
        public virtual Batch Batch { get; set; }
        public virtual LoginInfo LoginInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solution> Solutions { get; set; }
    }
}
