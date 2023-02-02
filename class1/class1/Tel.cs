

namespace class1
{
    public class Tel
    {
        public int day;
        public double time;
        public double cost;
        public double GetSum()
        {
            double finalPrice = time * cost;
            if (day == 6 || day == 7) return finalPrice - finalPrice * 0.1;
            else return finalPrice;
        }
    }
}