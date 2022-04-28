using Chain_Of_Responsibility;
using Chain_Of_Responsibility.Service;

Console.WriteLine("***** Chain of Responsibility *****");

var mechanic = new Mechanic();
var detailer = new Detailer();
var wheels = new WheelSpecialist();
var qa = new QualityControl();

qa.SetNextServiceHandler(detailer);
wheels.SetNextServiceHandler(qa);
mechanic.SetNextServiceHandler(wheels);

Console.WriteLine("First Car is dirty");

mechanic.Service(new Car { Requirements = ServiceRequirements.Dirty });

Console.WriteLine("\nSecond Car requires full service");

mechanic.Service(new Car
{
    Requirements = ServiceRequirements.Dirty | ServiceRequirements.WheelAlignment
    | ServiceRequirements.EngineTune | ServiceRequirements.TestDrive
});

Console.ReadLine();