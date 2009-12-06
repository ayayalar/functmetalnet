using System;
using System.Text;

namespace FunctMetaL.Util
{
    public static class Logger
    {
        static StringBuilder log = new StringBuilder();

        public static StringBuilder Log
        {
            get { return Logger.log; }
            set { Logger.log = value; }
        }

        public static void Write(string value)
        {
            log.Append(String.Format("{0}{1}", value, System.Environment.NewLine));
            
        }

        public static void Clear()
        {
            log.Remove(0, log.Length);
        }
    }
}
