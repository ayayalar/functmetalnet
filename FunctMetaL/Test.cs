using System;
using System.Xml;
using FunctMetaL.Core;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL
{
    class Test : ICore
    {
        public static void Parse(XmlNode node)
        {
            string test = GetNode.Value(node, "name");
            Util.Logger.Write(String.Format("Running test: {0}", test));
            XmlToObject.GoToChild(node);
            Util.Logger.Write("-".PadRight(20, '-'));
        }
    }
}
