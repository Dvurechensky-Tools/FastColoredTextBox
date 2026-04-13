/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 13:12:26
 * Version: 1.0.410
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
