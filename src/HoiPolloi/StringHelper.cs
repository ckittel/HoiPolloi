using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HoiPolloi
{
    public static class StringHelper
    {

        /// <summary>
        /// Reads all of the lines in a string.
        /// </summary>
        /// <param name="text">The text with lines.</param>
        /// <returns>A list of lines in the text.</returns>
        public static IList<string> ReadLines(string text)
        {
            var lines = new List<string>();

            // If text is empty, return an empty list.
            if (String.IsNullOrEmpty(text)) return lines;

            var reader = new StringReader(text);

            var currentLine = reader.ReadLine();

            // While there is more to read
            while (currentLine != null)
            {
                // add the line to our list
                lines.Add(currentLine);
                currentLine = reader.ReadLine();
            }

            return lines;
        }

        public static string Truncate(string text, int maxChars)
        {
            if ((!String.IsNullOrEmpty(text)) && (text.Length > maxChars))
                return text.Substring(0, maxChars);

            return text;
        }

        public static string GetOriginalOrEmptyString(string text)
        {
            return text ?? String.Empty;
        }

        public static string ConvertBoolToYesNo(bool value)
        {
            return value ? "Yes" : "No";
        }
    }
}
