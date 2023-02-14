using System;

namespace ArrivalTimePrediction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get current time
            DateTime currentTime = DateTime.Now;

            // Get expected travel time in minutes
            Console.Write("Enter expected travel time in minutes: ");
            int travelTime = int.Parse(Console.ReadLine());

            // Get distance from destination in kilometers
            Console.Write("Enter distance from destination in kilometers: ");
            double distance = double.Parse(Console.ReadLine());

            // Get traffic condition
            Console.Write("Enter traffic condition (1 = light, 2 = moderate, 3 = heavy): ");
            int trafficCondition = int.Parse(Console.ReadLine());

            // Calculate expected arrival time
            DateTime expectedArrivalTime = currentTime.AddMinutes(travelTime);
            double additionalTravelTime = 0;

            switch (trafficCondition)
            {
                case 1:
                    additionalTravelTime = distance / 60;
                    break;
                case 2:
                    additionalTravelTime = distance / 30;
                    break;
                case 3:
                    additionalTravelTime = distance / 15;
                    break;
            }

            expectedArrivalTime = expectedArrivalTime.AddMinutes((int)Math.Round(additionalTravelTime * 60));

            Console.WriteLine("Expected arrival time: " + expectedArrivalTime.ToString("hh:mm tt"));
        }
    }
}

