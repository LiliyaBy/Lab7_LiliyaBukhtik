using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDocument
{
    internal class ContractEmployee: IData
    {
        public int DocumentNumber { get; set; }
        public string DateDoc { get; set; }
        public int DateEndContract { get; set; }
        public int NameEmplyee { get; set;}


        public string Info()
        {
            return DocumentNumber + DateDoc + DateEndContract + NameEmplyee;
        }
    }


}
