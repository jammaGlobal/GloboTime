using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace timeZoneApp
{
    public class Region
    {
        public int ID { get; set; }
        public static String RegionName;

        [DataType(DataType.DateTime)]
        public static String CurrentDateTime;

        public static void getTime(String region)
        {
            TimeOffsets offsets = new TimeOffsets();

            RegionName = region;

            //String time;

            try
            {
                CurrentDateTime = offsets.getDateTime(region);
            }
            catch (KeyNotFoundException e)
            {
                CurrentDateTime = "";
            }
            
        }

        public static String getTime()
        {
            if (!CurrentDateTime.Equals(""))
            {
                return CurrentDateTime;
            }
            else
            {
                return "Region/Country was not found";
            }
        }
    }
}
