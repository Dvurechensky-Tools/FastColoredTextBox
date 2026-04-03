/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 апреля 2026 11:47:40
 * Version: 1.0.400
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
