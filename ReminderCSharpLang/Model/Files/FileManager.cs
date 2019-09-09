using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReminderCSharpLang.Model.Files
{
    class FileManager
    {
        private const string FILE_PATH = @"d:\Metapack materials\plugin description\EDIFACT IFTSTA D01C 1.1.txt";
        private const string IDENTCODESEGMENT = "CNI+";
        private const string EVENTSTATUSCOMPLETE = "STS+11";
        private const string EVENTDATETIME = "DTM+9";
        private const string EVENTLOCATION = "NAD+CS";
        private const string EXTRADATA = "NAD+AP";
        

        public static void ParseFile()
        {
            if(File.Exists(FILE_PATH))
            {
                string stream = File.ReadAllText(FILE_PATH);

                if (stream.Contains(IDENTCODESEGMENT))
                {
                    string content = stream;
                    int shipmentNumber = content.IndexOf(IDENTCODESEGMENT + 2);
                    string segment = content.Remove(0, content.IndexOf(IDENTCODESEGMENT));
                    segment = segment.Remove(segment.IndexOf(IDENTCODESEGMENT + 2));

                    GetInformationFromFile(segment);
                }

                // Open the file to read from.
                using (StreamReader sr = File.OpenText(FILE_PATH))
                {
                    string s;
                    List<string> str = new List<string>(); 
                    while ((s = sr.ReadLine()) != null)
                    {
                        if(s.Trim().StartsWith(IDENTCODESEGMENT))
                        {
                            str.Add(s);
                        }
                        Console.WriteLine(s);
                    }
                }

            }
        }

        private static void GetInformationFromFile(string content)
        {
            List<string> eventShipmentContent = content.Split('\r', '\n').ToList();

            string identcode = eventShipmentContent.Where(x => x.Trim().StartsWith(IDENTCODESEGMENT)).FirstOrDefault();

            //eventsShipment.Split('+')[2]?.Remove();
            for (int i = 0; i < eventShipmentContent.Length; i++)
            {
                eventShipmentContent[i].
            }

            foreach(string s in eventShipmentContent)
            {
                if (s.Trim().StartsWith(IDENTCODESEGMENT))
                {
                    string identcode = GetIdentcodeShipment(s);
                }
                
            }
        }

        private static string GetIdentcodeShipment(string identcodeSegmanet)
        {
            string identcode = identcodeSegmanet.Split('+')[2];
            return identcode.Remove(identcode.Length - 1);
        }
    }
}
