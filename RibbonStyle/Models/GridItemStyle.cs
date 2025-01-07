using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace RibbonStyle.Models
{
    public class GridItemStyle
    {
        public string Name { get; set; }
        public Thickness BorderThickness { get; set; } = new(0);
        public Brush Background { get; set; }=Brushes.White;
        public Brush Foreground { get; set; } = Brushes.Black;
        public string FontFamily { get; set; } = "STSong";
        public bool IsUnderlined { get; set; } = false;
    }
}
