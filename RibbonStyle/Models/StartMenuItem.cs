using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonStyle.Models
{
  public  class StartMenuItem
    {
        public string Icon { get; set; }
        public string Title { get; set; }

        public StartMenuItem(string icon,string title)
        {
            Icon = icon;
            Title = title;
        }
    }
}
