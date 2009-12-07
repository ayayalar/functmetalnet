using System;
using System.Xml;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL.Core
{
    class If : ICore
    {
        internal static void Parse(XmlNode node)
        {
            string test = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "test"));
            string condition = test.Split().GetValue(1).ToString();
            string left = Util.ExtractVariableOrArray.ExtractValue(test.Split().GetValue(0).ToString());
            string right = Util.ExtractVariableOrArray.ExtractValue(test.Split().GetValue(2).ToString());

            if (String.IsNullOrEmpty(left) || String.IsNullOrEmpty(right) ||
                String.IsNullOrEmpty(test))
                throw new Exception("Test condition is not constructed correctly.");
            
            int lOperand = int.Parse(left);
            int rOperand = int.Parse(right);

            XmlAttribute attr = node.OwnerDocument.CreateAttribute("IfEvaluatedTrue");

            switch (condition.Trim())
            {
                    
                case "-eq":
                    if (left.Equals(right))
                    {
                    	attr.Value = "True";
                    	node.Attributes.Append(attr);
                        XmlToObject.GoToChild(node);
                    }
                    else
                        XmlToObject.GoToSibling(node);
                    break;
                case "-ne":
                    if (!left.Equals(right))
                    {
                    	attr.Value = "True";
                    	node.Attributes.Append(attr);
                        XmlToObject.GoToChild(node);
                    }
                    else
                        XmlToObject.GoToSibling(node);
                    break;
                case "-lt":
                    if (lOperand < rOperand)
                    {
                    	attr.Value = "True";
                    	node.Attributes.Append(attr);
                        XmlToObject.GoToChild(node);
                    }
                    else
                        XmlToObject.GoToSibling(node);
                    break;
                case "-gt":
                    if (lOperand > rOperand)
                    {
                    	attr.Value = "True";
                    	node.Attributes.Append(attr);
                        XmlToObject.GoToChild(node);
                    }
                    else
                        XmlToObject.GoToSibling(node);
                    break;
            }      
        }
    }
}
