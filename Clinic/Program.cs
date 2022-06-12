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

            Console.Write("Сколько человек в очереди впереди вас? :");
            peopleInLine = Convert.ToInt32(Console.ReadLine());
            waitingHours = (peopleInLine * receptionTime) / 60;
            waitingMinutes = (peopleInLine * receptionTime) % 60;
            Console.Write($"Вы должны отстоять в очереди {waitingHours} часа и {waitingMinutes} минут.");
        }
    }
}
