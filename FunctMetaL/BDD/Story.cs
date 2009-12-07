using System.Xml;
using FunctMetaL.Interpreter;

namespace FunctMetaL.BDD
{
    internal class Story : Core.ICore
    {
        public static void Parse(XmlNode node)
        {
            int i = 0;
            foreach(XmlNode scenario in node)
            {
                XmlToObject.GoToChild(node, i);
                i++;
            }
            XmlToObject.GoToSibling(node);
        }
    }
}
