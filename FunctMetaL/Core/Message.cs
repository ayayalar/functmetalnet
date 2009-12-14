using System.Xml;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL.Core
{
    internal class Message
    {
        public static void Parse(XmlNode node)
        {
        	//string text = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "text"));
            string text = Util.ExtractVariableOrArray.Extract(GetNode.Value(node, "text"));
            if (Main.Log)
            {
                Util.Logger.Write(text);
            }
            XmlToObject.GoToSibling(node);
        }
    }
}
