using System;
using System.Text;

namespace SecondExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            //2. Nhập vào màn hình một số (2: Thứ 2, 3: Thứ 3, 4: Thứ 4, 5: Thứ 5, 6: Thứ 6, 7: Thứ 7, CN: Chủ nhật)
            // - In ra đó là thứ mấy.
            while (true)
            {
                Console.Write("Enter your choice here (enter \"exit\" to exit): ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "2":
                        Console.WriteLine("Thứ 2");
                        break;
                    case "3":
                        Console.WriteLine("Thứ 3");
                        break;
                    case "4":
                        Console.WriteLine("Thứ 4");
                        break;
                    case "5":
                        Console.WriteLine("Thứ 5");
                        break;
                    case "6":
                        Console.WriteLine("Thứ 6");
                        break;
                    case "7":
                        Console.WriteLine("Thứ 7");
                        break;
                    case "CN":
                        Console.WriteLine("Chủ nhật");
                        break;
                    case "Exit":
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("You have to enter 1 of these options: \"2\", \"3\", \"4\", \"5\", \"6\", \"7\", \"CN\", \"exit\"");
                        break;
                }   
            }
        }
    }
}