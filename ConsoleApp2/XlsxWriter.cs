using ClosedXML.Excel;

class XlsxWriter : Writer
{

    public XlsxWriter(string path)
        : base(path) { }
    public override void writeCollection(List<TestResult> list)
    {
        XLWorkbook wb = new XLWorkbook(path);
        var ws = wb.Worksheets.Worksheet(1);
        for (int i = 1; i < list.Count + 1; i++)
        {
            ws.Cell($"A{i}").Value = list[i - 1].Subject;
            ws.Cell($"B{i}").Value = list[i - 1].Result;
            ws.Cell($"C{i}").Value = list[i - 1].Score;
        }
        wb.Dispose();
    }
}