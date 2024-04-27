using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;

namespace secondProjectMrAmani1
{
    public class NewRand
    {
        private long seed;

        public NewRand()
        {
            seed = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }
        public NewRand(long seed)
        {
            this.seed = seed;
        }
        
        public int Next()
        {
            seed = (seed * 1103515245 + 12345) % int.MaxValue;
            int result = (int)(seed % int.MaxValue);
            return result < 0 ? -result : result;
        }

        public int Next(int max)
        {
            seed = (seed * 1103515245 + 12345) % int.MaxValue;
            int result = (int)(seed % max);
            return result < 0 ? -result : result;
        }
        public int Next(int min,int max)
        {
            return min + Next(max - min);
        }
    }

    public class PerCal
    {
        public PerCal()
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            DateTime current = DateTime.Now;
        }
        public string Get()
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            DateTime current = DateTime.Now;
            int year = persianCalendar.GetYear(current);
            int month = persianCalendar.GetMonth(current);
            int day = persianCalendar.GetDayOfMonth(current);
            return $"{year}/{month}/{day}";
        }
    }
}
