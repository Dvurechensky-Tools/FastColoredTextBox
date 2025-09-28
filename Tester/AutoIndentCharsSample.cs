/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2025 21:15:30
 * Version: 1.0.213
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
