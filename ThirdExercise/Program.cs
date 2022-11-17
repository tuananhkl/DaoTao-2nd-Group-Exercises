using System;
using System.Linq;

namespace ThirdExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Cho 1 mảng sau:
            // [Event-Assign, Event-View, Event-Assign, Event-Acept, Event-Delete, Event-Assign, Event-Acept,
            // Event-Delete,Event-Delete, Event-View, Event-Assign, Event-Acept, Event-Delete,Event-Assign]
            var eventsArray = new[]
            {
                "Event-Assign", "Event-View", "Event-Assign", "Event-Accept", "Event-Delete", 
                "Event-Assign", "Event-Accept", "Event-Delete", "Event-Delete", "Event-View", 
                "Event-Assign", "Event-Accept", "Event-Delete", "Event-Assign"
            };
            
            // - Hãy đếm số lượng giao dịch. Một giao dịch phải gồm các sử kiện sau: "Event-View, Event-Assign, Event-Acept, Event-Delete" các sự kiện phải đúng theo thứ tự.
            var count = 0;
            for (int i = 0; i < eventsArray.Length; i++)
            {
                if (eventsArray[i].Equals("Event-View") 
                    && eventsArray[i + 1].Equals("Event-Assign") 
                    && eventsArray[i + 2].Equals("Event-Accept") 
                    && eventsArray[i + 3].Equals("Event-Delete"))
                {
                    count++;
                }
            }
            
            Console.WriteLine($"The number of transactions is {count}");
            
            // - Đếm số lượng sự kiện "Event-Acept"
            var count2 = 0;
            foreach (var evenT in eventsArray)
            {
                if (evenT.Equals("Event-Accept"))
                {
                    count2++;
                }
            }
            //var count2 = eventsArray.Count(evenT => evenT.Equals("Event-Accept"));

            Console.WriteLine($"The number of Event-Accept is: {count2}");
        }
    }
}