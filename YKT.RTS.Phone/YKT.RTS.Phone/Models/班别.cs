

namespace YKT.RTS.Phone.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class 班别
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 班别()
        {
            this.员工 = new HashSet<员工>();
        }
    
        public System.Guid Id { get; set; }
        public string 班别1 { get; set; }
        public System.DateTime 登记时间 { get; set; }
        public bool 删除 { get; set; }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<员工> 员工 { get; set; }
    }
}
