namespace Opgave2
{
    public class MacBook : Laptop
    {
        public MacBook(string serialNumber)
        {
            this.serialNumber = serialNumber;
            this.Processor = new Intel_i5();
        }
    }
}
