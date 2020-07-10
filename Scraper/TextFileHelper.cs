using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scraper
{
    class TextFileHelper
    {
        public static string ReadFile(string filePath)
        {
            string returnText = string.Empty;
            string line = string.Empty;
            using (StreamReader sr = new StreamReader(filePath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    returnText = string.Format("{0}{1}", returnText, line);
                }
            }
          
            return returnText;
        }

        public static List<string> GetListFromText(string text, char separator)
        {
            var list = text.Split(separator);

            return list.ToList();
        }

        public static void WriteFile(string filePath, List<string> texts, char separator)
        {
            string returnText = string.Empty;
            string line = string.Empty;
            using (StreamWriter sr = new StreamWriter(filePath))
            {
                int count = 0;
                foreach (var text in texts)
                {
                    count++;

                    sr.Write(text);

                    if (count < texts.Count)
                        sr.Write(separator.ToString());
                }
            }
        }

    }
}
