using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Le Phu Qui
            Console.Write("Ho Ten : ");
            string hoTen = Console.ReadLine();
            Console.Write("Lop : ");
            string Lop = Console.ReadLine();
            Console.Write("Diem trung binh hoc ky I: ");
            float diemTBHKI = float.Parse(Console.ReadLine());
            Console.Write("Diem trung binh hoc ky II: ");
            float diemTBHKII = float.Parse(Console.ReadLine());
            float diemTrungBinhCaNam = (diemTBHKI + diemTBHKII* 2 )/ 3;
            Console.WriteLine("Ho ten hoc sinh: {0}", hoTen);
            Console.WriteLine("Lop: {0}", Lop);
            Console.WriteLine("Diem trung binh ca nam: {0}", diemTrungBinhCaNam);
            Console.ReadKey();
        }
    }
}
