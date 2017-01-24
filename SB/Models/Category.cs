using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.Models
{
    public class Category
    {
        public string Name;
        public string Icon;
        public Category(string name, string icon)
        {
            Name = name;
            Icon = icon;
        }
        public Category()
        {

        }
    }
}
