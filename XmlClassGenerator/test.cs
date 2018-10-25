using System.Xml.Serialization;

namespace XmlClassGenerator
{
	public class test
	{
		[XmlType(AnonymousType = true)]
		[XmlRoot(Namespace = "", IsNullable = false)]
		public class softwareName
		{
			/// <remarks />
			[XmlAttribute]
			public byte id { get; set; }

			/// <remarks />
			[XmlText]
			public string Value { get; set; }
		}
	}

	public class test2
	{
		[XmlType(AnonymousType = true)]
		[XmlRoot(Namespace = "", IsNullable = false)]
		public class device
		{
			/// <remarks />
			public string softwareName { get; set; }
		}
	}
}