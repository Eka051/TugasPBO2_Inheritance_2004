using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPBO2
{
    internal class PionCatur
    {
        public int posisi;
        public void Gerak() 
        {
            Console.WriteLine("Pion Catur Bergerak");
        }
    }

    internal class PionPutih : PionCatur
    {
        public void GerakMaju(int posisi)
        {
            this.posisi += posisi;
        }
    }

    internal class PionHitam : PionCatur
    {
        public void Menyerang(int posisi)
        {
            this.posisi += posisi;
        }
    }
}