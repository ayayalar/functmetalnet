using System.Xml;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL.Core
{
    internal class Eval : ICore
    {
        public static void Parse(XmlNode node)
        {
        	string varName = Util.ExtractVariableOrArray.ExtractName(GetNode.Value(node, "variable"));
            string condition = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "expression"));
            string var = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "variable"));
            int varInt = int.Parse(var);

            switch (condition.Trim())
            {
                case "++":
            		varInt++;
                    break;
                case "--":
                    varInt--;
                    break;
            }
   
            Variable.Variables[varName] = varInt.ToString();
            XmlToObject.GoToSibling(node);
        }
    }
}
