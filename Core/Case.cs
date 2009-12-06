using System;
using System.Xml;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL.Core
{
    class Case : ICore
    {
        internal static void Parse(XmlNode node)
        {
        	string switchCondition = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node.ParentNode, "condition"));
        	string caseCondition = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "condition"));
        	
        	if (!node.ParentNode.Name.Equals("Switch"))
        		throw new Exception("Case statement can not be used without 'Switch'");
        	else
        	{
        		if (switchCondition.Equals(caseCondition))
        		{
            		XmlToObject.GoToChild(node);
        		}
        		else
        		{                    
        			XmlToObject.GoToSibling(node.NextSibling["Case"]);
        		}
        	}
        }
    }
}
