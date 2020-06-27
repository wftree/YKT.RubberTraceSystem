

namespace YKT.RTS.Phone.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class 员工
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 员工()
        {
            this.检验修边 = new HashSet<检验修边>();
            this.帘布流转 = new HashSet<帘布流转>();
            this.皮囊成型 = new HashSet<皮囊成型>();
            this.皮囊硫化 = new HashSet<皮囊硫化>();
            this.橡胶薄片 = new HashSet<橡胶薄片>();
        }
    
        public System.Guid Id { get; set; }
        public string 姓名 { get; set; }
        public System.Guid 班别 { get; set; }
        public System.DateTime 登记时间 { get; set; }
        public bool 删除 { get; set; }

        [IgnoreDataMember]
        public virtual 班别 班别1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<检验修边> 检验修边 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<帘布流转> 帘布流转 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<皮囊成型> 皮囊成型 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<皮囊硫化> 皮囊硫化 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<橡胶薄片> 橡胶薄片 { get; set; }
    }
}
