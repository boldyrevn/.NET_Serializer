namespace Serializer
{
    public partial class Form1 : Form
    {
        List<TestResult> results;
        public Format deserFormat;
        public Format serFormat;
        public string savePath;
        public string readPath;
        public Form1()
        {
            InitializeComponent();
        }
        private void openFile(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);
            openFileDialog.Dispose();
        }
        private void defineFormat(string fileName, out Format format)
        {
            string fileFormat;
            int iDot = fileName.Length - 1;
            while (fileName[iDot] != '.')
            {
                iDot--;
            }
            fileFormat = fileName.Substring(iDot + 1);
            format = fileFormat switch
            {
                "json" => Format.json,
                "xlsx" => Format.xlsx,
                "csv" => Format.csv,
                "xml" => Format.xml,
                _ => Format.undefined
            };
        }
        private void showSettings(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void chooseFile(object sender, System.ComponentModel.CancelEventArgs e)
        {
            defineFormat(openFileDialog.FileName, out deserFormat);
            readPath = openFileDialog.FileName;
        }
        private void saveFile(object sender, EventArgs e)
        {
            deserFile();
            serFile();
        }
        private void deserFile()
        {
            if (deserFormat == Format.json)
            {
                JsonReader reader = new JsonReader(readPath);
                results = reader.getCollection();
            }
            else if (deserFormat == Format.xlsx)
            {
                XlsxReader reader = new XlsxReader(readPath);
                results = reader.getCollection();
            }
            else if (deserFormat == Format.csv)
            {
                CsvReader reader = new CsvReader(readPath);
                results = reader.getCollection();
            }
            else
            {
                XlsxReader reader = new XlsxReader(readPath);
                results = reader.getCollection();
            }
        }
        private void serFile()
        {
            if (serFormat == Format.json)
            {
                JsonWriter reader = new JsonWriter(savePath);
                reader.writeCollection(results);
            }
            else if (serFormat == Format.xml)
            {
                XmlWriter reader = new XmlWriter(savePath);
                reader.writeCollection(results);
            }
            else if (serFormat == Format.csv)
            {
                CsvWriter reader = new CsvWriter(savePath);
                reader.writeCollection(results);
            }
            else
            {
                XlsxWriter reader = new XlsxWriter(savePath);
                reader.writeCollection(results);
            }
        }
    }
    public enum Format
    {
        json,
        xml,
        csv,
        xlsx,
        undefined
    }
}
