using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourSheet
{
    [Serializable]
    public class DayModel
    {
        private DateTime date;
        /// <summary>
        /// The Date of the day in question - returns just the date component
        /// </summary>
        public DateTime Date
        {
            get { return date.Date; }
        }

        /// <summary>
        /// Returns the name of the day of the week (e.g. Monday)
        /// Todo: Do I want to truncate this, e.g. return Mon, Tues, Wed, Thurs, Fri, Sat, Sun?? - could easily be done by a string and a switch staement
        /// </summary>
        public DayOfWeek Day
        {
            get { return Date.DayOfWeek; }
        }

        private WorkStatusModel workStatus;
        /// <summary>
        /// WorkStatus - Weekend, Bank Holiday, Working, Working Weekend, Working Bank Holiday, Annual Leave, Furlough
        /// Todo: Implement work status models
        /// Todo: make this list so it can be added to
        /// </summary>
        public WorkStatusModel WorkStatus
        {
            get { return workStatus; }
            set { workStatus = value; }
        }

        private DateTime startTime;
        /// <summary>
        /// THe time at which I started work - stores only the time component
        /// </summary>
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value.ToLocalTime(); Console.WriteLine($"Start Time: {startTime}"); } //Todo: Check this only stores the time component
        }

        private DateTime stopTime;
        /// <summary>
        /// THe time at which I stopped work - stores only the time component
        /// </summary>
        public DateTime StopTime
        {
            get { return stopTime; }
            set { stopTime = value.ToLocalTime(); Console.WriteLine($"Start Time: {stopTime}"); } //Todo: Check this only stores the time component
        }

        private decimal breaks;
        /// <summary>
        /// Stores the number of hours spent on break
        /// </summary>
        public decimal Breaks
        {
            get { return breaks; }
            set { breaks = value; }
        }

        /// <summary>
        /// Returns the number of hours worked in the day
        /// </summary>
        public decimal HoursWorked
        {
            get { return 2; }
            //Todo: Implement the hours worked calculation
        }

        private decimal hoursPlanned;
        /// <summary>
        /// Returns the number of hours that should be worked in a day
        /// </summary>
        public decimal HoursPlanned
        {
            get { return hoursPlanned; }
            set { hoursPlanned = value; }
            //todo: Where to set this? Should this be editable in a config?
        }

        /// <summary>
        /// Text description of work done throughout the day
        /// </summary>
        public string DescriptionOfWork { get; set; } = "";

        /// <summary>
        /// Locations worked throughout the day
        /// </summary>
        public string Location { get; set; } = "";

        /// <summary>
        /// Stores any flags - e.g. travel, working from home - in a list that can be added to
        /// </summary>
        public List<FlagModel> flags = new List<FlagModel>();
        //todo: Implement flag model: name of flag and boolean value

        /// <summary>
        /// Records any notes about the working hours, e.g. time sovereignty taken
        /// </summary>
        public string HoursNotes { get; set; } = "";
    }
}
