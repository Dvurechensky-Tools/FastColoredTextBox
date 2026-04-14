/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:40:37
 * Version: 1.0.411
 */

using System.Windows.Forms;

namespace Tester
{
    public partial class AutoIndentCharsSample : Form
    {
        public AutoIndentCharsSample()
        {
            InitializeComponent();
            fctb.AutoIndentChars = true;
            fctb.AutoIndentCharsPatterns = @"^\s*\w+\s+(?<range>[^,]+)\s*,?\s*(?<range>.+)?";
        }
    }
}
