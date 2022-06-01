
namespace DVGB07_lab3
{
    partial class TextEditor
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
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nrOfChar = new System.Windows.Forms.Label();
            this.nrOfCharNoSpaces = new System.Windows.Forms.Label();
            this.nrOfWords = new System.Windows.Forms.Label();
            this.nrOfRows = new System.Windows.Forms.Label();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 321);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Öppna";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.open_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(93, 321);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Spara";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(174, 321);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 23);
            this.saveAsButton.TabIndex = 3;
            this.saveAsButton.Text = "Spara som...";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(336, 321);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Avsluta";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.close_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(255, 321);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "Ny...";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.new_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "txt files (*.txt)|*.txt|Alla filer (*.*)|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt files (*.txt)|*.txt|Alla filer (*.*)|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Antal tecken med mellanslag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Antal tecken utan mellanslag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Antal ord:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Antal rader:";
            // 
            // nrOfChar
            // 
            this.nrOfChar.AutoSize = true;
            this.nrOfChar.Location = new System.Drawing.Point(156, 363);
            this.nrOfChar.Name = "nrOfChar";
            this.nrOfChar.Size = new System.Drawing.Size(0, 13);
            this.nrOfChar.TabIndex = 10;
            // 
            // nrOfCharNoSpaces
            // 
            this.nrOfCharNoSpaces.AutoSize = true;
            this.nrOfCharNoSpaces.Location = new System.Drawing.Point(157, 385);
            this.nrOfCharNoSpaces.Name = "nrOfCharNoSpaces";
            this.nrOfCharNoSpaces.Size = new System.Drawing.Size(0, 13);
            this.nrOfCharNoSpaces.TabIndex = 11;
            // 
            // nrOfWords
            // 
            this.nrOfWords.AutoSize = true;
            this.nrOfWords.Location = new System.Drawing.Point(63, 408);
            this.nrOfWords.Name = "nrOfWords";
            this.nrOfWords.Size = new System.Drawing.Size(0, 13);
            this.nrOfWords.TabIndex = 12;
            // 
            // nrOfRows
            // 
            this.nrOfRows.AutoSize = true;
            this.nrOfRows.Location = new System.Drawing.Point(72, 430);
            this.nrOfRows.Name = "nrOfRows";
            this.nrOfRows.Size = new System.Drawing.Size(0, 13);
            this.nrOfRows.TabIndex = 13;
            // 
            // textArea
            // 
            this.textArea.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArea.Location = new System.Drawing.Point(0, 0);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(425, 306);
            this.textArea.TabIndex = 0;
            this.textArea.Text = "";
            this.textArea.WordWrap = false;
            this.textArea.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 459);
            this.Controls.Add(this.nrOfRows);
            this.Controls.Add(this.nrOfWords);
            this.Controls.Add(this.nrOfCharNoSpaces);
            this.Controls.Add(this.nrOfChar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.textArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TextEditor";
            this.Text = "namnlös.txt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEditor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nrOfChar;
        private System.Windows.Forms.Label nrOfCharNoSpaces;
        private System.Windows.Forms.Label nrOfWords;
        private System.Windows.Forms.Label nrOfRows;
        private System.Windows.Forms.RichTextBox textArea;
    }
}

