//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DocSearch.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Updates
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Updates()
        {
            this.tbl_UpdatesData = new HashSet<tbl_UpdatesData>();
        }
    
        public int Update_ID { get; set; }
        public int Document_ID { get; set; }
        public string UpdateUser { get; set; }
        public System.DateTime UpdateTime { get; set; }
    
        public virtual tbl_Document tbl_Document { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_UpdatesData> tbl_UpdatesData { get; set; }
    }
}