using System.Xml;
using FunctMetaL.Interpreter;

namespace FunctMetaL.BDD
{
    internal class Scenario
    {
        public static void Parse(XmlNode node)
        {
            XmlToObject.GoToNamedChild(node.SelectSingleNode("Given"));
            XmlToObject.GoToSibling(node);
        }
    }
}
