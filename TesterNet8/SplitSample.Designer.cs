/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 сентября 2025 06:53:06
 * Version: 1.0.199
 */

namespace TesterNet8
{
    partial class SplitSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitSample));
            label1 = new Label();
            label2 = new Label();
            splitter1 = new Splitter();
            fctbMaster = new FastColoredTextBoxNS.FastColoredTextBox();
            fctbSlave = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)fctbMaster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fctbSlave).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(712, 107);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            // 
            // splitter1
            // 
            splitter1.BorderStyle = BorderStyle.FixedSingle;
            splitter1.Dock = DockStyle.Bottom;
            splitter1.Location = new Point(0, 343);
            splitter1.Margin = new Padding(4, 3, 4, 3);
            splitter1.MinSize = 0;
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(712, 7);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // fctbMaster
            // 
            fctbMaster.AutoCompleteBracketsList = new char[]
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
            fctbMaster.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);\n";
            fctbMaster.AutoScrollMinSize = new Size(284, 255);
            fctbMaster.BackBrush = null;
            fctbMaster.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            fctbMaster.CharHeight = 15;
            fctbMaster.CharWidth = 7;
            fctbMaster.Cursor = Cursors.IBeam;
            fctbMaster.DefaultMarkerSize = 8;
            fctbMaster.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fctbMaster.Dock = DockStyle.Fill;
            fctbMaster.Font = new Font("Consolas", 9.75F);
            fctbMaster.IsReplaceMode = false;
            fctbMaster.Language = FastColoredTextBoxNS.Language.CSharp;
            fctbMaster.LeftBracket = '(';
            fctbMaster.LeftBracket2 = '{';
            fctbMaster.Location = new Point(0, 107);
            fctbMaster.Margin = new Padding(4, 3, 4, 3);
            fctbMaster.Name = "fctbMaster";
            fctbMaster.Paddings = new Padding(0);
            fctbMaster.RightBracket = ')';
            fctbMaster.RightBracket2 = '}';
            fctbMaster.SelectionColor = Color.FromArgb(50, 0, 0, 255);
            fctbMaster.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctbMaster.ServiceColors");
            fctbMaster.ShowCaretWhenInactive = true;
            fctbMaster.Size = new Size(712, 236);
            fctbMaster.TabIndex = 0;
            fctbMaster.Text = resources.GetString("fctbMaster.Text");
            fctbMaster.Zoom = 100;
            // 
            // fctbSlave
            // 
            fctbSlave.AutoCompleteBracketsList = new char[]
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
            fctbSlave.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);\n";
            fctbSlave.AutoScrollMinSize = new Size(0, 255);
            fctbSlave.BackBrush = null;
            fctbSlave.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            fctbSlave.CharHeight = 15;
            fctbSlave.CharWidth = 7;
            fctbSlave.Cursor = Cursors.IBeam;
            fctbSlave.DefaultMarkerSize = 8;
            fctbSlave.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fctbSlave.Dock = DockStyle.Bottom;
            fctbSlave.Font = new Font("Consolas", 9.75F);
            fctbSlave.IsReplaceMode = false;
            fctbSlave.Language = FastColoredTextBoxNS.Language.CSharp;
            fctbSlave.LeftBracket = '(';
            fctbSlave.LeftBracket2 = '{';
            fctbSlave.Location = new Point(0, 350);
            fctbSlave.Margin = new Padding(4, 3, 4, 3);
            fctbSlave.Name = "fctbSlave";
            fctbSlave.Paddings = new Padding(0);
            fctbSlave.RightBracket = ')';
            fctbSlave.RightBracket2 = '}';
            fctbSlave.SelectionColor = Color.FromArgb(50, 0, 0, 255);
            fctbSlave.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctbSlave.ServiceColors");
            fctbSlave.ShowCaretWhenInactive = true;
            fctbSlave.Size = new Size(712, 192);
            fctbSlave.SourceTextBox = fctbMaster;
            fctbSlave.TabIndex = 1;
            fctbSlave.Text = resources.GetString("fctbSlave.Text");
            fctbSlave.WordWrap = true;
            fctbSlave.Zoom = 100;
            // 
            // SplitSample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 542);
            Controls.Add(fctbMaster);
            Controls.Add(splitter1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fctbSlave);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SplitSample";
            Text = "SplitSample";
            ((System.ComponentModel.ISupportInitialize)fctbMaster).EndInit();
            ((System.ComponentModel.ISupportInitialize)fctbSlave).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctbMaster;
        private FastColoredTextBoxNS.FastColoredTextBox fctbSlave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
    }
}