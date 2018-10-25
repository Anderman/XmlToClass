#pragma warning disable IDE1006 // Naming Styles
// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedMember.Global
// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo

using System.Xml.Serialization;

[XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class CEnvelope
	{
		[XmlElement(ElementName = "Body")]
		public CBody Body { get; set; } = new CBody();
		public class CBody
		{
			[XmlElement(ElementName = "FICR_IN910101NL04", Namespace = "urn:hl7-org:v3")]
			public CFicrin910101nl04 Ficrin910101nl04 { get; set; } = new CFicrin910101nl04();
			public class CFicrin910101nl04
			{
				[XmlElement(ElementName = "id")]
				public CId Id { get; set; } = new CId();
				public class CId
				{
					[XmlAttribute(AttributeName = "extension")]
					public string Extension { get; set; } = "4CBD2F90-1E9C-4A65-B44C-2915D77E0330";
					[XmlAttribute(AttributeName = "root")]
					public string Root { get; set; } = "2.16.840.1.113883.2.4.3.27.15.99.1.4.1";
				}
				[XmlElement(ElementName = "creationTime")]
				public CCreationTime CreationTime { get; set; } = new CCreationTime();
				public class CCreationTime
				{
					[XmlAttribute(AttributeName = "value")]
					public string Value { get; set; } = "20180930172905";
				}
				[XmlElement(ElementName = "versionCode")]
				public CVersionCode VersionCode { get; set; } = new CVersionCode();
				public class CVersionCode
				{
					[XmlAttribute(AttributeName = "code")]
					public string Code { get; set; } = "NICTIZEd2005-Okt";
				}
				[XmlElement(ElementName = "interactionId")]
				public CInteractionId InteractionId { get; set; } = new CInteractionId();
				public class CInteractionId
				{
					[XmlAttribute(AttributeName = "extension")]
					public string Extension { get; set; } = "FICR_IN910101NL04";
					[XmlAttribute(AttributeName = "root")]
					public string Root { get; set; } = "2.16.840.1.113883.1.6";
				}
				[XmlElement(ElementName = "profileId")]
				public CProfileId ProfileId { get; set; } = new CProfileId();
				public class CProfileId
				{
					[XmlAttribute(AttributeName = "extension")]
					public string Extension { get; set; } = "4.0";
					[XmlAttribute(AttributeName = "root")]
					public string Root { get; set; } = "2.16.840.1.113883.2.4.3.27.15.12";
				}
				[XmlElement(ElementName = "processingCode")]
				public CProcessingCode ProcessingCode { get; set; } = new CProcessingCode();
				public class CProcessingCode
				{
					[XmlAttribute(AttributeName = "code")]
					public string Code { get; set; } = "T";
				}
				[XmlElement(ElementName = "processingModeCode")]
				public CProcessingModeCode ProcessingModeCode { get; set; } = new CProcessingModeCode();
				public class CProcessingModeCode
				{
					[XmlAttribute(AttributeName = "code")]
					public string Code { get; set; } = "T";
				}
				[XmlElement(ElementName = "acceptAckCode")]
				public CAcceptAckCode AcceptAckCode { get; set; } = new CAcceptAckCode();
				public class CAcceptAckCode
				{
					[XmlAttribute(AttributeName = "code")]
					public string Code { get; set; } = "NE";
				}
				[XmlElement(ElementName = "acknowledgement")]
				public CAcknowledgement Acknowledgement { get; set; } = new CAcknowledgement();
				public class CAcknowledgement
				{
					[XmlAttribute(AttributeName = "typeCode")]
					public string TypeCode { get; set; } = "AA";
					[XmlElement(ElementName = "targetMessage")]
					public CTargetMessage TargetMessage { get; set; } = new CTargetMessage();
					public class CTargetMessage
					{
						[XmlElement(ElementName = "id")]
						public CId1 Id { get; set; } = new CId1();
						public class CId1
						{
							[XmlAttribute(AttributeName = "extension")]
							public string Extension { get; set; } = "JWOGXFRVCCAAA";
							[XmlAttribute(AttributeName = "root")]
							public string Root { get; set; } = "2.16.528.1.1007.3.3.4021.1.1";
						}
					}
				}
				[XmlElement(ElementName = "receiver")]
				public CReceiver Receiver { get; set; } = new CReceiver();
				public class CReceiver
				{
					[XmlElement(ElementName = "device")]
					public CDevice Device { get; set; } = new CDevice();
					public class CDevice
					{
						[XmlElement(ElementName = "id")]
						public CId2 Id { get; set; } = new CId2();
						public class CId2
						{
							[XmlAttribute(AttributeName = "nullFlavor")]
							public string NullFlavor { get; set; } = "NA";
						}
					}
				}
				[XmlElement(ElementName = "sender")]
				public CSender Sender { get; set; } = new CSender();
				public class CSender
				{
					[XmlElement(ElementName = "device")]
					public CDevice1 Device { get; set; } = new CDevice1();
					public class CDevice1
					{
						[XmlElement(ElementName = "id")]
						public CId3 Id { get; set; } = new CId3();
						public class CId3
						{
							[XmlAttribute(AttributeName = "extension")]
							public int Extension { get; set; } = 4;
							[XmlAttribute(AttributeName = "root")]
							public string Root { get; set; } = "2.16.840.1.113883.2.4.3.27.15.99.1";
						}
						[XmlElement(ElementName = "softwareName")]
						public CSoftwareName SoftwareName { get; set; } = new CSoftwareName();
						public class CSoftwareName
						{
							[XmlAttribute(AttributeName = "id")]
							public int Id { get; set; } = 1;
							[XmlText]
							public string SoftwareName { get; set; } = "2.3.18185-04";
						}
					}
				}
				[XmlElement(ElementName = "ControlActProcess")]
				public CControlActProcess ControlActProcess { get; set; } = new CControlActProcess();
				public class CControlActProcess
				{
					[XmlAttribute(AttributeName = "moodCode")]
					public string MoodCode { get; set; } = "EVN";
					[XmlElement(ElementName = "authorOrPerformer")]
					public CAuthorOrPerformer AuthorOrPerformer { get; set; } = new CAuthorOrPerformer();
					public class CAuthorOrPerformer
					{
						[XmlAttribute(AttributeName = "typeCode")]
						public string TypeCode { get; set; } = "AUT";
						[XmlElement(ElementName = "participant")]
						public CParticipant Participant { get; set; } = new CParticipant();
						public class CParticipant
						{
							[XmlElement(ElementName = "AssignedDevice")]
							public CAssignedDevice AssignedDevice { get; set; } = new CAssignedDevice();
							public class CAssignedDevice
							{
								[XmlElement(ElementName = "id")]
								public CId4 Id { get; set; } = new CId4();
								public class CId4
								{
									[XmlAttribute(AttributeName = "extension")]
									public int Extension { get; set; } = 4;
									[XmlAttribute(AttributeName = "root")]
									public string Root { get; set; } = "2.16.840.1.113883.2.4.6.6";
								}
							}
						}
					}
					[XmlElement(ElementName = "overseer")]
					public COverseer Overseer { get; set; } = new COverseer();
					public class COverseer
					{
						[XmlAttribute(AttributeName = "typeCode")]
						public string TypeCode { get; set; } = "RESP";
						[XmlElement(ElementName = "AssignedPerson")]
						public CAssignedPerson AssignedPerson { get; set; } = new CAssignedPerson();
						public class CAssignedPerson
						{
							[XmlElement(ElementName = "Organization")]
							public COrganization Organization { get; set; } = new COrganization();
							public class COrganization
							{
								[XmlElement(ElementName = "id")]
								public CId5 Id { get; set; } = new CId5();
								public class CId5
								{
									[XmlAttribute(AttributeName = "extension")]
									public string Extension { get; set; } = " ";
									[XmlAttribute(AttributeName = "root")]
									public string Root { get; set; } = "2.16.528.1.1007.3.3";
								}
							}
						}
					}
					[XmlElement(ElementName = "subject")]
					public CSubject Subject { get; set; } = new CSubject();
					public class CSubject
					{
						[XmlElement(ElementName = "Declaratieresultset")]
						public CDeclaratieresultset Declaratieresultset { get; set; } = new CDeclaratieresultset();
						public class CDeclaratieresultset
						{
							[XmlElement(ElementName = "id")]
							public CId6 Id { get; set; } = new CId6();
							public class CId6
							{
								[XmlAttribute(AttributeName = "extension")]
								public string Extension { get; set; } = "315C8585-C499-41FE-A3A1-0615CCE8CE3D";
								[XmlAttribute(AttributeName = "root")]
								public string Root { get; set; } = "2.16.840.1.113883.2.4.3.27.15.99.1.1.2";
							}
							[XmlElement(ElementName = "code")]
							public CCode Code { get; set; } = new CCode();
							public class CCode
							{
								[XmlAttribute(AttributeName = "codeSystem")]
								public string CodeSystem { get; set; } = "2.16.840.1.113883.2.4.3.27.15.1";
								[XmlAttribute(AttributeName = "code")]
								public string Code { get; set; } = "GROUPER";
							}
							[XmlElement(ElementName = "statusCode")]
							public CStatusCode StatusCode { get; set; } = new CStatusCode();
							public class CStatusCode
							{
								[XmlAttribute(AttributeName = "code")]
								public string Code { get; set; } = "completed";
							}
							[XmlElement(ElementName = "author")]
							public CAuthor Author { get; set; } = new CAuthor();
							public class CAuthor
							{
								[XmlElement(ElementName = "assignedDevice")]
								public CAssignedDevice1 AssignedDevice { get; set; } = new CAssignedDevice1();
								public class CAssignedDevice1
								{
									[XmlElement(ElementName = "assignedGrouper")]
									public CAssignedGrouper AssignedGrouper { get; set; } = new CAssignedGrouper();
									public class CAssignedGrouper
									{
										[XmlElement(ElementName = "code")]
										public CCode1 Code { get; set; } = new CCode1();
										public class CCode1
										{
											[XmlAttribute(AttributeName = "codeSystem")]
											public string CodeSystem { get; set; } = "2.16.840.1.113883.2.4.3.27.15.99.2";
											[XmlAttribute(AttributeName = "code")]
											public string Code { get; set; } = "P";
										}
										[XmlElement(ElementName = "lastCalibrationTime")]
										public CLastCalibrationTime LastCalibrationTime { get; set; } = new CLastCalibrationTime();
										public class CLastCalibrationTime
										{
											[XmlAttribute(AttributeName = "value")]
											public int Value { get; set; } = 20171220;
										}
									}
									[XmlElement(ElementName = "certificateText")]
									public string CertificateText { get; set; } = "01";
			
								}
							}
							[XmlElement(ElementName = "component1")]
							public CComponent1 Component1 { get; set; } = new CComponent1();
							public class CComponent1
							{
								[XmlAttribute(AttributeName = "typeCode")]
								public string TypeCode { get; set; } = "COMP";
								[XmlElement(ElementName = "priorityNumber")]
								public CPriorityNumber PriorityNumber { get; set; } = new CPriorityNumber();
								public class CPriorityNumber
								{
									[XmlAttribute(AttributeName = "value")]
									public int Value { get; set; } = 1;
								}
								[XmlElement(ElementName = "zorgproductdeclaratie")]
								public CZorgproductdeclaratie Zorgproductdeclaratie { get; set; } = new CZorgproductdeclaratie();
								public class CZorgproductdeclaratie
								{
									[XmlAttribute(AttributeName = "classCode")]
									public string ClassCode { get; set; } = "XACT";
									[XmlAttribute(AttributeName = "moodCode")]
									public string MoodCode { get; set; } = "EVN";
									[XmlElement(ElementName = "code")]
									public CCode2 Code { get; set; } = new CCode2();
									public class CCode2
									{
										[XmlAttribute(AttributeName = "codeSystem")]
										public string CodeSystem { get; set; } = "2.16.840.1.113883.2.4.3.27.15.6";
										[XmlAttribute(AttributeName = "code")]
										public string Code { get; set; } = "14E488";
									}
									[XmlElement(ElementName = "derivedFrom3")]
									public CDerivedFrom3 DerivedFrom3 { get; set; } = new CDerivedFrom3();
									public class CDerivedFrom3
									{
										[XmlElement(ElementName = "zorgproduct")]
										public CZorgproduct Zorgproduct { get; set; } = new CZorgproduct();
										public class CZorgproduct
										{
											[XmlAttribute(AttributeName = "moodCode")]
											public string MoodCode { get; set; } = "EVN";
											[XmlAttribute(AttributeName = "classCode")]
											public string ClassCode { get; set; } = "XACT";
											[XmlElement(ElementName = "code")]
											public CCode3 Code { get; set; } = new CCode3();
											public class CCode3
											{
												[XmlAttribute(AttributeName = "codeSystem")]
												public string CodeSystem { get; set; } = "2.16.840.1.113883.2.4.3.27.15.9";
												[XmlAttribute(AttributeName = "code")]
												public int Code { get; set; } = 998418070;
											}
										}
									}
									[XmlElement(ElementName = "reference")]
									public CReference Reference { get; set; } = new CReference();
									public class CReference
									{
										[XmlElement(ElementName = "subtraject")]
										public CSubtraject Subtraject { get; set; } = new CSubtraject();
										public class CSubtraject
										{
											[XmlElement(ElementName = "id")]
											public CId7 Id { get; set; } = new CId7();
											public class CId7
											{
												[XmlAttribute(AttributeName = "extension")]
												public int Extension { get; set; } = 100190701;
												[XmlAttribute(AttributeName = "root")]
												public string Root { get; set; } = "2.16.528.1.1007.3.3.4021.14.3";
											}
										}
									}
									[XmlElement(ElementName = "reference3")]
									public CReference3[] Reference3 { get; set; } = new CReference3[26];
									public class CReference3
									{
										[XmlElement(ElementName = "zorgactiviteit")]
										public CZorgactiviteit Zorgactiviteit { get; set; } = new CZorgactiviteit();
										public class CZorgactiviteit
										{
											[XmlElement(ElementName = "id")]
											public CId8 Id { get; set; } = new CId8();
											public class CId8
											{
												[XmlAttribute(AttributeName = "extension")]
												public int Extension { get; set; } = 696918;
												[XmlAttribute(AttributeName = "root")]
												public string Root { get; set; } = "2.16.528.1.1007.3.3.4021.1.12";
											}
										}
									}
								}
							}
							[XmlElement(ElementName = "inFulfillmentOf")]
							public CInFulfillmentOf InFulfillmentOf { get; set; } = new CInFulfillmentOf();
							public class CInFulfillmentOf
							{
								[XmlElement(ElementName = "declaratiedataset")]
								public CDeclaratiedataset Declaratiedataset { get; set; } = new CDeclaratiedataset();
								public class CDeclaratiedataset
								{
									[XmlElement(ElementName = "id")]
									public CId9 Id { get; set; } = new CId9();
									public class CId9
									{
										[XmlAttribute(AttributeName = "extension")]
										public string Extension { get; set; } = "JWOGXFRVCCAAA";
										[XmlAttribute(AttributeName = "root")]
										public string Root { get; set; } = "2.16.528.1.1007.3.3.4021.14.8";
									}
								}
							}
						}
					}
				}
			}
		}
	}