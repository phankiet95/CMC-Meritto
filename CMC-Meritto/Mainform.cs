using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMC_Meritto
{
    public partial class Mainform : MetroFramework.Forms.MetroForm
    {
        public Mainform()
        {
            InitializeComponent();
        }
        DataTable table;
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnParse_Click(object sender, EventArgs e)
        {
            
        }
        bool editInputMod;
        private void txtInp_TextChanged(object sender, EventArgs e)
        {
            if (editInputMod)
            {
                table = MerittoCSVHelper.csvToGridEscapeQuote(txtInp.Text);
                csvGridView.DataSource = table;
            }
        }

        private void csvGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!editInputMod)
            {
                txtInp.Text = MerittoCSVHelper.gridToCSV(csvGridView);
            }
        }

        
        private void csvGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtInp_Click(object sender, EventArgs e)
        {
            editInputMod = true;
        }

        private void csvGridView_Click(object sender, EventArgs e)
        {
            editInputMod = false;
        }

        private void csvGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search(txtSearch.Text, 1);
        }

        private void txtSearchFull_TextChanged(object sender, EventArgs e)
        {
            search(txtSearchFull.Text, 2);
        }

        private void search(string key, int type)
        {
            if (csvGridView.Rows.Count == 0) return;

            foreach (DataGridViewCell cell in csvGridView.Rows[0].Cells)
            {

                if (type == 1)
                {
                    if (key == "")
                    {
                        cell.Style.BackColor = Color.White;
                        continue;
                    }

                    if (cell.Value.ToString().Contains(key))
                    {
                        cell.Style.BackColor = Color.OrangeRed;
                    }
                    else
                    {
                        if (cell.Style.BackColor == Color.OrangeRed)
                        {
                            cell.Style.BackColor = Color.White;
                        }
                        
                    }
                }

                if (type == 2)
                {
                    if (key == "")
                    {
                        cell.Style.BackColor = Color.White;
                        continue;
                    }

                    if (cell.Value.ToString() == key)
                    {
                        cell.Style.BackColor = Color.YellowGreen;
                    }
                    else
                    {
                        if (cell.Style.BackColor == Color.YellowGreen)
                        {
                            cell.Style.BackColor = Color.White;
                        }
                            
                    }
                }

            }
        }

        private void btnSaveCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtInp.Text, Encoding.Unicode);
                MessageBox.Show("Saved" + saveFileDialog.FileName, "Notice", MessageBoxButtons.OK);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}
