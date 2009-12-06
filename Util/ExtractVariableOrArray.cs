using System.Collections.Generic;

namespace FunctMetaL.Util
{
	/// <summary>
	/// Description of ExtractVariableOrArrayValue.
	/// </summary>
	public class ExtractVariableOrArray
	{
		public static string ExtractValue(string text)
		{
			Dictionary<string, string> replacement = 
				new Dictionary<string, string>();
			string strippedVariableName = string.Empty;
            string arrName = string.Empty;
			string variableValue = string.Empty;
            string arrayValue = string.Empty;
			string originalVariableName = string.Empty;
            int arrayIndex = -1;
            int index = -1;
			int startIndex = 0;
			int endIndex = 0;
			int length = 0;
            bool? variable = null;
			
			if (!string.IsNullOrEmpty(text))
			{
				while(startIndex != -1)
				{
					if (endIndex >= (text.Length - 1))
						break;

                    if ((text.IndexOf("@(", endIndex)) != -1)
                    {
                        string tmp = string.Empty;
                        string sub_text = string.Empty;
                        string stringToReplace = string.Empty;
                        startIndex = text.IndexOf("@(", endIndex);                       

                        sub_text = text.Substring(endIndex);
                        stringToReplace = sub_text.Substring((sub_text.IndexOf('[') + 1),
                            ((sub_text.IndexOf(']') - sub_text.IndexOf('[')) - 1));
                        tmp = ExtractName(stringToReplace);

                        if (Core.Variable.Variables.ContainsKey(tmp))
                            text = text.Replace(stringToReplace, Core.Variable.Variables[tmp]);

                        variable = false;
                    }
                    else if ((text.IndexOf("$(", endIndex)) != -1)
                    {
                        startIndex = text.IndexOf("$(", endIndex);
                        variable = true;
                    }
                    
                    else
                    {
                        return text;
                    }
                    
                    endIndex = text.IndexOf(")", startIndex);
                    length = (endIndex - startIndex);

                    originalVariableName = text.Substring(startIndex, length + 1);
                    strippedVariableName = text.Substring((startIndex + 2), length - 2);

                    if (variable.Value)
                    {
                        if (Core.Variable.Variables.ContainsKey(strippedVariableName))
                        {
                            variableValue = Core.Variable.Variables[strippedVariableName];
                            if (!replacement.ContainsKey(originalVariableName))
                                replacement.Add(originalVariableName, variableValue);
                        }
                    }
                    else
                    {
                        arrName = text.Substring((startIndex + 2), length - 5);
                        arrayIndex = strippedVariableName.IndexOf('[') + 1;

                        if (int.TryParse(strippedVariableName.Substring(arrayIndex, 1), out index))
                        {
                            if (Core.Array.Arrays.ContainsKey(arrName))
                            {
                                variableValue = Core.Array.Arrays[arrName][index];
                                if (!replacement.ContainsKey(originalVariableName))
                                    replacement.Add(originalVariableName, variableValue);
                            }
                        }
                        else
                        {
                            //Is it a variable?
                            string indexAsVariable = 
                                strippedVariableName.Substring((arrayIndex), strippedVariableName.IndexOf(']') - 1);
                            indexAsVariable = ExtractName(indexAsVariable);

                            if (Core.Variable.Variables.ContainsKey(indexAsVariable))
                            {
                                variableValue = Core.Variable.Variables[indexAsVariable];
                                arrayValue = Core.Array.Arrays[arrName][int.Parse(variableValue)];
                                if (!replacement.ContainsKey(originalVariableName))
                                    replacement.Add(originalVariableName, variableValue);
                            }
                        }
                    }					
				}
				if (replacement.Count > 0)
				{
					foreach(KeyValuePair<string, string> pair in replacement)
					{
						text = text.Replace(pair.Key, pair.Value);
					}
				}
				
				return text;
			}
			else
			{
				return text;
			}
		}
		
		public static string ExtractName(string text)
		{
			Dictionary<string, string> replacement = 
				new Dictionary<string, string>();
			string variableName = string.Empty;
			string variableValue = string.Empty;
			string originalVariableName = string.Empty;
			int startIndex = -1;
			int endIndex = 0;
			int length = 0;
			
			if (!string.IsNullOrEmpty(text))
			{
                if ((text.IndexOf("@(", endIndex)) != -1)
                {
                    startIndex = text.IndexOf("@(", endIndex);
                }
                else if ((text.IndexOf("$(", endIndex)) != -1)
                {
                    startIndex = text.IndexOf("$(", endIndex);
                }
                
                if (startIndex != -1)
                {
                    endIndex = text.IndexOf(")", startIndex);
                    length = (endIndex - startIndex);

                    originalVariableName = text.Substring(startIndex, length + 1);
                    variableName = text.Substring((startIndex + 2), length - 2);
                    
                    return variableName;
                }
			}
            return text;
			
		}
	}
}
