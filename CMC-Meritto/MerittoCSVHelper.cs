using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMC_Meritto
{
    public static class MerittoCSVHelper
    {
        public static DataTable csvToGridEscapeQuote(string input)
        {
            if (input == "") return null;
            DataTable csvData = new DataTable();
            string[] listLine = StringHelper.getList(input);

            string[] seps = { "\",", ",\"" };
            char[] quotes = { '\"', ' ' };
            string[] colFields = null;

            string header = listLine[0];
            string[] headerFields = header.Split(',');

            for (int i = 0; i < headerFields.Length; i++)
            {
                //DataColumn datacolumn = new DataColumn(thead);
                csvData.Columns.Add(i.ToString());
            }

            csvData.Rows.Add(headerFields);

            for (int i = 1; i < listLine.Length; i++)
            {

                string line = listLine[i];
                if (line.Trim() == "") continue;

                var fields = line
                    .Split(seps, StringSplitOptions.None)
                    .Select(s => s.Trim(quotes).Replace("\\\"", "\""))
                    .ToArray();
                csvData.Rows.Add(fields);

            }

            return csvData;
        }

        public static DataTable csvToGridNoQuote(string input)
        {
            if (input == "") return null;
            DataTable csvData = new DataTable();
            string[] listLine = StringHelper.getList(input);

            string[] seps = { ","};
            char[] quotes = { '\"', ' ' };
            string[] colFields = null;

            string header = listLine[0];
            string[] headerFields = header.Split(',');

            for (int i = 0; i < headerFields.Length; i++)
            {
                //DataColumn datacolumn = new DataColumn(thead);
                csvData.Columns.Add(i.ToString());
            }

            csvData.Rows.Add(headerFields);

            for (int i = 1; i < listLine.Length; i++)
            {

                string line = listLine[i];
                if (line.Trim() == "") continue;

                var fields = line
                    .Split(seps, StringSplitOptions.None)
                    .Select(s => s.Trim(quotes).Replace("\\\"", "\""))
                    .ToArray();
                csvData.Rows.Add(fields);

            }

            return csvData;
        }

        public static string gridToCSV(DataGridView dataGridView)
        {
            StringBuilder csv = new StringBuilder();
            StringBuilder line = new StringBuilder();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i == 0)
                {
                    foreach(DataGridViewCell cell in dataGridView.Rows[i].Cells)
                    {
                        line.Append(cell.Value.ToString() + ",");
                    }
                } else
                {
                    foreach (DataGridViewCell cell in dataGridView.Rows[i].Cells)
                    {
                        line.Append("\"" + cell.Value.ToString() + "\",");
                    }
                }

                csv.Append(line.ToString().Substring(0,line.Length-1));
                csv.Append(Environment.NewLine);
                line.Clear();


            }

            return csv.ToString();
        }

        public static string gridToCSVNoQuote(DataGridView dataGridView)
        {
            StringBuilder csv = new StringBuilder();
            StringBuilder line = new StringBuilder();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {

                    foreach (DataGridViewCell cell in dataGridView.Rows[i].Cells)
                    {
                        line.Append(cell.Value.ToString() + ",");
                    }

                csv.Append(line.ToString().Substring(0, line.Length - 1));
                csv.Append(Environment.NewLine);
                line.Clear();

            }

            return csv.ToString();
        }
    }
}
