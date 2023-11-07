using System.Text;
using System.Threading;


namespace Homework__7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const int MaxCustomers = 3;
            const int NumChairs = 1;
            Semaphore waitingRoom = new Semaphore(NumChairs, NumChairs);
            Semaphore barberChair = new Semaphore(1, 1);
            Semaphore barberSleepChair = new Semaphore(0, 1);
            Semaphore seatBelt = new Semaphore(0, 1);
            bool AllDone = false;
            void Barber()
            {
                while (!AllDone)
                {
                    Console.WriteLine("Barber is sleeping...");
                    barberSleepChair.WaitOne();
                    if (!AllDone)
                    {
                        Console.WriteLine("Barber is working...");
                        Thread.Sleep(random.Next(1,3) * 1000);
                        Console.WriteLine("Barber finished the work!");
                        seatBelt.Release();
                    }
                    else
                    {
                        Console.WriteLine("Barber is sleeping...");
                    }
                }
                return;
            }
            void Customer(Object number)
            {
                int Number = Convert.ToInt32(number);
                Console.WriteLine("Client {0} goes to the barbershop...", Number);
                Thread.Sleep(random.Next(1, 5)*1000);
                Console.WriteLine("Client {0} enters the barbershop...", Number);
                waitingRoom.WaitOne();
                Console.WriteLine("Client {0} enters the waiting room...", Number);
                barberChair.WaitOne();
                waitingRoom.Release();
                Console.WriteLine("Client {0} wakes barber up...", Number);
                barberSleepChair.Release();
                seatBelt.WaitOne();
                barberChair.Release();
                Console.WriteLine("Client {0} leaves the barbershop...", Number);
            }
            Thread BarberThread = new Thread(Barber);
            BarberThread.Start();
            Thread[] Customers = new Thread[MaxCustomers];
            for (int i = 0; i < MaxCustomers; i++)
            {
                Customers[i] = new Thread(new ParameterizedThreadStart(Customer));
                Customers[i].Start();
            }
            for (int i = 0;i < MaxCustomers;i++)
            {
                Customers[i].Join();
            }
            AllDone = true;
            barberSleepChair.Release();
            BarberThread.Join();
            Console.WriteLine("All work is done!");
        }
    }
}