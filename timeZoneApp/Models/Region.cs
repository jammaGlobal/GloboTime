using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace timeZoneApp.Models
{
    public class Region
    {
        //[Key]
        public int RegionId { get; set; }

        //[JsonPropertyName("name")]
        public String RegionName { get; set; }

        //[DisplayFormat(DataFormatString = @"{hh\:mm}")]
        public TimeSpan offset { get; set; }
        public String offsetType { get; set; }

        //[DataType(DataType.DateTime)]
        public DateTime mostRecentDateTime { get; set; }

        
    }
}
