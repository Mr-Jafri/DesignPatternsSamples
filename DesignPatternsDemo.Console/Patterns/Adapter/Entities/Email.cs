using System.Xml.Serialization;

namespace DesignPatternsDemo.Console.Patterns.Adapter.Entities;

[Serializable, XmlRoot("email")]
public class Email
{
    [XmlElement("to")]
    public required string To { get; set; }

    [XmlElement("from")]
    public required string From { get; set; }

    [XmlElement("subject")]
    public required string Subject { get; set; }

    [XmlElement("body")]
    public required string Body { get; set; }
}