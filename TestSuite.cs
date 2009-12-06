using System.Xml;
using FunctMetaL.Core;
using FunctMetaL.Interpreter;

namespace FunctMetaL
{
    public class TestSuite : ICore
    {
        public static void Parse(XmlNode node)
        {
            int i = 0;
            foreach(XmlNode testNode in node.SelectNodes("Test"))
            {
                XmlToObject.GoToChild(node, i);
                i++;            
            }
        }
    }
}
