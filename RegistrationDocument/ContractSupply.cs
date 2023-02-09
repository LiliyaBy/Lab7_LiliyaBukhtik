using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDocument
{
    internal class ContractSupply : IData
    {
        public double MonthlyTotal { get; set; }
        public string DateDoc { get; set; }
        public int DocumentNumber { get; set; }   
        public int DepartmentID { get; set; }

        public string Info()
        {
            return DocumentNumber + DateDoc + DocumentNumber + DepartmentID;
        }
    }
}
