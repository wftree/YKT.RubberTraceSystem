

namespace YKT.RTS.Phone.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class 机台
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 机台()
        {
            this.皮囊成型 = new HashSet<皮囊成型>();
            this.皮囊硫化 = new HashSet<皮囊硫化>();
        }
    
        public System.Guid Id { get; set; }
        public string 机台编号 { get; set; }
        public string 机台名称 { get; set; }
        public string 机台描述 { get; set; }
        public System.DateTime 登记时间 { get; set; }
        public bool 删除 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<皮囊成型> 皮囊成型 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<皮囊硫化> 皮囊硫化 { get; set; }
    }
}
