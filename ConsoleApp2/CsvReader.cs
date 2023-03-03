using System.Globalization;
class CsvReader : Reader
{
    public CsvReader(string path)
        : base(path) { }
    public override List<TestResult> getCollection()
    {
        StreamReader sr = new StreamReader(path);
        List<TestResult> output = new List<TestResult>();
        if (sr != null)
        {
            CsvHelper.CsvReader scv = new CsvHelper.CsvReader(sr, CultureInfo.InvariantCulture);
            output = scv.GetRecords<TestResult>().ToList();
        } 
        return output;
        sr.Dispose();
    }
}