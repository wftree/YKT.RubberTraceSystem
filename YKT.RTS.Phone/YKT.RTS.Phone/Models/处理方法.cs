

namespace YKT.RTS.Phone.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class 处理方法
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 处理方法()
        {
            this.检验修边 = new HashSet<检验修边>();
        }
    
        public System.Guid Id { get; set; }
        public string 处理方法1 { get; set; }
        public string 附件 { get; set; }
        public System.DateTime 登记时间 { get; set; }
        public bool 删除 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<检验修边> 检验修边 { get; set; }
    }
}
