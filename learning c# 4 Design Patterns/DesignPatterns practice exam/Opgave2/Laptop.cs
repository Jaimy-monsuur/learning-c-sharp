namespace Opgave2
{
    public abstract class Laptop
    {
        protected string serialNumber;
        public IProcessor Processor { get; set; }
        public Laptop()
        {

        }
        public void Execute(string programName)
        {
            Processor.Execute(programName);
        }
    }
}
