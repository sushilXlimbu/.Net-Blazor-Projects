using Microsoft.AspNetCore.Components;
using System.Globalization;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace NeoRMS.Shared
{
    public class CalendarBase : ComponentBase
    {
        public bool displayMonth = true;
        public bool displayWeek = false;
        public List<string> months = new List<string>();
        public List<string> days = new List<string> ();
        public List<WeekClass> weeks = new List<WeekClass>();
        public string selectedMonth = DateTime.Now.ToString("MMMM");
        public int selectedYear = DateTime.Now.Year;
        public string selectedYearandMonth = DateTime.Now.Year + " " + DateTime.Now.ToString("MMMM");
        DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime endDate = (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)).AddMonths(1).AddDays(-1);
        public bool disableNextmonthBtn = false;
        public bool disablePrevmonthBtn = false;

        protected override void OnInitialized()
        {
            months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.ToList();
            //GenerateCalendarHead();
            GenerateCalendarBodyForMonth();
        }

        protected void LoadCalendar(string currentDate)
        {
            var selectedMonth = currentDate.Split(' ')[1];
            var selectedYear = int.Parse(currentDate.Split(' ')[0]);
            
            //var selectedMonth = month;
            //var selectedYear = int.Parse(year);

            int monthIndex = DateTime.ParseExact(selectedMonth, "MMMM", CultureInfo.CreateSpecificCulture("en-GB")).Month;

            startDate = new DateTime(selectedYear, DateTime.ParseExact(selectedMonth, "MMMM", CultureInfo.CurrentCulture).Month, 1);
            endDate = startDate.AddMonths(1).AddDays(-1);

            if ((selectedYear+" "+selectedMonth) == ((DateTime.Now.Year + 1) + " December"))
            {
                disableNextmonthBtn = true;
                disablePrevmonthBtn = false;
            }
            else if((selectedYear + " " + selectedMonth) == ((DateTime.Now.Year -1) + " January"))
            {
                disablePrevmonthBtn = true;
                disableNextmonthBtn = false;
            }
            else
            {
                disableNextmonthBtn = false;
                disablePrevmonthBtn = false;
            }
            //GenerateCalendarHead();
            //if(displayMonth)
            //{
            //    GenerateCalendarBodyForMonth();

            //}
            //else
            //{
            //    GenerateCalendarBodyForWeek();
            //}
            GenerateCalendarBodyForMonth();
            
        }

        //protected void GenerateCalendarHead()
        //{

        //    var day1 = new List<string>();
        //    day1 = day1.SkipWhile(d => d != "Sunday").Concat(day1.TakeWhile(d => d != "Sunday")).ToList();

        //    for (var dt = startDate; dt <= endDate; dt = dt.AddDays(1))
        //    {
        //        day1.Add(dt.ToString("dddd"));
        //    }
        //    days = day1.Distinct().ToList();
        //}

        protected void GenerateCalendarBodyForMonth()
        {
            weeks = new List<WeekClass>();
            int flag = 0;
            WeekClass week = new WeekClass();
            List<DayEvent> dates = new List<DayEvent>();
            var totalDays = (int)(endDate - startDate).TotalDays;
            int countdays = 0;

            // Add empty dates for days before the start of the month
            for (int i = 0; i < (int)startDate.DayOfWeek; i++)
            {
                dates.Add(new DayEvent()
                {
                    DateValue = "",
                    DayName = ""
                });
                flag++;
            }

            // Add dates for the month
            for (var dt = startDate; dt <= endDate; dt = dt.AddDays(1))
            {
                flag++;
                dates.Add(new DayEvent()
                {
                    DateValue = dt.ToString("dd-MMM-yyyy"),
                    DayName = dt.ToString("dddd")
                });

                if (flag == 7)
                {
                    week = new WeekClass();
                    week.Dates = dates;
                    weeks.Add(week);

                    dates = new List<DayEvent>();
                    flag = 0;
                }

                countdays++;
            }

            // Add empty dates for days after the end of the month
            if (flag > 0)
            {
                for (int i = flag; i < 7; i++)
                {
                    dates.Add(new DayEvent()
                    {
                        DateValue = "",
                        DayName = ""
                    });
                }
                week = new WeekClass();
                week.Dates = dates;
                weeks.Add(week);
            }
        }

        //protected void GenerateCalendarBodyForWeek()
        //{
        //    weeks = new List<WeekClass>();
        //    int flag = 0;
        //    WeekClass week = new WeekClass();
        //    List<DayEvent> dates = new List<DayEvent>();
        //    var totalDays = (int)(endDate - startDate).TotalDays;
        //    int countdays = 0;

        //    // Add empty dates for days before the start of the month
        //    var prevMonthEndDate = startDate.AddDays(-1);
        //    var prevMonthEndDayOfWeek = prevMonthEndDate.DayOfWeek;
        //    var daysToAddFromPrevMonth = ((int)prevMonthEndDayOfWeek + 1) % 7;
        //    for (int i = 0; i < daysToAddFromPrevMonth; i++)
        //    {
        //        var dateValue = startDate.AddDays(-daysToAddFromPrevMonth + i).ToString("dd-MMM-yyyy");
        //        dates.Add(new DayEvent()
        //        {
        //            DateValue = dateValue,
        //            DayName = ""
        //        });
        //        flag++;
        //    }

        //    // Add dates for the month
        //    for (var dt = startDate; dt <= endDate; dt = dt.AddDays(1))
        //    {
        //        flag++;
        //        dates.Add(new DayEvent()
        //        {
        //            DateValue = dt.ToString("dd-MMM-yyyy"),
        //            DayName = dt.ToString("dddd")
        //        });

        //        if (flag == 7)
        //        {
        //            week = new WeekClass();
        //            week.Dates = dates;
        //            weeks.Add(week);

        //            dates = new List<DayEvent>();
        //            flag = 0;
        //        }

        //        countdays++;
        //    }

        //    // Add empty dates for days after the end of the month
        //    var nextMonthStartDate = endDate.AddDays(1);
        //    var nextMonthStartDayOfWeek = nextMonthStartDate.DayOfWeek;
        //    var daysToAddFromNextMonth = (7 - (int)nextMonthStartDayOfWeek) % 7;
        //    for (int i = 0; i < daysToAddFromNextMonth; i++)
        //    {
        //        var dateValue = nextMonthStartDate.AddDays(i).ToString("dd-MMM-yyyy");
        //        dates.Add(new DayEvent()
        //        {
        //            DateValue = dateValue,
        //            DayName = ""
        //        });
        //    }

        //    if (dates.Count > 0)
        //    {
        //        week = new WeekClass();
        //        week.Dates = dates;
        //        weeks.Add(week);
        //    }
        //}




        [Inject] NavigationManager NavigationManager { get; set; }
        protected void NavigatetoRoom(DateTime selectedDate)
        {
            Console.WriteLine("Selected date: " + selectedDate.ToShortDateString());
            //2/1/2023

            NavigationManager.NavigateTo($"/rooms/{selectedDate.ToString("dd-MM-yyyy")}");


        }

        protected void swapDisplayMode()
        {
            displayMonth = !displayMonth;
            displayWeek = !displayWeek;

            StateHasChanged();
        }

        protected void nextMonth()
        {
            

            startDate = startDate.AddMonths(1);
            endDate = startDate.AddMonths(1).AddDays(-1);
            selectedMonth = startDate.ToString("MMMM");
            selectedYear = startDate.Year;
            selectedYearandMonth = selectedYear + " " + selectedMonth;
            GenerateCalendarBodyForMonth();
            Console.WriteLine(selectedYearandMonth + ":" +(DateTime.Now.Year + 1) + "  December");
            if (selectedYearandMonth == ((DateTime.Now.Year + 1) + " December"))
            {
                disableNextmonthBtn = true;
            }
            if (selectedYearandMonth == ((DateTime.Now.Year - 1) + " February"))
            {
                disablePrevmonthBtn = false;
            }

            

        }

        protected void prevMonth()
        {
            startDate = startDate.AddMonths(-1);
            endDate = startDate.AddMonths(1).AddDays(-1);
            selectedMonth = startDate.ToString("MMMM");
            selectedYear = startDate.Year;
           
            selectedYearandMonth = selectedYear + " " + selectedMonth;
            GenerateCalendarBodyForMonth();
            if (selectedYearandMonth == ((DateTime.Now.Year + 1) + " November"))
            {
                disableNextmonthBtn = false;
            }
            if(selectedYearandMonth == ((DateTime.Now.Year - 1) + " January"))
            {
                disablePrevmonthBtn = true;
            }



        }




    }

    public class DayEvent
    {

        public string DateValue { get; set; }

        public string DayName { get; set; }



    }

    public class WeekClass
    {
        public List<DayEvent> Dates { get; set; } = new List<DayEvent>();
    }
}
