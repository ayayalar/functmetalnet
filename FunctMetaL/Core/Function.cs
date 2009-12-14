using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL.Core
{
    internal class Function : ICore
    {
        static Dictionary<string, string> functionList =
            new Dictionary<string, string>();

        public static Dictionary<string, string> FunctionList
        {
            get { return Function.functionList; }
            set { Function.functionList = value; }
        }

        public static void Parse(XmlNode node)
        {
            string name = string.Empty;
            if (GetNode.Value(node, "name") != string.Empty)
            {
                name = GetNode.Value(node, "name");
                functionList.Add(name, name);
            }
            XmlToObject.GoToSibling(node);
        }
    }
}
