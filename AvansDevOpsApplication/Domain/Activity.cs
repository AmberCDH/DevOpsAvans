﻿namespace AvansDevOpsApplication.Domain
{
    public class Activity
    {
        private string comment;
        private string movedTo;
        private string movedFrom;
        private DateTime time;

        public Activity(string comment, string movedTo, string movedFrom, DateTime time)
        {
            this.comment = comment;
            this.movedTo = movedTo;
            this.movedFrom = movedFrom;
            this.time = time;
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        public string MovedTo
        {
            get { return movedTo; }
            set { movedTo = value; }
        }
        public string MovedFrom
        {
            get { return movedFrom; }
            set { movedFrom = value; }
        }
        public DateTime Time
        {
            get { return time; }
        }
        public string toString()
        {
            return "Activity ~ Comment; " + comment + " ~ " + time;
        }
    }
}
