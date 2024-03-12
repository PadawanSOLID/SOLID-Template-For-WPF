using System.Windows;
using System.Windows.Media;

namespace RibbonStyle.AttachProperties
{
    public class ControlsHelper
    {
        public static Brush GetNonActiveBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(NonActiveBackgroundProperty);
        }

        public static void SetNonActiveBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(NonActiveBackgroundProperty, value);
        }

        public static readonly DependencyProperty NonActiveBackgroundProperty =
            DependencyProperty.RegisterAttached("NonActiveBackground", typeof(Brush), typeof(ControlsHelper), new PropertyMetadata());





    }
}
