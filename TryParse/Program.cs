using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {

            string userStrihg  ;
            userStrihg = Console.ReadLine();
            int number;
            bool results = int.TryParse(userStrihg, out number);

            while(true)
            {
                if (results == true)
                {
                    Console.WriteLine("Успешно - " + number);
                    break;
                }
                else
                {
                    Console.WriteLine("Еще раз");
                }
            }
        }  
    }
}
