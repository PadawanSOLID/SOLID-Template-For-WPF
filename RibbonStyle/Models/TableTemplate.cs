using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonStyle.Models
{
    public class TableTemplate
    {
        public TableTemplate(string path, string name)
        {
            Path = path;
            Name = name;
        }
        public string Path { get; set; }
        public string Name { get; set; }
    }
}
