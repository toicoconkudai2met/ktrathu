namespace ktrathu
{
    internal class Program
    {
        static string Menu() 
        {
            Console.WriteLine("\n-------MENu--------");
            Console.WriteLine("1. Nhap DS");
            Console.WriteLine("2. Xuat DS");
            Console.WriteLine("3. Xoa doi tuong theo ma laptop");
            Console.WriteLine("4. Xuat ktmh theo khoang nguoi dung nhap vao");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("Hay nhap su lua chon cua ban");
            string choose = Console.ReadLine();
            if (choose != "1" && choose != "2" && choose != "3"
                && choose != "4" && choose != "5" && choose != "6")
            {
                Console.WriteLine("Loi roi, hay nhap lai");
                return Menu(); 
            }
            else return choose;
        }
        static void Main(string[] args)
        {
            service sv = new service(); 
            while (true)
            {
                switch (Menu()) 
                {
                    case "1":
                        sv.NhapDS();
                        break;
                    case "2":
                        sv.XuatDS();
                        break;
                    case "3":
                        sv.XoaDT();
                        break;
                    case "4":
                        sv.XuatDStheomang();
                        break;
                    case "5":
                       
                        Environment.Exit(0); 
                        break;
                    
                }
            }

        }
    }
}
