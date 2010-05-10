using System.Collections.Generic;
using System.Xml;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL.Core
{
    internal class Array : Base
    {
    	static Dictionary<string, List<string>> arraylist =
            new Dictionary<string, List<string>>();

        public static Dictionary<string, List<string>> Arrays
        {
            get { return Array.arraylist; }
        }
    	
        public static void Parse(XmlNode node)
        {
        	string name = string.Empty;
            string itemData = string.Empty;

        	if (GetNode.Value(node, "name") != string.Empty)
        	{
        		name = GetNode.Value(node, "name");
                if (!arraylist.ContainsKey(name))
                    arraylist.Add(name, new List<string>());
                else
                    arraylist[name] =  new List<string>();

                foreach (XmlNode item in node.SelectNodes("Item"))
                {
                    itemData = ExtractVariableOrArray.ExtractValue(item.InnerText);
                    arraylist[name].Add(itemData);
                }

        	}

        	XmlToObject.GoToSibling(node);
        }
    }
}
