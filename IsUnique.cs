using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsUnique
{
    class Program
    {
       public static bool IsUnique(string str)
        {

            if (str.Length > 128)
                return false;

            bool[] char_array = new bool[128];

            for(int i = 0; i < str.Length; i++)
            {

                int val = str[i];
                if (char_array[val])
                    return false; 

                char_array[val] = true;
                
            }
            return true;
        }


        static void Main(string[] args)
        {

            Console.Write(IsUnique("carc"));
            Console.ReadKey(true);

        }
    }
}
