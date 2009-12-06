using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using FunctMetaL.Core;
using FunctMetaL.Interpreter;

namespace FunctMetaL.Util
{
    class Import : ICore
    {
        static Dictionary<string, Type[]> loadedTypes = new Dictionary<string, Type[]>();

        public static Dictionary<string, Type[]> LoadedTypes
        {
            get { return Import.loadedTypes; }
            set { Import.loadedTypes = value; }
        }
        public static void Parse(XmlNode node)
        {
            string libsPath = Path.Combine(".", "libs");
            string dll = node.Attributes["dll"].Value;
            try
            {
               
                Assembly assembly = Assembly.LoadFrom(Path.Combine(libsPath, dll));
                Type[] types = assembly.GetTypes();

                if (!loadedTypes.ContainsKey(dll))
                    loadedTypes.Add(dll, types);

                XmlToObject.GoToSibling(node);
            }
            catch (FileNotFoundException fnfEx)
            {
                throw new Exception(String.Format("{0} not found.", 
                    Path.Combine(libsPath, dll)) , fnfEx);
            }
        }
    }
}
