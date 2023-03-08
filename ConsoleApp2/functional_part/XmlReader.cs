using System.Xml.Serialization;
class XmlReader : Reader
{
    public XmlReader(string path)
        : base(path) { }
    public override List<TestResult> getCollection() 
    {
        StreamReader sr = new StreamReader(path);
        List<TestResult> ouput = new List<TestResult>();
        XmlSerializer serializer = new XmlSerializer(typeof(List<TestResult>));
        if (sr is not null)
        {
            try
            {
                ouput = (List<TestResult>)serializer.Deserialize(sr)!;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Wrong XML format!");
            }
        }
        sr.Dispose();
        return ouput;
    }
}