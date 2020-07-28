

namespace YKT.RTS.Phone.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class 皮囊硫化
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 皮囊硫化()
        {
            this.检验修边 = new HashSet<检验修边>();
        }
    
        public System.Guid Id { get; set; }
        public string 产品型号 { get; set; }
        public System.Guid 生产机台 { get; set; }
        public System.Guid 作业员 { get; set; }
        public System.Guid 成型皮囊 { get; set; }
        public Nullable<double> 硫化温度 { get; set; }
        public Nullable<double> 硫化时间 { get; set; }
        public Nullable<System.Guid> 模具 { get; set; }

        public System.DateTime 生产时间 { get; set; }
        public System.DateTime 登记时间 { get; set; }
        public bool 删除 { get; set; }
        [IgnoreDataMember]
        public virtual 机台 机台 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<检验修边> 检验修边 { get; set; }
        [IgnoreDataMember]
        public virtual 皮囊成型 皮囊成型 { get; set; }
        [IgnoreDataMember]
        public virtual 员工 员工 { get; set; }
    }
}
