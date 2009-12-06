using System.Xml;
using FunctMetaL.Interpreter;

namespace FunctMetaL.Core
{
    public class Main
    {
        static bool log = false;
        static XmlDocument doc = new XmlDocument();

        public static XmlDocument XmlDoc
        {
            get { return doc; }
            set { doc = value; }
        }

        public Main()
        {
            
        }

        public string TestSuite { get; set; }

        public static bool Log
        {
            get
            {
                return log;
            }
            set
            {
                log = value;
            }
        }
        public void Start()
        {
            if (TestSuite != null)
            {
                try
                {
                    doc.Load(this.TestSuite);
                }
                catch (XmlException xmlEx)
                {
                    Util.Logger.Log.Append(xmlEx.Message);
                }
                XmlToObject.Parser(doc.DocumentElement);
            }
        }
    }
}
