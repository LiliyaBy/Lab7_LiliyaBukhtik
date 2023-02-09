using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDocument
{
    internal class FinancialInvoice:IData
    {
        public int DocumentNumber { get; set; }
        public string ProductType { get; set; }
        public int  QuantityType { get; set; }
        public string DateDoc { get; set; }

        public string Info()
        {
            return DocumentNumber + ProductType + QuantityType + DateDoc;
        }
    }
}
