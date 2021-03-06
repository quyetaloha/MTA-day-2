using System;

namespace ArrayMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu mang:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array=new int[number];
            for(int i = 0; i < number; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Mang theo thu tu giam dan:");
            int[] copy = (int[])array.Clone();
            
            for (int i = 0; i < number-1; i++)
            {
                for(int j = i + 1; j < number; j++)
                {
                    if (copy[i] < copy[j])
                    {
                        int tmp = copy[i];
                        copy[i] = copy[j];
                        copy[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < number; i++)
            {
                Console.Write(copy[i]+" ");
            }

            Console.WriteLine("Mang ban dau:");
            for (int i = 0; i < number; i++)
            {
                Console.Write(array[i] + " ");
            }
            int min = copy[0];
            int max = copy[0];
            Console.WriteLine("Mang ban dau:");
            for (int i = 0; i < number; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                else
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Gia tri min:"+min);
            Console.WriteLine("Gia tri max:"+max);
            int sum=0;
            int avg;
            for (int i = 0; i < number; i++)
            {
                sum+=array[i];
            }
            Console.WriteLine("Tong:" + sum);
            Console.WriteLine("trung binh:" + (sum/number));
            int sl = 0;
            for (int i = 0; i < number; i++)
            {
                if (array[i] == max)
                {
                    sl++;
                }
            }
            Console.WriteLine("So luong phan tu co so luong lon nhat:" + sl);
        }
    }
}
