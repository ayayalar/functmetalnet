using System.Xml;
using FunctMetaL.Interpreter;

namespace FunctMetaL.BDD
{
    internal class Then
    {
        public static void Parse(XmlNode node)
        {
            XmlToObject.GoToNamedChild(node.SelectSingleNode("Action"));
            XmlToObject.GoToSibling(node);
        }
    }
}
