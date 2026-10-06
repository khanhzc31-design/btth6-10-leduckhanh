using System;
using System.Collections.Generic;
using System.Text;

namespace THB4_6_10_
{
    public class Employee
    {
        public string EmployeeId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public string GroupTag { get; set; } = string.Empty;
    }
}