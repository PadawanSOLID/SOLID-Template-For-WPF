using Fluent;
using RibbonStyle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonStyle.Services
{
    public class RibbonViewSwitchService: IRibbonViewSwitchService
    {
        Ribbon _ribbon;

        public void Register(Ribbon ribbon)
        {
            if (ribbon==null)
            {
                _ribbon = ribbon;
            }
        }
        public void ToBegin()
        {
            if (!_ribbon.StartScreen.IsOpen)
            {
                _ribbon.StartScreen.IsOpen = true;
            }
        }
        public void ToMain()
        {
            if (_ribbon.StartScreen.IsOpen)
            {
                _ribbon.StartScreen.IsOpen = false;
            }
        }
    }
}
