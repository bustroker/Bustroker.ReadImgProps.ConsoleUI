using System.Collections.Generic;
using System.IO;
using System;
using System.Text;
using System.Linq;

namespace Bustroker.ReadImgProps.ConsoleUI
{
    class Program
    {
        const string ImgFolder = "img";
        const string OutputFile = "output.csv";
        const string OutputSeparator = ",";

        static List<string> InterestingProperties = new List<string>
        {
            "S_PLATE=",
            "F_OCRSCORE=",
            "S_IMAGEID=",
            "S_OCRSCORE_CHAR="
        };

        static void Main(string[] args)
        {
            File.Delete(OutputFile);
            
            foreach (var file in System.IO.Directory.EnumerateFiles(ImgFolder))
            {
                var filename = file.Split(@"\").Last();
                var outputLine = $"{filename}{OutputSeparator}";

                foreach (var line in File.ReadAllLines(file, Encoding.ASCII))
                    if(IsInterestingProperty(line))
                        outputLine += $"{line}{OutputSeparator}";
                        
                File.AppendAllText(OutputFile, $"{outputLine}{Environment.NewLine}");
            }
        }
        
        static bool IsInterestingProperty(string line)
        {
            foreach(var interestingProperty in InterestingProperties)
                if(line.Contains(interestingProperty))
                    return true;
            return false;
        }
    }
}
