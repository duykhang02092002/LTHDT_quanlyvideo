using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baitap2;

namespace baitap2
{
    internal class video
    {
        // các thuộc tính của lớp 
        public string Tenphim { get; set; }

        public string Theloai { get; set; }

        public string Daodien { get; set; }

        public string Namchinh { get; set; }

        public string Nuchinh { get; set; }

        public int Namsx { get; set; }

        public string Hangxs { get; set; }
        public video(string ten, string theloai, string daodien, string namchinh, string nuchinh, int namsx, string hsx)
        {
            Tenphim = ten;
            Theloai = theloai;
            Daodien = daodien;
            Namchinh = namchinh;
            Nuchinh = nuchinh;
            Namsx = namsx;
            Hangxs = hsx;
        }
        public void Hienthivideo()
        {
            Console.WriteLine("Ten phim: " + Tenphim);
            Console.WriteLine("The loai: " + Theloai);
            Console.WriteLine("Dao dien: " + Daodien);
            Console.WriteLine("Namchinh: " + Namchinh);
            Console.WriteLine("Nu chinh: " + Nuchinh);
            Console.WriteLine("Nam san xuat: " + Namsx);
            Console.WriteLine("Hang san xuat: " + Hangxs);
            Console.WriteLine();
        }
    }

}