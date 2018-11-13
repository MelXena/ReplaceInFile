using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultText;
            if (!SearchReplaceInFile(@"..\..\ValkyrieManager_settings.txt", @"\Xena\XenaManager-2G\", @"\Xena\ValkyrieManager\", true, out resultText))
                throw new Exception(resultText);
        }

        /// <summary>
        /// Replaces all occurrences of oldString with newString in filename.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="oldString"></param>
        /// <param name="newString"></param>
        /// <param name="clearAttributes">If true then all file attributes for filename are cleared before processing.</param>
        /// <param name="resultText">Contains an error description on failure.</param>
        /// <returns>true if successful.</returns>
        static bool SearchReplaceInFile(string filename, string oldString, string newString, bool clearAttributes, out string resultText)
        {
            try {
                string str = File.ReadAllText(filename);
                str = str.Replace(oldString, newString);
                File.WriteAllText(filename, str);
            } catch (Exception exc) {
                resultText = $"SearchReplaceInFile: Failed to replace '{oldString}' with '{newString}' in file '{filename}'.\n{exc.Message}";
                return false;
            }

            resultText = "";
            return true;
        }

    }
}
