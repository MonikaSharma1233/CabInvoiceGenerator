using System.Security.Cryptography.X509Certificates;

namespace CabInvoiceGenerator
{
    public class Program
    {
        //public enum Month
        //{
        //    January,
        //    Feb,
        //    Mar,
        //    Apr,
        //    May
        //};
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine("Calculated Fare of 2 km and time 5 "+fare);
            RideRepository rideRepository = new RideRepository();

            Ride[] rides = { new Ride(2.0,5), new Ride(5, 7) };

            rideRepository.AddRide("Monika", rides);
            Ride[] val = rideRepository.GetRides("Monika");
            foreach (Ride ride in val)
            {
                Console.WriteLine("Distance: "+ride.distance);
            }
            //int val = (int)Month.Apr;
            //Console.WriteLine(val);
        }
    }
}
