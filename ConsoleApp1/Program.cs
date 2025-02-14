namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Homework homework = new Homework();


            /* 1.*/
            int[] numbers = [2,-5,199];

            homework.GetMinMax(numbers, out int max, out int min);

            Console.WriteLine($"max={max}, min = {min}");
        }
    }

        public class Homework { 

            /* 1. Create a method named GetMinMax that takes
                an array of integers and uses the out keyword
                to return both the minimum and maximum values
                in the array.*/

            public void GetMinMax(int[] nums, out int max, out int min)
            {
                max = nums[0];
                min = nums[0];

                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] > max) { 
                    max = nums[i];
                    }

                    if (nums[i] < min) {
                    min = nums[i];
                    }
                }
                                
            }
        }
    }

