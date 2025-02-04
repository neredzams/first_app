using System;


namespace array_home_work
{
    internal class app
    {
        static void Main(string[] args)
        {
            Console.Write("Input array size:");

            int array_size = int.Parse(Console.ReadLine());             //input array size


            int[] array = new int[array_size]; // created array

            for (int i = 0; i < array_size; i++)  // count array size

            {
                if (i == 0)
                {
                    Console.WriteLine("array length is:" + array_size); // get arrray index
                }

                Console.Write("input value " + i + ":");

                array[i] = int.Parse(Console.ReadLine());

                //Console.WriteLine(array[i]);

            }

            Console.WriteLine("===|array min -> max");


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array values for index:" + i + " is:" + array[i]);

            }

            Console.WriteLine("===|array max -> min");


            for (int i = array.Length - 1; i >= 0; i--)
            {


                Console.WriteLine("array values for index:" + i + " is:" + array[i]);

            }

            Console.WriteLine("===Even & Odd number sum in array");

            int event_sum = 0;
            int odd_sum = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] % 2 == 0)
                {
                    event_sum += array[i];
                }

                else
                {
                    odd_sum += array[i];

                }
                //Console.WriteLine("array values for index:" + i + ":" + array[i]);
            }

            Console.WriteLine("Event sum: " + event_sum);
            Console.WriteLine("Odd sum: " + odd_sum);

            Console.WriteLine("===find smallest & largest number in array");

            int min_number = array[0];

            for (int i = 1; i < array.Length; i++) // start array check from index 1 
            {
                if (array[i] <= min_number)
                {
                    min_number = array[i];
                }

            }

            Console.WriteLine("Min number in array is: " + min_number);

            int max_number = array[0];

            for (int i = 1; i < array.Length; i++) // start array check from index 1 
            {
                if (array[i] >= max_number)
                {
                    max_number = array[i];
                }

            }
            Console.WriteLine("Max number in array is: " + max_number);
           
            
            Console.WriteLine("");
            Console.WriteLine("Press for Exit");
            Console.ReadLine();

        }
    }
}
