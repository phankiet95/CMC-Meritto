using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMC_Meritto
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }
        DataTable table;
        bool editInputMod;
        private void txtInp_TextChanged(object sender, EventArgs e)
        {
            if (editInputMod)
            {
                table = MerittoCSVHelper.csvToGridEscapeQuote(txtInp.Text);
                csvGridView.DataSource = table;
            }
        }

        private void csvGridView_Click(object sender, EventArgs e)
        {
            editInputMod = false;
        }

        private void txtInp_Click(object sender, EventArgs e)
        {
            editInputMod = true;
        }

        private void csvGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!editInputMod)
            {
                txtInp.Text = MerittoCSVHelper.gridToCSV(csvGridView);
            }
        }
    }
}
