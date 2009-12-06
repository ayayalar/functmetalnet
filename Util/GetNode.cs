using System.Xml;

namespace FunctMetaL.Util
{
	/// <summary>
	/// Description of GetNodeValue.
	/// </summary>
	public class GetNode
	{
		public static string Value(XmlNode node, string name)
		{
			if (node.Attributes[name] == null)
				return string.Empty;
			
			string value = node.Attributes[name].Value.Trim();
			
			return value;
		}
		
		public static string Name(XmlNode node, string name)
		{
			if (node.Attributes[name] == null)
				return string.Empty;
			
			string localName = node.Attributes[name].Name.Trim();
			
			return localName;
		}
		
	}
}
