using System.Windows.Controls;
using System.Windows;
using VisualStudioStyle.ViewModels;

namespace VisualStudioStyle.StyleSelectors
{
    public class PanesStyleSelector : StyleSelector
    {
        public Style AnchorStyle
        {
            get;
            set;
        }

        public Style FileStyle
        {
            get;
            set;
        }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            return item switch
            {
                AnchorVMBase => AnchorStyle,
                _ => FileStyle,
            };
        }
    }
}
