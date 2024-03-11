using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPBO2
{
    internal class Mobil
    {
        public string merk, warna;
        public int kecepatanAwal;
        public void hidupkanMesin()
        {
            Console.WriteLine("Mesin mobil hidup");
        }
    }

    internal class MobilSedan : Mobil
    {
        public string transmisi;
        public int kecepatanAkhir;

        public MobilSedan(string merk, int kecepatanAwal, string transmisi, string warna)
        {
            this.merk = merk;
            this.warna = warna;
            this.kecepatanAwal = kecepatanAwal;
            this.transmisi = transmisi;

        }
        public void ubahGigi(int gigi)
        {
            Console.WriteLine($"Gigi di ubah ke gigi : {gigi}");
        }

        public void kecepatanAkhirSedan(int kecepatanAkhir)
        {
            Console.WriteLine($"Kecepatan akhir mobil sedan : {kecepatanAkhir} km/jam");
        }


    }
}
