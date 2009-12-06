using System.Xml;
using FunctMetaL.Interpreter;

namespace FunctMetaL.Core
{
    internal class Break
    {
    	public static bool BreakLoop { get; set; }
    	
        public static void Parse(XmlNode node)
        {
        	BreakLoop  = true;
            XmlToObject.GoToSibling(node);
        }
    }
}
