using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TimeStampWebAPI.Models
{
    public class TimeStampModel
    {

        private DateTime _timeStamp;
        [JsonIgnore]
        public DateTime TimeStamp
        {
            get
            {
                return _timeStamp;
            }

            set
            {
                _timeStamp = value;
            }
        }

        public int UnixTime { get; set; }
        public string NaturalTime { get; set; }


        public TimeStampModel()
        {

        }

        public TimeStampModel(string val)
        {
            DateTime dt = new DateTime();
            DateTime.TryParse(val, out dt);

            TimeStamp = dt;
        }

        public TimeStampModel(DateTime dt)
        {
            TimeStamp = dt;
            UnixTime = ReturnUnixDate();
            NaturalTime = ReturnNaturalDate();
        }

        public string ReturnNaturalDate()
        {
            return string.Format($"{TimeStamp.ToUniversalTime():MMMM dd, yyyy}");
        }

        public int ReturnUnixDate()
        {
            Int32 unixTimestamp = (Int32)(TimeStamp.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

            return unixTimestamp;
        }

        public string ReturnJson()
        {
            string jsonResult = JsonConvert.SerializeObject(this);
            return jsonResult;
        }

        public string ReturnString()
        {
            return string.Format($"\"unix\": {ReturnUnixDate()}, \"natural\": \"{ReturnNaturalDate()}\"");
        }
    }
}