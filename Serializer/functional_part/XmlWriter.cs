using System.Xml.Serialization;
class XmlWriter : Writer
{
    public XmlWriter(string path)
        : base(path) { }
    public override void writeCollection(List<TestResult> list)
    {
        StreamWriter sw = new StreamWriter(path);
        XmlSerializer serializer = new XmlSerializer(typeof(List<TestResult>));
        if (sw is not null)
        {
            serializer.Serialize(sw, list);
        }
        sw.Dispose();
    }
}

