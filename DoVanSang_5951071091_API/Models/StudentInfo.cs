using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DoVanSang_5951071091_API.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "Name")]
        public string NameStudent { get; set; }

        [DataMember(Name = "Id")]
        public float IdStudent { get; set; }

        [DataMember(Name = "Date")]
        public DateTime DateStudent { get; set; }
    }
}