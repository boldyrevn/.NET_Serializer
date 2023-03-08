using ClosedXML.Excel;
class XlsxReader : Reader
{
    public XlsxReader(string path)
        : base(path) { }
    public override List<TestResult> getCollection()
    {
        XLWorkbook wb = new XLWorkbook(path);
        List<TestResult> output = new List<TestResult>();
        var ws = wb.Worksheets.Worksheet(1);
        int row = 1;
        while (ws.Cell($"A{row}").Value.ToString() != "")
        {
            output.Add(new TestResult(ws.Cell($"A{row}").Value.ToString(), 
                Convert.ToInt32(ws.Cell($"B{row}").Value.ToString()),
                Convert.ToInt32(ws.Cell($"C{row}").Value.ToString())));
            row++;
        }
        wb.Dispose();
        return output;
    }
}