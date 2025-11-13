/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 ноября 2025 06:53:01
 * Version: 1.0.259
 */

using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;

namespace Tester
{
    public partial class SimplestCodeFoldingSample : Form
    {
        public SimplestCodeFoldingSample()
        {
            InitializeComponent();
        }

        private void fctb_TextChanged(object sender, TextChangedEventArgs e)
        {
            //clear folding markers
            e.ChangedRange.ClearFoldingMarkers();
            //set markers for folding
            e.ChangedRange.SetFoldingMarkers("{", "}");
        }
    }
}
