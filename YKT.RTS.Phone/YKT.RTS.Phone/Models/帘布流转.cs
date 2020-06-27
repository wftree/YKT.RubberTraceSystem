

namespace YKT.RTS.Phone.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class 帘布流转
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 帘布流转()
        {
            this.皮囊成型 = new HashSet<皮囊成型>();
        }
    
        public System.Guid Id { get; set; }
        public string 产品编号 { get; set; }
        public double 宽度 { get; set; }
        public double 厚度 { get; set; }
        public double 角度 { get; set; }
        public Nullable<System.Guid> 作业员 { get; set; }
        public System.Guid 帘布批号 { get; set; }
        public System.DateTime 使用期限 { get; set; }
        public System.DateTime 登记时间 { get; set; }
        public bool 删除 { get; set; }

        [IgnoreDataMember]
        public virtual 帘布入库 帘布入库 { get; set; }
        [IgnoreDataMember]
        public virtual 员工 员工 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<皮囊成型> 皮囊成型 { get; set; }
    }
}
