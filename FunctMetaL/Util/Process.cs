using System;
using System.Threading;
using System.Xml;
using FunctMetaL.Core;
using FunctMetaL.Interpreter;
using DProc = System.Diagnostics.Process;
using DProcStartInfo = System.Diagnostics.ProcessStartInfo;

namespace FunctMetaL.Util
{
    public class Process : ICore
    {
        public static void Parse(XmlNode node)
        {
            Thread t = null;
            ProcessData data = new ProcessData();
            string procName = ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "name"));
            string output = ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "output"));
            string error = ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "error"));
            int timeout = 0;
            if (GetNode.Value(node, "timeout") != string.Empty)
                timeout = int.Parse(ExtractVariableOrArray.ExtractValue(GetNode.Value(node, "timeout")));
                
            XmlNodeList arguments = node.ChildNodes[0].ChildNodes;
            data.procName = procName;
            data.output = output;
            data.error = error;
            data.timeout = timeout;
            data.arguments = arguments;

            t = new Thread(LaunchProcess);
            t.Start(data);
            t.Join();
                        
            XmlToObject.GoToSibling(node);
        }
        
        private static void LaunchProcess(object data)
        {
            ProcessData procData = (ProcessData)data;
            DProc proc = new DProc();
            DProcStartInfo startInfo = new DProcStartInfo();
            startInfo.FileName = procData.procName;

            foreach (XmlNode n in procData.arguments)
            {
                startInfo.Arguments += n.InnerText + " ";
            }
            startInfo.Arguments.TrimEnd();

            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            proc.StartInfo = startInfo;

            proc.Start();
            if (procData.timeout > 0)
                if (!proc.WaitForExit((int)TimeSpan.FromMinutes(procData.timeout).TotalMilliseconds))
                    throw new Exception("Process timed out.");


            if (!String.IsNullOrEmpty(procData.output))
            {
                if (Variable.Variables.ContainsKey(procData.output))
                    Variable.Variables[procData.output] = proc.StandardOutput.ReadToEnd();
                else
                    Variable.Variables.Add(procData.output, proc.StandardOutput.ReadToEnd());
            }

            if (!String.IsNullOrEmpty(procData.error))
            {
                if (Variable.Variables.ContainsKey(procData.error))
                    Variable.Variables[procData.error] = proc.StandardError.ReadToEnd();
                else
                    Variable.Variables.Add(procData.error, proc.StandardError.ReadToEnd());
            }
        }

        public struct ProcessData
        {
            public string procName;
            public string output;
            public string error;
            public int timeout;
            public XmlNodeList arguments;
        }
    }
}
