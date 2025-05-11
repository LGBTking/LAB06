namespace ClassLibrary
{
    public class Phone
    {
        public string Brand;
        public string Model;
        public double ScreenSize;
        public int BatteryCapacity;
        public int RAM;
        public int Storage;
        public decimal Price;
        public string Union()
        {
            return $"{Brand} {Model}";
        }
    }
}