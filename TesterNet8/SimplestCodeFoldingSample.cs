/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 марта 2026 16:57:10
 * Version: 1.0.368
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
