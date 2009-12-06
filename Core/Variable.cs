using System.Collections.Generic;
using System.Xml;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL.Core
{
    internal class Variable
    {
        static Dictionary<string, string> variables = 
            new Dictionary<string, string>();
        
        static Dictionary<string, string> tempVariables = 
            new Dictionary<string, string>();
        
        public static Dictionary<string, string> Variables
        {
        	get
        	{
        		return variables;
        	}
        }

        public static void Parse(XmlNode node)
        {            
            string name = GetNode.Value(node, "name");
            string value = GetNode.Value(node, "value");
            
            if (value != null)
            {
	            if (!variables.ContainsKey(name))
	                variables.Add(name, value);
	            else
	            	variables[name] = value;
            }
            XmlToObject.GoToSibling(node);
        }
    }
}
