/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 февраля 2026 13:23:37
 * Version: 1.0.362
 */

using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Tester
{
    public partial class SimplestSyntaxHighlightingSample : Form
    {
        //Create style for highlighting
        TextStyle brownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Regular);

        public SimplestSyntaxHighlightingSample()
        {
            InitializeComponent();
        }

        private void fctb_TextChanged(object sender, TextChangedEventArgs e)
        {
            //clear previous highlighting
            e.ChangedRange.ClearStyle(brownStyle);
            //highlight tags
            e.ChangedRange.SetStyle(brownStyle, "<[^>]+>");
        }
    }
}
