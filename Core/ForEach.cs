using System.Collections.Generic;
using System.Xml;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL.Core
{
    internal class ForEach
    {
        public static void Parse(XmlNode node)
        {
            string array = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "array"));
            List<string> arr = Array.Arrays[array];
            foreach (string item in arr)
            {
                XmlToObject.GoToChild(node);    
            }

            XmlToObject.GoToSibling(node);
        }
    }
}
