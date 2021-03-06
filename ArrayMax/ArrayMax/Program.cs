using System;

namespace ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] bonus = {-1,-0.5,0.5,2,3.5,5 };
            String[] message = { "Rất kém","Kém","Có cố gắng","Tốt","Rất tốt", "Tuyệt vời"};
            Console.WriteLine("Nhap doanh so:");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input < 0 || input > 10)
            {
                Console.WriteLine("Nhap sai");
            }
            else if (input <= 3)
            {
                Console.WriteLine(message[0]+bonus[0]);
            }
            else if (input == 4)
            {
                Console.WriteLine(message[1] + bonus[1]);
            }
            else if (input == 5)
            {
                Console.WriteLine(message[2] + bonus[2]);
            }
            else if (input == 6)
            {
                Console.WriteLine(message[3] + bonus[3]);
            }
            else if (input == 7)
            {
                Console.WriteLine(message[4] + bonus[4]);
            }
            else if (input <= 10)
            {
                Console.WriteLine(message[5] + bonus[5]);
            }
        }
    }

}
