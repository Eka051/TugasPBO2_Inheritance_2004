using System.Runtime.CompilerServices;
using TugasPBO2;

class Program
{
    public static void Main(string[] args)
    {
        MobilSedan toyota = new MobilSedan("Vios", 20, "Manual", "Hitam");
        Console.WriteLine($"Merk Sedan      : {toyota.merk}"
            + $"\nJenis Transmisi : {toyota.transmisi}"
            + $"\nWarna Sedan     : {toyota.warna}");
        toyota.hidupkanMesin();
        Console.WriteLine($"Kecepatan awal sedan : {toyota.kecepatanAwal} km/jam");
        toyota.ubahGigi(2);
        toyota.kecepatanAkhirSedan(60);
        Console.WriteLine();

        IkanCakalang cakalang = new IkanCakalang("Putih", "Air Laut", 2, "Jantan");
        Console.WriteLine($"Warna cakalang   : {cakalang.warna}"
             + $"\nHabitat cakalang : {cakalang.habitat}"
             + $"\nUmur cakalang    : {cakalang.umur}"
             + $"\nJenis kelamin    : {cakalang.jenisKelamin}");
        cakalang.Berenang();
        cakalang.Berburu();
        Console.WriteLine();

        PionPutih caturPutih = new PionPutih();
        caturPutih.posisi = 2;
        caturPutih.Gerak();
        caturPutih.GerakMaju(5);
        Console.WriteLine($"Posisi pion putih : {caturPutih.posisi}");
        Console.WriteLine();

        PionHitam caturHitam = new PionHitam();
        caturHitam.posisi = 7;
        caturHitam.Gerak();
        caturHitam.Menyerang(4);
        Console.WriteLine($"Posisi pion hitam : {caturHitam.posisi}");
        Console.WriteLine();

        RekeningTabungan tabungan = new RekeningTabungan("Eka", "051004090306", 250000);
        tabungan.Setor(50000);
        tabungan.Tarik(25000);
        Console.WriteLine();

        RekeningGiro giro = new RekeningGiro("Eka", "051004090306", 250000);
        Console.WriteLine("Rekening Giro");
        giro.PotonganBiayaAdmin(6000);
        Console.WriteLine();

        Sedan sedan2 = new Sedan("Mercedes", "Matic", 2023, "Pertamax Turbo", 35 );
        Console.WriteLine($"Merk : {sedan2.merk}"
            + $"\nTransmisi : {sedan2.transimisi}"
            + $"\nTahun     : {sedan2.tahun}"
            + $"\nJenis BBM : {sedan2.jenisBBM}"
            + $"\nSisa BBM  : {sedan2.sisaBBM} Liter");
        sedan2.isiBBM(12);
        Console.WriteLine();
        
        Truk kontainer = new Truk("Mitsubishi", "Truk Kontainer", 20);
        Console.WriteLine($"Merk truk : {kontainer.merk}"
            + $"\nJenis truk : {kontainer.jenisTruk}"
            + $"\nKapasitas muatan : {kontainer.kapasitasMuatan} ton");
        kontainer.AngkutBarang(15);
        Console.WriteLine();

        SepedaMotor motor = new SepedaMotor("Honda Vario", 40);
        Console.WriteLine($"Merk motor : {motor.merk}"
            + $"\nKecepatan awal : {motor.kecepatan} km/jam");
        motor.tambahGas(35);
        Console.WriteLine("Tambah Gas"
           + $"\nKecepatan sekarang : {motor.kecepatan} km/jam");
        Console.ReadKey();
    }

}