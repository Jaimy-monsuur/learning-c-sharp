namespace Opgave2
{
    public class HPLaptop : Laptop
    {
        public HPLaptop(string serialNumber)
        {
            this.serialNumber = serialNumber;
            this.Processor = new AMD_Ryzen_3();
        }
    }
}
