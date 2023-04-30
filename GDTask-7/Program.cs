using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTask_7
{
    internal class Program
    {
        public static int[] ThreeHundredBacks(int n) 
        {
            int mod_5_less_3 = 0, mod_3_less_5 = 0, mod_5_3 = 0;
            mod_3_less_5 = n / 3;
            if (n % 3 == 0) 
            {
                mod_3_less_5--;
            }

            mod_5_3 = mod_3_less_5 / 5;
            mod_3_less_5 -= (mod_3_less_5 / 5);

            mod_5_less_3 = n / 5;
            if (n % 5 == 0) 
            {
                mod_5_less_3--;
            }

            mod_5_less_3 -= (mod_5_less_3 / 3);

            return new int[3] {mod_3_less_5, mod_5_less_3, mod_5_3};
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = ThreeHundredBacks(n);
            for(int i = 0;i < arr.Length;i++) 
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
