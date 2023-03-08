using System.Text.Json;
class JsonWriter : Writer
{
    public JsonWriter(string path) 
        : base(path) { }
    public override void writeCollection(List<TestResult> list)
    {
        StreamWriter sw = new StreamWriter(path);
        sw?.Write("[");
        for (int i = 0; i < list.Count - 1; i++)
        {
            sw?.WriteLine(JsonSerializer.Serialize<TestResult>(list[i]) + ",");
        }
        sw?.WriteLine(JsonSerializer.Serialize<TestResult>(list[list.Count() - 1]) + "]");
        sw?.Flush();
        sw.Dispose();
    }
}