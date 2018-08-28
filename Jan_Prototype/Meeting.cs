using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_Prototype
{
    class Meeting
    {

        private string meetingName;
        private string meetingDescription;
        private DateTime meetingDate;
        private DateTime timeFrom;
        private DateTime timeTo;
        private int roomNumber;

        public Meeting()
        {

        }

        public string getName() {
            return this.meetingName;
        }

        public string getMeetingDescription()
        {
            return this.meetingDescription;
        }

        public DateTime getMeetingDate()
        {
            return this.meetingDate;
        }

        public DateTime getTimeFrom()
        {
            return this.timeFrom;
        }

        public DateTime getTimeTo()
        {
            return this.timeTo;
        }

        public int getRoomNumber()
        {
            return this.roomNumber;
        }


    }
}
