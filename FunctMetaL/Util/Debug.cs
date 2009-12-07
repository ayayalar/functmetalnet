using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctMetaL.Util
{
    public class Debug : Core.ICore
    {
        public static void Parse(System.Xml.XmlNode node)
        {
        	System.Diagnostics.Debugger.Launch();
        }        
    }
}
