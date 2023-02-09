using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    internal interface IGetEmployee
    {
         string PrintsPosition();
    }
    internal interface IEmployeeIncludes 
    {
        string EmployeeIncludes(IGetEmployee getEmployee);
        
    }
}
