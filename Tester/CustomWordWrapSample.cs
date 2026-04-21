/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 07:09:31
 * Version: 1.0.418
 */

using System;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;

namespace Tester
{
    public partial class CustomWordWrapSample : Form
    {
        public CustomWordWrapSample()
        {
            InitializeComponent();
        }

        private Regex regex = new Regex(@"&&|&|\|\||\|");

        private void fctb_WordWrapNeeded(object sender, WordWrapNeededEventArgs e)
        {
            //var max = (fctb.ClientSize.Width - fctb.LeftIndent)/fctb.CharWidth;
            //FastColoredTextBox.CalcCutOffs(e.CutOffPositions, max, max, e.ImeAllowed, true, e.Line);

            e.CutOffPositions.Clear();           
            foreach (Match m in regex.Matches(e.Line.Text))
                e.CutOffPositions.Add(m.Index);
        }
    }
}
