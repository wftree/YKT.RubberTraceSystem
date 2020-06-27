

namespace YKT.RTS.Phone.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class 胶料入库
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 胶料入库()
        {
            this.橡胶薄片 = new HashSet<橡胶薄片>();
        }
    
        public System.Guid Id { get; set; }
        public string 胶料牌号 { get; set; }
        public string 箱号 { get; set; }
        public string 生产线号 { get; set; }
        public string 供应商产品代号 { get; set; }
        public System.DateTime 生产日期 { get; set; }
        public string 批次号 { get; set; }
        public double 重量 { get; set; }
        public System.DateTime 登记时间 { get; set; }
        public bool 删除 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<橡胶薄片> 橡胶薄片 { get; set; }
    }
}
