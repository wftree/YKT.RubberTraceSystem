

namespace YKT.RTS.Phone.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class 橡胶薄片
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 橡胶薄片()
        {
            this.皮囊成型 = new HashSet<皮囊成型>();
            this.皮囊成型1 = new HashSet<皮囊成型>();
        }
    
        public System.Guid Id { get; set; }
        public double 宽度 { get; set; }
        public double 厚度 { get; set; }
        public double 数量 { get; set; }
        public System.Guid 作业员 { get; set; }
        public System.Guid 胶料批号 { get; set; }
        public double 生产序号 { get; set; }
        public System.DateTime 生产时间 { get; set; }
        public System.DateTime 登记时间 { get; set; }
        public bool 删除 { get; set; }

        [IgnoreDataMember]
        public virtual 胶料入库 胶料入库 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<皮囊成型> 皮囊成型 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<皮囊成型> 皮囊成型1 { get; set; }
        [IgnoreDataMember]
        public virtual 员工 员工 { get; set; }
    }
}
