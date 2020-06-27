using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace YKT.RubberTraceSystem.Phone.Models
{
    public class SettingItem
    {
        [PrimaryKey]
        public string Name { get; set; }

        public string Value { get; set; }

    }
}
