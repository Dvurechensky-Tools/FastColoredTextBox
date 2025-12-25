/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 декабря 2025 09:31:49
 * Version: 1.0.301
 */

using System;

namespace FastColoredTextBoxNS
{
    /// <summary>
    /// Char and style
    /// </summary>
    public struct Char
    {
        /// <summary>
        /// Unicode character
        /// </summary>
        public char c;
        /// <summary>
        /// Style bit mask
        /// </summary>
        /// <remarks>Bit 1 in position n means that this char will rendering by FastColoredTextBox.Styles[n]</remarks>
        public StyleIndex style;

        public Char(char c)
        {
            this.c = c;
            style = StyleIndex.None;
        }
    }
}
