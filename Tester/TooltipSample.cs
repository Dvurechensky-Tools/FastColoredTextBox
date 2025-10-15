/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 октября 2025 10:51:11
 * Version: 1.0.230
 */

using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Tester
{
    public partial class TooltipSample : Form
    {
        public TooltipSample()
        {
            InitializeComponent();
        }

        private void fctb_ToolTipNeeded(object sender, ToolTipNeededEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.HoveredWord))
            {
                e.ToolTipTitle = e.HoveredWord;
                e.ToolTipText = "This is tooltip for '" + e.HoveredWord + "'";
            }

            /*
             * Also you can get any fragment of the text for tooltip.
             * Following example gets whole line for tooltip:
            
            var range = new Range(sender as FastColoredTextBox, e.Place, e.Place);
            string hoveredWord = range.GetFragment("[^\n]").Text;
            e.ToolTipTitle = hoveredWord;
            e.ToolTipText = "This is tooltip for '" + hoveredWord + "'";

             */
        }
    }
}
