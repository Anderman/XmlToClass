using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Xunit;

namespace XmlClassGenerator.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void Xml_file_can_generate_class()
		{
			Program.Main(new[]{ "C:/git/XmlClassGenerator/XmlClassGenerator.Tests/Resources/dbc.xml"});
		}
		[Fact]
		public void xml_can_deserialized_to_class()
		{

			var fs= File.Open("C:/git/XmlClassGenerator/XmlClassGenerator.Tests/Resources/dbc.xml",FileMode.Open,FileAccess.Read,FileShare.Read );
			var s = new XmlSerializer(typeof(CEnvelope));
			var result = s.Deserialize(fs);
			Assert.NotNull(result);
			
		}

		[Fact]
		public void Class_can_serialized_to_xml()
		{
			var fs = File.Open("C:/git/XmlClassGenerator/XmlClassGenerator.Tests/Resources/dbc.new.xml", FileMode.Create);
			var s = new XmlSerializer(typeof(CEnvelope));
			var cEnvelope = new CEnvelope();
			s.Serialize(fs,cEnvelope);
		}

		[Fact]
		public void ReadWriteTest()
		{

			var contentOrg = File.ReadAllText("C:/git/XmlClassGenerator/XmlClassGenerator.Tests/Resources/dbc.xml");
			var fsRead = File.Open("C:/git/XmlClassGenerator/XmlClassGenerator.Tests/Resources/dbc.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
			var s = new XmlSerializer(typeof(CEnvelope));
			var resultRead = s.Deserialize(fsRead);

			var ms = new MemoryStream();
			s.Serialize(ms, resultRead);
			var content =Encoding.ASCII.GetString(ms.ToArray()).Replace(" />", "/>");
			File.WriteAllText("C:/git/XmlClassGenerator/XmlClassGenerator.Tests/Resources/dbc.read.write.xml",content);

			var testOrg = string.Join('\n',contentOrg.Split('\n').Skip(3).Take(208));
			var testNew = string.Join('\n',content.Split('\n').Skip(4).Take(208));
			Assert.Equal(testOrg,testNew);
		}

	}
}
