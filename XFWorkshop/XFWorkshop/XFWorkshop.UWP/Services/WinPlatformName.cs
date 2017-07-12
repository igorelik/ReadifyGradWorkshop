using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFWorkshop.Services;

namespace XFWorkshop.UWP.Services
{
    public class WinPlatformName: IPlatformName
    {
        public string PlatformSpecificName => "I am WIndows 10";
    }
}
