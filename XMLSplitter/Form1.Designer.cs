namespace XMLSplitter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXT_TagsPerFile = new System.Windows.Forms.TextBox();
            this.Txt_XMLTag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSplitXML = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OutputLogArea = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File: ";
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Location = new System.Drawing.Point(49, 19);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.Size = new System.Drawing.Size(371, 20);
            this.TxtFilePath.TabIndex = 1;
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(441, 17);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectFile.TabIndex = 2;
            this.BtnSelectFile.Text = "Select File";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSelectFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtFilePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXT_TagsPerFile);
            this.groupBox2.Controls.Add(this.Txt_XMLTag);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // TXT_TagsPerFile
            // 
            this.TXT_TagsPerFile.Location = new System.Drawing.Point(180, 64);
            this.TXT_TagsPerFile.Name = "TXT_TagsPerFile";
            this.TXT_TagsPerFile.Size = new System.Drawing.Size(100, 20);
            this.TXT_TagsPerFile.TabIndex = 3;
            // 
            // Txt_XMLTag
            // 
            this.Txt_XMLTag.Location = new System.Drawing.Point(180, 22);
            this.Txt_XMLTag.Name = "Txt_XMLTag";
            this.Txt_XMLTag.Size = new System.Drawing.Size(100, 20);
            this.Txt_XMLTag.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of Tags Per File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tag to Split:\r\n(This must be a child tag of root) ";
            // 
            // BtnSplitXML
            // 
            this.BtnSplitXML.Location = new System.Drawing.Point(344, 76);
            this.BtnSplitXML.Name = "BtnSplitXML";
            this.BtnSplitXML.Size = new System.Drawing.Size(184, 93);
            this.BtnSplitXML.TabIndex = 5;
            this.BtnSplitXML.Text = "Split XML";
            this.BtnSplitXML.UseVisualStyleBackColor = true;
            this.BtnSplitXML.Click += new System.EventHandler(this.BtnSplitXML_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OutputLogArea
            // 
            this.OutputLogArea.BackColor = System.Drawing.SystemColors.MenuBar;
            this.OutputLogArea.Location = new System.Drawing.Point(13, 188);
            this.OutputLogArea.Name = "OutputLogArea";
            this.OutputLogArea.Size = new System.Drawing.Size(515, 270);
            this.OutputLogArea.TabIndex = 6;
            this.OutputLogArea.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 484);
            this.Controls.Add(this.OutputLogArea);
            this.Controls.Add(this.BtnSplitXML);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFilePath;
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXT_TagsPerFile;
        private System.Windows.Forms.TextBox Txt_XMLTag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSplitXML;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox OutputLogArea;
    }
}

