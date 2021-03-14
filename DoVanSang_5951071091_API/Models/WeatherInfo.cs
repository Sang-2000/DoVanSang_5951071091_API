using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DoVanSang_5951071091_API.Models
{
    [DataContract]
    public class WeatherInfo
    {
        [DataMember(Name = "Location")]
        public string Location { get; set; }

        [DataMember(Name = "Degree")]
        public float Degree { get; set; }

        [DataMember(Name = "DateTime")]
        public DateTime DateTime { get; set; }
    }
}