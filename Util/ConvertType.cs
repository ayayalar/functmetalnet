/*
 * Created by SharpDevelop.
 * User: ayayalar
 * Date: 8/9/2009
 * Time: 2:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FunctMetaL.Util
{
	/// <summary>
	/// Description of ConvertType.
	/// </summary>
	public static class ConvertType
	{
		static ConvertType() {}
		static T Convert<T>(System.Xml.XmlNode node)
		{
			T type = default(T);
            
            //if (node.Attributes["type"] != null)
//            	type = Convert.ChangeType(node.Attributes["value"].Value,
//            	                          typeof(type));
//            
            return type;
		}
	}
}
