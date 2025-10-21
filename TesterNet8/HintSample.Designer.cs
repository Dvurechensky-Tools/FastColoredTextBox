/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:30:03
 * Version: 1.0.236
 */

namespace TesterNet8
{
    partial class HintSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HintSample));
            btFind = new Button();
            cbInline = new CheckBox();
            panel2 = new Panel();
            cbSimple = new CheckBox();
            tbFind = new TextBox();
            cbDock = new CheckBox();
            label2 = new Label();
            fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fctb).BeginInit();
            SuspendLayout();
            // 
            // btFind
            // 
            btFind.Location = new Point(14, 16);
            btFind.Margin = new Padding(4, 3, 4, 3);
            btFind.Name = "btFind";
            btFind.Size = new Size(103, 36);
            btFind.TabIndex = 2;
            btFind.Text = "Find and hint:";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += button2_Click;
            // 
            // cbInline
            // 
            cbInline.AutoSize = true;
            cbInline.Checked = true;
            cbInline.CheckState = CheckState.Checked;
            cbInline.Location = new Point(262, 25);
            cbInline.Margin = new Padding(4, 3, 4, 3);
            cbInline.Name = "cbInline";
            cbInline.Size = new Size(57, 21);
            cbInline.TabIndex = 3;
            cbInline.Text = "Inline";
            cbInline.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbSimple);
            panel2.Controls.Add(tbFind);
            panel2.Controls.Add(cbDock);
            panel2.Controls.Add(btFind);
            panel2.Controls.Add(cbInline);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 51);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 62);
            panel2.TabIndex = 4;
            // 
            // cbSimple
            // 
            cbSimple.AutoSize = true;
            cbSimple.Checked = true;
            cbSimple.CheckState = CheckState.Checked;
            cbSimple.Location = new Point(405, 25);
            cbSimple.Margin = new Padding(4, 3, 4, 3);
            cbSimple.Name = "cbSimple";
            cbSimple.Size = new Size(66, 21);
            cbSimple.TabIndex = 6;
            cbSimple.Text = "Simple";
            cbSimple.UseVisualStyleBackColor = true;
            // 
            // tbFind
            // 
            tbFind.Location = new Point(124, 23);
            tbFind.Margin = new Padding(4, 3, 4, 3);
            tbFind.Name = "tbFind";
            tbFind.Size = new Size(116, 25);
            tbFind.TabIndex = 5;
            tbFind.Text = "char";
            // 
            // cbDock
            // 
            cbDock.AutoSize = true;
            cbDock.Checked = true;
            cbDock.CheckState = CheckState.Checked;
            cbDock.Location = new Point(337, 25);
            cbDock.Margin = new Padding(4, 3, 4, 3);
            cbDock.Name = "cbDock";
            cbDock.Size = new Size(56, 21);
            cbDock.TabIndex = 4;
            cbDock.Text = "Dock";
            cbDock.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(573, 51);
            label2.TabIndex = 5;
            label2.Text = "The example shows usage of Hints. Press Find to add some hints. Press Esc to remove all hints.";
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
            fctb.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);\n";
            fctb.AutoScrollMinSize = new Size(0, 290);
            fctb.BackBrush = null;
            fctb.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            fctb.CharHeight = 15;
            fctb.CharWidth = 7;
            fctb.Cursor = Cursors.IBeam;
            fctb.DefaultMarkerSize = 8;
            fctb.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fctb.Dock = DockStyle.Fill;
            fctb.Font = new Font("Consolas", 9.75F);
            fctb.IsReplaceMode = false;
            fctb.Language = FastColoredTextBoxNS.Language.CSharp;
            fctb.LeftBracket = '(';
            fctb.LeftBracket2 = '{';
            fctb.Location = new Point(0, 113);
            fctb.Margin = new Padding(4, 3, 4, 3);
            fctb.Name = "fctb";
            fctb.PaddingBackColor = Color.WhiteSmoke;
            fctb.Paddings = new Padding(10);
            fctb.RightBracket = ')';
            fctb.RightBracket2 = '}';
            fctb.SelectionColor = Color.FromArgb(50, 0, 0, 255);
            fctb.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctb.ServiceColors");
            fctb.Size = new Size(573, 523);
            fctb.TabIndex = 0;
            fctb.Text = resources.GetString("fctb.Text");
            fctb.TextAreaBorder = FastColoredTextBoxNS.TextAreaBorderType.Shadow;
            fctb.TextAreaBorderColor = Color.Gray;
            fctb.WordWrap = true;
            fctb.Zoom = 100;
            fctb.HintClick += fctb_HintClick;
            // 
            // HintSample
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 636);
            Controls.Add(fctb);
            Controls.Add(panel2);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            Name = "HintSample";
            Text = "HintSample";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fctb).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.CheckBox cbInline;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbDock;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.CheckBox cbSimple;
        private System.Windows.Forms.Label label2;
    }
}