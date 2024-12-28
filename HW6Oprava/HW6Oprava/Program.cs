using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6Oprava
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 }; ;
            
            //1
            int[] Ascent = VzostupnePoradie(array);
            Poradie(Ascent);

            //2
            int[] Descent = ZostupnePoradie(array);
            Poradie(Descent);

            //3
            int[] Smaller = OdstraniNaZaciatku(array);
            Poradie(Smaller);

            //4
            int[] Smaller2 = OdstraniNaKonci(array);
            Poradie(Smaller2);

            //5
            int[] Smaller3 = OdstraniNaIndex(array, 2);
            Poradie(Smaller3);
            //6
            int[] Bigger = PridaNaZaciatok(array, 0);
            Poradie(Bigger);

            //7
            int[] Bigger2 = PridaNaKoniec(array, 0);
            Poradie(Bigger2);

            //8
            int[] Bigger3 = PridaNaIndex(array, 2, 0);
            Poradie(Bigger3);
        }

        //1
        private static int[] VzostupnePoradie(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Array is null.");
                return null;
            }

            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return array;
            }

            int[] copyArray = (int[])array.Clone();
            Array.Sort(copyArray); 
            return copyArray;
        }

        //2
        private static int[] ZostupnePoradie(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Array is null.");
                return null;
            }

            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return array;
            }
 
            int[] copyArray = (int[])array.Clone(); 
            Array.Reverse(copyArray); 
            return copyArray;
        }

        //3
        private static int[] OdstraniNaZaciatku(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Array is null.");
                return null;
            }

            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return array;
            }

            int[] newArray = new int[array.Length - 1];

            for (int i = 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }

            return newArray;
        }

        //4
        private static int[] OdstraniNaKonci(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Array is null.");
                return null;
            }

            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return array;
            }

            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        //5
        private static int[] OdstraniNaIndex(int[] array, int index)
        {
            if (array == null)
            {
                Console.WriteLine("Array is null.");
                return null;
            }

            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return array;
            }

            int[] smallerArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                smallerArray[i] = array[i];
            }

            for (int i = index + 1; i < array.Length; i++)
            {
                smallerArray[i - 1] = array[i];
            }

            return smallerArray;
        }

        //6
        private static int[] PridaNaZaciatok(int[] array, int numberToAdd)
        {
            if (array == null)
            {
                Console.WriteLine("Array is null.");
                return null;
            }

            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return array;
            }

            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            newArray[0] = numberToAdd;

            return newArray;
        }

        //7
        private static int[] PridaNaKoniec(int[] array, int numberToAdd)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = numberToAdd;

            return newArray;
        }

        //8
        private static int[] PridaNaIndex(int[] array, int index, int numberToAdd)
        {
            if (array == null)
            {
                Console.WriteLine("Array is null.");
                return null;
            }

            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return array;
            }

            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            newArray[index] = numberToAdd;

            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }

            return newArray;
        }

        private static void Poradie(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Array is null.");
                return;
            }

            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return;
            }

            foreach (int element in array)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }

    }
}

