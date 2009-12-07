using System;
using System.Xml;
using FunctMetaL.Interpreter;

namespace FunctMetaL.BDD
{
    internal class Given
    {
        public static void Parse(XmlNode node)
        {
            XmlToObject.GoToNamedChild(node.SelectSingleNode("Action"));

            if (node.NextSibling.Name.Equals("When"))
                XmlToObject.GoToNamedSibling(node.NextSibling);
            else
                throw new Exception("When block expected");
        }
    }
}
