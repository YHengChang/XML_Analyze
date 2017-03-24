using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            var stations = FindStations();

            Console.WriteLine("Total {0} data" , stations.Count);

            foreach(Station s in stations)
            {
                Console.Write(s.StationIdentifier);
                Console.Write(s.RecordTime);
                Console.WriteLine(s.WaterLevel);
            }



            Console.ReadLine();
        }


        public static List<Station> FindStations()
        {
            List<Station> stations = new List<Station>();



            var xml = XElement.Load(@"C:\Users\HengChang\Desktop\test\test.xml");


            XNamespace twed = @"http://twed.wra.gov.tw/twedml/opendata";
            var stationsNode = xml.Descendants(twed + "RealtimeWaterLevel").ToList();



            stationsNode
                .Where(x=>!x.IsEmpty).ToList()
                .ForEach(stationNode =>
            {
                

                var BasinIdentifier = stationNode.Element(twed + "StationIdentifier").Value.Trim();
                var ObservatoryName = stationNode.Element(twed + "RecordTime").Value.Trim();
                var LocationAddress = stationNode.Element(twed + "WaterLevel").Value.Trim();

                Station stationData = new Station();
                stationData.StationIdentifier = BasinIdentifier;
                stationData.RecordTime = ObservatoryName;
                stationData.WaterLevel = LocationAddress;
                stationData.CreateTime = DateTime.Now;
                stations.Add(stationData);

            });



            return stations;

        }
    }
}
