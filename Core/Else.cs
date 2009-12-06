using System;
using System.Xml;
using FunctMetaL.Interpreter;

namespace FunctMetaL.Core
{
    internal class Else : ICore
    {
        public static void Parse(XmlNode node)
        {
        	if (node.PreviousSibling.Name != "If")
        		throw new Exception("Else statement can not be used without 'If'");
        	
        	if (node.PreviousSibling.Attributes.GetNamedItem("IfEvaluatedTrue") == null)
        	{
	        	XmlToObject.GoToChild(node);
        	}
        	else
        	{
        		if (!node.PreviousSibling.Attributes["IfEvaluatedTrue"].Value.Equals("True"))
	            	XmlToObject.GoToChild(node);
        	}
            XmlToObject.GoToSibling(node);
        }
    }
}
