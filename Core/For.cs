using System.Xml;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL.Core
{
    internal class For
    {
        public static void Parse(XmlNode node)
        {
            
        	int start = int.Parse(Util.ExtractVariableOrArray.ExtractValue(
        		GetNode.Value(node, "from")));
        	int to = int.Parse(Util.ExtractVariableOrArray.ExtractValue(
        		GetNode.Value(node, "to")));
            
            for (int i = start; start <= to; start++)
            {
                XmlToObject.GoToChild(node);
            }

            XmlToObject.GoToSibling(node);
        }
    }
}
