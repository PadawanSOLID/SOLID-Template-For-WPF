using Fluent;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RibbonStyle.AttachProperties
{
    [StyleTypedProperty(Property = "Style", StyleTargetType = typeof(RibbonTabControl))]

    public class RibbonTabControlHelper
    {
        [AttachedPropertyBrowsableForType(typeof(RibbonTabControl))]
        public static Style GetStyle(DependencyObject obj) => (Style)obj.GetValue(StyleProperty);

        public static void SetStyle(DependencyObject obj, Style value) => obj.SetValue(StyleProperty, value);

        public static readonly DependencyProperty StyleProperty = DependencyProperty.RegisterAttached("Style", typeof(Style), typeof(RibbonTabControlHelper), new PropertyMetadata());



        public static Brush GetTabBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(TabBackgroundProperty);
        }

        public static void SetTabBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(TabBackgroundProperty, value);
        }

        public static readonly DependencyProperty TabBackgroundProperty =DependencyProperty.RegisterAttached("TabBackground", typeof(Brush), typeof(RibbonTabControlHelper), new PropertyMetadata());

        public static Brush GetContentBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ContentBackgroundProperty);
        }

        public static void SetContentBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(ContentBackgroundProperty, value);
        }

        public static readonly DependencyProperty ContentBackgroundProperty =DependencyProperty.RegisterAttached("ContentBackground", typeof(Brush), typeof(RibbonTabControlHelper), new PropertyMetadata());
    }
}
