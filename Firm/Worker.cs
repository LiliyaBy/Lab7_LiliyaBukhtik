using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    internal class Worker : IGetEmployee
    {
        string employee = "Worker";
        public string PrintsPosition()
        {
            return employee;
        }
    }
}
