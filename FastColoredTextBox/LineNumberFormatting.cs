/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 декабря 2025 15:52:53
 * Version: 1.0.303
 */

namespace FastColoredTextBoxNS
{
    /// <summary>
    /// Customize how we display the line numbers
    /// </summary>
    public abstract class LineNumberFormatting
    {
        /// <summary>
        /// Defines how line number is displayed
        /// </summary>
        /// <param name="lineNumber"></param>
        /// <returns></returns>
        public abstract string FromLineNumberToString(int lineNumber);

        /// <summary>
        /// Recover the line number from the formatted string
        /// </summary>
        /// <param name="lineNumber"></param>
        /// <param name="parsedLineNumber"></param>
        /// <returns></returns>
        public abstract bool TryParseStringIntoLineNumber(string lineNumber, out int parsedLineNumber);
    }
}