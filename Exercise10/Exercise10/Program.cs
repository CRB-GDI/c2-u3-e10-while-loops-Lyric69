using System.Net.Security;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("**************\r\nMenu:\r\n1 - New Game\r\n2 - Load Game\r\n3 - Options\r\n4 - Quit\r\n**************");
            int Menu = int.Parse(Console.ReadLine());

            while (Menu != 4)
            {
                Console.WriteLine();
                Console.Write("**************\r\nMenu:\r\n1 - New Game\r\n2 - Load Game\r\n3 - Options\r\n4 - Quit\r\n**************");
                Menu = int.Parse(Console.ReadLine());
            

            while (Menu >= 5 ||
                Menu <=0)
            {
                Console.WriteLine();
                Console.Write("You need to pick between 1 to 4\r\n");
                Console.Write("**************\r\nMenu:\r\n1 - New Game\r\n2 - Load Game\r\n3 - Options\r\n4 - Quit\r\n**************");
                Menu = int.Parse(Console.ReadLine());
            }

            while (Menu == 1)
            {
                Console.WriteLine();
                Console.Write("Starting new game...\r\n");
                Console.Write("**************\r\nMenu:\r\n1 - New Game\r\n2 - Load Game\r\n3 - Options\r\n4 - Quit\r\n**************");
                Menu = int.Parse(Console.ReadLine());
            }

            while (Menu == 2)
            {
                Console.WriteLine();
                Console.Write("Loading game...\r\n");
                Console.Write("**************\r\nMenu:\r\n1 - New Game\r\n2 - Load Game\r\n3 - Options\r\n4 - Quit\r\n**************");
                Menu = int.Parse(Console.ReadLine());
            }

            while (Menu == 3)
            {
                Console.WriteLine();
                Console.Write("Options settings...\r\n");
                Console.Write("**************\r\nMenu:\r\n1 - New Game\r\n2 - Load Game\r\n3 - Options\r\n4 - Quit\r\n**************");
                Menu = int.Parse(Console.ReadLine());
                //make if statments
            }
          }
       }
    }
}