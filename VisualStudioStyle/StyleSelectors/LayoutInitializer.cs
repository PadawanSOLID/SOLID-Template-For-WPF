using AvalonDock.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualStudioStyle.ViewModels;

namespace VisualStudioStyle.StyleSelectors
{
    public class LayoutInitializer : ILayoutUpdateStrategy
    {
        public void AfterInsertAnchorable(LayoutRoot layout, LayoutAnchorable anchorableShown)
        {
           
        }

        public void AfterInsertDocument(LayoutRoot layout, LayoutDocument anchorableShown)
        {
        }

        public bool BeforeInsertAnchorable(LayoutRoot layout, LayoutAnchorable anchorableToShow, ILayoutContainer destinationContainer)
        {
            LayoutAnchorablePane destPane = destinationContainer as LayoutAnchorablePane;
            if (destinationContainer != null && destinationContainer.FindParent<LayoutFloatingWindow>() != null)
                return false;
            anchorableToShow.AutoHideWidth = 256;
            anchorableToShow.CanShowOnHover = false;
            string paneName = default;
            switch (anchorableToShow.Content)
            {
                case GitChangeViewModel:
                    paneName = "Git更改";
                    break;
                default:
                    return false;
            }
           var pane= layout.Descendents().OfType<LayoutAnchorablePane>().FirstOrDefault(d=>d.Name==paneName);
            if (pane != null)
            {
                pane.Children.Add(anchorableToShow);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BeforeInsertDocument(LayoutRoot layout, LayoutDocument anchorableToShow, ILayoutContainer destinationContainer)
        {
            return false;
        }
    }
}
