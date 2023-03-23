using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ngay thang: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("<------------------------------------>");
            Console.WriteLine("Ngay hom qua la: \t{0}", date.AddDays(-1).ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay hom nay la \t{0}", date.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay mai la: \t\t{0}", date.AddDays(1).ToString("dd/MM/yyyy"));
            Console.WriteLine("<------------------------------------>");
            Console.ReadKey();
        }
    }
}
