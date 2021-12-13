namespace CMC_Meritto
{
    partial class CSVOptionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(7, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 70);
            this.panel1.TabIndex = 4;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 38);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Header: No Quote\r\nData: Quote";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(128, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(224, 43);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "文書番号,紐づけID,繰返項番,\n\"0000003279\",\"\",\"1\",";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Location = new System.Drawing.Point(7, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 70);
            this.panel2.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 38);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Header: No Quote\r\nData: No Quote";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(128, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(224, 43);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "文書番号,紐づけID,繰返項番,\n123,20272,1,";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.metroLabel3);
            this.panel3.Controls.Add(this.richTextBox3);
            this.panel3.Location = new System.Drawing.Point(7, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 70);
            this.panel3.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 12);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 38);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Header: Quote\r\nData: Quote";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox3.Location = new System.Drawing.Point(128, 12);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(224, 43);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "\"Name\",\"ChiikiLevel__c\",\"ChiikiMei__c\",\n\"千葉県\",\"都道府県\",\"千葉県\",";
            // 
            // CSVOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 350);
            this.Controls.Add(this.groupBox1);
            this.Name = "CSVOptionForm";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Text = "CSV Option";
            this.Load += new System.EventHandler(this.CSVOptionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}