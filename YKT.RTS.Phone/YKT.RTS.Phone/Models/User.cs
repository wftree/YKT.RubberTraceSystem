

namespace YKT.RTS.Phone.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string MD5 { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
