using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CalendarXamarin
{
    public class CalendarViewModel
    {
        public List<DateTime> SelectedDates { get; set; }
        public CalendarViewModel()
        {
            SelectedDates = new List<DateTime>();
            SelectedDates.Add(new DateTime(2019, 3, 06));
            SelectedDates.Add(new DateTime(2019, 3, 11));
            SelectedDates.Add(new DateTime(2019, 3, 15));
            SelectedDates.Add(new DateTime(2019, 3, 19));
            SelectedDates.Add(new DateTime(2019, 3, 21));
            SelectedDates.Add(new DateTime(2019, 3, 25));
            SelectedDates.Add(new DateTime(2019, 3, 27));
        }
    }
}

