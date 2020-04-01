using Facade.Subsystem;

namespace Facade.Facade
{
    public class Facade
    {
        private readonly Subsystem1 Subsystem1;

        private readonly Subsystem2 Subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            Subsystem1 = subsystem1;
            Subsystem2 = subsystem2;
        }
        
        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string Operation()
        {
            var result = "Facade initializes subsystems:\n";
            result += Subsystem1.Operation1();
            result += Subsystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += Subsystem1.OperationN();
            result += Subsystem2.OperationZ();
            return result;
        }
    }
}