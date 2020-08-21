using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVFileReader
{
    public partial class FileReader : Form
    {
        public FileReader()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            textFilePath.Text = openFileDialog.FileName;
            BindData(textFilePath.Text);
        }
        private void BindData(string filePath)
        {
            string[] records = System.IO.File.ReadAllLines(filePath);
            DataTable dataTable = new DataTable();

            if (records.Length > 0)
            {
                //First line to create header
                string[] firstLine = records[0].Split(',');
                foreach (var columnName in firstLine)
                {
                    dataTable.Columns.Add(new DataColumn(columnName));
                }

                //For Data
                for (int rowNo = 1; rowNo < records.Length; rowNo++)
                {
                    string[] rows = records[rowNo].Split(',');
                    DataRow dataRow = dataTable.NewRow();
                    int columnIndex = 0;
                    foreach (var headerWord in firstLine)
                    {
                        dataRow[headerWord] = rows[columnIndex++];
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }
            DGV.DataSource = dataTable;
        }
    }
}
