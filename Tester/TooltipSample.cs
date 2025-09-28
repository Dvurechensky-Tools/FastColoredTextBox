/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2025 21:15:30
 * Version: 1.0.213
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
