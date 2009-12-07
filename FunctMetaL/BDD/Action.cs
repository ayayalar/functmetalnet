using System.Xml;
using FunctMetaL.Core;
using FunctMetaL.Interpreter;

namespace FunctMetaL.BDD
{
    internal class Action
    {
        public static void Parse(XmlNode node)
        {
            string text = Util.ExtractVariableOrArray.ExtractValue(node.InnerText.Trim());
            if (Main.Log)
            {
                Util.Logger.Write(text);
            }
            XmlToObject.GoToSibling(node);
        }
    }
}
