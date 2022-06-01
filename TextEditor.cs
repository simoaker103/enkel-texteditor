using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVGB07_lab3
{
    public partial class TextEditor : Form
    {

        string filePath;
        bool dragAndDropFile;

        public TextEditor()
        {
            InitializeComponent();

            this.textArea.AllowDrop = true;
            this.textArea.DragEnter += new System.Windows.Forms.DragEventHandler (this.textArea_DragEnter);
            this.textArea.DragDrop += new System.Windows.Forms.DragEventHandler (this.textArea_DragDrop);

            filePath = "";
            dragAndDropFile = false;
        }

        private string fileFromPath(string s)
        {
            int i = s.LastIndexOf('\\');
            s = s.Substring(i + 1);

            return s;
        }

        private void open_Click(object sender, EventArgs e)
        {

            if (Text.Contains('*'))
            {
                var d = new DialogSave();
                var dResult = d.ShowDialog();

                if (dResult == DialogResult.Yes)
                {
                    saveAsButton.PerformClick();
                }

                if (dResult == DialogResult.No)
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;

                        textArea.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                        Text = fileFromPath(openFileDialog.FileName);
                    }
                }
            }
            else
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    textArea.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    Text = fileFromPath(openFileDialog.FileName);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (Text.Contains('*'))
            {
                if (filePath != "")
                {
                    textArea.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                    Text = Text.Remove(Text.Length - 1);
                }
                else
                {
                    saveAsButton.PerformClick();
                }
            }  

        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;

                textArea.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                Text = fileFromPath(saveFileDialog.FileName);

            }
        }

        private void new_Click(object sender, EventArgs e)
        {
            if (Text.Contains('*'))
            {
                var d = new DialogSave();
                var dResult = d.ShowDialog();

                if(dResult == DialogResult.Yes)
                {
                    saveAsButton.PerformClick();
                }

                if (dResult == DialogResult.No)
                {
                    textArea.Text = "";
                    Text = "namnlös.txt";
                    filePath = "";
                }
            } else
            {
                textArea.Text = "";
                Text = "namnlös.txt";
                filePath = "";
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Text.Contains("*") && !dragAndDropFile)
            {
                Text += "*";
            }

            if (dragAndDropFile)
            {
                dragAndDropFile = false;
            }

            nrOfChar.Text = textArea.Text.Replace("\n", "").Length.ToString();
            nrOfCharNoSpaces.Text = textArea.Text.Replace(" ", "").Replace("\n", "").Count().ToString();

            string[] s = textArea.Text.Split(' ', '\n');
            var temp = new List<string>();

            foreach (var item in s)
            {
                if(item != "")
                    temp.Add(item);
            }

            nrOfWords.Text = temp.Count().ToString();
            nrOfRows.Text = textArea.Text.Split('\n').Length.ToString();            

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Text.Contains('*'))
            {
                var d = new DialogClose();
                var dResult = d.ShowDialog();

                if (dResult == DialogResult.Yes)
                {
                    saveButton.PerformClick();
                }

                if (dResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
          
        }

        // För drag&drop-funktionaliteten har jag använt kodsnuttar hämtade från Microsofts dokumentation.
        // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.dragdropeffects?view=windowsdesktop-6.0
        // https://docs.microsoft.com/en-US/troubleshoot/developer/visualstudio/cpp/language-compilers/provide-file-drag-drop-functionality

        private void textArea_DragDrop(object sender, DragEventArgs e)
        {

            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop);
            string filePathDroppedFile = s[0];

            // CTRL-knappen hålls nedtryckt.
            if ((e.KeyState & 8) == 8)
            {
                if(textArea.Text.Trim() != "")
                {
                    string temp = textArea.Text;

                    textArea.LoadFile(filePathDroppedFile, RichTextBoxStreamType.PlainText);
                    textArea.Text = temp.Insert(temp.Length, textArea.Text);

                } else
                {
                    textArea.LoadFile(filePathDroppedFile, RichTextBoxStreamType.PlainText);

                }

            }

            // SHIFT-knappen hålls nedtryckt.
            else if ((e.KeyState & 4) == 4)
            {

                if (textArea.Text.Trim() != "")
                {
                    string temp = textArea.Text;

                    int caretPosition = textArea.SelectionStart;

                    textArea.LoadFile(filePathDroppedFile, RichTextBoxStreamType.PlainText);
                    textArea.Text = temp.Insert(caretPosition, textArea.Text );

                }
                else
                {
                    textArea.LoadFile(filePathDroppedFile, RichTextBoxStreamType.PlainText);
                }
            }

            // Ingen knapp hålls nedtryckt.
            else
            {   
                // Inget att spara.
                if (!Text.Contains("*"))
                {
                    textArea.LoadFile(filePathDroppedFile, RichTextBoxStreamType.PlainText);
                    Text = fileFromPath(filePathDroppedFile);

                    dragAndDropFile = true;
                    filePath = filePathDroppedFile;
                }

                // Frågar om ändringarna ska sparas innan filen laddas in.
                else
                {
                    var d = new DialogSave();
                    var dResult = d.ShowDialog();

                    if(dResult == DialogResult.Yes)
                    {
                        saveButton.PerformClick();
                        textArea.LoadFile(filePathDroppedFile, RichTextBoxStreamType.PlainText);
                        Text = fileFromPath(filePathDroppedFile);

                        dragAndDropFile = true;
                        filePath = filePathDroppedFile;
                    }
                    else if(dResult == DialogResult.No)
                    {
                        textArea.LoadFile(filePathDroppedFile, RichTextBoxStreamType.PlainText);
                        Text = fileFromPath(filePathDroppedFile);

                        dragAndDropFile = true;
                        filePath = filePathDroppedFile;
                    }
                    else if (dResult == DialogResult.Cancel)
                    {
                        return;
                    }

                }

            }

        }
        
        private void textArea_DragEnter(object sender, DragEventArgs e)
        {
            // Kontrollerar att det är en fil.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;

        }
    }
}
