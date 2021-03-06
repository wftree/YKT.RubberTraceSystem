

namespace YKT.RTS.Phone.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class 皮囊成型
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 皮囊成型()
        {
            this.皮囊硫化 = new HashSet<皮囊硫化>();
        }
    
        public System.Guid Id { get; set; }
        public string 产品型号 { get; set; }
        public Nullable<System.Guid> 生产机台 { get; set; }
        public Nullable<System.Guid> 作业员 { get; set; }
        public System.Guid 帘布批号 { get; set; }
        public System.Guid 外胶片批号 { get; set; }
        public System.Guid 内胶片批号 { get; set; }

        public System.DateTime 生产时间 { get; set; }
        public System.DateTime 登记时间 { get; set; }
        public bool 删除 { get; set; }
        [IgnoreDataMember]
        public virtual 机台 机台 { get; set; }
        [IgnoreDataMember]
        public virtual 帘布流转 帘布流转 { get; set; }
        [IgnoreDataMember]
        public virtual 橡胶薄片 橡胶薄片 { get; set; }
        [IgnoreDataMember]
        public virtual 橡胶薄片 橡胶薄片1 { get; set; }
        [IgnoreDataMember]
        public virtual 员工 员工 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<皮囊硫化> 皮囊硫化 { get; set; }
    }
}
