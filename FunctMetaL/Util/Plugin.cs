using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using FunctMetaL.Core;
using FunctMetaL.Interpreter;

namespace FunctMetaL.Util
{
    public class Plugin : Core.ICore
    {
        public static void Parse(XmlNode node)
        {
            foreach (XmlNode each_method in node.SelectNodes("Method"))
            {
                string @out = string.Empty;
                string plugin = node.Attributes["name"].Value;

                if (each_method.Attributes["out"] != null)
                    @out = each_method.Attributes["out"].Value;

                string method = string.Empty;
                string type = string.Empty;
                object instance = null;
                object result = null;
                Type[] types = null;
                Type selectedType = null;
                MethodInfo mi = null;
                ParameterInfo[] paramInfo = null;
                List<object> @params = new List<object>();

                if (Import.LoadedTypes.ContainsKey(plugin))
                {
                    types = Import.LoadedTypes[plugin];
                }

                method = each_method.Attributes["name"].Value;
                type = each_method.Attributes["type"].Value;

                foreach (XmlNode param in each_method.SelectNodes("Param"))
                {
                    @params.Add(param.InnerText);
                }

                var query = from t in types
                            from m in t.GetMethods()
                            where m.Name == method && t.Name == type
                            select t;

                selectedType = query.SingleOrDefault<Type>();

                if (selectedType == null)
                    throw new Exception(String.Format("{0} not found in any of the imported libraries.", method));

                instance = Activator.CreateInstance(selectedType);
                mi = selectedType.GetMethod(method);
                paramInfo = mi.GetParameters();

                for (int i = 0; i < @params.Count; i++)
                {
                    Type t = paramInfo[i].ParameterType;
                    object newType = Convert.ChangeType(@params[i], t);
                    @params[i] = newType;
                }

                result = mi.Invoke(instance, @params.ToArray());

                if (!String.IsNullOrEmpty(@out))
                    if (Variable.Variables.ContainsKey(@out))
                        Variable.Variables[@out] = result.ToString();
                    else
                        Variable.Variables.Add(@out, result.ToString());
            }
            XmlToObject.GoToSibling(node);
        }
    }
}
