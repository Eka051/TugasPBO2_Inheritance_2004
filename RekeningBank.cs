using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPBO2
{
    internal class RekeningBank
    {
        public string namaNasabah;
        public string nomorRekening;
        public double saldo;

        public void Setor(double jumlah)
        {
            saldo += jumlah;
            Console.WriteLine($"Setoran telah masuk. Saldo Rp.{saldo}");
        }

    }

    internal class RekeningTabungan : RekeningBank
    {
        public double jumlah;
        public RekeningTabungan(string namaNasabah, string nomorRekening, double saldo)
        {
            this.namaNasabah = namaNasabah;
            this.nomorRekening = nomorRekening;
            this.saldo = saldo;
        }
        public void Tarik(double jumlah)
        {
            saldo -= jumlah;
            if (jumlah < saldo)
            {
                Console.WriteLine($"Penarikan berhasil. Sisa saldo Rp.{saldo}");
            }
            else
            {
                Console.WriteLine("Penarikan gagal. Saldo tidak mencukupi!");
            }
        }
    }

    internal class RekeningGiro : RekeningBank
    {
        public double biayaAdmin;
        public RekeningGiro(string namaNasabah, string nomorRekening, double saldo)
        {
            this.namaNasabah = namaNasabah;
            this.nomorRekening = nomorRekening;
            this.saldo = saldo;
        }

        public void PotonganBiayaAdmin(int biayaAdmin)
        {
            saldo -= biayaAdmin;
            Console.WriteLine($"Saldo telah terpotong untuk biaya Admin. Sisa saldo Rp.{saldo}");
        }
    }
}
