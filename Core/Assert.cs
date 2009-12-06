using System.Xml;
using FunctMetaL.Interpreter;
using FunctMetaL.Util;

namespace FunctMetaL.Core
{
    internal class Assert : ICore
    {
        public static void Parse(XmlNode node)
        {
            string condition = GetNode.Value(node, "condition");
            string actual = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "actual"));
            string expected = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "expected"));
            string @out = Util.ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "out"));


            switch (condition.ToLower())
            {
                case "istrue":
                    if (actual.Equals(expected))
                    {
                        if (!Variable.Variables.ContainsKey(@out))
                            Variable.Variables.Add(@out, "true");
                        else
                            Variable.Variables[@out] = "true";

                        Util.Logger.Write(string.Format("Assert Actual: {0}, Expected: {1}, Condition: {2}, Result: {3}",
                            actual, expected, condition, "PASS"));
                    }
                    else
                    {
                        if (!Variable.Variables.ContainsKey(@out))
                            Variable.Variables.Add(@out, "false");
                        else
                            Variable.Variables[@out] = "false";

                        Util.Logger.Write(string.Format("Assert Actual: {0}, Expected: {1}, Condition: {2}, Result: {3}",
                            actual, expected, condition, "FAIL"));
                    }
                    break;
                case "isfalse":
                    if (!actual.Equals(expected))
                    {
                        if (!Variable.Variables.ContainsKey(@out))
                            Variable.Variables.Add(@out, "true");
                        else
                            Variable.Variables[@out] = "true";

                        Util.Logger.Write(string.Format("Assert Actual: {0}, Expected: {1}, Condition: {2}, Result: {3}",
                            actual, expected, condition, "PASS"));
                    }
                    else
                    {
                        if (!Variable.Variables.ContainsKey(@out))
                            Variable.Variables.Add(@out, "false");
                        else
                            Variable.Variables[@out] = "false";

                        Util.Logger.Write(string.Format("Assert Actual: {0}, Expected: {1}, Condition: {2}, Result: {3}",
                            actual, expected, condition, "FAIL"));
                    }
                    break;
                case "contains":
                    if (actual.Contains(expected))
                    {
                        if (!Variable.Variables.ContainsKey(@out))
                            Variable.Variables.Add(@out, "true");
                        else
                            Variable.Variables[@out] = "true";

                        Util.Logger.Write(string.Format("Assert Actual: {0}, Expected: {1}, Condition: {2}, Result: {3}",
                            actual, expected, condition, "PASS"));
                    }
                    else
                    {
                        if (!Variable.Variables.ContainsKey(@out))
                            Variable.Variables.Add(@out, "false");
                        else
                            Variable.Variables[@out] = "false";

                        Util.Logger.Write(string.Format("Assert Actual: {0}, Expected: {1}, Condition: {2}, Result: {3}",
                            actual, expected, condition, "FAIL"));
                    }
                    break;
                case "notcontains":
                    if (!actual.Contains(expected))
                    {
                        if (!Variable.Variables.ContainsKey(@out))
                            Variable.Variables.Add(@out, "true");
                        else
                            Variable.Variables[@out] = "true";

                        Util.Logger.Write(string.Format("Assert Actual: {0}, Expected: {1}, Condition: {2}, Result: {3}",
                            actual, expected, condition, "PASS"));
                    }
                    else
                    {
                        if (!Variable.Variables.ContainsKey(@out))
                            Variable.Variables.Add(@out, "false");
                        else
                            Variable.Variables[@out] = "false";

                        Util.Logger.Write(string.Format("Assert Actual: {0}, Expected: {1}, Condition: {2}, Result: {3}",
                            actual, expected, condition, "FAIL"));
                    }
                    break;
            }
            
            XmlToObject.GoToSibling(node);
        }
    }
}
