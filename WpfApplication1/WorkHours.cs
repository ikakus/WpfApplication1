using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class WorkHours
    {

        private DateTime mStartTime;
        private DateTime mEndTime;
        private TimeSpan mTimeSpan;

        public WorkHours()
        {
            mStartTime = DateTime.MinValue;
            mEndTime = DateTime.MinValue;
            mTimeSpan = new TimeSpan(0,0,0);
        }

        public WorkHours(DateTime sTime)
        {
            mStartTime = sTime;
            mEndTime = DateTime.MinValue;
            mTimeSpan = new TimeSpan(0, 0, 0);
        }

        public WorkHours(DateTime sTime, DateTime eTime)
        {
            mStartTime = sTime;
            mEndTime = eTime;
            mTimeSpan = new TimeSpan(0, 0, 0);
        }

        public DateTime MEndTime
        {
            get { return mEndTime; }
            set { mEndTime = value; }
        }

        public DateTime MStartTime
        {
            get { return mStartTime; }
            set { mStartTime = value; }
        }

        public TimeSpan MTimeSpan
        {
            get { return mTimeSpan; }
            set { mTimeSpan = value; }
        }

        public void OnLoggedOut()
        {
            MEndTime = DateTime.Now;
            MTimeSpan += MEndTime - MStartTime;
        }

        public void OnLoggedIn()
        {
            MStartTime = DateTime.Now;
        }
    }
}
