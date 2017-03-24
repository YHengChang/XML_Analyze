using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Station
    {
        public string StationIdentifier { get; set; }
        public string RecordTime { get; set; }
        public string WaterLevel { get; set; }
        public DateTime CreateTime { get; set; }


        //public string locationAddress;

        //public string LocationAddress
        //{
        //    get
        //    {
        //        return locationAddress;
        //    }
        //    set
        //    {
        //        if (value.Length < 10)
        //            locationAddress = value;
        //        else
        //            locationAddress = "";
        //    }
        //}


    }
}
