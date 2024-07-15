using baitap2;
List<video> movielist = new List<video>();

while (true)
{
    Console.WriteLine("\n=====Quan ly video=====");
    Console.WriteLine("1. ten bo phim moi ");
    Console.WriteLine("2. Hien thi danh sach video");
    Console.WriteLine("3. Thoát ");
    Console.WriteLine("4. Nhập tên thể loại ");

    Console.Write("vui long chon (1/2/3/4):");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("\n nhap thong tin cho bo phim moi:");
            Console.Write(" ten phim: ");
            string ten = Console.ReadLine();
            Console.Write(" the loai: ");
            string theloai = Console.ReadLine();
            Console.Write(" Dao dien: ");
            string daodien = Console.ReadLine();
            Console.Write(" Nam chinh: ");
            string namchinh = Console.ReadLine();
            Console.Write("Nu chinh: ");
            string nuchinh = Console.ReadLine();
            Console.Write(" Nam san xuat: ");
            int namsx = int.Parse(Console.ReadLine());
            Console.Write(" Hang san xuat: ");
            string hangsx = Console.ReadLine();

            video movie = new video(ten, theloai, daodien, namchinh, nuchinh, namsx, hangsx);
            movielist.Add(movie);
            Console.WriteLine("\n da them bo phim moi vao danh sach.");
            break;


        case "2":
            Console.WriteLine("\n Danh sach các bo phim: ");
            foreach (var mv in movielist)
            {
                mv.Hienthivideo();
            }
            break;


        case "3":
            Console.WriteLine("\n Da thoat chuong trinh.");
            return;


        case "4":
            Console.WriteLine("Nhap ten the loai: ");
            string loai = Console.ReadLine();
            foreach (var mv in movielist)
            {
                if (mv.Theloai == loai)
                    mv.Hienthivideo();
            }
            break;

        default:
            Console.WriteLine("\nLua chon khong hop le. vui long chon lai.");
            break;
    }
}