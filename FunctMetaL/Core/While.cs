using System.Xml;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL.Core
{
    internal class While : ICore
    {
        public static void Parse(XmlNode node)
        {
            
            string condition = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "condition"));
            string left = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "left"));
            string right = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "right"));
            int lOperand = int.Parse(left);
            int rOperand = int.Parse(right);

            switch (condition.Trim())
            {
                case "-eq":
            		while (lOperand == rOperand)
            		{
            			if (Core.Break.BreakLoop)
            				break;
                        XmlToObject.GoToChild(node);
            		}
                    break;
                case "-ne":
                    while (lOperand != rOperand)
                    {
                    	if (Core.Break.BreakLoop)
            				break;
                    	XmlToObject.GoToChild(node);
                    }
                    break;
                case "-lt":
                    while (lOperand < rOperand)
                    {
                    	if (Core.Break.BreakLoop)
            				break;
                    	XmlToObject.GoToChild(node);
                    }
                    break;
                case "-gt":
                    while (lOperand > rOperand)
                    {
                    	if (Core.Break.BreakLoop)
            				break;
                    	XmlToObject.GoToChild(node);
                    }
                    break;
            }
            XmlToObject.GoToSibling(node);
        }
    }
}
