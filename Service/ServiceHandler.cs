using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Service
{
    internal abstract class ServiceHandler
    {
        protected ServiceRequirements _serviceProvided;
        protected ServiceHandler? _nextServiceHandler;

        public ServiceHandler(ServiceRequirements serviceProvider)
        {
            _serviceProvided = serviceProvider;
        }

        public void SetNextServiceHandler(ServiceHandler nextServiceHandler)
        {
            _nextServiceHandler = nextServiceHandler;
        }

        public void Service(Car car)
        {
            if (_serviceProvided == (car.Requirements & _serviceProvided))
            {
                Console.WriteLine($"{this.GetType().Name} providing {this._serviceProvided} services");
            }

            if (car.IsServiceComplete || _nextServiceHandler == null)
            {
                return;
            }
            else
            {
                _nextServiceHandler.Service(car);
            }
        }
    }
}
