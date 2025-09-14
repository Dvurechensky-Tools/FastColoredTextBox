/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 сентября 2025 06:53:06
 * Version: 1.0.199
 */

namespace TesterNet8
{
    partial class LazyLoadingSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LazyLoadingSample));
            ofd = new OpenFileDialog();
            ms = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            miOpen = new ToolStripMenuItem();
            miSave = new ToolStripMenuItem();
            closeFileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            collapseAllFoldingBlocksToolStripMenuItem = new ToolStripMenuItem();
            expandAllCollapsedBlocksToolStripMenuItem = new ToolStripMenuItem();
            removeEmptyLinesToolStripMenuItem = new ToolStripMenuItem();
            createTestFileToolStripMenuItem = new ToolStripMenuItem();
            sfd = new SaveFileDialog();
            label2 = new Label();
            fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            ms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fctb).BeginInit();
            SuspendLayout();
            // 
            // ofd
            // 
            ofd.DefaultExt = "txt";
            ofd.Filter = "Text file|*.txt|All files|*.*";
            // 
            // ms
            // 
            ms.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, createTestFileToolStripMenuItem });
            ms.Location = new Point(0, 0);
            ms.Name = "ms";
            ms.Padding = new Padding(7, 2, 0, 2);
            ms.Size = new Size(755, 24);
            ms.TabIndex = 1;
            ms.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miOpen, miSave, closeFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // miOpen
            // 
            miOpen.Name = "miOpen";
            miOpen.Size = new Size(166, 22);
            miOpen.Text = "Bind to file ...";
            miOpen.Click += miOpen_Click;
            // 
            // miSave
            // 
            miSave.Name = "miSave";
            miSave.Size = new Size(166, 22);
            miSave.Text = "Save to file ...";
            miSave.Click += miSave_Click;
            // 
            // closeFileToolStripMenuItem
            // 
            closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            closeFileToolStripMenuItem.Size = new Size(166, 22);
            closeFileToolStripMenuItem.Text = "Close binding file";
            closeFileToolStripMenuItem.Click += closeFileToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { collapseAllFoldingBlocksToolStripMenuItem, expandAllCollapsedBlocksToolStripMenuItem, removeEmptyLinesToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // collapseAllFoldingBlocksToolStripMenuItem
            // 
            collapseAllFoldingBlocksToolStripMenuItem.Name = "collapseAllFoldingBlocksToolStripMenuItem";
            collapseAllFoldingBlocksToolStripMenuItem.Size = new Size(218, 22);
            collapseAllFoldingBlocksToolStripMenuItem.Text = "Collapse all folding blocks";
            collapseAllFoldingBlocksToolStripMenuItem.Click += collapseAllFoldingBlocksToolStripMenuItem_Click;
            // 
            // expandAllCollapsedBlocksToolStripMenuItem
            // 
            expandAllCollapsedBlocksToolStripMenuItem.Name = "expandAllCollapsedBlocksToolStripMenuItem";
            expandAllCollapsedBlocksToolStripMenuItem.Size = new Size(218, 22);
            expandAllCollapsedBlocksToolStripMenuItem.Text = "Expand all collapsed blocks";
            expandAllCollapsedBlocksToolStripMenuItem.Click += expandAllCollapsedBlocksToolStripMenuItem_Click;
            // 
            // removeEmptyLinesToolStripMenuItem
            // 
            removeEmptyLinesToolStripMenuItem.Name = "removeEmptyLinesToolStripMenuItem";
            removeEmptyLinesToolStripMenuItem.Size = new Size(218, 22);
            removeEmptyLinesToolStripMenuItem.Text = "Remove empty lines";
            removeEmptyLinesToolStripMenuItem.Click += removeEmptyLinesToolStripMenuItem_Click;
            // 
            // createTestFileToolStripMenuItem
            // 
            createTestFileToolStripMenuItem.Name = "createTestFileToolStripMenuItem";
            createTestFileToolStripMenuItem.Size = new Size(94, 20);
            createTestFileToolStripMenuItem.Text = "Create test file";
            createTestFileToolStripMenuItem.Click += createTestFileToolStripMenuItem_Click;
            // 
            // sfd
            // 
            sfd.DefaultExt = "txt";
            sfd.Filter = "Text file|*.txt|All files|*.*";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(755, 72);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
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
            fctb.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            fctb.AutoScrollMinSize = new Size(480, 45);
            fctb.BackBrush = null;
            fctb.CharHeight = 15;
            fctb.CharWidth = 7;
            fctb.Cursor = Cursors.IBeam;
            fctb.DefaultMarkerSize = 8;
            fctb.DelayedEventsInterval = 300;
            fctb.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fctb.Dock = DockStyle.Fill;
            fctb.Font = new Font("Consolas", 9.75F);
            fctb.IsReplaceMode = false;
            fctb.Location = new Point(0, 96);
            fctb.Margin = new Padding(4, 3, 4, 3);
            fctb.Name = "fctb";
            fctb.Paddings = new Padding(0);
            fctb.SelectionColor = Color.FromArgb(50, 0, 0, 255);
            fctb.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctb.ServiceColors");
            fctb.Size = new Size(755, 293);
            fctb.TabIndex = 0;
            fctb.Text = "Press \"Create test file\", select target directory and press Save.\r\nWill be created large file (approx. 50mb). \r\nThen bind file to the control in menu File/Bind to file.";
            fctb.Zoom = 100;
            fctb.TextChangedDelayed += fctb_TextChangedDelayed;
            fctb.VisibleRangeChangedDelayed += fctb_VisibleRangeChangedDelayed;
            // 
            // LazyLoadingSample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 389);
            Controls.Add(fctb);
            Controls.Add(label2);
            Controls.Add(ms);
            MainMenuStrip = ms;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LazyLoadingSample";
            Text = "LazyLoadingSample";
            FormClosing += LazyLoadingSample_FormClosing;
            ms.ResumeLayout(false);
            ms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fctb).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ToolStripMenuItem createTestFileToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllFoldingBlocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllCollapsedBlocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmptyLinesToolStripMenuItem;
    }
}