using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Service
{
    internal class QualityControl : ServiceHandler
    {
        public QualityControl() : base(ServiceRequirements.TestDrive)
        {
        }
    }
}
