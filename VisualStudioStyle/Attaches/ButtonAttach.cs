using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VisualStudioStyle.Attaches
{
   public class ButtonAttach
    {


        public static string GetIcon(DependencyObject obj)
        {
            return (string)obj.GetValue(IconProperty);
        }

        public static void SetIcon(DependencyObject obj, string value)
        {
            obj.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(string), typeof(ButtonAttach), new PropertyMetadata());



        public static string GetKeyGesture(DependencyObject obj)
        {
            return (string)obj.GetValue(KeyGestureProperty);
        }

        public static void SetKeyGesture(DependencyObject obj, string value)
        {
            obj.SetValue(KeyGestureProperty, value);
        }

        public static readonly DependencyProperty KeyGestureProperty =
            DependencyProperty.RegisterAttached("KeyGesture", typeof(string), typeof(ButtonAttach), new PropertyMetadata(default));


    }
}
