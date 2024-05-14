using miniprojekt_rk69345;
using System.Security.Cryptography.X509Certificates;

namespace miniprojekt_rk69345
{
    class ArrayMin
    {
        public int Min(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array nuk mund të jetë null ose bosh.");
            }

            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Shkruani madhësinë e array:");
            int size = int.Parse(Console.ReadLine());

            int[] myArray = new int[size];

            Console.WriteLine("Shkruani vlerat e array:");

            for (int i = 0; i < size; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            ArrayMin arrayMin = new ArrayMin();
            int minValue = arrayMin.Min(myArray);

            Console.WriteLine("Vlera minimale në array është: " + minValue);
        }
    }
}





