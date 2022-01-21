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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtInp = new System.Windows.Forms.TextBox();
            this.csvGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFull = new System.Windows.Forms.Label();
            this.lblContains = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchFull = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unicodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboSplitOption = new System.Windows.Forms.ToolStripComboBox();
            this.optionExplainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboOntop = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(10, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 424);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.28226F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.71774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AllowDrop = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 44);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.67712F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(840, 358);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // txtInp
            // 
            this.txtInp.AllowDrop = true;
            this.txtInp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInp.Location = new System.Drawing.Point(0, 0);
            this.txtInp.Margin = new System.Windows.Forms.Padding(12, 12, 3, 3);
            this.txtInp.MaxLength = 2400000;
            this.txtInp.Multiline = true;
            this.txtInp.Name = "txtInp";
            this.txtInp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInp.Size = new System.Drawing.Size(800, 122);
            this.txtInp.TabIndex = 0;
            this.txtInp.WordWrap = false;
            this.txtInp.Click += new System.EventHandler(this.txtInp_Click);
            this.txtInp.TextChanged += new System.EventHandler(this.txtInp_TextChanged);
            this.txtInp.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtInp_DragDrop);
            this.txtInp.DragOver += new System.Windows.Forms.DragEventHandler(this.txtInp_DragOver);
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
            this.csvGridView.Location = new System.Drawing.Point(0, 0);
            this.csvGridView.Margin = new System.Windows.Forms.Padding(12, 12, 3, 3);
            this.csvGridView.Name = "csvGridView";
            this.csvGridView.Size = new System.Drawing.Size(800, 220);
            this.csvGridView.TabIndex = 1;
            this.csvGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.csvGridView_CellEndEdit);
            this.csvGridView.Click += new System.EventHandler(this.csvGridView_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboOntop);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(809, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 352);
            this.panel2.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::CMC_Meritto.Properties.Resources.return1;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.Location = new System.Drawing.Point(1, 28);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(26, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1, -1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(26, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFull);
            this.panel1.Controls.Add(this.lblContains);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.txtSearchFull);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 35);
            this.panel1.TabIndex = 1;
            // 
            // lblFull
            // 
            this.lblFull.AutoSize = true;
            this.lblFull.Location = new System.Drawing.Point(813, 8);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(13, 13);
            this.lblFull.TabIndex = 5;
            this.lblFull.Text = "0";
            // 
            // lblContains
            // 
            this.lblContains.AutoSize = true;
            this.lblContains.Location = new System.Drawing.Point(383, 8);
            this.lblContains.Name = "lblContains";
            this.lblContains.Size = new System.Drawing.Size(13, 13);
            this.lblContains.TabIndex = 4;
            this.lblContains.Text = "0";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(448, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(29, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "full:";
            // 
            // txtSearchFull
            // 
            this.txtSearchFull.Location = new System.Drawing.Point(483, 5);
            this.txtSearchFull.Name = "txtSearchFull";
            this.txtSearchFull.Size = new System.Drawing.Size(324, 20);
            this.txtSearchFull.TabIndex = 2;
            this.txtSearchFull.TextChanged += new System.EventHandler(this.txtSearchFull_TextChanged);
            this.txtSearchFull.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchFull_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "contain:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(64, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(313, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.encodeToolStripMenuItem,
            this.cboSplitOption,
            this.optionExplainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // encodeToolStripMenuItem
            // 
            this.encodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unicodeToolStripMenuItem,
            this.uTF8ToolStripMenuItem});
            this.encodeToolStripMenuItem.Name = "encodeToolStripMenuItem";
            this.encodeToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
            this.encodeToolStripMenuItem.Text = "Encoding Select";
            // 
            // unicodeToolStripMenuItem
            // 
            this.unicodeToolStripMenuItem.Checked = true;
            this.unicodeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.unicodeToolStripMenuItem.Name = "unicodeToolStripMenuItem";
            this.unicodeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.unicodeToolStripMenuItem.Text = "Unicode";
            this.unicodeToolStripMenuItem.Click += new System.EventHandler(this.unicodeToolStripMenuItem_Click);
            // 
            // uTF8ToolStripMenuItem
            // 
            this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.uTF8ToolStripMenuItem.Text = "UTF-8";
            this.uTF8ToolStripMenuItem.Click += new System.EventHandler(this.uTF8ToolStripMenuItem_Click);
            // 
            // cboSplitOption
            // 
            this.cboSplitOption.Items.AddRange(new object[] {
            "Header: No Quote | Data: Quote",
            "Header: No Quote | Data: No Quote"});
            this.cboSplitOption.Name = "cboSplitOption";
            this.cboSplitOption.Size = new System.Drawing.Size(210, 23);
            this.cboSplitOption.Text = "Header: No Quote | Data: Quote";
            this.cboSplitOption.Click += new System.EventHandler(this.cboSplitOption_Click);
            this.cboSplitOption.TextChanged += new System.EventHandler(this.cboSplitOption_TextChanged);
            // 
            // optionExplainToolStripMenuItem
            // 
            this.optionExplainToolStripMenuItem.Name = "optionExplainToolStripMenuItem";
            this.optionExplainToolStripMenuItem.Size = new System.Drawing.Size(113, 23);
            this.optionExplainToolStripMenuItem.Text = "<- Option explain";
            this.optionExplainToolStripMenuItem.Visible = false;
            this.optionExplainToolStripMenuItem.Click += new System.EventHandler(this.optionExplainToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusFileName});
            this.statusStrip1.Location = new System.Drawing.Point(10, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(852, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusFileName
            // 
            this.lblStatusFileName.Name = "lblStatusFileName";
            this.lblStatusFileName.Size = new System.Drawing.Size(10, 17);
            this.lblStatusFileName.Text = ".";
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
            // cboOntop
            // 
            this.cboOntop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOntop.AutoSize = true;
            this.cboOntop.Checked = true;
            this.cboOntop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboOntop.Location = new System.Drawing.Point(6, 332);
            this.cboOntop.Name = "cboOntop";
            this.cboOntop.Size = new System.Drawing.Size(15, 14);
            this.cboOntop.TabIndex = 6;
            this.cboOntop.UseVisualStyleBackColor = true;
            this.cboOntop.CheckedChanged += new System.EventHandler(this.cboOntop_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtInp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.csvGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 352);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // Mainform
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 546);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Text = "           CMC-Meritto (Helio)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.csvGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtInp;
        private System.Windows.Forms.DataGridView csvGridView;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtSearchFull;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusFileName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblContains;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cboSplitOption;
        private System.Windows.Forms.ToolStripMenuItem optionExplainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unicodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox cboOntop;
    }
}

