

namespace CRUD_Basic_Class
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Nullable<decimal> EmployeeSalary { get; set; }
        public string EmployeeCity { get; set; }
    }
}
