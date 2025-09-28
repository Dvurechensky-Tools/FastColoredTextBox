/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2025 21:15:30
 * Version: 1.0.213
 */

namespace TesterNet8
{
    partial class AutocompleteSample2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutocompleteSample2));
            label1 = new Label();
            imageList1 = new ImageList(components);
            fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)fctb).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(572, 111);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth24Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "script_16x16.png");
            imageList1.Images.SetKeyName(1, "app_16x16.png");
            imageList1.Images.SetKeyName(2, "1302166543_virtualbox.png");
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
            fctb.AutoScrollMinSize = new Size(466, 330);
            fctb.BackBrush = null;
            fctb.BorderStyle = BorderStyle.FixedSingle;
            fctb.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
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
            fctb.Language = FastColoredTextBoxNS.Language.CSharp;
            fctb.LeftBracket = '(';
            fctb.LeftBracket2 = '{';
            fctb.Location = new Point(0, 111);
            fctb.Margin = new Padding(4, 3, 4, 3);
            fctb.Name = "fctb";
            fctb.Paddings = new Padding(0);
            fctb.RightBracket = ')';
            fctb.RightBracket2 = '}';
            fctb.SelectionColor = Color.FromArgb(50, 0, 0, 255);
            fctb.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctb.ServiceColors");
            fctb.Size = new Size(572, 350);
            fctb.TabIndex = 3;
            fctb.Text = resources.GetString("fctb.Text");
            fctb.Zoom = 100;
            // 
            // AutocompleteSample2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 461);
            Controls.Add(fctb);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AutocompleteSample2";
            Text = "AutocompleteSample2";
            ((System.ComponentModel.ISupportInitialize)fctb).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.ImageList imageList1;
    }
}