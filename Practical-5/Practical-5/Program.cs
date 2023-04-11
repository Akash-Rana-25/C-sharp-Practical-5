namespace Practical_5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] myNum=new int [5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter Array");
               
                if ((int.TryParse(Console.ReadLine(),out int value)))
                {
                    myNum[i] = value;
                }
                else
                {
                    myNum[i] = 0;   
                }
                Console.WriteLine($"myNum[{i}]={myNum[i]}");
            }

            try
            {
                Console.WriteLine("enter Array if you want to genrate error");

                if ((int.TryParse(Console.ReadLine(), out int value)))
                {
                    myNum[5] = value;
                }
                else
                {
                    myNum[5] = 0;
                }

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("This is finally block");
            }
        }
    }
}