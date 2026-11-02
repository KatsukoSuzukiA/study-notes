using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{

    public class AppSettings
    {
        public StaffSettings Staff { get; set; } = new();
    }

    public class StaffSettings
    {
        public string[] Surgeons { get; set; } = [];
        public string[] Assistants { get; set; } = [];
        public string[] AnesthesiaStaff { get; set; } = [];
    }

}
