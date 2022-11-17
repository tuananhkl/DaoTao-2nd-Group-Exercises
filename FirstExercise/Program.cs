using System;
using System.Linq;

namespace FirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Cho 1 mảng giá trị [2,3,1,5,4,6,8,20,14]
            var intArray = new[] {2, 3, 1, 5, 4, 6, 8, 20, 14};
            int smallestNumber = default;

            //     - Sử dụng từ khóa ref để lấy kết quả tìm được
            FindSmallestNumber(intArray, ref smallestNumber);
        }
        
        private static void FindSmallestNumber(int[] intArray, ref int smallestNumber)
        {
            //     - Tìm giá trị nhỏ nhất trong mảng
            smallestNumber = Int32.MaxValue;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] < smallestNumber)
                {
                    smallestNumber = intArray[i];
                }
            }
            
            Console.WriteLine(smallestNumber);
            //smallestNumber = intArray.Prepend(smallestNumber).Min();
        }
    }
}