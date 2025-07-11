namespace TesterNet8
{
    partial class MarkerToolSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkerToolSample));
            cmMark = new ContextMenuStrip(components);
            markAsYellowToolStripMenuItem = new ToolStripMenuItem();
            markAsRedToolStripMenuItem = new ToolStripMenuItem();
            markAsGreenToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            markLineBackgroundToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            clearMarkedToolStripMenuItem = new ToolStripMenuItem();
            fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            cmMark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fctb).BeginInit();
            SuspendLayout();
            // 
            // cmMark
            // 
            cmMark.Items.AddRange(new ToolStripItem[] { markAsYellowToolStripMenuItem, markAsRedToolStripMenuItem, markAsGreenToolStripMenuItem, toolStripMenuItem1, markLineBackgroundToolStripMenuItem, toolStripMenuItem2, clearMarkedToolStripMenuItem });
            cmMark.Name = "contextMenuStrip1";
            cmMark.Size = new Size(191, 126);
            // 
            // markAsYellowToolStripMenuItem
            // 
            markAsYellowToolStripMenuItem.Name = "markAsYellowToolStripMenuItem";
            markAsYellowToolStripMenuItem.Size = new Size(190, 22);
            markAsYellowToolStripMenuItem.Tag = "yellow";
            markAsYellowToolStripMenuItem.Text = "Mark as Yellow";
            markAsYellowToolStripMenuItem.Click += markAsYellowToolStripMenuItem_Click;
            // 
            // markAsRedToolStripMenuItem
            // 
            markAsRedToolStripMenuItem.Name = "markAsRedToolStripMenuItem";
            markAsRedToolStripMenuItem.Size = new Size(190, 22);
            markAsRedToolStripMenuItem.Tag = "red";
            markAsRedToolStripMenuItem.Text = "Mark as Red";
            markAsRedToolStripMenuItem.Click += markAsYellowToolStripMenuItem_Click;
            // 
            // markAsGreenToolStripMenuItem
            // 
            markAsGreenToolStripMenuItem.Name = "markAsGreenToolStripMenuItem";
            markAsGreenToolStripMenuItem.Size = new Size(190, 22);
            markAsGreenToolStripMenuItem.Tag = "green";
            markAsGreenToolStripMenuItem.Text = "Mark as Green";
            markAsGreenToolStripMenuItem.Click += markAsYellowToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(187, 6);
            // 
            // markLineBackgroundToolStripMenuItem
            // 
            markLineBackgroundToolStripMenuItem.Name = "markLineBackgroundToolStripMenuItem";
            markLineBackgroundToolStripMenuItem.Size = new Size(190, 22);
            markLineBackgroundToolStripMenuItem.Tag = "lineBackground";
            markLineBackgroundToolStripMenuItem.Text = "Mark line background";
            markLineBackgroundToolStripMenuItem.Click += markAsYellowToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(187, 6);
            // 
            // clearMarkedToolStripMenuItem
            // 
            clearMarkedToolStripMenuItem.Name = "clearMarkedToolStripMenuItem";
            clearMarkedToolStripMenuItem.Size = new Size(190, 22);
            clearMarkedToolStripMenuItem.Text = "Clear marked";
            clearMarkedToolStripMenuItem.Click += clearMarkedToolStripMenuItem_Click;
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
            fctb.AutoScrollMinSize = new Size(0, 119);
            fctb.BackBrush = null;
            fctb.CharHeight = 17;
            fctb.CharWidth = 8;
            fctb.Cursor = Cursors.IBeam;
            fctb.DefaultMarkerSize = 8;
            fctb.DelayedEventsInterval = 500;
            fctb.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fctb.Dock = DockStyle.Fill;
            fctb.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fctb.IndentBackColor = Color.FromArgb(50, 255, 255, 255);
            fctb.IsReplaceMode = false;
            fctb.LeftBracket = '(';
            fctb.LeftPadding = 15;
            fctb.Location = new Point(0, 0);
            fctb.Margin = new Padding(4, 3, 4, 3);
            fctb.Name = "fctb";
            fctb.Paddings = new Padding(0);
            fctb.RightBracket = ')';
            fctb.SelectionColor = Color.FromArgb(50, 0, 0, 255);
            fctb.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fctb.ServiceColors");
            fctb.Size = new Size(522, 302);
            fctb.TabIndex = 0;
            fctb.Text = resources.GetString("fctb.Text");
            fctb.WordWrap = true;
            fctb.Zoom = 100;
            fctb.SelectionChangedDelayed += fctb_SelectionChangedDelayed;
            fctb.VisualMarkerClick += fctb_VisualMarkerClick;
            fctb.PaintLine += fctb_PaintLine;
            fctb.Resize += fctb_Resize;
            // 
            // MarkerToolSample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 302);
            Controls.Add(fctb);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MarkerToolSample";
            Text = "MarkerTool Sample";
            cmMark.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fctb).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.ContextMenuStrip cmMark;
        private System.Windows.Forms.ToolStripMenuItem markAsYellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAsRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAsGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearMarkedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markLineBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}