using System;
using System.Text;
using System.Xml.Linq;

namespace XmlClassGenerator
{
	public static class StringExtensions
	{
		public static string Format(this string str)
		{
			return SqlFormat(str.Replace("`", "\""));
		}

		public static string SqlFormat(this string str)
		{
			str = str.Trim('\r', '\n');
			var ret = new StringBuilder();
			var tabsString = "";
			foreach (char c in str)
				if (c != '\t')
					break;
				else
					tabsString += "\t";
			var tabs = tabsString.Length;
			var lines = str.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
			foreach (var line in lines)

			{
				var tmp = (line.EndsWith(";")) ? line.TrimEnd(';').TrimEnd(' ') + ";" : line.TrimEnd(' ');
				ret.Append((tmp.StartsWith(tabsString) ? tmp.Substring(tabs).TrimEnd(' ') : tmp) + "\r\n");
			}

			var result = ret.ToString();
			return result.Trim('\r', '\n');
		}


		public static string ToCamelCase(this XElement value)
		{
			return value.Name.LocalName.ToCamelCase();
		}

		public static string ToCamelCase(this string value)
		{
			if (string.IsNullOrEmpty(value)) return null;
			var camelCase = "";
			var toUpper = true;
			var toLower = false;
			foreach (var c in value)
			{
				var chr = (c == 'ë') ? 'e' : c == 'Ë' ? 'E' : c;
				if (chr >= 'a' && chr <= 'z')
				{
					camelCase += toUpper ? char.ToUpper(chr) : chr;
					toLower = toUpper;
					toUpper = false;
					continue;
				}

				if (chr >= 'A' && chr <= 'Z')
				{
					camelCase += toLower ? char.ToLower(chr) : chr;
					toLower = true;
					toUpper = false;
					continue;
				}

				if (chr >= '0' && chr <= '9')
					camelCase += chr;
				toUpper = true;
			}

			return camelCase;
		}

	}
}