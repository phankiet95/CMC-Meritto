namespace CMC_Meritto
{
    partial class EditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtInp = new System.Windows.Forms.TextBox();
            this.csvGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel3.Controls.Add(this.txtInp, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.csvGridView, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.29787F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.70213F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(832, 516);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // txtInp
            // 
            this.txtInp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInp.Location = new System.Drawing.Point(12, 12);
            this.txtInp.Margin = new System.Windows.Forms.Padding(12, 12, 3, 3);
            this.txtInp.MaxLength = 2400000;
            this.txtInp.Multiline = true;
            this.txtInp.Name = "txtInp";
            this.txtInp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInp.Size = new System.Drawing.Size(817, 131);
            this.txtInp.TabIndex = 0;
            this.txtInp.WordWrap = false;
            this.txtInp.Click += new System.EventHandler(this.txtInp_Click);
            this.txtInp.TextChanged += new System.EventHandler(this.txtInp_TextChanged);
            // 
            // csvGridView
            // 
            this.csvGridView.AllowUserToAddRows = false;
            this.csvGridView.AllowUserToDeleteRows = false;
            this.csvGridView.AllowUserToResizeColumns = false;
            this.csvGridView.AllowUserToResizeRows = false;
            this.csvGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.csvGridView.BackgroundColor = System.Drawing.Color.White;
            this.csvGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.csvGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.csvGridView.Location = new System.Drawing.Point(12, 158);
            this.csvGridView.Margin = new System.Windows.Forms.Padding(12, 12, 3, 3);
            this.csvGridView.Name = "csvGridView";
            this.csvGridView.Size = new System.Drawing.Size(817, 355);
            this.csvGridView.TabIndex = 1;
            this.csvGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.csvGridView_CellEndEdit);
            this.csvGridView.Click += new System.EventHandler(this.csvGridView_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 516);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "EditorForm";
            this.Text = "EditorForm";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtInp;
        private System.Windows.Forms.DataGridView csvGridView;
    }
}