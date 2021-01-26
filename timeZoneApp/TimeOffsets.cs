using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace timeZoneApp
{
    public class TimeOffsets
    {

        private Dictionary<string, TimeSpan> listOfOffsets;
        private Dictionary<string, Boolean> operationList;      //true equals add, false equals subtract

        public TimeOffsets()
        {
            listOfOffsets = new Dictionary<string, TimeSpan>();
            operationList = new Dictionary<string, Boolean>();

            listOfOffsets.Add("afghanistan", new TimeSpan(4, 30, 0));
            operationList.Add("afghanistan", true);

            listOfOffsets.Add("aland islands", new TimeSpan(2, 0, 0));
            operationList.Add("aland islands", true);

            listOfOffsets.Add("albania", new TimeSpan(1, 0, 0));
            operationList.Add("albania", true);

            listOfOffsets.Add("american samoa", new TimeSpan(11, 0, 0));
            operationList.Add("american samoa", false);

            listOfOffsets.Add("andorra", new TimeSpan(1, 0, 0));
            operationList.Add("andorra", true);

            listOfOffsets.Add("angola", new TimeSpan(1, 0, 0));
            operationList.Add("angola", true);

            listOfOffsets.Add("anguilla", new TimeSpan(4, 0, 0));
            operationList.Add("anguilla", false);

            listOfOffsets.Add("antigua", new TimeSpan(4, 0, 0));
            operationList.Add("antigua", false);

            listOfOffsets.Add("barbuda", new TimeSpan(4, 0, 0));
            operationList.Add("barbuda", false);

            listOfOffsets.Add("argentina", new TimeSpan(3, 0, 0));
            operationList.Add("argentina", false);

            listOfOffsets.Add("armenia", new TimeSpan(4, 0, 0));
            operationList.Add("armenia", true);

            listOfOffsets.Add("aruba", new TimeSpan(4, 0, 0));
            operationList.Add("aruba", false);

            listOfOffsets.Add("ascension island", new TimeSpan(0, 0, 0));
            operationList.Add("ascension island", true);
        }

        public String getDateTime(String region)
        {

            DateTime dateNow;

            if (!listOfOffsets.ContainsKey(region.ToLower()))
            {
                throw new KeyNotFoundException("Region/Country not found.");
            }

            if(operationList[region.ToLower()])     //add timespan
            {
                dateNow = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).Add(listOfOffsets[region.ToLower()]);
            }
            else                                    //subtract timespan
            {
                dateNow = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).Subtract(listOfOffsets[region.ToLower()]);
            }

            return dateNow.ToString();
        }

        


    }
}
