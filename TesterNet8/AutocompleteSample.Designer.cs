/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 сентября 2025 06:53:11
 * Version: 1.0.198
 */

namespace TesterNet8
{
    partial class AutocompleteSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutocompleteSample));
            label1 = new Label();
            fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)fctb).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(413, 58);
            label1.TabIndex = 2;
            label1.Text = "This example shows how to create simplest autocomplete functionality.\r\nPopup menu contains 500000 words.";
            // 
            // fctb
            // 
            fctb.AutoCompleteBracketsList = new char[]
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
            fctb.AutoIndent = false;
            fctb.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            fctb.AutoScrollMinSize = new Size(0, 105);
            fctb.BackBrush = null;
            fctb.BorderStyle = BorderStyle.FixedSingle;
            fctb.CharHeight = 15;
            fctb.CharWidth = 7;
            fctb.Cursor = Cursors.IBeam;
            fctb.DefaultMarkerSize = 8;
            fctb.DelayedEventsInterval = 500;
            fctb.DelayedTextChangedInterval = 500;
            fctb.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fctb.Dock = DockStyle.Fill;
            fctb.Font = new Font("Consolas", 9.75F);
            fctb.IsReplaceMode = false;
            fctb.LeftBracket = '(';
            fctb.Location = new Point(0, 58);
            fctb.Margin = new Padding(4, 3, 4, 3);
            fctb.Name = "fctb";
            fctb.Paddings = new Padding(0);
            fctb.RightBracket = ')';
            fctb.SelectionColor = Color.FromArgb(50, 0, 0, 255);
            fctb.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctb.ServiceColors");
            fctb.ShowLineNumbers = false;
            fctb.Size = new Size(413, 243);
            fctb.TabIndex = 3;
            fctb.Text = resources.GetString("fctb.Text");
            fctb.WordWrap = true;
            fctb.Zoom = 100;
            fctb.KeyDown += fctb_KeyDown;
            // 
            // AutocompleteSample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 301);
            Controls.Add(fctb);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AutocompleteSample";
            Text = "AutocompleteSample";
            ((System.ComponentModel.ISupportInitialize)fctb).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FastColoredTextBoxNS.FastColoredTextBox fctb;
    }
}