using System;

namespace Task1_string
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nFirst nine task shows here\n");

            Console.WriteLine("Enter Input string you want to print:");
            string str;
            int spa = 0;
            int w = 0, r = 0;

            str = Console.ReadLine();
            Console.WriteLine("Your string:" + str);

            Console.WriteLine("Your string lendth:" + str.Length);

            Console.Write("\nBy spacing your string it will result:");
            while (spa < str.Length)
            {

                Console.Write("  {0}    ", str[spa]);
                spa++;
            }

            Console.Write("\nBy reversing your string:");


            int l = str.Length - 1;
            while (l >= 0)
            {
                Console.Write(" {0}  ", str[l]);
                l--;
            }
            Console.Write("\n");
            while (r < str.Length)
            {
                if (str[r] == ' ' || str[r] == '\n')
                {
                    w++;
                }
                r++;
            }
            Console.Write("\nNumber of words in your string:" + w);
            Console.Write("\n");

            string first, second;
            Console.WriteLine("Enter your first string:");
            first = Console.ReadLine();
            Console.WriteLine("Enter your second string:");
            second = Console.ReadLine();
            int compare = first.CompareTo(second);


            int stl = first.Length;
            int stle = second.Length;
            if (stl == stle)
            {

                if (compare == -1)
                {
                    Console.WriteLine("string length matched but String don't match");
                }
               
            }
            else
            { 
             Console.WriteLine("string Length not matched and so both string are not equal");
            }

            

            Console.Write("\n");
            Console.Write("Enter the string to copy:");
            string cpy = Console.ReadLine();
            Console.Write("Original string:"+cpy);
            string copy = string.Copy(cpy);     //this is immutable ()
            Console.WriteLine("Copied string:"+ copy);
           
            char[] car = { 'a', 'e', 'i', 'o', 'u' };
            

            Console.WriteLine("Enter the string you want to count vowels and consonents");
            string sare = Console.ReadLine();
            string sar = sare.Replace(" ","");
            int  f = 0, d = 0 ;
            for (int o = 0; o < 5; o++) 
            {
                for (int k = 0; k < sar.Length; k++)
                {
                    if (car[o] == sar[k])
                    {
                        f++;
                    }  
                }
 
            }
            d = sar.Length - f;
            Console.WriteLine("Total vowels:" + f);
            Console.WriteLine("Total Consonents:" + d);

        }

    }
    
}
