/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 сентября 2025 13:13:22
 * Version: 1.0.193
 */

using System.Windows.Forms;

namespace TesterNet8
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
