using System;

namespace Clinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInLine;
            int receptionTime = 10;
            int waitingHours;
            int waitingMinutes;
            int minutesPerHour = 60;
            int waitingTime;

            Console.Write("Сколько человек в очереди впереди вас? :");
            peopleInLine = Convert.ToInt32(Console.ReadLine());
            waitingTime = peopleInLine * receptionTime;
            waitingHours = waitingTime / minutesPerHour;
            waitingMinutes = waitingTime % minutesPerHour;
            Console.Write($"Вы должны отстоять в очереди {waitingHours} часа и {waitingMinutes} минут.");
        }
    }
}
