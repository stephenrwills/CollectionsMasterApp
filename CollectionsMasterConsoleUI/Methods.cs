using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsMasterConsoleUI
{
    internal class Methods
    {
        public static void PopulateMethod(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Random r = new Random();
                numbers[i] = r.Next(0, 50);  
            }
        }
    }
}
