

namespace YKT.RTS.Phone.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class 帘布入库
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 帘布入库()
        {
            this.帘布流转 = new HashSet<帘布流转>();
        }
    
        public System.Guid Id { get; set; }
        public string 帘布代号 { get; set; }
        public string 胶料 { get; set; }
        public double 帘布长度 { get; set; }
        public Nullable<double> 生产序号 { get; set; }
        public System.DateTime 生产日期 { get; set; }
        public System.DateTime 有效日期 { get; set; }
        public double 重量 { get; set; }
        public System.DateTime 登记时间 { get; set; }
        public bool 删除 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<帘布流转> 帘布流转 { get; set; }
    }
}
