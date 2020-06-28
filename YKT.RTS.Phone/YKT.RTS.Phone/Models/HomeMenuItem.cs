using System;
using System.Collections.Generic;
using System.Text;

namespace YKT.RTS.Phone.Models
{
    public enum MenuItemType
    {
        Work,
        Setting,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
