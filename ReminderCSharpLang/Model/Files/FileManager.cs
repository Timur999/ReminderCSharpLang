using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private static Stopwatch _stopWatchReadByLine;
        private static Stopwatch _stopWatchReadByShipment;

        public static void ParseFile()
        {
            _stopWatchReadByLine = new Stopwatch();
            _stopWatchReadByShipment = new Stopwatch();

            if (File.Exists(FILE_PATH))
            {

                var fileLine = File.ReadAllLines(FILE_PATH);

                var events = new List<string>();
                var eventsList = new List<List<string>>();

                _stopWatchReadByLine.Start();

                foreach (string line in fileLine)
                {
                    if (line.Contains(IDENTCODESEGMENT) )
                    {
                        eventsList.Add(events);
                        events = new List<string>();
                        events.Add(line);
                    }
                    if (line.Contains(EVENTSTATUSCOMPLETE) || line.Contains(EVENTDATETIME) || line.Contains(EVENTLOCATION) || line.Contains(EXTRADATA) )
                    {
                        events.Add(line);
                    }
                }

                _stopWatchReadByLine.Stop();

                Console.WriteLine("Time By line: " + _stopWatchReadByLine.Elapsed.ToString());

                var fileText = File.ReadAllText(FILE_PATH);
                string shipmentContent;
                string[] numbersOfShipment = fileLine.Where(x => x.Trim().StartsWith(IDENTCODESEGMENT)).Select(x => x.Split('+')[1]).ToArray();

                _stopWatchReadByShipment.Start();

                for (int i =0; i < numbersOfShipment.Length-1; i++)
                {
                    eventsList.Add(events);
                    events = new List<string>();

                    string content = fileText;
                    shipmentContent = content.Remove(0, content.IndexOf(IDENTCODESEGMENT + numbersOfShipment[i], StringComparison.Ordinal));
                    shipmentContent = shipmentContent.Remove(shipmentContent.IndexOf(IDENTCODESEGMENT + numbersOfShipment[i + 1], StringComparison.Ordinal));
                    List<string> eventLine = shipmentContent.Split('\'').ToList();

                    events.Add(eventLine.FirstOrDefault(x => x.Contains(IDENTCODESEGMENT)));
                    events.Add(eventLine.FirstOrDefault(x => x.Contains(EVENTSTATUSCOMPLETE)));
                    events.Add(eventLine.FirstOrDefault(x => x.Contains(EVENTDATETIME)));
                    events.Add(eventLine.FirstOrDefault(x => x.Contains(EVENTLOCATION)));
                    events.Add(eventLine.FirstOrDefault(x => x.Contains(EXTRADATA)));

                }

                _stopWatchReadByShipment.Stop();

                Console.WriteLine("Time By shipment: " + _stopWatchReadByShipment.Elapsed.ToString());

                //shipmentContent = fileText.Remove(0, fileText.IndexOf(IDENTCODESEGMENT + numbersOfShipment[numbersOfShipment.Length - 1], StringComparison.Ordinal));
                //List<string> eventLine = shipmentContent.Split('\r', '\n').ToList();
                //events.Add(eventLine.FirstOrDefault(x => x.Contains(IDENTCODESEGMENT)));
                //events.Add(eventLine.FirstOrDefault(x => x.Contains(EVENTSTATUSCOMPLETE)));
                //events.Add(eventLine.FirstOrDefault(x => x.Contains(EVENTDATETIME)));
                //events.Add(eventLine.FirstOrDefault(x => x.Contains(EVENTLOCATION)));
                //events.Add(eventLine.FirstOrDefault(x => x.Contains(EXTRADATA)));
                //eventsList.Add(events);


                //string identcode = eventLine.FirstOrDefault(x => x.Contains(IDENTCODESEGMENT));
                //string eventStatus = eventLine.FirstOrDefault(x => x.Contains(EVENTSTATUSCOMPLETE));
                //string date = eventLine.FirstOrDefault(x => x.Contains(EVENTDATETIME));
                //string location = eventLine.FirstOrDefault(x => x.Contains(EVENTLOCATION));
                //string extra = eventLine.FirstOrDefault(x => x.Contains(EXTRADATA));

                //string stream = File.ReadAllText(FILE_PATH);

                //if (stream.Contains(IDENTCODESEGMENT))
                //{
                //    string content = stream;
                //    int shipmentNumber = content.IndexOf(IDENTCODESEGMENT + 2);
                //    string segment = content.Remove(0, content.IndexOf(IDENTCODESEGMENT));
                //    segment = segment.Remove(segment.IndexOf(IDENTCODESEGMENT + 2));

                //    GetInformationFromFile(segment);
                //}

                //// Open the file to read from.
                //using (StreamReader sr = File.OpenText(FILE_PATH))
                //{
                //    string s;
                //    List<string> str = new List<string>(); 
                //    while ((s = sr.ReadLine()) != null)
                //    {
                //        if(s.Trim().StartsWith(IDENTCODESEGMENT))
                //        {
                //            str.Add(s);
                //        }
                //        Console.WriteLine(s);
                //    }
                //}

            }
        }

        private static void GetInformationFromFile(string content)
        {
            List<string> eventShipmentContent = content.Split('\r', '\n').ToList();

            string identcode = eventShipmentContent.Where(x => x.Trim().StartsWith(IDENTCODESEGMENT)).FirstOrDefault();
 
            ////eventsShipment.Split('+')[2]?.Remove();
            //for (int i = 0; i < eventShipmentContent.Length; i++)
            //{
            //    //eventShipmentContent[i]
            //}

            //foreach(string s in eventShipmentContent)
            //{
            //    if (s.Trim().StartsWith(IDENTCODESEGMENT))
            //    {
            //        string identcode = GetIdentcodeShipment(s);
            //    }
                
            //}
        }

        private static string GetIdentcodeShipment(string identcodeSegmanet)
        {
            string identcode = identcodeSegmanet.Split('+')[2];
            return identcode.Remove(identcode.Length - 1);
        }
    }
}
