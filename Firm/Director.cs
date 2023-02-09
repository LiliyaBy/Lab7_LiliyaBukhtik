using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    internal class Director : IGetEmployee
    {
        string employee = "Director";
        public string PrintsPosition()
        {

            return employee;
        }
    }
}
