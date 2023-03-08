using System.Text.Json;
class JsonReader : Reader
{
    public JsonReader(string path)
        : base(path) { }
    public override List<TestResult> getCollection()
    {
        StreamReader sr = new StreamReader(path);
        List<TestResult> output = new List<TestResult>();
        string? json = sr?.ReadLine();
        output = JsonSerializer.Deserialize<List<TestResult>>(json!);
        sr.Dispose();
        return output;
    }
}    