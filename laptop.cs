using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktrathu
{
    internal class laptop
    {
        int ID;string malaptop;double kichthuocmh;

        public laptop()
        {
            
        }
        public laptop(int iD, string malaptop, double kichthuocmh)
        {
            ID = iD;
            this.malaptop = malaptop;
            this.kichthuocmh = kichthuocmh;
        }
        public int ID1 { get => ID; set => ID = value; }
        public string Malaptop { get => malaptop; set => malaptop = value; }
        public double Kichthuocmh { get => kichthuocmh; set => kichthuocmh = value; }

        public void inthongtin() 
        {
            Console.WriteLine($"ID: {ID}, ma laptop: {Malaptop}, kich thuoc mh: {kichthuocmh}");
        }
    }
}
