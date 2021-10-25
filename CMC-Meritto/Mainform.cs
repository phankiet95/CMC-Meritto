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
        string currentPath;
        string inpBackup = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        bool editInputMod;
        private void txtInp_TextChanged(object sender, EventArgs e)
        {
            lblStatusFileName.Text = currentPath + " *";
            if (editInputMod)
            {
                table = MerittoCSVHelper.csvToGridEscapeQuote(txtInp.Text);
                csvGridView.DataSource = table;
                //csvGridView.Rows[0].ReadOnly = true;
            }
        }

        private void csvGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!editInputMod)
            {
                txtInp.Text = MerittoCSVHelper.gridToCSV(csvGridView);
            }
        }


        private void txtInp_Click(object sender, EventArgs e)
        {
            editInputMod = true;
        }

        private void csvGridView_Click(object sender, EventArgs e)
        {
            editInputMod = false;
        }

        private void metroTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblContains.Text = search(txtSearch.Text, 1).ToString();
        }

        private void txtSearchFull_TextChanged(object sender, EventArgs e)
        {
            lblFull.Text = search(txtSearchFull.Text, 2).ToString();
        }

        private int search(string key, int type)
        {
            if (csvGridView.Rows.Count == 0) return 0;
            int count = 0;

            foreach (DataGridViewCell cell in csvGridView.Rows[0].Cells)
            {

                if (type == 1)
                {
                    if (key == "")
                    {
                        cell.Style.BackColor = Color.White;
                        continue;
                    }

                    if (cell.Value.ToString().Contains(key) || cell.Value.ToString().Contains(key.Replace(" ", "　")) || cell.Value.ToString().Contains(key.Replace("　", " ")))
                    {
                        cell.Style.BackColor = Color.OrangeRed;
                        count++;
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

                    if (cell.Value.ToString() == key || cell.Value.ToString() == key.Replace(" ", "　") || cell.Value.ToString() == key.Replace("　", " "))
                    {
                        cell.Style.BackColor = Color.YellowGreen;
                        count++;
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

            return count;
        }

        private void saveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtInp.Text, Encoding.Unicode);
                MessageBox.Show("Saved" + saveFileDialog.FileName, "Notice", MessageBoxButtons.OK);
            }
        }

        private void btnSaveCsv_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.TopMost = true;
            about.ShowDialog();
        }

        private void txtInp_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void txtInp_DragOver(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            currentPath = fileList[0].ToString();
            editInputMod = true;
            txtInp.Text = File.ReadAllText(currentPath, Encoding.Unicode);
            lblStatusFileName.Text = currentPath;
            inpBackup = File.ReadAllText(currentPath, Encoding.Unicode);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            editInputMod = true;
            txtInp.Text = "";
        }

        private void cboOntop_CheckedChanged(object sender, EventArgs e)
        {
            if (cboOntop.Checked)
            {
                this.TopMost = true;
            } else
            {
                this.TopMost = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentPath != "")
            {
                File.WriteAllText(currentPath, txtInp.Text, Encoding.Unicode);
                lblStatusFileName.Text = currentPath;
            } else
            {
                saveAs();
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            editInputMod = true;
            txtInp.Text = inpBackup;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            lblContains.Text = search(txtSearch.Text, 1).ToString();
        }

        private void txtSearchFull_KeyDown(object sender, KeyEventArgs e)
        {
            lblFull.Text = search(txtSearchFull.Text, 2).ToString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentPath = openFileDialog.FileName;
                editInputMod = true;
                txtInp.Text = File.ReadAllText(currentPath, Encoding.Unicode);
                lblStatusFileName.Text = currentPath;
                inpBackup = File.ReadAllText(currentPath, Encoding.Unicode);
            }


        }
    }
}
