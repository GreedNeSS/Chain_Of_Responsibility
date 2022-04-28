using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Service
{
    internal class Mechanic : ServiceHandler
    {
        public Mechanic() : base(ServiceRequirements.EngineTune)
        {
        }
    }
}
