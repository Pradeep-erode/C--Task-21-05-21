using System;

namespace Task_string2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n4 tasks\n");

            Console.WriteLine("Enter the initial string");
             string str = Console.ReadLine();
             Console.WriteLine("Enter the start index to extract a substring");
             int st = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the array length to extract a substring");
             int s = Convert.ToInt32(Console.ReadLine());
             String stt = str.Substring(st, s);
             Console.WriteLine("The extracted substring:"+stt);
             Console.WriteLine("Enter the substring you want to search");
             string arm = Console.ReadLine();
             string [] chr = str.Split(' ');

             for (int i = 0; i < chr.Length; i++)
             {
                 if (arm == chr[i])
                 {
                     string ar = chr[i];
                     Console.WriteLine("\nThe only substring exists in the string  :" + ar);
                 }
                 else { Console.WriteLine("\nThe other string not matching your search"); }

             }

             Console.WriteLine("Enter the string you want to covert uppercase lower case vise versa");
             string sta = Console.ReadLine();
             int len = sta.Length;

             for (int y = 0; y < sta.Length; y++)
             {
                 char hill = sta[y];
                 if (char.IsLower(hill))
                 {
                     Console.Write(char.ToUpper(hill));
                 }
                 else if(char.IsUpper(hill))
                 {
                     Console.Write(char.ToLower(hill));
                 }
             }
            Console.WriteLine("Enter the string you want to iniatialize for position searching");
            string sar = Console.ReadLine();
            Console.WriteLine("Enter the string you want to find position");
            string sa= Console.ReadLine();
            string[] sti = sar.Split(' ');
            for (int z = 0; z < sti.Length; z++)
            {
                if (sa == sti[z])
                { Console.WriteLine(sar.IndexOf(sti[z])); }
            }
            

        }
    }
}
