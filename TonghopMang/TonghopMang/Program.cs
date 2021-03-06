using System;

namespace TonghopMang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu mang:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[1000];
            for (int i = 0; i < number; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Mang theo thu tu giam dan:");
            int[] copy = (int[])array.Clone();

            for (int i = 0; i < number - 1; i++)
            {
                for (int j = i + 1; j < number; j++)
                {
                    if (copy[i] < copy[j])
                    {
                        int tmp = copy[i];
                        copy[i] = copy[j];
                        copy[j] = tmp;
                    }
                }
                
            }
            inmang(copy, number);
            Console.WriteLine("vi tri tren phan tu:");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("gia tri chen:");
            int value = Convert.ToInt32(Console.ReadLine());
            
            for (int i = number + 1; i > position ; i--)
            {
                array[i] = array[i - 1]; 
            }
            array[position]=value;
            number++;
            inmang(array, number);


        }

        public static void inmang(int[] copy,int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(copy[i] + " ");
            }
        }
    }
}
