using System.Globalization;
class CsvWriter : Writer
{
    public CsvWriter(string path)
        : base(path) { }
    public override void writeCollection(List<TestResult> list)
    {
        StreamWriter sw = new StreamWriter(path);
        CsvHelper.CsvWriter csv = new CsvHelper.CsvWriter(sw, CultureInfo.InvariantCulture);
        csv.WriteRecords(list);
        sw.Dispose();
    }
}
