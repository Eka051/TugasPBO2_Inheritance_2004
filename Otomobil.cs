using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TugasPBO2
{
    internal class Otomobil
    {
        public string transimisi;
        public int tahun;
        public void startMesin()
        {
            Console.WriteLine("Mesin hidup");
        }
    }

    internal class Sedan : Otomobil
    {
        public string merk, jenisBBM;
        public int sisaBBM;
        public Sedan(string merk, string transmisi, int tahun, string jenisBBM, int sisaBBM)
        {
            this.transimisi = transmisi;
            this.tahun = tahun;
            this.merk = merk;
            this.jenisBBM = jenisBBM;
            this.sisaBBM = sisaBBM;
        }
        public void isiBBM(int isiUlang)
        {
            sisaBBM += isiUlang;
            Console.WriteLine("Mobil Sedan Diisi BBM" + $"\nTotal BBM sekarang : {sisaBBM} Liter");
        }
    }

    internal class Truk : Otomobil
    {
        public string merk, jenisTruk;
        public int kapasitasMuatan;
        public Truk(string merk, string jenisTruk, int kapasitasMuatan)
        {
            this.merk = merk;
            this.jenisTruk = jenisTruk;
            this.kapasitasMuatan = kapasitasMuatan;
        }

        public void AngkutBarang(int beratMuatan)
        {
            Console.WriteLine($"Muatan truk sekarang : {beratMuatan} ton");
        }
    }

    internal class SepedaMotor : Otomobil
    {
        public string merk;
        public int kecepatan;
        public SepedaMotor(string merk, int kecepatan)
        {
            this.merk = merk;
            this.kecepatan = kecepatan;
        }

        public void tambahGas(int tambahKecepatan)
        {
            kecepatan += tambahKecepatan;
        }
    }
}
