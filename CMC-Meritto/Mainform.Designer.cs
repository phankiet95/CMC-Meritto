namespace CMC_Meritto
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtInp = new System.Windows.Forms.TextBox();
            this.csvGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchFull = new MetroFramework.Controls.MetroTextBox();
            this.btnSaveCsv = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroTab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1272, 525);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metroTab, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.28226F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.71774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1266, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroTab
            // 
            this.metroTab.Controls.Add(this.metroTabPage1);
            this.metroTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTab.Location = new System.Drawing.Point(3, 55);
            this.metroTab.Name = "metroTab";
            this.metroTab.SelectedIndex = 0;
            this.metroTab.Size = new System.Drawing.Size(1260, 448);
            this.metroTab.TabIndex = 0;
            this.metroTab.SelectedIndexChanged += new System.EventHandler(this.metroTab_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel3);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1252, 409);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Tab 1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.19906F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.80094F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1252, 409);
            this.tableLayoutPanel3.TabIndex = 2;
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
            this.txtInp.Size = new System.Drawing.Size(1237, 169);
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
            this.csvGridView.Location = new System.Drawing.Point(12, 196);
            this.csvGridView.Margin = new System.Windows.Forms.Padding(12, 12, 3, 3);
            this.csvGridView.Name = "csvGridView";
            this.csvGridView.Size = new System.Drawing.Size(1237, 210);
            this.csvGridView.TabIndex = 1;
            this.csvGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.csvGridView_CellClick);
            this.csvGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.csvGridView_CellContentClick);
            this.csvGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.csvGridView_CellEndEdit);
            this.csvGridView.Click += new System.EventHandler(this.csvGridView_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSaveCsv);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.txtSearchFull);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 46);
            this.panel1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(64, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "contain:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(448, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(29, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "full:";
            // 
            // txtSearchFull
            // 
            this.txtSearchFull.Location = new System.Drawing.Point(483, 9);
            this.txtSearchFull.Name = "txtSearchFull";
            this.txtSearchFull.Size = new System.Drawing.Size(324, 20);
            this.txtSearchFull.TabIndex = 2;
            this.txtSearchFull.TextChanged += new System.EventHandler(this.txtSearchFull_TextChanged);
            // 
            // btnSaveCsv
            // 
            this.btnSaveCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCsv.Location = new System.Drawing.Point(1219, 10);
            this.btnSaveCsv.Name = "btnSaveCsv";
            this.btnSaveCsv.Size = new System.Drawing.Size(33, 23);
            this.btnSaveCsv.TabIndex = 4;
            this.btnSaveCsv.Text = "___";
            this.btnSaveCsv.Click += new System.EventHandler(this.btnSaveCsv_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CMC_Meritto.Properties.Resources.CMCicon;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Text = "           CMC-Meritto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroTab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTabControl metroTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtInp;
        private System.Windows.Forms.DataGridView csvGridView;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtSearchFull;
        private MetroFramework.Controls.MetroButton btnSaveCsv;
    }
}

