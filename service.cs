using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktrathu
{
    internal class service
    {
        List<laptop> list = new List<laptop>(); 
        public service()
        {
            list = new List<laptop>(); 
        }
        public void NhapDS()
        {
            Console.WriteLine("ban muon nhap bao nhieu laptop?");
            int soluong = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < soluong; i++)
            {

                laptop l = new laptop();
                Console.WriteLine("Nhap id: ");
                l.ID1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap ten laptop: ");
                l.Malaptop = Console.ReadLine();
                Console.WriteLine("Nhap kich thuoc manh hinh: ");
                l.Kichthuocmh = Convert.ToDouble(Console.ReadLine());              
                list.Add(l);
            }
            Console.WriteLine("Ban muon nhap tiep khong? (Nhap Y neu tiep tuc)");
            string choose = Console.ReadLine();
            if (choose == "Y") NhapDS(); 
            else return;
        }
        public void XuatDS() 
        {
            if (list.Count == 0) 
            {
                Console.WriteLine("List dang rong, hay nhap vao di");
                NhapDS(); 
                XuatDS();
            }
            foreach (var item in list)
            {
                item.inthongtin();
            }
        }
        public void XoaDT()
        {
            Console.WriteLine("Nhap ma laptop ban can xoa");
            string IDlaptop = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Malaptop == IDlaptop)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            XuatDS();
        }
        public void XuatDStheomang()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List dang rong, hay nhap vao di");
                NhapDS();
                XuatDStheomang();
            }
            foreach (var item in list)
            {

                if (item.Kichthuocmh == 6) item.inthongtin();
            }
        }
    }
}
