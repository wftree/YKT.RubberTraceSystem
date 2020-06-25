using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.Windows
{
    public class Auth
    {
        private static User user = null;

        public static User User { get => user; set => user = value; }
    }
}
