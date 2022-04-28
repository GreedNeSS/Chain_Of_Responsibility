using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chain_Of_Responsibility.Service;

namespace Chain_Of_Responsibility
{
    internal class Car
    {
        public ServiceRequirements Requirements { get; set; }

        public bool IsServiceComplete => Requirements == ServiceRequirements.None;
    }
}
