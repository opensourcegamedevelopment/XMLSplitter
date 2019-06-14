using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XMLSplitter
{
    public partial class Form1 : Form
    {
        int tagsPerFile;
        string outputLog;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
           openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
           DialogResult result = openFileDialog1.ShowDialog();
           if (result == DialogResult.OK)
           {
                TxtFilePath.Text = openFileDialog1.FileName;
           }
        }

        private async void BtnSplitXML_Click(object sender, EventArgs e)
        {
            outputLog = "";
            if (Txt_XMLTag.Text == "")
            {
                MessageBox.Show("Error - Please Enter the tag you would like the split base on");
            }
            else
            {
                bool parseSuccess = int.TryParse(TXT_TagsPerFile.Text, out tagsPerFile);
                if (parseSuccess)
                {
                    //await Task.Run(ShowOutput);
                    await Task.Run(SplitXML);
                }
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.OutputLogArea.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.OutputLogArea.Text = text;
            }
        }

        private void SplitXML()
        {
            int currentFileCount = 0;
            try
            {
                using (StreamReader reader = new StreamReader(TxtFilePath.Text))
                {
                    string currentLine;
                    string startTagToFind = "<" + Txt_XMLTag.Text + ">";
                    string endTagToFind = "</" + Txt_XMLTag.Text + ">";
                    StreamWriter writer = StreamWriter.Null;
                    writer.AutoFlush = true;
                    bool writingToFile = false;
                    int currentTagCount = 0;

                    bool headerChecked = false;
                    List<string> headerTags = new List<string>();
                    string rootTag = "";

                    while (!reader.EndOfStream)
                    {
                        currentLine = reader.ReadLine();
                        if (!headerChecked)
                        {
                            if (currentLine.StartsWith("<?") || currentLine.StartsWith("<!"))
                            {
                                headerTags.Add(currentLine);
                            }
                            else if (currentLine == startTagToFind)
                            {
                                headerChecked = true;
                            }
                            else if (rootTag == "")
                            {
                                rootTag = currentLine;
                                headerTags.Add(currentLine);
                            }
                            else
                            {
                                headerTags.Add(currentLine);
                            }
                        }

                        if (headerChecked)
                        {
                            if (writingToFile && currentTagCount < tagsPerFile && currentLine == startTagToFind)
                            {
                                //writing to file hitting start tag but not reach tagCount, so write to file only
                                writer.WriteLine(currentLine);
                                //await writer.WriteLineAsync(currentLine);
                                //Console.WriteLine("Write Line: " + currentLine);
                                //outputLog += ("Write Line: " + currentLine + "\n");
                            }
                            else if (writingToFile && currentTagCount < tagsPerFile && currentLine == endTagToFind)
                            {
                                //writing to file hitting end tag but not reach tagCount, so write to file and increase tagCount by 1
                                writer.WriteLine(currentLine);
                                //await writer.WriteLineAsync(currentLine);
                                //Console.WriteLine("Write Line: " + currentLine);
                                //outputLog += ("Write Line: " + currentLine + "\n");
                                currentTagCount++;
                                if (currentTagCount == tagsPerFile)
                                {
                                    //writing to file hitting end tag and reach tagCount, so write end root tag and close current File
                                    //write root end tags
                                    string rootEndTag = "</" + rootTag.Substring(1);
                                    writer.WriteLine(rootEndTag);

                                    writingToFile = false;
                                    writer.Close();
                                    Console.WriteLine("Closed File");
                                    outputLog += ("Closed File" + "\n");
                                }

                            }
                            else if (currentLine == startTagToFind)
                            {
                                //writing to file hitting start tag and reach tagCount, so create new file and reset tagCount to 1
                                currentFileCount++;
                                writingToFile = true;
                                string fileName = Path.GetFileName(TxtFilePath.Text);
                                string NewFileName = fileName.Substring(0, fileName.Length - 4) + "_" + currentFileCount + ".xml";
                                string NewFileFullPath = Path.GetDirectoryName(TxtFilePath.Text) + "/SplittedXML/" + NewFileName;
                                Directory.CreateDirectory(Path.GetDirectoryName(TxtFilePath.Text) + "/SplittedXML");
                                //writer.Close();
                                //Console.WriteLine("Closed File");
                                //outputLog += ("Closed File" + "\n");
                                writer = new StreamWriter(NewFileFullPath);
                                
                                //write root tags
                                foreach(string tag in headerTags)
                                {
                                    writer.WriteLine(tag);
                                }

                                writer.WriteLine(currentLine);
                                //await writer.WriteLineAsync(currentLine);
                                Console.WriteLine("Created File: " + NewFileFullPath);
                                outputLog += ("Created File: " + NewFileFullPath + "\n");
                                //Console.WriteLine("Write Line: " + currentLine);
                                //outputLog += ("Write Line: " + currentLine + "\n");
                                currentTagCount = 0;
                            }
                            else if (writingToFile)
                            {
                                writer.WriteLine(currentLine);
                                //await writer.WriteLineAsync(currentLine);
                                //Console.WriteLine("Write Line: " + currentLine);
                                //outputLog += ("Write Line: " + currentLine + "\n");
                            }
                            SetText(outputLog);
                        }
                    }
                    writer.Close();
                }
                MessageBox.Show("XML Split Completed!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
