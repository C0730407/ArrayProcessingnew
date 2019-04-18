using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            String line = Convert.ToString(Console.ReadLine());
            String[] words = line.Split(' ');

            String word = "";
            int ctr = 0;
            foreach(String s in words)
            {
                if(s.Length>ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(word);
        }
    }
}
