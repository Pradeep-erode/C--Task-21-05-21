using System;

namespace Task1_array
{
    class Program
    {
        static void Main(string[] args)
        {
            findunique obj = new findunique();
            obj.maine();
            /*
             Console.WriteLine("Enter the array elements to store");
             int d = Convert.ToInt32(Console.ReadLine());
             int[] arr = new int[d];
             int[] are = new int[d];
             for (int i = 0; i < d; i++)
             {
                 Console.WriteLine("Enter the array elements{0}",d);
                 arr[i] = Convert.ToInt32(Console.ReadLine());

             }
             int sum = 0;
             for (int j = 0; j < d; j++)
             {
                 Console.Write(arr[j]);
                 sum += arr[j];
             }
             Console.Write("\n");
             int r = d-1;

             while (r >= 0)
             {

            //print reverse 
            
                 Console.Write(arr[r]);
                 r--;
             }
             Console.WriteLine("\nsumming all the array elemens:"+sum);

             for(int t=0;t<d;t++)
             {
             are[t]=arr[t];
             }

             for(int h=0;h<d;h++)
             {
             Console.WriteLine(are[h]);
             }
             Console.WriteLine("\n");

             */
        } 
    }
    public class findunique
    {
        public void maine()
        {
            Console.WriteLine("Enter the array elements to find duplicates and unique elements:");
            int e = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[e];

            int fer = 0;

            for (int b = 0; b < e; b++)
            {
                Console.WriteLine("Enter the array elements{0}", b);
                ar[b] = Convert.ToInt32(Console.ReadLine());
            }
            int[] den = new int[e];
            for (int t = 0; t < e; t++)
            {
                den[t] = ar[t];
            }

            for (int g = 0; g < e; g++)
            {
                for (int v = 0; v < e; v++)
                {
                    if (den[g] == ar[v])
                    {
                        fer = ar[v];

                    }

                    else
                    {
                        int t = 0;
                        t = ar[v];
                        Console.WriteLine("The unique value in your array:" + t);
                    }
                }
                break;

            }
            Console.WriteLine("The duplicate value found in array:" + fer);
        }
    }

        
    
}
