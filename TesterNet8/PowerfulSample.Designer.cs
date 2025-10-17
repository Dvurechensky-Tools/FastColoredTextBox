/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 октября 2025 13:19:32
 * Version: 1.0.232
 */

using FastColoredTextBoxNS;
namespace TesterNet8
{
    partial class PowerfulSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerfulSample));
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            setSelectedAsReadonlyToolStripMenuItem = new ToolStripMenuItem();
            setSelectedAsWritableToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripSeparator();
            collapseSelectedBlockToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            collapseAllregionToolStripMenuItem = new ToolStripMenuItem();
            exapndAllregionToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            increaseIndentSiftTabToolStripMenuItem = new ToolStripMenuItem();
            decreaseIndentTabToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripSeparator();
            commentSelectedLinesToolStripMenuItem = new ToolStripMenuItem();
            uncommentSelectedLinesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            goBackwardCtrlToolStripMenuItem = new ToolStripMenuItem();
            goForwardCtrlShiftToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            autoIndentToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            goLeftBracketToolStripMenuItem = new ToolStripMenuItem();
            goRightBracketToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripSeparator();
            miPrint = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripSeparator();
            startStopMacroRecordingToolStripMenuItem = new ToolStripMenuItem();
            executeMacroToolStripMenuItem = new ToolStripMenuItem();
            miLanguage = new ToolStripMenuItem();
            miCSharp = new ToolStripMenuItem();
            cSharpbuiltinHighlighterToolStripMenuItem = new ToolStripMenuItem();
            miVB = new ToolStripMenuItem();
            hTMLToolStripMenuItem = new ToolStripMenuItem();
            xmlToolStripMenuItem = new ToolStripMenuItem();
            sQLToolStripMenuItem = new ToolStripMenuItem();
            pHPToolStripMenuItem = new ToolStripMenuItem();
            jSToolStripMenuItem = new ToolStripMenuItem();
            luaToolStripMenuItem = new ToolStripMenuItem();
            jSONToolStripMenuItem = new ToolStripMenuItem();
            assemblyToolStripMenuItem = new ToolStripMenuItem();
            batchToolStripMenuItem = new ToolStripMenuItem();
            miExport = new ToolStripMenuItem();
            hTMLToolStripMenuItem1 = new ToolStripMenuItem();
            rTFToolStripMenuItem = new ToolStripMenuItem();
            miChangeColors = new ToolStripMenuItem();
            changeHotkeysToolStripMenuItem = new ToolStripMenuItem();
            fctb = new FastColoredTextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fctb).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, miLanguage, miExport, miChangeColors, changeHotkeysToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(404, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findToolStripMenuItem, replaceToolStripMenuItem, toolStripMenuItem1, setSelectedAsReadonlyToolStripMenuItem, setSelectedAsWritableToolStripMenuItem, toolStripMenuItem8, collapseSelectedBlockToolStripMenuItem, toolStripMenuItem3, collapseAllregionToolStripMenuItem, exapndAllregionToolStripMenuItem, toolStripMenuItem2, increaseIndentSiftTabToolStripMenuItem, decreaseIndentTabToolStripMenuItem, toolStripMenuItem10, commentSelectedLinesToolStripMenuItem, uncommentSelectedLinesToolStripMenuItem, toolStripMenuItem4, goBackwardCtrlToolStripMenuItem, goForwardCtrlShiftToolStripMenuItem, toolStripMenuItem5, autoIndentToolStripMenuItem, toolStripMenuItem6, goLeftBracketToolStripMenuItem, goRightBracketToolStripMenuItem, toolStripMenuItem7, miPrint, toolStripMenuItem9, startStopMacroRecordingToolStripMenuItem, executeMacroToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(267, 22);
            findToolStripMenuItem.Text = "&Find [Ctrl+F]";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.Size = new Size(267, 22);
            replaceToolStripMenuItem.Text = "&Replace [Ctrl+H]";
            replaceToolStripMenuItem.Click += replaceToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(264, 6);
            // 
            // setSelectedAsReadonlyToolStripMenuItem
            // 
            setSelectedAsReadonlyToolStripMenuItem.Name = "setSelectedAsReadonlyToolStripMenuItem";
            setSelectedAsReadonlyToolStripMenuItem.Size = new Size(267, 22);
            setSelectedAsReadonlyToolStripMenuItem.Text = "Set selected as readonly";
            setSelectedAsReadonlyToolStripMenuItem.Click += setSelectedAsReadonlyToolStripMenuItem_Click;
            // 
            // setSelectedAsWritableToolStripMenuItem
            // 
            setSelectedAsWritableToolStripMenuItem.Name = "setSelectedAsWritableToolStripMenuItem";
            setSelectedAsWritableToolStripMenuItem.Size = new Size(267, 22);
            setSelectedAsWritableToolStripMenuItem.Text = "Set selected as writable";
            setSelectedAsWritableToolStripMenuItem.Click += setSelectedAsWritableToolStripMenuItem_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(264, 6);
            // 
            // collapseSelectedBlockToolStripMenuItem
            // 
            collapseSelectedBlockToolStripMenuItem.Name = "collapseSelectedBlockToolStripMenuItem";
            collapseSelectedBlockToolStripMenuItem.Size = new Size(267, 22);
            collapseSelectedBlockToolStripMenuItem.Text = "Collapse selected block";
            collapseSelectedBlockToolStripMenuItem.Click += collapseSelectedBlockToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(264, 6);
            // 
            // collapseAllregionToolStripMenuItem
            // 
            collapseAllregionToolStripMenuItem.Name = "collapseAllregionToolStripMenuItem";
            collapseAllregionToolStripMenuItem.Size = new Size(267, 22);
            collapseAllregionToolStripMenuItem.Text = "Collapse all #region";
            collapseAllregionToolStripMenuItem.Click += collapseAllregionToolStripMenuItem_Click;
            // 
            // exapndAllregionToolStripMenuItem
            // 
            exapndAllregionToolStripMenuItem.Name = "exapndAllregionToolStripMenuItem";
            exapndAllregionToolStripMenuItem.Size = new Size(267, 22);
            exapndAllregionToolStripMenuItem.Text = "Exapnd all #region";
            exapndAllregionToolStripMenuItem.Click += exapndAllregionToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(264, 6);
            // 
            // increaseIndentSiftTabToolStripMenuItem
            // 
            increaseIndentSiftTabToolStripMenuItem.Name = "increaseIndentSiftTabToolStripMenuItem";
            increaseIndentSiftTabToolStripMenuItem.Size = new Size(267, 22);
            increaseIndentSiftTabToolStripMenuItem.Text = "Increase Indent [Tab]";
            increaseIndentSiftTabToolStripMenuItem.Click += increaseIndentSiftTabToolStripMenuItem_Click;
            // 
            // decreaseIndentTabToolStripMenuItem
            // 
            decreaseIndentTabToolStripMenuItem.Name = "decreaseIndentTabToolStripMenuItem";
            decreaseIndentTabToolStripMenuItem.Size = new Size(267, 22);
            decreaseIndentTabToolStripMenuItem.Text = "Decrease Indent [Shift + Tab]";
            decreaseIndentTabToolStripMenuItem.Click += decreaseIndentTabToolStripMenuItem_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(264, 6);
            // 
            // commentSelectedLinesToolStripMenuItem
            // 
            commentSelectedLinesToolStripMenuItem.Name = "commentSelectedLinesToolStripMenuItem";
            commentSelectedLinesToolStripMenuItem.Size = new Size(267, 22);
            commentSelectedLinesToolStripMenuItem.Text = "Comment selected lines";
            commentSelectedLinesToolStripMenuItem.Click += commentSelectedLinesToolStripMenuItem_Click;
            // 
            // uncommentSelectedLinesToolStripMenuItem
            // 
            uncommentSelectedLinesToolStripMenuItem.Name = "uncommentSelectedLinesToolStripMenuItem";
            uncommentSelectedLinesToolStripMenuItem.Size = new Size(267, 22);
            uncommentSelectedLinesToolStripMenuItem.Text = "Uncomment selected lines";
            uncommentSelectedLinesToolStripMenuItem.Click += uncommentSelectedLinesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(264, 6);
            // 
            // goBackwardCtrlToolStripMenuItem
            // 
            goBackwardCtrlToolStripMenuItem.Name = "goBackwardCtrlToolStripMenuItem";
            goBackwardCtrlToolStripMenuItem.Size = new Size(267, 22);
            goBackwardCtrlToolStripMenuItem.Text = "Go Backward [Ctrl+ -]";
            goBackwardCtrlToolStripMenuItem.Click += goBackwardCtrlToolStripMenuItem_Click;
            // 
            // goForwardCtrlShiftToolStripMenuItem
            // 
            goForwardCtrlShiftToolStripMenuItem.Name = "goForwardCtrlShiftToolStripMenuItem";
            goForwardCtrlShiftToolStripMenuItem.Size = new Size(267, 22);
            goForwardCtrlShiftToolStripMenuItem.Text = "Go Forward [Ctrl+Shift+ -]";
            goForwardCtrlShiftToolStripMenuItem.Click += goForwardCtrlShiftToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(264, 6);
            // 
            // autoIndentToolStripMenuItem
            // 
            autoIndentToolStripMenuItem.Name = "autoIndentToolStripMenuItem";
            autoIndentToolStripMenuItem.Size = new Size(267, 22);
            autoIndentToolStripMenuItem.Text = "Auto Indent selected text";
            autoIndentToolStripMenuItem.Click += autoIndentToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(264, 6);
            // 
            // goLeftBracketToolStripMenuItem
            // 
            goLeftBracketToolStripMenuItem.Name = "goLeftBracketToolStripMenuItem";
            goLeftBracketToolStripMenuItem.Size = new Size(267, 22);
            goLeftBracketToolStripMenuItem.Text = "Go Left Bracket";
            goLeftBracketToolStripMenuItem.Click += goLeftBracketToolStripMenuItem_Click;
            // 
            // goRightBracketToolStripMenuItem
            // 
            goRightBracketToolStripMenuItem.Name = "goRightBracketToolStripMenuItem";
            goRightBracketToolStripMenuItem.Size = new Size(267, 22);
            goRightBracketToolStripMenuItem.Text = "Go Right Bracket";
            goRightBracketToolStripMenuItem.Click += goRightBracketToolStripMenuItem_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(264, 6);
            // 
            // miPrint
            // 
            miPrint.Name = "miPrint";
            miPrint.Size = new Size(267, 22);
            miPrint.Text = "Print...";
            miPrint.Click += miPrint_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(264, 6);
            // 
            // startStopMacroRecordingToolStripMenuItem
            // 
            startStopMacroRecordingToolStripMenuItem.Name = "startStopMacroRecordingToolStripMenuItem";
            startStopMacroRecordingToolStripMenuItem.Size = new Size(267, 22);
            startStopMacroRecordingToolStripMenuItem.Text = "Start/Stop macro recording [Ctrl+M]";
            startStopMacroRecordingToolStripMenuItem.Click += startStopMacroRecordingToolStripMenuItem_Click;
            // 
            // executeMacroToolStripMenuItem
            // 
            executeMacroToolStripMenuItem.Name = "executeMacroToolStripMenuItem";
            executeMacroToolStripMenuItem.Size = new Size(267, 22);
            executeMacroToolStripMenuItem.Text = "Execute macro [Ctrl+E]";
            executeMacroToolStripMenuItem.Click += executeMacroToolStripMenuItem_Click;
            // 
            // miLanguage
            // 
            miLanguage.DropDownItems.AddRange(new ToolStripItem[] { miCSharp, cSharpbuiltinHighlighterToolStripMenuItem, miVB, hTMLToolStripMenuItem, xmlToolStripMenuItem, sQLToolStripMenuItem, pHPToolStripMenuItem, jSToolStripMenuItem, luaToolStripMenuItem, jSONToolStripMenuItem, assemblyToolStripMenuItem, batchToolStripMenuItem });
            miLanguage.Name = "miLanguage";
            miLanguage.Size = new Size(71, 20);
            miLanguage.Text = "Language";
            miLanguage.DropDownOpening += miLanguage_DropDownOpening;
            // 
            // miCSharp
            // 
            miCSharp.Name = "miCSharp";
            miCSharp.Size = new Size(224, 22);
            miCSharp.Text = "CSharp (custom highlighter)";
            miCSharp.Click += miCSharp_Click;
            // 
            // cSharpbuiltinHighlighterToolStripMenuItem
            // 
            cSharpbuiltinHighlighterToolStripMenuItem.Name = "cSharpbuiltinHighlighterToolStripMenuItem";
            cSharpbuiltinHighlighterToolStripMenuItem.Size = new Size(224, 22);
            cSharpbuiltinHighlighterToolStripMenuItem.Text = "CSharp (built-in highlighter)";
            cSharpbuiltinHighlighterToolStripMenuItem.Click += miCSharp_Click;
            // 
            // miVB
            // 
            miVB.Name = "miVB";
            miVB.Size = new Size(224, 22);
            miVB.Text = "VB";
            miVB.Click += miCSharp_Click;
            // 
            // hTMLToolStripMenuItem
            // 
            hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            hTMLToolStripMenuItem.Size = new Size(224, 22);
            hTMLToolStripMenuItem.Text = "HTML";
            hTMLToolStripMenuItem.Click += miCSharp_Click;
            // 
            // xmlToolStripMenuItem
            // 
            xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            xmlToolStripMenuItem.Size = new Size(224, 22);
            xmlToolStripMenuItem.Text = "XML";
            xmlToolStripMenuItem.Click += miCSharp_Click;
            // 
            // sQLToolStripMenuItem
            // 
            sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            sQLToolStripMenuItem.Size = new Size(224, 22);
            sQLToolStripMenuItem.Text = "SQL";
            sQLToolStripMenuItem.Click += miCSharp_Click;
            // 
            // pHPToolStripMenuItem
            // 
            pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
            pHPToolStripMenuItem.Size = new Size(224, 22);
            pHPToolStripMenuItem.Text = "PHP";
            pHPToolStripMenuItem.Click += miCSharp_Click;
            // 
            // jSToolStripMenuItem
            // 
            jSToolStripMenuItem.Name = "jSToolStripMenuItem";
            jSToolStripMenuItem.Size = new Size(224, 22);
            jSToolStripMenuItem.Text = "JS";
            jSToolStripMenuItem.Click += miCSharp_Click;
            // 
            // luaToolStripMenuItem
            // 
            luaToolStripMenuItem.Name = "luaToolStripMenuItem";
            luaToolStripMenuItem.Size = new Size(224, 22);
            luaToolStripMenuItem.Text = "Lua";
            luaToolStripMenuItem.Click += miCSharp_Click;
            // 
            // jSONToolStripMenuItem
            // 
            jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            jSONToolStripMenuItem.Size = new Size(224, 22);
            jSONToolStripMenuItem.Text = "JSON";
            jSONToolStripMenuItem.Click += miCSharp_Click;
            // 
            // assemblyToolStripMenuItem
            // 
            assemblyToolStripMenuItem.Name = "assemblyToolStripMenuItem";
            assemblyToolStripMenuItem.Size = new Size(224, 22);
            assemblyToolStripMenuItem.Text = "Assembly";
            assemblyToolStripMenuItem.Click += miCSharp_Click;
            // 
            // batchToolStripMenuItem
            // 
            batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            batchToolStripMenuItem.Size = new Size(224, 22);
            batchToolStripMenuItem.Text = "Batch";
            batchToolStripMenuItem.Click += miCSharp_Click;
            // 
            // miExport
            // 
            miExport.DropDownItems.AddRange(new ToolStripItem[] { hTMLToolStripMenuItem1, rTFToolStripMenuItem });
            miExport.Name = "miExport";
            miExport.Size = new Size(53, 20);
            miExport.Text = "Export";
            // 
            // hTMLToolStripMenuItem1
            // 
            hTMLToolStripMenuItem1.Name = "hTMLToolStripMenuItem1";
            hTMLToolStripMenuItem1.Size = new Size(106, 22);
            hTMLToolStripMenuItem1.Text = "HTML";
            hTMLToolStripMenuItem1.Click += hTMLToolStripMenuItem1_Click;
            // 
            // rTFToolStripMenuItem
            // 
            rTFToolStripMenuItem.Name = "rTFToolStripMenuItem";
            rTFToolStripMenuItem.Size = new Size(106, 22);
            rTFToolStripMenuItem.Text = "RTF";
            rTFToolStripMenuItem.Click += rTFToolStripMenuItem_Click;
            // 
            // miChangeColors
            // 
            miChangeColors.Enabled = false;
            miChangeColors.Name = "miChangeColors";
            miChangeColors.Size = new Size(95, 20);
            miChangeColors.Text = "Change colors";
            miChangeColors.Click += miChangeColors_Click;
            // 
            // changeHotkeysToolStripMenuItem
            // 
            changeHotkeysToolStripMenuItem.Name = "changeHotkeysToolStripMenuItem";
            changeHotkeysToolStripMenuItem.Size = new Size(104, 20);
            changeHotkeysToolStripMenuItem.Text = "Change hotkeys";
            changeHotkeysToolStripMenuItem.Click += changeHotkeysToolStripMenuItem_Click;
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
            fctb.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            fctb.AutoIndentExistingLines = false;
            fctb.AutoScrollMinSize = new Size(284, 285);
            fctb.BackBrush = null;
            fctb.BorderStyle = BorderStyle.FixedSingle;
            fctb.CharHeight = 15;
            fctb.CharWidth = 7;
            fctb.Cursor = Cursors.IBeam;
            fctb.DefaultMarkerSize = 8;
            fctb.DelayedEventsInterval = 200;
            fctb.DelayedTextChangedInterval = 500;
            fctb.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fctb.Dock = DockStyle.Fill;
            fctb.Font = new Font("Consolas", 9.75F);
            fctb.ImeMode = ImeMode.Off;
            fctb.IsReplaceMode = false;
            fctb.Location = new Point(0, 24);
            fctb.Margin = new Padding(4, 3, 4, 3);
            fctb.Name = "fctb";
            fctb.Paddings = new Padding(0);
            fctb.PreferredLineWidth = 80;
            fctb.ReservedCountOfLineNumberChars = 2;
            fctb.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            fctb.ServiceColors = (ServiceColors)resources.GetObject("fctb.ServiceColors");
            fctb.Size = new Size(404, 363);
            fctb.TabIndex = 3;
            fctb.Text = resources.GetString("fctb.Text");
            fctb.Zoom = 100;
            fctb.TextChanged += fctb_TextChanged;
            fctb.SelectionChangedDelayed += fctb_SelectionChangedDelayed;
            fctb.AutoIndentNeeded += fctb_AutoIndentNeeded;
            fctb.CustomAction += fctb_CustomAction;
            // 
            // PowerfulSample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 387);
            Controls.Add(fctb);
            Controls.Add(menuStrip1);
            ImeMode = ImeMode.Hiragana;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PowerfulSample";
            Text = "FastColoredTextBox sample";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fctb).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private FastColoredTextBox fctb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLanguage;
        private System.Windows.Forms.ToolStripMenuItem miCSharp;
        private System.Windows.Forms.ToolStripMenuItem miVB;
        private System.Windows.Forms.ToolStripMenuItem collapseAllregionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exapndAllregionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem increaseIndentSiftTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseIndentTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem miExport;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem collapseSelectedBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem goBackwardCtrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goForwardCtrlShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem autoIndentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem goLeftBracketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goRightBracketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem miPrint;
        private System.Windows.Forms.ToolStripMenuItem miChangeColors;
        private System.Windows.Forms.ToolStripMenuItem cSharpbuiltinHighlighterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSelectedAsReadonlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSelectedAsWritableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem startStopMacroRecordingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeMacroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeHotkeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem commentSelectedLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncommentSelectedLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
    }
}

