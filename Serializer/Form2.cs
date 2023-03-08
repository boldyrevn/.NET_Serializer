using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializer
{
    public partial class Form2 : Form
    {
        Form1 parent;
        Format serFormat;
        string folderName;
        string fileName;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void changeFormat(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            serFormat = radio.Text switch
            {
                "json" => Format.json,
                "xlsx" => Format.xlsx,
                "csv" => Format.csv,
                "xml" => Format.xml,
                _ => Format.undefined
            };
        }

        private void chooseFolder(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            folderName = folderBrowserDialog1.SelectedPath;
            if (folderName != null && folderName != "")
            {
                folderName += (folderName[folderName.Length - 1] == '\\') ? "" : "\\";
                textBox1.Text = folderName;
            }  
        }
        private bool validFileName(string filename)
        {
            return filename.IndexOfAny(Path.GetInvalidFileNameChars()) < 0;
        }
        private void changeFileName(object sender, EventArgs e)
        {
            fileName = textBox2.Text;
        }
        private void saveConfiguration(object sender, EventArgs e)
        {
            if (folderName != null && fileName != null && validFileName(fileName))
            {
                parent.savePath = folderName + fileName + serFormat switch
                {
                    Format.xml => ".xml",
                    Format.json => ".json",
                    Format.csv => ".csv",
                    Format.xlsx => ".xlsx"
                };
                label3.Text = parent.savePath;
                parent.serFormat = serFormat;
            }
            else
            {
                label3.Text = "Ivalid file name!";
            }
        }
    }
}
