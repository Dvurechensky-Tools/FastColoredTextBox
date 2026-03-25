/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 марта 2026 10:15:31
 * Version: 1.0.391
 */

using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace TesterNet8
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
