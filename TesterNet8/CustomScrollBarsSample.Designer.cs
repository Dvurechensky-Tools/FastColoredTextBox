/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 сентября 2025 06:53:14
 * Version: 1.0.209
 */

namespace TesterNet8
{
    partial class CustomScrollBarsSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomScrollBarsSample));
            label2 = new Label();
            vScrollBar = new VScrollBar();
            hScrollBar = new HScrollBar();
            hMyScrollBar = new MyScrollBar();
            vMyScrollBar = new MyScrollBar();
            fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)fctb).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(538, 50);
            label2.TabIndex = 2;
            label2.Text = "Here we create custom outside scrollbars for FCTB.";
            // 
            // vScrollBar
            // 
            vScrollBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            vScrollBar.Location = new Point(419, 82);
            vScrollBar.Name = "vScrollBar";
            vScrollBar.Size = new Size(17, 237);
            vScrollBar.TabIndex = 8;
            vScrollBar.Scroll += ScrollBar_Scroll;
            // 
            // hScrollBar
            // 
            hScrollBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hScrollBar.Location = new Point(48, 432);
            hScrollBar.Name = "hScrollBar";
            hScrollBar.Size = new Size(265, 17);
            hScrollBar.TabIndex = 9;
            hScrollBar.Scroll += ScrollBar_Scroll;
            // 
            // hMyScrollBar
            // 
            hMyScrollBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hMyScrollBar.BackColor = Color.Gold;
            hMyScrollBar.BorderColor = Color.Gray;
            hMyScrollBar.Location = new Point(48, 366);
            hMyScrollBar.Margin = new Padding(4, 3, 4, 3);
            hMyScrollBar.Maximum = 100;
            hMyScrollBar.Name = "hMyScrollBar";
            hMyScrollBar.Orientation = ScrollOrientation.HorizontalScroll;
            hMyScrollBar.Size = new Size(265, 18);
            hMyScrollBar.TabIndex = 7;
            hMyScrollBar.Text = "myScrollBar2";
            hMyScrollBar.ThumbColor = Color.Red;
            hMyScrollBar.ThumbSize = 10;
            hMyScrollBar.Value = 0;
            hMyScrollBar.Scroll += ScrollBar_Scroll;
            // 
            // vMyScrollBar
            // 
            vMyScrollBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            vMyScrollBar.BackColor = Color.Gold;
            vMyScrollBar.BorderColor = Color.Gray;
            vMyScrollBar.Location = new Point(366, 82);
            vMyScrollBar.Margin = new Padding(4, 3, 4, 3);
            vMyScrollBar.Maximum = 100;
            vMyScrollBar.Name = "vMyScrollBar";
            vMyScrollBar.Orientation = ScrollOrientation.VerticalScroll;
            vMyScrollBar.Size = new Size(16, 235);
            vMyScrollBar.TabIndex = 6;
            vMyScrollBar.Text = "myScrollBar1";
            vMyScrollBar.ThumbColor = Color.Red;
            vMyScrollBar.ThumbSize = 10;
            vMyScrollBar.Value = 0;
            vMyScrollBar.Scroll += ScrollBar_Scroll;
            // 
            // fctb
            // 
            fctb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            fctb.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);\n";
            fctb.AutoScrollMinSize = new Size(284, 315);
            fctb.BackBrush = null;
            fctb.BackColor = Color.Gold;
            fctb.BorderStyle = BorderStyle.FixedSingle;
            fctb.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            fctb.CharHeight = 15;
            fctb.CharWidth = 7;
            fctb.Cursor = Cursors.IBeam;
            fctb.DefaultMarkerSize = 8;
            fctb.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fctb.Font = new Font("Consolas", 9.75F);
            fctb.IndentBackColor = Color.Orange;
            fctb.IsReplaceMode = false;
            fctb.Language = FastColoredTextBoxNS.Language.CSharp;
            fctb.LeftBracket = '(';
            fctb.LeftBracket2 = '{';
            fctb.Location = new Point(48, 82);
            fctb.Margin = new Padding(4, 3, 4, 3);
            fctb.Name = "fctb";
            fctb.Paddings = new Padding(0);
            fctb.RightBracket = ')';
            fctb.RightBracket2 = '}';
            fctb.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            fctb.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctb.ServiceColors");
            fctb.ServiceLinesColor = Color.DarkGray;
            fctb.ShowScrollBars = false;
            fctb.Size = new Size(264, 233);
            fctb.TabIndex = 3;
            fctb.Text = resources.GetString("fctb.Text");
            fctb.Zoom = 100;
            fctb.ScrollbarsUpdated += fctb_ScrollbarsUpdated;
            // 
            // CustomScrollBarsSample
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 527);
            Controls.Add(hScrollBar);
            Controls.Add(vScrollBar);
            Controls.Add(hMyScrollBar);
            Controls.Add(vMyScrollBar);
            Controls.Add(fctb);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CustomScrollBarsSample";
            Text = "CustomScrollBarsSample";
            ((System.ComponentModel.ISupportInitialize)fctb).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private MyScrollBar vMyScrollBar;
        private MyScrollBar hMyScrollBar;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.HScrollBar hScrollBar;

    }
}