using System;
using System.Xml;
using FunctMetaL.Interpreter;

namespace FunctMetaL.BDD
{
    internal class When
    {
        public static void Parse(XmlNode node)
        {
            XmlToObject.GoToNamedChild(node.SelectSingleNode("Action"));

            if (node.NextSibling.Name.Equals("When") || node.NextSibling.Name.Equals("Then"))
                XmlToObject.GoToNamedSibling(node.NextSibling);
            else
                throw new Exception("When or Then block expected");
        }
    }
}
