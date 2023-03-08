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
        while (json is not null)
        {
            try
            {
                output.Add(JsonSerializer.Deserialize<TestResult>(json!));
            }
            catch (JsonException)
            {
                Console.WriteLine("Wrong json format!");
            }
            json = sr?.ReadLine();
        }
        return output;
        sr.Dispose();
    }
}    