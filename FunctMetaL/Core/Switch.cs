using System;
using System.Xml;
using FunctMetaL.Interpreter;

namespace FunctMetaL.Core
{
    internal class Switch : ICore
    {
        public static void Parse(XmlNode node)
        {
        	if (!node.ChildNodes[0].Name.Equals("Case"))
        		throw new Exception("Syntax error. Switch expects 'Case' statement");
        	
        	XmlToObject.GoToChild(node.SelectSingleNode("Case"));
            XmlToObject.GoToSibling(node);
        }
    }
}
