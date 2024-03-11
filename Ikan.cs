using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPBO2
{
    internal class Ikan
    {
        public string warna, habitat;
        public void Berenang()
        {
            Console.WriteLine("Ikan mulai berenang");
        }
    }

    internal class IkanCakalang : Ikan
    {
        public int umur;
        public string jenisKelamin;
        public IkanCakalang(string warna, string habitat, int umur, string jenisKelamin)
        {
            this.warna = warna;
            this.habitat = habitat;
            this.umur = umur;
            this.jenisKelamin = jenisKelamin;
        }
        public void Berburu()
        {
            Console.WriteLine("Ikan cakalang berburu makanan");
        }
    }
}
