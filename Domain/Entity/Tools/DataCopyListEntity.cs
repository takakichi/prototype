using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MasterPrototype.Domain.Entity.Tools
{
    internal class DataCopyListEntity
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime? HireDate { get; set; }
        public bool IsActive { get; set; }
    }
}
