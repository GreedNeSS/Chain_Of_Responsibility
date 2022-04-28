using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Service
{
    [Flags]
    public enum ServiceRequirements
    {
        None = 0,
        WheelAlignment = 1,
        Dirty = 2,
        EngineTune = 4,
        TestDrive = 8,
    }
}
