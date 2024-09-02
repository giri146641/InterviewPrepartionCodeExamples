using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StringRegexExpression
    {
        public static string RemovePunctuation(string str)
        {
            return Regex.Replace(str, @"[^\w\s-]", "");
        }

        public  string[] NameToParts(string name)
        {
            // Remove punctuation from the name
            name = RemovePunctuation(name);

            // Split the name into parts
            string[] parts = name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Initialize the result array with 4 elements
            string[] result = new string[4] { "", "", "", "" };

            if (parts.Length >= 1)
            {
                result[0] = parts[0]; // First name (always present)
            }

            // Middle Initial (optional) and Last Name
            if (parts.Length == 2)
            {
                result[2] = parts[1]; // Only last name
            }
            else if (parts.Length >= 3)
            {
                if (parts[1].Length == 1 || (parts[1].Length == 2 && parts[1][1] == '.'))
                {
                    result[1] = parts[1].TrimEnd('.'); // Middle initial
                    result[2] = parts[2]; // Last name
                }
                else
                {
                    result[2] = parts[1]; // Last name
                }
            }

            // Suffix (optional)
            if (parts.Length >= 3)
            {
                var lastElement = parts[parts.Length - 1];
                if (IsValidSuffix(lastElement)) // Suffix check for last part
                {
                    result[3] = lastElement;
                    if (parts.Length == 3 && string.IsNullOrEmpty(result[1]))
                    {
                        result[2] = parts[1]; // Correct assignment for last name
                    }
                }
            }

            return result;
        }

        private static bool IsValidSuffix(string part)
        {
            return part == "Sr" || part == "Jr" || part == "II" || part == "III" || part == "IV";
        }

    }
}
