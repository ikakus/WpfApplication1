using System;
using System.Windows;
using Microsoft.Win32;

namespace WpfApplication1
{
    internal class CustomTimer
    {
        private WorkHours mWorkHours;
        public CustomTimer()
        {
            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
            mWorkHours = new WorkHours(DateTime.Now);
        }

        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            switch (e.Reason)
            {
                case SessionSwitchReason.SessionLock:

                   
                    mWorkHours.OnLoggedOut();
                   // MessageBox.Show("Logged out, Time LoggedI :" + mWorkHours.MTimeSpan.Minutes.ToString());
                    
                    break;

                case SessionSwitchReason.SessionUnlock:

                    mWorkHours.OnLoggedIn();
                   // MessageBox.Show("Logged In");
                   
                    break;
            }
        }
    }
}
