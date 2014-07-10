using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._05_NumbersOfWorkingDays
{
    class Program
    {
        static bool IsHoliday(DateTime startDay, DateTime[] holidays)
        {
            for (int j = 0; j < holidays.Length; j++)
            {
                if (startDay.Day == holidays[j].Day && startDay.Month == holidays[j].Month)
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter end day");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter end month");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter end year");
                int year = int.Parse(Console.ReadLine());
                DateTime endDay = new DateTime(year, month, day);

                //start day is today
                DateTime startDay = DateTime.Today;

                //swap start and end date if end date is in the past
                if (startDay > endDay)
                {
                    startDay = endDay;
                    endDay = DateTime.Today;
                }

                //add some holidays in this array (these are not correct!)
                DateTime[] holidays =
            {
                new DateTime(2014, 1, 2),
                new DateTime(2014, 2, 26),
                new DateTime(2014, 3, 4),
                new DateTime(2014, 1, 4),
            };

                int timeLen = Math.Abs((endDay - startDay).Days);
                int workDayCounter = 0;

                for (int i = 0; i < timeLen; i++)
                {
                    startDay = startDay.AddDays(1);
                    //check if its not working day
                    if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
                    {
                        //check if its holiday
                        if (!IsHoliday(startDay, holidays))
                        {
                            workDayCounter++;
                        }
                    }
                }

                Console.WriteLine(workDayCounter);
            }
        }
    }
}

