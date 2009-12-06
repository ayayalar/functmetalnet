using System.Xml;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL.Core
{
    internal class DoWhile : ICore
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
            		do
            		{
            			if (Core.Break.BreakLoop)
            				break;
                        XmlToObject.GoToChild(node);
            		}
            		while (lOperand == rOperand);
                    break;
                case "-ne":
                    do
                    {
                    	if (Core.Break.BreakLoop)
            				break;
                    	XmlToObject.GoToChild(node);
                    }
                    while (lOperand != rOperand);
                    break;
                case "-lt":
                    do
                    {
                    	if (Core.Break.BreakLoop)
            				break;
                    	XmlToObject.GoToChild(node);
                    }
                    while (lOperand < rOperand);
                    break;
                case "-gt":
                    do
                    {
                    	if (Core.Break.BreakLoop)
            				break;
                    	XmlToObject.GoToChild(node);
                    }
                    while (lOperand > rOperand);
                    break;
            }

            XmlToObject.GoToSibling(node);
        }
    }
}
