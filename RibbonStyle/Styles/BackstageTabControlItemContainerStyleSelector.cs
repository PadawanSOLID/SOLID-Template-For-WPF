using Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Button = Fluent.Button;

namespace RibbonStyle.Styles
{
    public class BackstageTabControlItemContainerStyleSelector : StyleSelector
    {
        public static BackstageTabControlItemContainerStyleSelector Instance { get; } = new();

        /// <inheritdoc />
        public override Style? SelectStyle(object item, DependencyObject container)
        {
            switch (item)
            {
                case Button _:
                    return (container as FrameworkElement)?.TryFindResource("Fluent.Ribbon.Styles.BackstageTabControl.Button") as Style;

                case SeparatorTabItem _:
                    return (container as FrameworkElement)?.TryFindResource("separatorTabItem") as Style;

                case BackstageTabItem _:
                    return (container as FrameworkElement)?.TryFindResource("backstageTabItemStyle") as Style;

            }

            return base.SelectStyle(item, container);
        }
    }
}
