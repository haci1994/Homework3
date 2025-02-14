namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Homework homework = new Homework();

            int[] numbers = [2, -5, 199];
            double[] nums = [1, 3, 5, 7];

            /* 1.*/
            homework.GetMinMax(out int max, out int min, numbers);
            Console.WriteLine($"max={max}, min = {min}");

            /* 2.*/
            Console.WriteLine($"Average is {homework.AverageNumbers(nums)}");

        }
    }

    public class Homework
    {

        /* 1. Create a method named GetMinMax that takes
            an array of integers and uses the out keyword
            to return both the minimum and maximum values
            in the array.*/

        public void GetMinMax(out int max, out int min, params int[] nums)
        {
            max = nums[0];
            min = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }

                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

        }

        /* 2. Create a method called AverageNumbers that
          takes a variable number of doubles using the
          params keyword and returns their average.Handle
          the case where no arguments are passed by returning 0.*/

        public double AverageNumbers(params double[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            else
            {
                double sum = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                }

                return sum / nums.Length;
            }

        }
    }
}
