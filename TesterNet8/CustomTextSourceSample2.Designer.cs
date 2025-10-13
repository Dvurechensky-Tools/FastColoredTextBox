/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 октября 2025 10:03:22
 * Version: 1.0.228
 */

namespace TesterNet8
{
    partial class CustomTextSourceSample2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomTextSourceSample2));
            fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            label1 = new Label();
            tbLineFilter = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)fctb).BeginInit();
            SuspendLayout();
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
            fctb.AutoScrollMinSize = new Size(27, 17);
            fctb.BackBrush = null;
            fctb.CharHeight = 15;
            fctb.CharWidth = 7;
            fctb.Cursor = Cursors.IBeam;
            fctb.DefaultMarkerSize = 8;
            fctb.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fctb.Dock = DockStyle.Fill;
            fctb.Font = new Font("Consolas", 9.75F);
            fctb.IsReplaceMode = false;
            fctb.LeftBracket = '(';
            fctb.Location = new Point(0, 74);
            fctb.Margin = new Padding(4, 5, 4, 5);
            fctb.Name = "fctb";
            fctb.Paddings = new Padding(1);
            fctb.RightBracket = ')';
            fctb.SelectionColor = Color.FromArgb(50, 0, 0, 255);
            fctb.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctb.ServiceColors");
            fctb.Size = new Size(664, 346);
            fctb.TabIndex = 0;
            fctb.Zoom = 100;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(664, 74);
            label1.TabIndex = 2;
            label1.Text = "Custom TextSource with supporting of line filtering.";
            // 
            // tbLineFilter
            // 
            tbLineFilter.Location = new Point(86, 43);
            tbLineFilter.Name = "tbLineFilter";
            tbLineFilter.Size = new Size(136, 25);
            tbLineFilter.TabIndex = 3;
            tbLineFilter.TextChanged += tbLineFilter_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 45);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 4;
            label2.Text = "Line Filter:";
            // 
            // CustomTextSourceSample2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 420);
            Controls.Add(label2);
            Controls.Add(tbLineFilter);
            Controls.Add(fctb);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CustomTextSourceSample2";
            Text = "CustomTextSourceSample";
            Shown += CustomTextSourceSample_Shown;
            ((System.ComponentModel.ISupportInitialize)fctb).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLineFilter;
        private System.Windows.Forms.Label label2;
    }
}