using System;
using System.Xml;

namespace FunctMetaL.Interpreter
{
    class XmlToObject
    {
        public static void Parser(XmlNode node)
        {
            if (node != null)
            {
                switch (node.Name)
                {
                    case "TestSuite":
                        TestSuite.Parse(node);
                        break;
                    case "Test":
                        Test.Parse(node);
                        break;
                    case "Array":
                        Core.Array.Parse(node);
                        break;
                    case "Assert":
                        Core.Assert.Parse(node);
                        break;
                    case "Break":
                        Core.Break.Parse(node);
                        break;
                    case "Debug":
                        Util.Debug.Parse(node);
                        break;
                    case "DoWhile":
                        Core.DoWhile.Parse(node);
                        break;
                    case "Eval":
                        Core.Eval.Parse(node);
                        break;
                    case "Error":
                        Core.Error.Parse(node);
                        break;
                    case "For":
                        Core.For.Parse(node);
                        break;
                    case "ForEach":
                        Core.ForEach.Parse(node);
                        break;
                    case "If":
                        Core.If.Parse(node);
                        break;
                    case "Else":
                        Core.Else.Parse(node);
                        break;
                    case "Switch":
                        Core.Switch.Parse(node);
                        break;
                    case "Case":
                        Core.Case.Parse(node);
                        break;
                    case "Message":
                        Core.Message.Parse(node);
                        break;
                    case "Variable":
                        Core.Variable.Parse(node);
                        break;
                    case "While":
                        Core.While.Parse(node);
                        break;
                    case "#comment":
                        Core.XmlComment.Parse(node);
                        break;
                    case "Process":
                        Util.Process.Parse(node);
                        break;
                    case "Plugin":
                        Util.Plugin.Parse(node);
                        break;
                    case "Import":
                        Util.Import.Parse(node);
                        break;
                    case "Story":
                        BDD.Story.Parse(node);
                        break;
                    case "Scenario":
                        BDD.Scenario.Parse(node);
                        break;
                    case "Given":
                        BDD.Given.Parse(node);
                        break;
                    case "When":
                        BDD.When.Parse(node);
                        break;
                    case "Then":
                        BDD.Then.Parse(node);
                        break;
                    case "Action":
                        BDD.Action.Parse(node);
                        break;
                    default:
                        throw new
                            Exception(string.Format("{0} not found.", node.Name));
                }
            }
        }

        public static void GoToSibling(XmlNode node)
        {
            if (node != null)
            {
                if (node.NextSibling != null)
                {
                    Parser(node.NextSibling);
                }

            }
        }

        public static void GoToNamedSibling(XmlNode node)
        {
            if (node != null)
            {
                Parser(node);
            }
        }

        public static void GoToChild(XmlNode node)
        {
            if (node.HasChildNodes)
            {
                Parser(node.ChildNodes[0]);
            }
        }

        public static void GoToNamedChild(XmlNode node)
        {
            if (node != null)
            {
                Parser(node);
            }
        }

        public static void GoToChild(XmlNode node, int index)
        {
            if (node.HasChildNodes)
            {
                Parser(node.ChildNodes[index]);
            }
        }

        public static void GoToChildOrSibling(XmlNode node)
        {
            if (node.HasChildNodes)
            {
                Parser(node.ChildNodes[0]);
            }
            else
            {
                Parser(node.NextSibling);
            }
        }
    }
}
