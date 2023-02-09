using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    internal class Employee : IEmployeeIncludes
    {
        public string EmployeeIncludes(IGetEmployee getEmployee)
        {
            return getEmployee.PrintsPosition();
        }
    }
}
