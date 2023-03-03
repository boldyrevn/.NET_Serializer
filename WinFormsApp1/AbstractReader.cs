abstract class Reader
{
    protected StreamReader sr;
    public Reader(string path)
    {
        sr = new StreamReader(path);
    }
    ~Reader()
    {
        sr.Close();
    }
};
class JsonReader : Reader
{
    public JsonReader(string path)
        : base(path) { }
}

class XmlReader : Reader
{
    public XmlReader(string path)
        : base(path) { }
}

class CsvReader : Reader
{
    public CsvReader(string path)
        : base(path) { }
}

class XlsxReader : Reader
{
    public XlsxReader(string path)
        : base(path) { }
}