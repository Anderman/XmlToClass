using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using static System.String;

namespace XmlClassGenerator
{
	public class Program
	{
		public static Dictionary<string, Dictionary<string, string>> ClassNames = new Dictionary<string, Dictionary<string, string>>();
		public static void Main(string[] args)
		{
			var filename = args[0];

			var fr = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
			var doc = XDocument.Load(fr);
			if (doc.Root == null) return;
			var ns = doc.Root.Name.NamespaceName;
			var format = $@"
			#pragma warning disable IDE1006 // Naming Styles
			// ReSharper disable MemberHidesStaticFromOuterClass
			// ReSharper disable UnusedMember.Local
			// ReSharper disable UnusedMember.Global
			// ReSharper disable CheckNamespace
			// ReSharper disable InconsistentNaming
			// ReSharper disable IdentifierTypo
			// ReSharper disable StringLiteralTypo

			using System.Xml.Serialization;

			[XmlRoot(ElementName = `{doc.Root.Name.LocalName}`, Namespace = `{ns}`)]
			{WriteClass(doc.Root, 0, ns)}".Format();
			File.WriteAllText($"{filename.Replace(".xml", "")}.cs", format);
		}


		public static string WriteClass(XElement e, int i, string ns)
		{
			var tmp = ns;
			return $@"public class {GetClassName(e)}
				{Tabs(i)}{{{
					Concat(e.Attributes().Where(x => !x.IsNamespaceDeclaration && x.Name.Namespace.NamespaceName == "").Select(x =>
					{
						var type = GetTypeName(x.Value);
						var name = x.Name.LocalName;
						var value = GetValue(x.Value);
						//ns = x.Name.Namespace.NamespaceName;
						return $@"
					{Tabs(i)}[XmlAttribute(AttributeName = `{name}`)]
					{Tabs(i)}public {type} {name.ToCamelCase()} {{ get; set; }} = {value};";
					}))}{
					(!e.HasElements && e.Value != "" ? $@"
					{Tabs(i)}[XmlText]
					{Tabs(i)}public string {e.ToCamelCase()} {{ get; set; }} = `{e.Value}`;" : "")
					}{
					Concat(e.Elements().Where(x => x.HasElements || x.HasAttributes).GroupBy(x => x.Name.LocalName).Select(x => new { a = x.Count(), b = x.First() }).Select(x =>
					  {
						  ns = x.b.Name.Namespace.NamespaceName;
						  var name = x.b.Name.LocalName;
						  var type = GetClassTypeProperty(x.b, x.a);
						  return $@"
					{Tabs(i)}[XmlElement(ElementName = `{name}`{(tmp != ns ? $", Namespace = `{ns}`" : "")})]
					{Tabs(i)}public {type} {name.ToCamelCase()} {{ get; set; }} = {GetClassInstance(x.b, x.a)};
					{Tabs(i)}{WriteClass(x.b, i + 1, ns)}";
					  }))}{Concat(e.Elements().Where(x => !x.HasElements && !x.HasAttributes).GroupBy(x => x.Name.LocalName).Select(x => new { a = x.Count(), b = x.First() }).Select(x =>
					  {
						  var name = x.b.Name.LocalName;
						  return $@"
					{Tabs(i)}[XmlElement(ElementName = `{name}`{(tmp != ns ? $", Namespace = `{ns}`" : "")})]{(
								  x.a==1?$@"
					{Tabs(i)}public string {name.ToCamelCase()} {{ get; set; }} = `{x.b.Value}`;" :$@"
					{Tabs(i)}public string[] {name.ToCamelCase()} {{ get; set; }} = {{`{x.b.Value}`}};")}
						";
					  }))}
				{Tabs(i)}}}";

		}

		private static string GetClassInstance(XElement e, int n)
		{
			return $"new {GetClassName(e)}{(n > 1 ? $"[{n}]" : "()")}";
		}

		private static string GetClassTypeProperty(XElement e, int n)
		{
			return $"{GetClassName(e)}{(n > 1 ? "[]" : "")}";
		}

		private static string Tabs(int n) => new string('\t', n);

		public static string GetTypeName(string value)
		{
			return int.TryParse(value, out var _)
				? "int"
				: "string";
		}

		public static string GetValue(string value)
		{
			return int.TryParse(value, out var _)
				? value
				: $"\"{value}\"";
		}

		public static string GetClassName(XElement e)
		{
			var s = e.Name.LocalName.ToCamelCase();
			var p = GetPathName(e);
			if (!ClassNames.TryGetValue(s, out var paths))
				paths = ClassNames[s] = new Dictionary<string, string>();
			if (!paths.TryGetValue(p, out var cn))
				paths[p] = $"C{e.ToCamelCase()}{(paths.Count > 0 ? $"{paths.Count}" : "")}";
			return paths[p];
		}

		public static string GetPathName(XElement e)
		{
			return e.Parent == null ? e.Name.LocalName : $"{GetPathName(e.Parent)}{e.Name.LocalName}";
		}
	}
}
