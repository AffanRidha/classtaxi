using System;

namespace ConsoleApp1
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);

            if (OnDuty == true)
            {
                Console.WriteLine("OnDuty : Yes", OnDuty);
            }else
            {
                Console.WriteLine("OnDuty : No", OnDuty);
            }
            Console.WriteLine("Number Of Passenger : {0}\n", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName);
        }
        public void DropOfPassenger()
        {
            Console.WriteLine("{0} Selesai Menjemput Penumpang\n", DriverName);
        }
    }
}
