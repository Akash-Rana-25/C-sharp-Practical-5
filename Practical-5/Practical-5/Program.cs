namespace Practical_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myNum = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < myNum.Length; i++)
            {
                Console.WriteLine($"myNum[{i}]={myNum[i]}");
            
            }
            try
            {
                myNum[5] = 15;

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