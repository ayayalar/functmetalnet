using System.Xml;
using FunctMetaL.Interpreter;

namespace FunctMetaL.Core
{
    /// <summary>
    /// Description of XmlComment.
    /// </summary>
    internal class XmlComment
    {
        public static void Parse(XmlNode node)
        {
            XmlToObject.GoToSibling(node);
        }
    }
}
