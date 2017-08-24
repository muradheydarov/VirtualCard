using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCard
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Console.WriteLine("Istifadeci adini daxil edin(muradheydarov): ");
            string userName = Console.ReadLine();
            Console.WriteLine("Sifrenizi daxil edin(12345): ");
            string password = Console.ReadLine();
            Console.WriteLine();
            RealCard realCard = new RealCard(userName, password);
        }
    }
}
