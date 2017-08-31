using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace FolderNames
{
    class Folders
    {
        public static IEnumerable<string> FolderNames(string xml, char startingLetter)
        {
            var xDoc = XDocument.Parse(xml);
            var a = xDoc.Descendants("folder").Where(x => x.Attribute("name").Value.StartsWith(startingLetter.ToString())).Select(x => x.Attribute("name").Value).ToList();
            return a;
        }

        public static void Main(string[] args)
        {
            string xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<folder name=\"c\">" +
                    "<folder name=\"program files\">" +
                        "<folder name=\"uninstall information\" />" +
                    "</folder>" +
                    "<folder name=\"users\" />" +
                "</folder>";

            foreach (string name in FolderNames(xml, 'u'))
                Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
