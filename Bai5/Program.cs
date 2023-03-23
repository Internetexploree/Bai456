using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        //Le Phu Qui
            struct ThongTinNhanVien
        { 
            
            public string hoTen { get; set; }

            public string gioiTinh { get; set; }

            public DateTime ngaySinh { get; set; }

            public float HSL { get; set; }

            public float LCB { get; set; }

            public float soNam { get; set; }

            public float PC { get; set; }

            public float tamTinh { get; set; }

            public float Luong { get; set; }
            public ThongTinNhanVien(string ten, string gt, DateTime ns, float hsl, float lcb, float sonam)
            {
                this.hoTen = ten;
                this.gioiTinh = gt;
                this.ngaySinh = ns;
                this.HSL = hsl;
                this.LCB = lcb;
                this.soNam = sonam;
                this.PC = sonam >= 5 ? lcb / 2 : 0;
                this.tamTinh = (float)Math.Ceiling(this.LCB * this.HSL);
                this.Luong = this.tamTinh + this.PC;
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Ho ten: ");
            string hoTen = Console.ReadLine();
            Console.Write("Gioi tinh: ");
            string gioiTinh = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            DateTime ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("LCB: ");
            float LCB = float.Parse(Console.ReadLine());
            Console.Write("HSL: ");
            float HSL = float.Parse(Console.ReadLine());
            Console.Write("So nam: ");
            float soNam = float.Parse(Console.ReadLine());
            ThongTinNhanVien nv1 = new ThongTinNhanVien(hoTen,gioiTinh,ngaySinh,HSL,LCB,soNam);
            Console.WriteLine("Thong tin nhan vien 1:\n" +
                                    "Ho ten: \t{0}\n" +
                                    "Gioi tinh: \t{1}\n" +
                                    "Ngay sinh: \t{2}\n" +
                                    "LCB:\t\t{3}\n" +
                                    "HSL:\t\t{4}\n" +
                                    "So nam:\t\t{5}\n" +
                                    "Phu cap:\t{6}\n" +
                                    "Tam tinh:\t{7}\n" +
                                    "Tien luong: \t{8}"
                                    , nv1.hoTen, nv1.gioiTinh, nv1.ngaySinh.ToString("dd/MM/yyyy"),
                                    nv1.LCB, nv1.HSL, nv1.soNam, nv1.PC, nv1.tamTinh, nv1.Luong); 
           Console.ReadKey();
            }
        }

    }


