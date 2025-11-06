using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLib
{
    public struct DayTime
    {
        private long minutes;

        public DayTime(long minutes)
        {
            this.minutes = minutes;
        }

        public static DayTime operator +(DayTime lhs, int addMinutes)
        {
            return new DayTime(lhs.minutes + addMinutes);
        }

        public override string ToString()
        {
            long mins = minutes;
            long year = 2023 + mins / 518400;
            mins %= 518400;
            long month = 1 + mins / 43200;
            mins %= 43200;
            long day = 1 + mins / 1440;
            mins %= 1440;
            long hour = mins / 60;
            mins %= 60;
            long min = mins;

            return $"{year:D4}-{month:D2}-{day:D2} {hour:D2}:{min:D2}";
        }
    }

}
