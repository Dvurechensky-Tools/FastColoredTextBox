/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 марта 2026 16:57:10
 * Version: 1.0.368
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
