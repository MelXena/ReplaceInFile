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
            UpdateSettingsFile();
        }

        static void UpdateSettingsFile()
        {
            string str = File.ReadAllText(@"..\..\ValkyrieManager_settings.txt");
            str = str.Replace(@"\\Xena\\XenaManager-2G\\", @"\\Xena\\ValkyrieManager\\");
            File.WriteAllText(@"..\..\ValkyrieManager_settings.txt", str);
        }

    }
}
