using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDocument
{
    internal class Document : IDataDocument
    {
        public string DataDocument(IData data)
        {
            return data.Info();
        }

    }
}
