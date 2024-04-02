using Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonStyle.Interfaces
{
    public interface IRibbonViewSwitchService
    {
        void Register(Ribbon ribbon);
        void ToBegin();
        void ToMain();
    }
}
