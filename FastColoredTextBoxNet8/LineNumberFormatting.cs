/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 марта 2026 11:14:19
 * Version: 1.0.395
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