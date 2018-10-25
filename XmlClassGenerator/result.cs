// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedMember.Global
// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo
#pragma warning disable IDE1006 // Naming Styles
using System.Xml.Serialization;

[XmlType(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
[XmlRoot(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
public class Envelope
{
	public Body Body { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class Body
{
	[XmlElement(Namespace = "urn:hl7-org:v3")]
	public FICR_IN910101NL04 FICR_IN910101NL04 { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
[XmlRoot(Namespace = "urn:hl7-org:v3", IsNullable = false)]
public class FICR_IN910101NL04
{
	public FICR_IN910101NL04ID id { get; set; }
	public FICR_IN910101NL04CreationTime creationTime { get; set; }
	public FICR_IN910101NL04VersionCode versionCode { get; set; }
	public FICR_IN910101NL04InteractionId interactionId { get; set; }
	public FICR_IN910101NL04ProfileId profileId { get; set; }
	public FICR_IN910101NL04ProcessingCode processingCode { get; set; }
	public FICR_IN910101NL04ProcessingModeCode processingModeCode { get; set; }
	public FICR_IN910101NL04AcceptAckCode acceptAckCode { get; set; }
	public FICR_IN910101NL04Acknowledgement acknowledgement { get; set; }
	public FICR_IN910101NL04Receiver receiver { get; set; }
	public FICR_IN910101NL04Sender sender { get; set; }
	public FICR_IN910101NL04ControlActProcess ControlActProcess { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ID
{
	[XmlAttribute]
	public string extension { get; set; }

	[XmlAttribute]
	public string root { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04CreationTime
{
	[XmlAttribute]
	public ulong value { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04VersionCode
{
	[XmlAttribute]
	public string code { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04InteractionId
{
	[XmlAttribute]
	public string extension { get; set; }

	[XmlAttribute]
	public string root { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ProfileId
{
	[XmlAttribute]
	public decimal extension { get; set; }

	[XmlAttribute]
	public string root { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ProcessingCode
{
	[XmlAttribute]
	public string code { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ProcessingModeCode
{
	[XmlAttribute]
	public string code { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04AcceptAckCode
{
	[XmlAttribute]
	public string code { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04Acknowledgement
{
	public FICR_IN910101NL04AcknowledgementTargetMessage targetMessage { get; set; }

	[XmlAttribute]
	public string typeCode { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04AcknowledgementTargetMessage
{
	public FICR_IN910101NL04AcknowledgementTargetMessageID id { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04AcknowledgementTargetMessageID
{
	[XmlAttribute]
	public string extension { get; set; }

	[XmlAttribute]
	public string root { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04Receiver
{
	public FICR_IN910101NL04ReceiverDevice device { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ReceiverDevice
{
	public FICR_IN910101NL04ReceiverDeviceID id { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ReceiverDeviceID
{
	[XmlAttribute]
	public string nullFlavor { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04Sender
{
	public FICR_IN910101NL04SenderDevice device { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04SenderDevice
{
	public FICR_IN910101NL04SenderDeviceID id { get; set; }
	public string softwareName { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04SenderDeviceID
{
	[XmlAttribute]
	public byte extension { get; set; }

	[XmlAttribute]
	public string root { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcess
{
	public FICR_IN910101NL04ControlActProcessAuthorOrPerformer authorOrPerformer { get; set; }
	public FICR_IN910101NL04ControlActProcessOverseer overseer { get; set; }
	public FICR_IN910101NL04ControlActProcessSubject subject { get; set; }

	[XmlAttribute]
	public string moodCode { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessAuthorOrPerformer
{
	public FICR_IN910101NL04ControlActProcessAuthorOrPerformerParticipant participant { get; set; }

	[XmlAttribute]
	public string typeCode { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessAuthorOrPerformerParticipant
{
	public FICR_IN910101NL04ControlActProcessAuthorOrPerformerParticipantAssignedDevice AssignedDevice { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessAuthorOrPerformerParticipantAssignedDevice
{
	public FICR_IN910101NL04ControlActProcessAuthorOrPerformerParticipantAssignedDeviceID id { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessAuthorOrPerformerParticipantAssignedDeviceID
{
	[XmlAttribute]
	public byte extension { get; set; }

	[XmlAttribute]
	public string root { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessOverseer
{
	public FICR_IN910101NL04ControlActProcessOverseerAssignedPerson AssignedPerson { get; set; }

	[XmlAttribute]
	public string typeCode { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessOverseerAssignedPerson
{
	public FICR_IN910101NL04ControlActProcessOverseerAssignedPersonOrganization Organization { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessOverseerAssignedPersonOrganization
{
	public FICR_IN910101NL04ControlActProcessOverseerAssignedPersonOrganizationID id { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessOverseerAssignedPersonOrganizationID
{
	[XmlAttribute]
	public string extension { get; set; }

	[XmlAttribute]
	public string root { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubject
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultset Declaratieresultset { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultset
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetID id { get; set; }
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetCode code { get; set; }
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetStatusCode statusCode { get; set; }
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetAuthor author { get; set; }
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1 component1 { get; set; }
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetInFulfillmentOf inFulfillmentOf { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetID
{
	[XmlAttribute]
	public string extension { get; set; }

	[XmlAttribute]
	public string root { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetCode
{
	[XmlAttribute]
	public string codeSystem { get; set; }

	[XmlAttribute]
	public string code { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetStatusCode
{
	[XmlAttribute]
	public string code { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetAuthor
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetAuthorAssignedDevice assignedDevice { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetAuthorAssignedDevice
{
	public byte certificateText { get; set; }
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetAuthorAssignedDeviceAssignedGrouper assignedGrouper { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetAuthorAssignedDeviceAssignedGrouper
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetAuthorAssignedDeviceAssignedGrouperCode code { get; set; }
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetAuthorAssignedDeviceAssignedGrouperLastCalibrationTime lastCalibrationTime { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetAuthorAssignedDeviceAssignedGrouperCode
{
	[XmlAttribute]
	public string codeSystem { get; set; }

	[XmlAttribute]
	public string code { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetAuthorAssignedDeviceAssignedGrouperLastCalibrationTime
{
	[XmlAttribute]
	public uint value { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1PriorityNumber priorityNumber { get; set; }
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1Zorgproductdeclaratie zorgproductdeclaratie { get; set; }

	[XmlAttribute]
	public string typeCode { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1PriorityNumber
{
	[XmlAttribute]
	public byte value { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1Zorgproductdeclaratie
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieCode code { get; set; }
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieDerivedFrom3 derivedFrom3 { get; set; }
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieReference reference { get; set; }

	[XmlElement("reference3")]
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieReference3[] reference3 { get; set; }

	[XmlAttribute]
	public string classCode { get; set; }

	[XmlAttribute]
	public string moodCode { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieCode
{
	[XmlAttribute]
	public string codeSystem { get; set; }

	[XmlAttribute]
	public string code { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieDerivedFrom3
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieDerivedFrom3Zorgproduct zorgproduct { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieDerivedFrom3Zorgproduct
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieDerivedFrom3ZorgproductCode code { get; set; }

	[XmlAttribute]
	public string moodCode { get; set; }

	[XmlAttribute]
	public string classCode { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieDerivedFrom3ZorgproductCode
{
	[XmlAttribute]
	public string codeSystem { get; set; }

	[XmlAttribute]
	public uint code { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieReference
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieReferenceSubtraject subtraject { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieReferenceSubtraject
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieReferenceSubtrajectID id { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieReferenceSubtrajectID
{
	[XmlAttribute]
	public uint extension { get; set; }

	[XmlAttribute]
	public string root { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieReference3
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieReference3Zorgactiviteit zorgactiviteit { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieReference3Zorgactiviteit
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieReference3ZorgactiviteitID id { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetComponent1ZorgproductdeclaratieReference3ZorgactiviteitID
{
	[XmlAttribute]
	public uint extension { get; set; }

	[XmlAttribute]
	public string root { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetInFulfillmentOf
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetInFulfillmentOfDeclaratiedataset declaratiedataset { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetInFulfillmentOfDeclaratiedataset
{
	public FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetInFulfillmentOfDeclaratiedatasetID id { get; set; }
}

[XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
public class FICR_IN910101NL04ControlActProcessSubjectDeclaratieresultsetInFulfillmentOfDeclaratiedatasetID
{
	[XmlAttribute]
	public string extension { get; set; }

	[XmlAttribute]
	public string root { get; set; }
}
