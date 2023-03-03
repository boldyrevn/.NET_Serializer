global using System.Collections.Generic;

List<TestResult> ouput = new List<TestResult>()
{
    new TestResult("fof", 75, 3),
    new TestResult("sus", 23, 2),
    new TestResult("sas", 99, 5)
};
CsvWriter sus = new CsvWriter(@"C:\code_projects\ConsoleApp2\csv.csv");
sus.writeCollection(ouput);

