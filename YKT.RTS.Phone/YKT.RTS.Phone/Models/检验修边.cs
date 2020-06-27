

namespace YKT.RTS.Phone.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class 检验修边
    {
        public System.Guid Id { get; set; }
        public bool 结果 { get; set; }
        public System.Guid 处理方法 { get; set; }
        public System.Guid 检验员 { get; set; }
        public System.Guid 硫化皮囊 { get; set; }
        public System.DateTime 登记时间 { get; set; }
        public bool 删除 { get; set; }

        [IgnoreDataMember]
        public virtual 处理方法 处理方法1 { get; set; }
        [IgnoreDataMember]
        public virtual 皮囊硫化 皮囊硫化 { get; set; }
        [IgnoreDataMember]
        public virtual 员工 员工 { get; set; }
    }
}
