using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace NeoRMS.Shared
{
    public class CalendarWeekBase : ComponentBase
    {
        public List<string> months = new List<string>();
        public List<string> days = new List<string>();
        public List<WeekClass> weeks = new List<WeekClass>();
        public string selectedMonth = DateTime.Now.ToString("MMMM");
        public int selectedYear = DateTime.Now.Year;
        public int currentWeekIndex = 0;

        public string todayDate = DateTime.Now.ToString("dd-MMM-yyyy");

        DateTime startDate;
        DateTime endDate;


        protected override void OnInitialized()
        {
            months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.ToList();
            startDate = DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek);
            endDate = startDate.AddDays(6);
            GenerateCalendarBody();
        }

        protected void nextWeek()
        {
            if (currentWeekIndex < weeks.Count - 1)
            {
                currentWeekIndex++;
            }
            else
            {
                startDate = endDate.AddDays(1);
                endDate = startDate.AddDays(6);
                GenerateCalendarBody();
                currentWeekIndex = 0;
            }

            StateHasChanged();
        }


        protected void prevWeek()
        {
            if (currentWeekIndex > 0)
            {
                currentWeekIndex--;
            }
            else
            {
                endDate = startDate.AddDays(-1);
                startDate = endDate.AddDays(-6);
                GenerateCalendarBody();
                currentWeekIndex = weeks.Count - 1;
            }

            StateHasChanged();
        }

        protected void GenerateCalendarBody()
        {
            weeks = new List<WeekClass>();
            WeekClass week = new WeekClass();
            List<DayEvent> dates = new List<DayEvent>();

            

            for (var dt = startDate; dt <= endDate; dt = dt.AddDays(1))
            {
                dates.Add(new DayEvent()
                {
                    DateValue = dt.ToString("dd-MMM-yyyy"),
                    DayName = dt.ToString("dddd")
                });
            }

            week.Dates = dates;
            weeks.Add(week);
        }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        protected void NavigatetoRoom(DateTime selectedDate)
        {
            Console.WriteLine("Selected date: " + selectedDate.ToShortDateString());
            //2/1/2023

            NavigationManager.NavigateTo($"/rooms/{selectedDate.ToString("dd-MM-yyyy")}");
        }
    }
}
