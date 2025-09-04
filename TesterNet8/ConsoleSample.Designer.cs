/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2025 08:09:39
 * Version: 1.0.189
 */

namespace TesterNet8
{
    partial class ConsoleSample
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleSample));
            label2 = new Label();
            consoleTextBox1 = new ConsoleTextBox();
            ((System.ComponentModel.ISupportInitialize)consoleTextBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(860, 44);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // consoleTextBox1
            // 
            consoleTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            consoleTextBox1.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            consoleTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            consoleTextBox1.AutoScrollMinSize = new Size(585, 15);
            consoleTextBox1.BackBrush = null;
            consoleTextBox1.BackColor = Color.Black;
            consoleTextBox1.CaretColor = Color.White;
            consoleTextBox1.CharHeight = 15;
            consoleTextBox1.CharWidth = 7;
            consoleTextBox1.Cursor = Cursors.IBeam;
            consoleTextBox1.DefaultMarkerSize = 8;
            consoleTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            consoleTextBox1.FoldingIndicatorColor = Color.Gold;
            consoleTextBox1.Font = new Font("Consolas", 9.75F);
            consoleTextBox1.ForeColor = Color.White;
            consoleTextBox1.IndentBackColor = Color.Black;
            consoleTextBox1.IsReadLineMode = false;
            consoleTextBox1.IsReplaceMode = false;
            consoleTextBox1.LineNumberColor = Color.Gold;
            consoleTextBox1.Location = new Point(14, 47);
            consoleTextBox1.Margin = new Padding(4, 3, 4, 3);
            consoleTextBox1.Name = "consoleTextBox1";
            consoleTextBox1.PaddingBackColor = Color.Black;
            consoleTextBox1.Paddings = new Padding(0);
            consoleTextBox1.PreferredLineWidth = 80;
            consoleTextBox1.SelectionColor = Color.FromArgb(150, 255, 255, 255);
            consoleTextBox1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("consoleTextBox1.ServiceColors");
            consoleTextBox1.ServiceLinesColor = Color.DimGray;
            consoleTextBox1.Size = new Size(832, 395);
            consoleTextBox1.TabIndex = 0;
            consoleTextBox1.WordWrap = true;
            consoleTextBox1.WordWrapMode = FastColoredTextBoxNS.WordWrapMode.CharWrapPreferredWidth;
            consoleTextBox1.Zoom = 100;
            // 
            // ConsoleSample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 456);
            Controls.Add(label2);
            Controls.Add(consoleTextBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ConsoleSample";
            Text = "ConsoleSample";
            ((System.ComponentModel.ISupportInitialize)consoleTextBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private ConsoleTextBox consoleTextBox1;
        private System.Windows.Forms.Label label2;

    }
}