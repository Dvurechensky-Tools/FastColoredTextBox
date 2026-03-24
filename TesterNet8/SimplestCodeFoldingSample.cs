/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 марта 2026 08:55:10
 * Version: 1.0.390
 */

using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;

namespace TesterNet8
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
