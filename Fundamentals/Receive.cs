using System;
namespace Fundamentals
{
    public class Receive
    {
      
        public static int Int(string instruction)
        {
            try
            {
                Console.WriteLine(instruction);
                return int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Int(instruction);
            }
        }

        public static float FloatByOrder(int order)
        {
            try
            {
                Console.WriteLine($"Informe o {order}º número: ");
                return float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return FloatByOrder(order);
            }

        }

        public static float Float(string instruction)
        {
            try
            {
                Console.WriteLine(instruction);
                return float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Float(instruction);
            }

        }
    }
}

